﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

using ProjectTimeTracker.Logging;
using ProjectTimeTracker.Models;
using ProjectTimeTracker.Services;

namespace ProjectTimeTracker.Forms
{
    public partial class AppForm : Form
    {
        private readonly IProjectsService _projectsService;

        private bool _isMeasuring;

        private BindingList<Project> _projects { get; set; }
        private Project CurrentProject => lbProjects.SelectedItem as Project;
        private ProjectEntry CurrentProjectEntry { get; set; }

        public AppForm(IProjectsService projectsService)
        {
            InitializeComponent();
            BindEventHandlers();

            _projectsService = projectsService;
        }

        #region overrides

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (_isMeasuring && (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.WindowsShutDown))
            {
                var dr = MessageBox.Show(
                    $"Time tracking in progress.{Environment.NewLine}Stop?",
                    "Confirm",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );
                if (dr == DialogResult.OK)
                {
                    ToggleState();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _projectsService.LoadProjects();
            _projects = new BindingList<Project>(_projectsService.Projects);
            lbProjects.DataSource = _projects;
            lbProjects.ResetBindings();
        }

        #endregion

        private void BindEventHandlers()
        {
            tbNewProject.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { AddProject(); }
            };

            btnToggle.Click += (s, e) => ToggleState();

            lbProjects.MouseDoubleClick += (s, e) => ShowSubForm<EntriesForm>();

            lbProjects.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Delete) { DeleteProject(); }
                else if (e.KeyCode == Keys.A) { ShowSubForm<ArchivesForm>(); }
                else if (e.KeyCode == Keys.E) { ShowSubForm<EntriesForm>(); }
                else if (e.KeyCode == Keys.S) { ToggleState(); }
            };
        }

        private void AddProject()
        {
            var name = tbNewProject.Text;

            _projectsService.AddProject(name);
            _projects.ResetBindings();
            tbNewProject.Text = string.Empty;
        }

        private void DeleteProject()
        {
            if (DialogResult.No == MessageBox.Show($"Are you sure you want to delete '{CurrentProject.Name}'?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                return;
            }

            _projectsService.DeleteProject(CurrentProject.Id);
            _projects.ResetBindings();
        }

        private void ToggleState()
        {
            if (CurrentProject == null)
            {
                MessageBox.Show("Pick a project", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _isMeasuring = !_isMeasuring;

            if (_isMeasuring) //START ACTION
            {
                _projectsService.AddProjectEntry(CurrentProject, CurrentProjectEntry = new ProjectEntry());
                btnToggle.Text = "STOP";
            }
            else //STOP ACTION
            {
                CurrentProjectEntry.Finish();
                CurrentProject.UpdateUsage();
                _projectsService.SaveProjects();
                btnToggle.Text = "START";
            }
        }

        private void ShowSubForm<T>() where T : ISubForm, IDisposable
        {
            using (var form = IoC.Resolve<T>())
            {
                form.Project = CurrentProject;
                form.ShowDialog(this);
            }
        }

    }
}

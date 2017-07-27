using System;
using System.ComponentModel;
using System.Windows.Forms;

using ProjectTimeTracker.Logging;
using ProjectTimeTracker.Models;
using ProjectTimeTracker.Services;

namespace ProjectTimeTracker.Forms
{
    public partial class AppForm : Form
    {
        private readonly ILogger<AppForm> _logger;
        private readonly IProjectsService _projectsService;

        private bool _isMeasuring;

        private BindingList<Project> _projects { get; set; }
        private Project CurrentProject => lbProjects.SelectedItem as Project;
        private ProjectEntry CurrentProjectEntry { get; set; }

        public AppForm(ILogger<AppForm> logger, IProjectsService projectsService)
        {
            InitializeComponent();
            BindEventHandlers();

            _logger = logger;
            _projectsService = projectsService;
        }

        #region overrides

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            //todo
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

            lbProjects.MouseDoubleClick += (s, e) =>
            {
                using (var form = IoC.Resolve<EntriesForm>())
                {
                    form.Project = CurrentProject;
                    form.ShowDialog(this);
                }
            };
            lbProjects.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Delete)
                {
                    DeleteProject();
                }
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
    }
}

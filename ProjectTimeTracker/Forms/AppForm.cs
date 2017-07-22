using System;
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
            lbProjects.DataSource = _projectsService.Projects;
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
        }
    

        private void AddProject()
        {
            var name = tbNewProject.Text;

            _projectsService.AddProject(name);

            tbNewProject.Text = string.Empty;
        }

        private void ToggleState()
        {
            _isMeasuring = !_isMeasuring;

            if (_isMeasuring)
            {
                _projectsService.AddProjectEntry(CurrentProject, CurrentProjectEntry = new ProjectEntry());
                btnToggle.Text = "STOP";
            }
            else
            {
                CurrentProjectEntry.Finish();
                _projectsService.SaveProjects();
                btnToggle.Text = "START";
            }
        }
    }
}

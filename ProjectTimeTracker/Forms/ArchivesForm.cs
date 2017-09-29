using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using ProjectTimeTracker.Logging;
using ProjectTimeTracker.Models;
using ProjectTimeTracker.Services;

namespace ProjectTimeTracker.Forms
{
    public partial class ArchivesForm : Form, ISubForm
    {
        private readonly IProjectsService _projectsService;
        public Project Project { get; set; }
        IEntriesContainer ISubForm.Project { get => Project; set => Project = value as Project; }

        private BindingList<ProjectArchiveEntry> _entries;

        public ArchivesForm(IProjectsService projectsService)
        {
            _projectsService = projectsService;
            InitializeComponent();
            BindEventHandlers();
        }

        #region overrides

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _entries = new BindingList<ProjectArchiveEntry>(Project.Archives);
            lbEntries.DataSource = _entries;
            lbEntries.ResetBindings();
        }

        #endregion

        private void BindEventHandlers()
        {
            lbEntries.MouseDoubleClick += (s, e) =>
            {
                using (var form = IoC.Resolve<EntriesForm>())
                {
                    form.Project = lbEntries.SelectedItem as ProjectArchiveEntry;
                    form.IsExtendedView = false;
                    form.ShowDialog(this);
                }
            };

            lbEntries.KeyDown += LbEntries_KeyDown;
        }

        private string[] GetSelectedIds() => lbEntries.SelectedItems
            .Cast<ProjectArchiveEntry>()
            .Select(pe => pe.Id)
            .ToArray();

        private void LbEntries_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var toRemove = GetSelectedIds();

                _projectsService.DeleteProjectArchives(Project, toRemove);
                _entries.ResetBindings();
            }
        }
    }
}

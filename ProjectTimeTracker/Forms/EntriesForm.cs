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
    public partial class EntriesForm : Form, ISubForm
    {
        private readonly IProjectsService _projectsService;
        public IEntriesContainer Project { get; set; }
        public bool IsExtendedView { get; set; } = true;

        private BindingList<ProjectEntry> _entries;

        public EntriesForm(IProjectsService projectsService)
        {
            _projectsService = projectsService;
            InitializeComponent();
        }

        #region overrides

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BindEventHandlers();

            pnMenu.Visible =
                pnMenu2.Visible = IsExtendedView;

            _entries = new BindingList<ProjectEntry>(Project.Entries);
            lbEntries.DataSource = _entries;
            lbEntries.ResetBindings();
            PrepareSummary();
        }

        #endregion

        private void BindEventHandlers()
        {
            lbEntries.SelectedValueChanged += (s, e) => PrepareSummary();

            if (!IsExtendedView) { return; }

            lbEntries.KeyDown += LbEntries_KeyDown;

            btnSelectToday.Click += (s, e) => SelectItems(DateTime.Today, DateTime.Today);

            btnSelectThisWeek.Click += (s, e) => SelectItems(DateTime.Today.StartOfWeek(), DateTime.Today.EndOfWeek());
            btnSelectLastWeek.Click += (s, e) => SelectItems(DateTime.Today.AddDays(-7).StartOfWeek(), DateTime.Today.AddDays(-7).EndOfWeek());

            btnSelectThisMonth.Click += (s, e) => SelectItems(DateTime.Today.StartOfMonth(), DateTime.Today.EndOfMonth());
            btnSelectLastMonth.Click += (s, e) => SelectItems(DateTime.Today.AddMonths(-1).StartOfMonth(), DateTime.Today.AddMonths(-1).EndOfMonth());

            btnSelectAll.Click += (s, e) => SelectItems(DateTime.MinValue, DateTime.MaxValue);

            btnArchive.Click += (s, e) => Archive();
            btnViewArchives.Click += (s, e) =>
            {
                using (var form = IoC.Resolve<ArchivesForm>())
                {
                    form.Project = Project as Project;
                    form.ShowDialog(this);
                }
            };
        }

        private void SelectItems(DateTime since, DateTime until)
        {
            lbEntries.SelectedItems.Clear();
            for (var i = 0; i < lbEntries.Items.Count; i++)
            {
                var entry = lbEntries.Items[i] as ProjectEntry;
                var date = entry.Start.Date;
                if (date >= since && date <= until)
                {
                    lbEntries.SelectedItems.Add(entry);
                }
            }
        }

        private void PrepareSummary()
        {
            var items = lbEntries.SelectedItems.Cast<ProjectEntry>();
            var (totalTime, days) = items.SumTimes();

            output.Clear();
            AppendOutput(string.Join(
                Environment.NewLine,
                days.Select(r => $@"{r.Day.ToString("dddd dd-MM-yyyy").PadLeft(23, ' ')} -> {r.Time:h\:mm}")) + Environment.NewLine
            );

            AppendOutputWithColor($"[ Total: {Math.Floor(totalTime.TotalHours)}h {totalTime.Minutes}mins. ]", Color.DarkOrange);
        }

        private string[] GetSelectedIds() => lbEntries.SelectedItems
            .Cast<ProjectEntry>()
            .Select(pe => pe.Id)
            .ToArray();

        private void LbEntries_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var toRemove = GetSelectedIds();

                _projectsService.DeleteProjectEntries(Project, toRemove);
                _entries.ResetBindings();
            }
        }

        private void AppendOutput(string data, bool appendNewLine = true)
        {
            output.AppendText(data);
            if (appendNewLine) { output.AppendText(Environment.NewLine); }
        }

        private void AppendOutputWithColor(string data, Color color, bool appendNewLine = true)
        {
            var originalColor = output.ForeColor;
            output.SelectionColor = color;
            AppendOutput(data, appendNewLine);
            output.SelectionColor = originalColor;
        }

        private void Archive()
        {
            var toArchive = GetSelectedIds();

            _projectsService.ArchiveProjectEntries(Project as Project, toArchive);
            _entries.ResetBindings();
        }
    }
}

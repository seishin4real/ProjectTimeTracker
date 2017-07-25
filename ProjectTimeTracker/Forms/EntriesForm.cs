using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ProjectTimeTracker.Logging;
using ProjectTimeTracker.Models;
using ProjectTimeTracker.Services;

namespace ProjectTimeTracker.Forms
{
    public partial class EntriesForm : Form
    {
        private readonly ILogger<EntriesForm> _logger;
        private readonly IProjectsService _projectsService;

        private BindingList<ProjectEntry> Entries { get; set; }
        public Project Project { get; set; }

        public EntriesForm(ILogger<EntriesForm> logger, IProjectsService projectsService)
        {
            _logger = logger;
            _projectsService = projectsService;
            InitializeComponent();
            BindEventHandlers();
        }

        #region overrides

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Entries = new BindingList<ProjectEntry>(Project.Entries);
            lbEntries.DataSource = Entries;
            lbEntries.ResetBindings();
            PrepareSummary();
        }

        #endregion

        private void BindEventHandlers()
        {
            lbEntries.KeyDown += LbEntries_KeyDown;
            lbEntries.SelectedValueChanged += (s, e) => PrepareSummary();
        }

        private void PrepareSummary()
        {
            var items = lbEntries.SelectedItems.Cast<ProjectEntry>();
            var result = items.GroupBy(i => i.Start.Date)
                .Select(g => new
                {
                    Day = g.Key,
                    Time = TimeSpan.FromTicks(g.Sum(i => ((i.End ?? DateTime.Now) - i.Start).Ticks))
                })
                .ToArray();
            var totalTime = TimeSpan.FromTicks(result.Sum(r => r.Time.Ticks));
            
            output.Clear();
            AppendOutput(string.Join(Environment.NewLine, result.Select(r => $@"{r.Day.ToString("dddd dd-MM-yyyy").PadLeft(23,' ')} -> {r.Time:h\:mm}")) + Environment.NewLine );

            AppendOutputWithColor($"[ Total: {Math.Floor(totalTime.TotalHours)}h {totalTime.Minutes}mins. ]", Color.DarkOrange);
        }

        private void LbEntries_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var toRemove = lbEntries.SelectedItems
                    .Cast<ProjectEntry>()
                    .Select(pe => pe.Id)
                    .ToArray();

                _projectsService.DeleteProjectEntries(Project, toRemove);
                Entries.ResetBindings();
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
    }
}

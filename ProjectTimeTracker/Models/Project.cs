using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using NLog.Layouts;

namespace ProjectTimeTracker.Models
{
    public class Project
    {
        [JsonProperty(Order = 1)]
        public long Id { get; set; } = DateTime.Now.Ticks;
        [JsonProperty(Order = 2)]
        public string Name { get; set; }
        [JsonProperty(Order = 3)]
        public DateTime LastUsed { get; set; } = DateTime.Now;
        [JsonProperty(Order = 4)]
        public List<ProjectEntry> Entries { get; set; } = new List<ProjectEntry>();

        public Project(string name)
        {
            Name = name;
        }

        #region overrides

        public override string ToString() => Name;

        #endregion
    }

    public class ProjectEntry
    {
        [JsonProperty(Order = 1)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [JsonProperty(Order = 2)]
        public DateTime Start { get; set; } = DateTime.Now;
        [JsonProperty(Order = 3)]
        public DateTime? End { get; set; }

        public ProjectEntry Finish()
        {
            End = DateTime.Now;
            return this;
        }

        #region overrides

        public override string ToString() => $"{Start:yyyy-MM-dd HH:mm} -> " + (End?.ToString("yyyy-MM-dd HH:mm") ?? "...");

        #endregion
    }
}

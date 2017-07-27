using System;
using System.Collections.Generic;

using Newtonsoft.Json;

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

        public void UpdateUsage()
        {
            LastUsed = DateTime.Now;
        }
    }
}

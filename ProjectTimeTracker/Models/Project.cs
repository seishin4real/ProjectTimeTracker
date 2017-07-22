using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using NLog.Layouts;

namespace ProjectTimeTracker.Models
{
    public class Project
    {
        [JsonProperty(Order = 1)]
        public long Id { get; set; }
        [JsonProperty(Order = 2)]
        public string Name { get; set; }
        [JsonProperty(Order = 3)]
        public DateTime LastUsed { get; set; }
        [JsonProperty(Order = 4)]
        public List<ProjectEntry> Entries { get; set; }

        public Project(string name)
        {
            Name = name;

            Id = DateTime.Now.Ticks;
            Entries = new List<ProjectEntry>();
            LastUsed = DateTime.Now;
        }

        #region overrides

        public override string ToString() => Name;

        #endregion
    }

    public class ProjectEntry
    {
        [JsonProperty(Order = 1)]
        public DateTime Start { get; } = DateTime.Now;
        [JsonProperty(Order = 2)]
        public DateTime? End { get; private set; }
        
        public ProjectEntry Finish()
        {
            End = DateTime.Now;
            return this;
        }
    }
}

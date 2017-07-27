using System;

using Newtonsoft.Json;

namespace ProjectTimeTracker.Models
{
    public class ProjectEntry
    {
        [JsonProperty(Order = 1)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [JsonProperty(Order = 2)]
        public DateTime Start { get; set; } = DateTime.Now;
        [JsonProperty(Order = 3)]
        public DateTime? End { get; set; }

        #region overrides

        public override string ToString() => $"{Start:yyyy-MM-dd HH:mm} -> " + (End?.ToString("yyyy-MM-dd HH:mm") ?? "...");

        #endregion

        public ProjectEntry Finish()
        {
            End = DateTime.Now;
            return this;
        }
    }
}

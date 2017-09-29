using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;

namespace ProjectTimeTracker.Models
{
    public class ProjectArchiveEntry : IEntriesContainer
    {
        [JsonProperty(Order = 1)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [JsonProperty(Order = 2)]
        public DateTime Date { get; set; }
        [JsonProperty(Order = 3)]
        public List<ProjectEntry> Entries { get; set; } = new List<ProjectEntry>();

        #region overrides

        public override string ToString()
        {
            var (totalTime, days) = Entries.SumTimes();
            return $"{Date:yyyy-MM-dd HH:mm}, Entries Count: {Entries.Count.ToString().PadLeft(3, ' ')}, Time: {Math.Floor(totalTime.TotalHours)}h {totalTime.Minutes}mins., Range: {Entries.First().Start:yyyy-MM-dd HH:mm} -> {Entries.Last().End:yyyy-MM-dd HH:mm}";
        }

        #endregion
    }
}
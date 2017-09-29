using System.Collections.Generic;

namespace ProjectTimeTracker.Models {
    public interface IEntriesContainer
    {
        List<ProjectEntry> Entries { get; set; }
    }
}
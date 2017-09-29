using System.Windows.Forms;

using ProjectTimeTracker.Models;

namespace ProjectTimeTracker.Forms {
    public interface ISubForm
    {
        IEntriesContainer Project { get; set; }
        DialogResult ShowDialog(IWin32Window owner);
    }
}
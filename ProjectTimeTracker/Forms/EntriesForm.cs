using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NLog;

using ProjectTimeTracker.Logging;

namespace ProjectTimeTracker.Forms
{
    public partial class EntriesForm : Form
    {
        private readonly ILogger<EntriesForm> _logger;

        public EntriesForm(ILogger<EntriesForm> logger)
        {
            _logger = logger;
            InitializeComponent();
        }
    }
}

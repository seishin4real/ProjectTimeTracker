using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTimeTracker.Logging;

namespace ProjectTimeTracker.Forms
{
    public partial class ReportGeneratorForm : Form
    {
        private readonly ILogger<ReportGeneratorForm> _logger;
        
        public ReportGeneratorForm(ILogger<ReportGeneratorForm> logger)
        {
            InitializeComponent();
            _logger = logger;
        }
    }
}

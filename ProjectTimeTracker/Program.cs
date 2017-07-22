using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autofac;

using ProjectTimeTracker.Forms;
using ProjectTimeTracker.Logging;

namespace ProjectTimeTracker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture =
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var container = IoC.BuildContainer())
            {
                LoggerConfig.Configure();

#if DEBUG
                LoggerConfig.ClearLogs();
#endif

                Application.Run(container.Resolve<AppForm>());
            }
        }
    }
}

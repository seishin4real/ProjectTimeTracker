using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

using Autofac;

using ProjectTimeTracker.Forms;
using ProjectTimeTracker.Logging;

namespace ProjectTimeTracker
{
    static class Program
    {
        [STAThread]
        private static void Main()
        {
//            Thread.CurrentThread.CurrentCulture =
//                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

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

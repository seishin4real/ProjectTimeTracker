using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

using NLog;
using NLog.Config;
using NLog.Targets;

using ProjectTimeTracker.Configuration;

namespace ProjectTimeTracker.Logging
{
    internal class LoggerConfig
    {
        private static string LogPath => AppConfig.SettingsConfig.LogPath.StartsWith("\\")
            ? Path.Combine(Application.StartupPath, AppConfig.SettingsConfig.LogPath)
            : AppConfig.SettingsConfig.LogPath;

        public static void Configure()
        {
            const string loggerLayout = @"[${level}] [${threadid}] ${longdate} -> 
${callsite:skipFrames=2:includeNamespace:false}:${callsite-linenumber:skipFrames=2}
${message}
${exception:format=toString}";

            var allLogsFileTarget = GetFileTarget(loggerLayout, "${date:format=yyyy-dd-MM/HH}.txt");

            var config = new LoggingConfiguration();

            config.LoggingRules.Add(new LoggingRule("*", LogLevel.FromString(AppConfig.SettingsConfig.LogLevel ?? "Debug"), allLogsFileTarget));

            LogManager.Configuration = config;
        }

#if DEBUG

        public static void ClearLogs()
        {
            try
            {
                new DirectoryInfo(LogPath)
                    .GetDirectories("*", SearchOption.TopDirectoryOnly)
                    .ForEach(dir => Directory.Delete(dir.FullName, true));
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Faild to clear logs. Error: {e.Message}");
            }
        }

#endif

        private static FileTarget GetFileTarget(string loggerLayout, string fileName) => new FileTarget
        {
            CreateDirs = true,
            AutoFlush = true,
            Layout = loggerLayout,
            Encoding = Encoding.UTF8,
            LineEnding = LineEndingMode.Default,
            ConcurrentWrites = false,
            Footer = Environment.NewLine,
            FileName = Path.Combine(LogPath, fileName)
        };
    }
}

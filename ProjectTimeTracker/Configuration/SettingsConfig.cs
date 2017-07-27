namespace ProjectTimeTracker.Configuration
{
    public class SettingsConfig : IConfig
    {
        public string LogPath { get; set; }
        public string LogLevel { get; set; }

        public IConfig GetDefault() => new SettingsConfig
        {
            LogPath = "\\logs",
            LogLevel = "Error"
        };
    }
}

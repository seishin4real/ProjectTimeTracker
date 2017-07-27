using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace ProjectTimeTracker.Configuration
{
    public interface IConfig
    {
        IConfig GetDefault();
    }

    public class AppConfig
    {
        private const string SettingsConfigFileName = "settings.config.json";

        private static SettingsConfig _settingsConfig;
        private static FontFamily _iconsFontFamily;

        public static SettingsConfig SettingsConfig => _settingsConfig ?? (_settingsConfig = LoadConfig<SettingsConfig>(SettingsConfigFileName));

        public static FontFamily IconsFontFamily
        {
            get
            {
                if (_iconsFontFamily != null) { return _iconsFontFamily; }

                var pfc = new PrivateFontCollection();
                pfc.AddFontFile(Path.Combine(Application.StartupPath, "Resources/fontawesome-webfont.ttf"));
                _iconsFontFamily = pfc.Families[0];

                return _iconsFontFamily;
            }
        }

        public static void SaveSettings()
        {
            var file = Path.Combine(Application.StartupPath, SettingsConfigFileName);

            SaveConfigFile(file, SettingsConfig);
        }

        private static TConfig LoadConfig<TConfig>(string fileName)
            where TConfig : class, IConfig, new()
        {
            if (string.IsNullOrEmpty(fileName)) { throw new ArgumentException($"Parametr '{fileName}' jest pusty."); }

            var file = Path.Combine(Application.StartupPath, fileName);
            IConfig result;

            if (!File.Exists(file))
            {
                SaveConfigFile(file, result = new TConfig().GetDefault());

                IoC.ResolveLogger<AppConfig>().Info($"File '{file}' not found. Created new one with default values.");
            }
            else { result = JsonConvert.DeserializeObject<TConfig>(File.ReadAllText(file)); }

            return result as TConfig;
        }

        private static void SaveConfigFile(string file, IConfig config)
        {
            try { File.WriteAllText(file, JsonConvert.SerializeObject(config, Formatting.Indented)); }
            catch (Exception e) { IoC.ResolveLogger<AppConfig>().Error(e, $"Error writing file '{file}'."); }
        }
    }
}

using System.Configuration;
using FishingGame.Output;
using FishingGame.Helper;

namespace FishingGame
{
    public static class AppConfigurationCalls
    {
        #region "Character"

        private static string _name = "PlayerName";
        private static string _fishingLevel = "FishingLvl";
        private static string _currentFishingEXP = "CurrentFishingEXP";
        private static string _coins = "Coins";

        public static string PlayerName
        {
            get { return _name; }
            set { UpdateAppSettings(_name, value); }
        }

        public static int FishingLvl
        {
            get { return Convert.ToInt32(GetAppSettings(_fishingLevel)); }
            set { UpdateAppSettings(_fishingLevel, value.ToString()); }
        }

        public static int CurrentFishingEXP
        {
            get { return (Convert.ToInt32(GetAppSettings(_currentFishingEXP))); }
            set { UpdateAppSettings(_currentFishingEXP, value.ToString()); }
        }

        public static int Coins
        {
            get { return Convert.ToInt32(GetAppSettings(_coins)); }
            set { UpdateAppSettings(_coins, value.ToString()); }
        }

        #endregion

        #region Backpack

        private static string _backpack = "Backpack";
        

        public static List<string> Backpack
        {
            get { return BackpackSerialization.DeserializeBackpack(GetAppSettings(_backpack)); }
            set { UpdateAppSettings(_backpack, BackpackSerialization.SerializeBackpack(value)); }             
        }


        #endregion



        #region "Modify"

        /// <summary>
        /// Looks in the app.config file for the key and returns the value assisgned to it
        /// </summary>
        /// <param name="key">Label for Key in App.Config</param>
        /// <returns>Value of Key in Config File</returns>
        public static string GetAppSettings(string key)
        {

            Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;

            return settings[key].Value;

        }

        /// <summary>
        /// Sets the value of Key in App.Conifg with the string value
        /// </summary>
        /// <param name="key">Label for Key in App.Config</param>
        /// <param name="value">String to set value of Key</param>
        public static void UpdateAppSettings(string key, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                DisplayToPlayer.ShowSingleLine($"Failed to update app setting {key} because no value was given.");
                return;
            }

            Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;

            settings[key].Value = value;

            configFile.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);


        }

        #endregion
    }
}

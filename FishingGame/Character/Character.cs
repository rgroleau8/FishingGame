using FishingGame.Output;
using FishingGame.Input;

namespace FishingGame.Character
{
    public class Character : ICharacter
    {

        #region Variables

        public string Name { get; set; }
        public int FishingLvl { get; set; }
        public int CurrentFishingEXP { get; set; }
        public int Coins { get; set; }

        #endregion

        #region Constructors

        public Character()
        {
            LoadDataFromAppSettings();
        }

        #endregion

        #region Methods


        #region Display Stats
        public void DisplayStats()
        {
            DisplayToPlayer.ShowSingleLine("Player Stats:");
            DisplayToPlayer.ShowBlankLine();
            DisplayToPlayer.ShowSingleLine($"Player Name: {Name}");
            DisplayToPlayer.ShowSingleLine($"Fishing Lvl: {FishingLvl}");
            DisplayToPlayer.ShowSingleLine($"Current Fishing Exp: {CurrentFishingEXP}");
            DisplayToPlayer.ShowSingleLine($"Amount of Coins: {Coins}");
            DisplayToPlayer.ShowBlankLine();
        }

        #endregion

        #region Saving Stats Methods

        public void SetPlayerName()
        {
            DisplayToPlayer.ShowSingleLine("What would you like your character name to be?:");

            string name = "";

            do
            {
                name = UserInput.GetInputFromUser();

            } while (string.IsNullOrWhiteSpace(name) == true);

            Name = name;

            AppConfigurationCalls.PlayerName = Name;
        }

        public void SaveFishingLevel()
        {
            AppConfigurationCalls.FishingLvl = FishingLvl;
        }

        public void SaveCurrentExp()
        {
            AppConfigurationCalls.CurrentFishingEXP = CurrentFishingEXP;
        }

        public void SaveCoins()
        {
            AppConfigurationCalls.Coins = Coins;
        }

        public void SaveAllProgress()
        {
            AppConfigurationCalls.FishingLvl = FishingLvl;
            AppConfigurationCalls.CurrentFishingEXP = CurrentFishingEXP;
            AppConfigurationCalls.Coins = Coins;

        }


        #endregion

        #region Loading Stats Methods

        public void LoadDataFromAppSettings()
        {
            Name = AppConfigurationCalls.PlayerName;
            FishingLvl = AppConfigurationCalls.FishingLvl;
            CurrentFishingEXP = AppConfigurationCalls.CurrentFishingEXP;
            Coins = AppConfigurationCalls.Coins;
        }

        public void ResetProgress()
        {
            FishingLvl = 1;
            CurrentFishingEXP = 0;
            Coins = 0;
            DisplayToPlayer.ShowSingleLine("Progress has been reset, player must now Save Progress, or choose Load Progess to revert back to config");

        }

        #endregion

        #endregion

        #region Deconstructor

        //Insures that progress is saved when the application closes
        ~Character()
        {
            SaveAllProgress();
        }

        #endregion



    }
}

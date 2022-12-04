namespace FishingGame.Character
{
    public interface ICharacter
    {
        string Name { get; set; }
        int CurrentFishingEXP { get; set; }
        int FishingLvl { get; set; }

        int Coins { get; set; }
        void SetPlayerName();

        void SaveFishingLevel();
        void SaveCurrentExp();

        void SaveCoins();

        void LoadDataFromAppSettings();

        void DisplayStats();

        void SaveAllProgress();

        void ResetProgress();
    }
}
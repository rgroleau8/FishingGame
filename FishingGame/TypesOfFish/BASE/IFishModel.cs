using FishingGame;


namespace FishingGame.TypesOfFish
{
    public interface IFishModel
    {
        Enums.Tools neededTool { get; set; }
        int ExpGained { get; set; }
        string FishName { get; set; }
        int LevelRequired { get; set; }
        int MaxTimeToCatchInMilliseconds { get; set; }
        int MinTimeToCatchInMilliseconds { get; set; }
    }
}
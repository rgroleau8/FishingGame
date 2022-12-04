namespace FishingGame.FishingSpots
{
    public interface IFishSpotTimer
    {
        void SetupAndStart(int activeMinTime, int activeMaxTime, int deactiveMinTime, int deactiveMaxTime);
        bool IsAFishingSpotAvailable();
    }
}
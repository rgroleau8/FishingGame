using FishingGame.FishingSpots;
using FishingGame.TypesOfFish;

namespace FishingGame.Casting
{
    public interface ICastTypeRegular
    {
        void CastingLoop(Enums.Tools toolName, IFishingSpot fishingSpot, IFishes fishes);
    }
}
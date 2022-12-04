using FishingGame.FishingSpots;
using FishingGame.TypesOfFish;
using FishingGame.Casting;

namespace FishingGame.FishingMethods
{
    public class RodFishing : IRodFishing
    {

        #region Variables

        private IRodFishingSpot _rodFishingSpot;
        private IRodFishes _rodFishes;
        private ICastTypeRegular _castType;

        #endregion

        #region Constructor

        public RodFishing(IRodFishingSpot rodFishingSpot, IRodFishes rodFishes, ICastTypeRegular castType)
        {
            _rodFishingSpot = rodFishingSpot;
            _rodFishes = rodFishes;
            _castType = castType;
        }

        #endregion

        #region Methods

        public void StartFishing()
        {
            _castType.CastingLoop(Enums.Tools.Rod, _rodFishingSpot, _rodFishes);

        }

        #endregion






    }
}

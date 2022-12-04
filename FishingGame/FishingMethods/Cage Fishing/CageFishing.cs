using FishingGame.FishingSpots;
using FishingGame.TypesOfFish;
using FishingGame.Casting;

namespace FishingGame.FishingMethods
{
    public class CageFishing : ICageFishing
    {

        #region Variables

        private ICageFishingSpot _cageFishingSpot;
        private ICageFishes _cageFishes;
        private ICastTypeRegular _castType;

        #endregion

        #region Constructor

        public CageFishing(ICageFishingSpot cageFishingSpot, ICageFishes cageFishes, ICastTypeRegular castType)
        {
            _cageFishingSpot = cageFishingSpot;
            _cageFishes = cageFishes;
            _castType = castType;

        }

        #endregion

        #region Methods

        public void StartFishing()
        {
            _castType.CastingLoop(Enums.Tools.Cage, _cageFishingSpot, _cageFishes);

        }

        #endregion




    }
}

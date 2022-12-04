using FishingGame.FishingSpots;
using FishingGame.TypesOfFish;
using FishingGame.Casting;

namespace FishingGame.FishingMethods
{
    public class HarpoonFishing : IHarpoonFishing
    {

        #region Variables

        private IHarpoonFishingSpot _harpoonFishingSpot;
        private IHarpoonFishes _harpoonFishes;
        private ICastTypeRegular _castType;

        #endregion

        #region Constructor

        public HarpoonFishing(IHarpoonFishingSpot harpoonFishingSpot, IHarpoonFishes harpoonFishes, ICastTypeRegular castType)
        {
            _harpoonFishes = harpoonFishes;
            _harpoonFishingSpot = harpoonFishingSpot;
            _castType = castType;
        }

        #endregion

        #region Methods

        public void StartFishing()
        {
            _castType.CastingLoop(Enums.Tools.Harpoon, _harpoonFishingSpot, _harpoonFishes);

        }

        #endregion







    }
}

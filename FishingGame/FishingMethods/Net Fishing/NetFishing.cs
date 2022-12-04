using FishingGame.FishingSpots;
using FishingGame.TypesOfFish;
using FishingGame.Casting;

namespace FishingGame.FishingMethods
{
    public class NetFishing : INetFishing
    {

        #region Variables

        private INetFishingSpot _netFishingSpot;
        private INetFishes _netFishes;
        private ICastTypeRegular _castType;

        #endregion

        #region Constructor

        public NetFishing(INetFishes netFishes, INetFishingSpot netFishingSpot, ICastTypeRegular castType)
        {
            _netFishes = netFishes;
            _netFishingSpot = netFishingSpot;
            _castType = castType;

        }

        #endregion

        #region Methods

        public void StartFishing()
        {
            _castType.CastingLoop(Enums.Tools.Net, _netFishingSpot, _netFishes);

        }

        #endregion










    }
}

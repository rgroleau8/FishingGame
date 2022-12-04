

namespace FishingGame.FishingSpots
{
    public class NetFishingSpot : INetFishingSpot
    {


        #region Variables

        private IFishSpotTimer _timerForFishingAvail;

        #endregion

        #region Constructor

        public NetFishingSpot(IFishSpotTimer fishSpotTimer)
        {
            _timerForFishingAvail = fishSpotTimer;
            _timerForFishingAvail.SetupAndStart(120000, 240000, 20000, 35000);

        }

        #endregion

        #region Methods

        public bool IsFishingSpotAvailable()
        {
            return _timerForFishingAvail.IsAFishingSpotAvailable();
        }

        #endregion







    }
}

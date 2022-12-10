

namespace FishingGame.FishingSpots
{
    public class NetFishingSpot : FishingSpot, INetFishingSpot
    {

        #region Constructor

        public NetFishingSpot(IFishSpotTimer fishSpotTimer)
        {
            _timerForFishingAvail = fishSpotTimer;
            _timerForFishingAvail.SetupAndStart(120000, 240000, 20000, 35000);

        }

        #endregion

    }
}

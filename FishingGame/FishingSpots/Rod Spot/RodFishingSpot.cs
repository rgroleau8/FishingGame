using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.FishingSpots
{
    class RodFishingSpot : IRodFishingSpot
    {
        #region Variables

        private IFishSpotTimer _timerForFishingAvail;

        #endregion

        #region Constructor

        public RodFishingSpot(IFishSpotTimer fishSpotTimer)
        {
            _timerForFishingAvail = fishSpotTimer;
            _timerForFishingAvail.SetupAndStart(100000, 250000, 20000, 60000);

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

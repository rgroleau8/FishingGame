using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.FishingSpots
{
    class RodFishingSpot : FishingSpot, IRodFishingSpot
    {
 

        #region Constructor

        public RodFishingSpot(IFishSpotTimer fishSpotTimer)
        {
            _timerForFishingAvail = fishSpotTimer;
            _timerForFishingAvail.SetupAndStart(100000, 250000, 20000, 60000);

        }

        #endregion








    }
}

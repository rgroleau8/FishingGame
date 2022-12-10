using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.FishingSpots
{
    public class HarpoonFishingSpot : FishingSpot, IHarpoonFishingSpot
    {
     
        #region Constructor

        public HarpoonFishingSpot(IFishSpotTimer fishSpotTimer)
        {
            _timerForFishingAvail = fishSpotTimer;
            _timerForFishingAvail.SetupAndStart(120000, 300000, 20000, 50000);

        }

        #endregion

      






    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.FishingSpots
{
    class CageFishingSpot : FishingSpot, ICageFishingSpot
    {

        #region Constructor

        public CageFishingSpot(IFishSpotTimer fishSpotTimer)
        {

            _timerForFishingAvail = fishSpotTimer;
            _timerForFishingAvail.SetupAndStart(120000, 300000, 20000, 60000);

        }

        #endregion

    






    }
}

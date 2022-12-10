using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.FishingSpots
{
    public class FishingSpot : IFishingSpot
    {

        //Uniquely set in the ctor of each indv FishingSpot type
        public IFishSpotTimer _timerForFishingAvail;



        //called by each instance of indv FishingSpot type
        public bool IsFishingSpotAvailable()
        {
            return _timerForFishingAvail.IsAFishingSpotAvailable();
        }

    }
}

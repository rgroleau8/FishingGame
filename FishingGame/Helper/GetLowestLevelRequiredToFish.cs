using FishingGame.TypesOfFish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.Helper
{
    public  class GetLowestLevelRequiredToFish
    {
        public static int LowestLevel(List<IFishModel> listOfFishes)
        {
            //orders the list by Level Required, and returns the first value in the list
            var output = listOfFishes.OrderBy(x => x.LevelRequired).First();
            return output.LevelRequired;

        }
    }
}

using FishingGame.TypesOfFish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.Helper
{
    public static  class PickRandomFishFromList
    {
        public static IFishModel GetFish(List<IFishModel> listOfFish)
        {
            Random listRandom = new Random();

            int index = listRandom.Next(listOfFish.Count);

            IFishModel output = listOfFish[index];

            return output;
        }
    }
}

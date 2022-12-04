using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishingGame.TypesOfFish;

namespace FishingGame.Helper
{
    public static class GetFishUserCanCatch
    {

        public static List<IFishModel> GetList(List<IFishModel> listOfFishes, int playerLevel)
        {
            List<IFishModel> output = new List<IFishModel>();

            foreach (IFishModel fish in listOfFishes)
            {
                if (fish.LevelRequired <= playerLevel)
                {
                    output.Add(fish);
                }
            }

            return output;
        }

    }
}

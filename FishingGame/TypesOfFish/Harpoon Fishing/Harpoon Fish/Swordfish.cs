using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.TypesOfFish
{
    public  class Swordfish : FishModel, ISwordfish
    {
        public Swordfish()
        {
            neededTool = Enums.Tools.Harpoon;
            ExpGained = 100;
            FishName = "Swordfish";
            LevelRequired = 50;
            MinTimeToCatchInMilliseconds = 2000;
            MaxTimeToCatchInMilliseconds = 11000;
        }

      

    }
}

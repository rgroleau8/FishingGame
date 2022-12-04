using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.TypesOfFish
{
    public class Trout : FishModel, ITrout
    {
        public Trout()
        {
            neededTool = Enums.Tools.Rod;
            ExpGained = 50;
            FishName = "Trout";
            LevelRequired = 20;
            MinTimeToCatchInMilliseconds = 1000;
            MaxTimeToCatchInMilliseconds = 7000;
        }


    }
}

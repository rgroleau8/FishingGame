using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.TypesOfFish
{
    public class Pike : FishModel, IPike
    {
        public Pike()
        {
            neededTool = Enums.Tools.Rod;
            ExpGained = 60;
            FishName = "Pike";
            LevelRequired = 25;
            MinTimeToCatchInMilliseconds = 2000;
            MaxTimeToCatchInMilliseconds = 10000;
        }
    }
}

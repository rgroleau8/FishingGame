using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.TypesOfFish
{
    public class Shrimp : FishModel, IShrimp
    {
        public Shrimp()
        {
            neededTool = Enums.Tools.Net;
            ExpGained = 10;
            FishName = "Shrimp";
            LevelRequired = 1;
            MinTimeToCatchInMilliseconds = 1000;
            MaxTimeToCatchInMilliseconds = 7000;

        }
    
    }
}

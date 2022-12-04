using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.TypesOfFish
{
    public class Anchovie : FishModel, IAnchovie
    {
        public Anchovie()
        {
            neededTool = Enums.Tools.Net;
            ExpGained = 40;
            FishName = "Anchovie";
            LevelRequired = 15;
            MinTimeToCatchInMilliseconds = 1000;
            MaxTimeToCatchInMilliseconds = 8000;

        }

    }
}

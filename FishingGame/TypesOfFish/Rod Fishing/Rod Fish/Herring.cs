using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.TypesOfFish
{
    public class Herring : FishModel, IHerring
    {
        public Herring()
        {
            neededTool = Enums.Tools.Rod;
            ExpGained = 30;
            FishName = "Herring";
            LevelRequired = 10;
            MinTimeToCatchInMilliseconds = 1000;
            MaxTimeToCatchInMilliseconds = 7000;
        }

    }
}

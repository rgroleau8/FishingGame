using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.TypesOfFish
{
    public  class Tuna : FishModel, ITuna
    {
        public Tuna()
        {
            neededTool = Enums.Tools.Harpoon;
            ExpGained = 80;
            FishName = "Tuna";
            LevelRequired = 35;
            MinTimeToCatchInMilliseconds = 2000;
            MaxTimeToCatchInMilliseconds = 8000;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.TypesOfFish
{
    public class Shark : FishModel, IShark
    {
        public Shark()
        {
            neededTool = Enums.Tools.Harpoon;
            ExpGained = 110;
            FishName = "Shark";
            LevelRequired = 76;
            MinTimeToCatchInMilliseconds = 2000;
            MaxTimeToCatchInMilliseconds = 11000;
        }    

    }
}

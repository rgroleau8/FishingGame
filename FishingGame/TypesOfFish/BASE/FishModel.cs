using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.TypesOfFish
{
    public abstract class FishModel : IFishModel
    {
        public Enums.Tools neededTool { get; set; }

        public string FishName { get; set; }
        public int LevelRequired { get; set; }
        public int ExpGained { get; set; }

        public int MinTimeToCatchInMilliseconds { get; set; }

        public int MaxTimeToCatchInMilliseconds { get; set; }




    }
}

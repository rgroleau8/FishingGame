using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.TypesOfFish
{
    public  class Lobster : FishModel, ILobster
    {
        public Lobster()
        {
            neededTool = Enums.Tools.Cage;
            ExpGained = 90;
            FishName = "Lobster";
            LevelRequired = 40;
            MinTimeToCatchInMilliseconds = 2000;
            MaxTimeToCatchInMilliseconds = 10000;
        }

       
    }
}

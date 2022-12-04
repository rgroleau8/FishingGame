using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.TypesOfFish
{
    public class NetFishes : BaseFishes, INetFishes
    {
        private IShrimp _shirmp;
        private IAnchovie _anchovie;

        public NetFishes(IShrimp shirmp, IAnchovie anchovie)
        {
            _shirmp = shirmp;
            _anchovie = anchovie;
            listOfPossibleFish = new List<IFishModel>();
            listOfPossibleFish.Add(_shirmp);
            listOfPossibleFish.Add(_anchovie);
            
        }

    }
}

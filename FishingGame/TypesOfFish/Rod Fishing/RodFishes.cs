using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.TypesOfFish
{
    public class RodFishes : BaseFishes, IRodFishes
    {
        private IHerring _herring;
        private IPike _pike;
        private ITrout _trout;

        public RodFishes(IHerring herring, IPike pike, ITrout trout)
        {
            _herring = herring;
            _pike = pike;
            _trout = trout;

            listOfPossibleFish = new List<IFishModel>();
            listOfPossibleFish.Add(_herring);
            listOfPossibleFish.Add(_pike);
            listOfPossibleFish.Add(_trout);
            
        }
    }
}

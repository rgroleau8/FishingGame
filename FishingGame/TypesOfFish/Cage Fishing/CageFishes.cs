using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.TypesOfFish
{
    public class CageFishes : BaseFishes, ICageFishes
    {

        private ILobster _lobster;

        public CageFishes(ILobster lobster)
        {
            _lobster = lobster;

            listOfPossibleFish = new List<IFishModel>();
            listOfPossibleFish.Add(_lobster);
            
        }
    }
}

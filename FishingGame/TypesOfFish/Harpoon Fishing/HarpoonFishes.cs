using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.TypesOfFish
{
    public class HarpoonFishes : BaseFishes, IHarpoonFishes
    {

        private ITuna _tuna;
        private ISwordfish _swordfish;
        private IShark _shark;
        public HarpoonFishes(ITuna tuna, ISwordfish swordfish, IShark shark)
        {
            _tuna = tuna;
            _swordfish = swordfish;
            _shark = shark;

            listOfPossibleFish = new List<IFishModel>();
            listOfPossibleFish.Add(_tuna);
            listOfPossibleFish.Add(_swordfish);
            listOfPossibleFish.Add(_shark);
            
        }
    }
}

using FishingGame.Character;
using FishingGame.EXP_Calc;
using FishingGame.Helper;
using FishingGame.Input;
using FishingGame.Inventory;
using FishingGame.TypesOfFish;
using FishingGame.Output;
using FishingGame.FishingSpots;

namespace FishingGame.Casting
{
    public class CastTypeRegular : ICastTypeRegular
    {
        #region Variables

        private IUserKillSwitch _userKillSwitch;
        private ICharacter _character;
        private IExperienceUtil _experienceUtil;
        private IInventory _inventory;

        private IFishingSpot _fishingSpot;
        private IFishes _fishes;

        #endregion

        #region Constructor

        public CastTypeRegular(IUserKillSwitch userKillSwitch, ICharacter character, IExperienceUtil experienceUtil,
          IInventory inventory)
        {
            _userKillSwitch = userKillSwitch;
            _character = character;
            _experienceUtil = experienceUtil;
            _inventory = inventory;
        }

        #endregion

        #region Methods

        /// <summary>
        /// To prevent only slight variations of this method, the toolName, fishing spot, and fishes to fish for instances are passed in.  Cast Type is called within the fising methods section
        /// </summary>
        /// <param name="toolName">Tool Enum</param>
        /// <param name="fishingSpot">Type of fishing spot</param>
        /// <param name="fishes">type of fishes</param>
        public void CastingLoop(Enums.Tools toolName, IFishingSpot fishingSpot, IFishes fishes)
        {
            if (_inventory.InventoryContains(toolName.ToString()) == false)
            {
                DisplayToPlayer.ShowSingleLine($"{_character.Name} doesn't have a {toolName} in their inventory, please purchase one from the store!");
                return;
            }

            _fishingSpot = fishingSpot;
            _fishes = fishes;

            DisplayToPlayer.ShowSingleLine($"You place your {toolName} in the water");

            int minLevelRequired = GetLowestLevelRequiredToFish.LowestLevel(_fishes.listOfPossibleFish);

            if (_character.FishingLvl < minLevelRequired)
            {
                DisplayToPlayer.ShowSingleLine($"{_character.Name} finds that they need a fishing level of {minLevelRequired} in order to catch a fish with the {toolName}");
                return;
            }

            while (true)
            {
                if (_fishingSpot.IsFishingSpotAvailable() == false)
                {
                    DisplayToPlayer.ShowSingleLine($"There doesnt seem to be an available spot to {toolName} fish at the moment");
                    return;
                }

                if (_userKillSwitch.IsKillSwitchEnabled() == true)
                {
                    DisplayToPlayer.ShowSingleLine($"{_character.Name} has stopped fishing!");
                    return;
                }


                IFishModel caughtFish = CommonCastSequence.Fish(fishes.listOfPossibleFish, _character.FishingLvl);

                _experienceUtil.AddExp(caughtFish.ExpGained);

                if (_inventory.InsertItem(caughtFish.FishName) == false)
                {
                    return;
                }


            }
        }

        #endregion







    }
}

using FishingGame.Character;
using FishingGame.Inventory;
using FishingGame.Output;
using FishingGame.Prompts;

namespace FishingGame.Store
{
    public class Store : IStore
    {

        #region Variables

        private ICharacter _character;
        private IInventory _inventory;
        private IStoreBuyToolsPrompt _storeBuyToolsPrompt;

        #endregion

        #region Constructor

        public Store(ICharacter character, IInventory inventory, IStoreBuyToolsPrompt storeBuyToolsPrompt)
        {
            _character = character;
            _inventory = inventory;
            _storeBuyToolsPrompt = storeBuyToolsPrompt;
        }

        #endregion

        #region Methods

        public void SellAllSellableItems()
        {
            List<string> newBackpack = _inventory.BackpackContents;

            foreach (string item in newBackpack.ToList())
            {
                foreach (Enums.SellableItems sellableItem in (Enums.SellableItems[])Enum.GetValues(typeof(Enums.SellableItems)))
                {
                    if (item == sellableItem.ToString())
                    {
                        newBackpack.Remove(item);
                        _character.Coins = _character.Coins + (int)sellableItem;
                    }
                }

            }

            _inventory.BackpackContents = newBackpack;

        }

        public void BuyTool()
        {
            _storeBuyToolsPrompt.PromptUser();

        }

        #endregion







    }
}

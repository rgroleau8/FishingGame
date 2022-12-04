using FishingGame.Store;

namespace FishingGame.Prompts
{
    public class StorePrompt : PromptBaseClass, IStorePrompt
    {
        #region Variables

        private IStore _store;
        private IInventoryPrompt _inventoryPrompt;

        #endregion

        #region Constructor

        public StorePrompt(IStore store, IFishingPrompt fishingPrompt, IInventoryPrompt inventoryPrompt)
        {
            _store = store;
            _inventoryPrompt = inventoryPrompt;

            PromptsForUser = new List<string>();

            PromptsForUser.Add("1: Check Inventory");
            PromptsForUser.Add("2: Sell All Items, tools excluded");
            PromptsForUser.Add("3: Buy Tool");
            PromptsForUser.Add("4: Exit");
        }

        #endregion

        #region Methods

        public void PromptUser()
        {
            base.PromptUser(StoreOptions, "4");
        }

        private void StoreOptions(string input)
        {
            switch (input)
            {
                case "1":
                    _inventoryPrompt.PromptUser();
                    break;
                case "2":
                    _store.SellAllSellableItems();
                    break;
                case "3":
                    _store.BuyTool();
                    break;
                case "4":
                    break;


            }
        }

        #endregion


    }
}

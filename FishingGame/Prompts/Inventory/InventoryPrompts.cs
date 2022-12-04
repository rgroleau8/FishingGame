using FishingGame.Inventory;
using FishingGame.Input;

namespace FishingGame.Prompts
{
    public class InventoryPrompt : PromptBaseClass, IInventoryPrompt
    {
        #region Variables

        private IInventory _inventory;

        #endregion

        #region Constructor

        public InventoryPrompt(IInventory inventory)
        {
            _inventory = inventory;

            PromptsForUser = new List<string>();

            PromptsForUser.Add("1: Check Inventory");
            PromptsForUser.Add("2: Drop Items");
            PromptsForUser.Add("3: Exit");

        }

        #endregion

        #region Methods

        public void PromptUser()
        {
            base.PromptUser(InventoryOptions, "3");
        }

        private void InventoryOptions(string input)
        {
            switch (input)
            {
                case "1":
                    _inventory.LookAtInventory();
                    break;
                case "2":
                    _inventory.RemoveItems();
                    break;
                case "3":
                    return;
            }
        }

        #endregion






    }

    public class CopyOfInventoryPrompt : PromptBaseClass, IInventoryPrompt
    {
        #region Variables

        private IInventory _inventory;

        #endregion

        #region Constructor

        public CopyOfInventoryPrompt(IInventory inventory)
        {
            _inventory = inventory;

            PromptsForUser = new List<string>();

            PromptsForUser.Add("1: Check Inventory");
            PromptsForUser.Add("2: Drop Items");
            PromptsForUser.Add("3: Exit");

        }

        #endregion

        #region Methods

        public void PromptUser()
        {
            base.PromptUser(InventoryOptions, "3");
        }

        private void InventoryOptions(string input)
        {
            switch (input)
            {
                case "1":
                    _inventory.LookAtInventory();
                    break;
                case "2":
                    _inventory.RemoveItems();
                    break;
                case "3":
                    return;
            }
        }

        #endregion






    }
}

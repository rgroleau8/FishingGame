using FishingGame.Input;
using FishingGame.Inventory;
using FishingGame.Character;

namespace FishingGame.Prompts
{
    public class MainMenuPrompt : PromptBaseClass, IMainMenuPrompt
    {

        #region Variables

        private IInventoryPrompt _inventoryPrompt;
        private IFishingPrompt _fishingPrompt;
        private IStorePrompt _storePrompt;
        private IInventory _inventory;
        private ICharacter _character;
        private ICharacterInfoPrompt _characterPrompts;

        #endregion

        #region Constructor

        public MainMenuPrompt(IInventoryPrompt inventoryPrompt, IFishingPrompt fishingPrompt, IStorePrompt storePrompt, IInventory inventory, ICharacter character, ICharacterInfoPrompt characterPrompts)
        {
            _fishingPrompt = fishingPrompt;
            _inventoryPrompt = inventoryPrompt;
            _storePrompt = storePrompt;
            _inventory = inventory;
            _character = character;
            _characterPrompts = characterPrompts;

            PromptsForUser = new List<string>();

            PromptsForUser.Add("1: Access Inventory");
            PromptsForUser.Add("2: Go To Fishing Dock");
            PromptsForUser.Add("3: Go To Store");
            PromptsForUser.Add("4: Check Stats");
            PromptsForUser.Add("5: Save and Quit");

        }

        #endregion

        #region Methods

        public void PromptUser()
        {
            base.PromptUser(MainMenuOptions, "5");
        }

        private void MainMenuOptions(string input)
        {

            switch (input)
            {
                case "1":
                    _inventoryPrompt.PromptUser();
                    break;
                case "2":
                    _fishingPrompt.PromptUser();
                    break;
                case "3":
                    _storePrompt.PromptUser();
                    break;
                case "4":
                    _characterPrompts.PromptUser();
                    break;
                case "5":
                    _character.SaveAllProgress();
                    _inventory.SaveBackpack();
                    return;
            }
        }

        #endregion


    }
}

using FishingGame.Inventory;
using FishingGame.Character;
using FishingGame.Output;

namespace FishingGame.Prompts
{
    public class StoreBuyToolsPrompt : PromptBaseClass, IStoreBuyToolsPrompt
    {

        #region Variables

        private IInventory _inventory;
        private ICharacter _character;

        #endregion

        #region Constructor

        public StoreBuyToolsPrompt(IInventory inventory, ICharacter character)
        {
            _inventory = inventory;
            _character = character;

            PromptsForUser = new List<string>();

            PromptsForUser.Add("1: " + Enums.Tools.Net + " -- Price: " + ((int)Enums.Tools.Net).ToString());
            PromptsForUser.Add("2: " + Enums.Tools.Rod + "-- Price: " + ((int)Enums.Tools.Rod).ToString());
            PromptsForUser.Add("3: " + Enums.Tools.Harpoon + "-- Price: " + ((int)Enums.Tools.Harpoon).ToString());
            PromptsForUser.Add("4: " + Enums.Tools.Cage + "-- Price: " + ((int)Enums.Tools.Cage).ToString());
            PromptsForUser.Add("5: Exit");
        }

        #endregion

        #region Methods

        public void PromptUser()
        {

            base.PromptUser(BuyOptions, "5");
        }

        private void BuyOptions(string input)
        {
            switch (input)
            {
                case "1":
                    BuyItem(Enums.Tools.Net.ToString(), (int)Enums.Tools.Net);
                    break;
                case "2":
                    BuyItem(Enums.Tools.Rod.ToString(), (int)Enums.Tools.Rod);
                    break;
                case "3":
                    BuyItem(Enums.Tools.Harpoon.ToString(), (int)Enums.Tools.Harpoon);
                    break;
                case "4":
                    BuyItem(Enums.Tools.Cage.ToString(), (int)Enums.Tools.Cage);
                    break;
                case "5":
                    return;
            }
        }

        private void BuyItem(string item, int price)
        {
            if (_inventory.DoesBackpackHaveSpace() == false)
            {
                DisplayToPlayer.ShowSingleLine($"You dont have space in your inventory to buy {item}");
                return;
            }

            if (_character.Coins < price)
            {
                DisplayToPlayer.ShowSingleLine($"{_character.Name} doesn't have enough to purchase {item}");
                return;
            }

            _inventory.InsertItem(item);
            _inventory.SaveBackpack();
            _character.Coins -= price;
            _character.SaveCoins();

        }
    }

    #endregion





}

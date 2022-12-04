using FishingGame.Output;
using FishingGame.Input;

namespace FishingGame.Inventory
{
    public class Inventory : IInventory
    {


        #region Private Variables

        private int AmountOfItems = 1;
        private const int ItemLimit = 28;
        private List<string> backpack;

        #endregion

        #region Constructor

        public Inventory()
        {
            backpack = AppConfigurationCalls.Backpack;

        }

        #endregion

        #region Properties

        public List<string> BackpackContents
        {
            get { return backpack; }
            set { backpack = value; }
        }

        #endregion

        #region Methods

        public bool InsertItem(string itemToInsert)
        {
            if (DoesBackpackHaveSpace() == false)
                return false;

            backpack.Add(itemToInsert);

            AmountOfItems += 1;

            return true;
        }

        public bool DoesBackpackHaveSpace()
        {
            if (BackpackValidation.BackpackSpaceAvailable(backpack, ItemLimit) == false)
                return false;

            return true;
        }


        public void LookAtInventory()
        {
            DisplayToPlayer.ShowSingleLine("Backpack contains: ");
            DisplayToPlayer.ShowBlankLine();

            foreach (string item in backpack)
            {
                DisplayToPlayer.ShowSingleLine(item);
            }
            DisplayToPlayer.ShowBlankLine();
        }

        public bool InventoryContains(string item)
        {
            return BackpackValidation.DoesBackpackContainThisItem(backpack, item);
        }

        public void RemoveItems()
        {
            DisplayToPlayer.ShowSingleLine("What Item Would You Like To Drop? If you wish to drop all but the tools, type all:");
            string itemName = UserInput.GetInputFromUser();

            if (BackpackValidation.ItemInputIsValid(itemName) == false)
                return;

            if (itemName == "all")
            {
                backpack = BackpackRemoveItems.NewBackupDeleteAllExceptTools(backpack);
                return;

            }

            if (InventoryContains(itemName) == false)
                return;

            DisplayToPlayer.ShowSingleLine("How many would you like to drop");
            string amountText = UserInput.GetInputFromUser();

            if (BackpackValidation.AmountInputIsValid(amountText) == false)
                return;

            int amount = Convert.ToInt32(amountText);

            backpack = BackpackRemoveItems.NewBackpackDeleteItem(backpack, itemName, amount);

        }

        public void SaveBackpack()
        {
            AppConfigurationCalls.Backpack = backpack;
        }

        #endregion

        #region Deconstructor

        //Deconstructor to make sure the backpack is saved if application closes.  Inventory instance is set to singleInstance, so this should only get fired once.
        ~Inventory()
        {
            SaveBackpack();
        }

        #endregion





    }

    public class Copy1OfInventory : IInventory
    {


        #region Private Variables

        private int AmountOfItems = 1;
        private const int ItemLimit = 28;
        private List<string> backpack;

        #endregion

        #region Constructor

        public Copy1OfInventory()
        {
            backpack = AppConfigurationCalls.Backpack;

        }

        #endregion

        #region Properties

        public List<string> BackpackContents
        {
            get { return backpack; }
            set { backpack = value; }
        }

        #endregion

        #region Methods

        public bool InsertItem(string itemToInsert)
        {
            if (DoesBackpackHaveSpace() == false)
                return false;

            backpack.Add(itemToInsert);

            AmountOfItems += 1;

            return true;
        }

        public bool DoesBackpackHaveSpace()
        {
            if (BackpackValidation.BackpackSpaceAvailable(backpack, ItemLimit) == false)
                return false;

            return true;
        }


        public void LookAtInventory()
        {
            DisplayToPlayer.ShowSingleLine("Backpack contains: ");
            DisplayToPlayer.ShowBlankLine();

            foreach (string item in backpack)
            {
                DisplayToPlayer.ShowSingleLine(item);
            }
            DisplayToPlayer.ShowBlankLine();
        }

        public bool InventoryContains(string item)
        {
            return BackpackValidation.DoesBackpackContainThisItem(backpack, item);
        }

        public void RemoveItems()
        {
            DisplayToPlayer.ShowSingleLine("What Item Would You Like To Drop? If you wish to drop all but the tools, type all:");
            string itemName = UserInput.GetInputFromUser();

            if (BackpackValidation.ItemInputIsValid(itemName) == false)
                return;

            if (itemName == "all")
            {
                backpack = BackpackRemoveItems.NewBackupDeleteAllExceptTools(backpack);
                return;

            }

            if (InventoryContains(itemName) == false)
                return;

            DisplayToPlayer.ShowSingleLine("How many would you like to drop");
            string amountText = UserInput.GetInputFromUser();

            if (BackpackValidation.AmountInputIsValid(amountText) == false)
                return;

            int amount = Convert.ToInt32(amountText);

            backpack = BackpackRemoveItems.NewBackpackDeleteItem(backpack, itemName, amount);

        }

        public void SaveBackpack()
        {
            AppConfigurationCalls.Backpack = backpack;
        }

        #endregion

        #region Deconstructor

        //Deconstructor to make sure the backpack is saved if application closes.  Copy1OfInventory instance is set to singleInstance, so this should only get fired once.
        ~Copy1OfInventory()
        {
            SaveBackpack();
        }

        #endregion





    }

    public class CopyOfInventory : IInventory
    {


        #region Private Variables

        private int AmountOfItems = 1;
        private const int ItemLimit = 28;
        private List<string> backpack;

        #endregion

        #region Constructor

        public CopyOfInventory()
        {
            backpack = AppConfigurationCalls.Backpack;

        }

        #endregion

        #region Properties

        public List<string> BackpackContents
        {
            get { return backpack; }
            set { backpack = value; }
        }

        #endregion

        #region Methods

        public bool InsertItem(string itemToInsert)
        {
            if (DoesBackpackHaveSpace() == false)
                return false;

            backpack.Add(itemToInsert);

            AmountOfItems += 1;

            return true;
        }

        public bool DoesBackpackHaveSpace()
        {
            if (BackpackValidation.BackpackSpaceAvailable(backpack, ItemLimit) == false)
                return false;

            return true;
        }


        public void LookAtInventory()
        {
            DisplayToPlayer.ShowSingleLine("Backpack contains: ");
            DisplayToPlayer.ShowBlankLine();

            foreach (string item in backpack)
            {
                DisplayToPlayer.ShowSingleLine(item);
            }
            DisplayToPlayer.ShowBlankLine();
        }

        public bool InventoryContains(string item)
        {
            return BackpackValidation.DoesBackpackContainThisItem(backpack, item);
        }

        public void RemoveItems()
        {
            DisplayToPlayer.ShowSingleLine("What Item Would You Like To Drop? If you wish to drop all but the tools, type all:");
            string itemName = UserInput.GetInputFromUser();

            if (BackpackValidation.ItemInputIsValid(itemName) == false)
                return;

            if (itemName == "all")
            {
                backpack = BackpackRemoveItems.NewBackupDeleteAllExceptTools(backpack);
                return;

            }

            if (InventoryContains(itemName) == false)
                return;

            DisplayToPlayer.ShowSingleLine("How many would you like to drop");
            string amountText = UserInput.GetInputFromUser();

            if (BackpackValidation.AmountInputIsValid(amountText) == false)
                return;

            int amount = Convert.ToInt32(amountText);

            backpack = BackpackRemoveItems.NewBackpackDeleteItem(backpack, itemName, amount);

        }

        public void SaveBackpack()
        {
            AppConfigurationCalls.Backpack = backpack;
        }

        #endregion

        #region Deconstructor

        //Deconstructor to make sure the backpack is saved if application closes.  CopyOfInventory instance is set to singleInstance, so this should only get fired once.
        ~CopyOfInventory()
        {
            SaveBackpack();
        }

        #endregion





    }
}

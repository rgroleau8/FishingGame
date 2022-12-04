

namespace FishingGame.Inventory
{
    public interface IInventory
    {
        List<string> BackpackContents { get; set; }
        bool InsertItem(string itemToInsert);

        bool DoesBackpackHaveSpace();

        bool InventoryContains(string item);
        void LookAtInventory();

        void RemoveItems();

        void SaveBackpack();
    }
}
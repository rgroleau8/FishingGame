
using FishingGame.Output;

namespace FishingGame.Inventory
{
    public static class BackpackRemoveItems
    {

        /// <summary>
        /// Create a new empty list and adds any tool currently in the inventory and returns it, 
        /// deleting anything else that may be in the backpact
        /// </summary>
        /// <param name="backpack"></param>
        /// <returns>Backpack with only tools currently in backpack</returns>
        public static List<string> NewBackupDeleteAllExceptTools(List<string> backpack)
        {
            List<string> outputBackpack = new List<string>();

            foreach (Enums.Tools tool in (Enums.Tools[])Enum.GetValues(typeof(Enums.Tools)))
            {
                if (backpack.Contains(tool.ToString()))
                {
                    outputBackpack.Add(tool.ToString());
                }
            }

            DisplayToPlayer.ShowSingleLine("All Items expect for Tool have been removed!");
            return outputBackpack;
        }

        /// <summary>
        /// Deletes x amountToDelete of items with the name itemToDelete from the backpack and returns the new one
        /// </summary>
        /// <param name="backpack"></param>
        /// <param name="itemToDelete"></param>
        /// <param name="amountToDelete"></param>
        /// <returns></returns>
        public static List<string> NewBackpackDeleteItem(List<string> backpack, string itemToDelete, int amountToDelete)
        {
            List<string> outputList = backpack;

            for (int i = 0; i < amountToDelete || i == outputList.Count - 1; i++)
            {
                outputList.Remove(itemToDelete);
            }

            return outputList;

        }

    }
}

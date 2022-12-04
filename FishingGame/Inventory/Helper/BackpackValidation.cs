using FishingGame.Output;

namespace FishingGame.Inventory
{
    public static class BackpackValidation
    {

        private static string invalidMessage = "Not a valid input";

        /// <summary>
        /// Checks for an invalid user input
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        public static bool ItemInputIsValid(string itemName)
        {
            if (string.IsNullOrWhiteSpace(itemName))
            {
                DisplayToPlayer.ShowSingleLine(invalidMessage);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if amount string can be converted to a Int or if its whitespace
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static bool AmountInputIsValid(string amount)
        {
            int integerOut;

            if (!int.TryParse(amount, out integerOut) || string.IsNullOrWhiteSpace(amount))
            {
                DisplayToPlayer.ShowSingleLine(invalidMessage);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if backpact contains the passes in item
        /// </summary>
        /// <param name="backpack"></param>
        /// <param name="itemName"></param>
        /// <returns></returns>
        public static bool DoesBackpackContainThisItem(List<string> backpack, string itemName)
        {
            if (backpack.Contains(itemName) == false)
            {
                DisplayToPlayer.ShowSingleLine($"Backpack doesn't contain {itemName}");
                return false;
            }

            return true;
        }

        public static bool BackpackSpaceAvailable(List<string> backpack, int spaceLimit)
        {
            if (backpack.Count >= spaceLimit)
            {
                DisplayToPlayer.ShowSingleLine("You are out of available inventory space, please drop some items!");
                return false;
            }

            return true;
        }

      
    }
}

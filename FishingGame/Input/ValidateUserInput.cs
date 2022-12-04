using FishingGame.Output;

namespace FishingGame.Input
{
    public static class ValidateUserInput
    {
        public static bool ValidateAgainstList(string userInput, List<string> list)
        {
            //used to pass type into try parse
            int option;
            bool validated = true;

            if (string.IsNullOrWhiteSpace(userInput))
            {
                DisplayToPlayer.ShowSingleLine("Not a valid input");
                return false;
            }


            //checks if the 
            if (!int.TryParse(userInput, out option))
               validated = false;


            if (Convert.ToInt32(userInput) < 1 || Convert.ToInt32(userInput) > list.Count)          
                validated = false;


            if (validated == false)
            {
                DisplayToPlayer.ShowSingleLine("Not a valid input");
                return false;
            }      
                
            return true;

        }
    }
}

using FishingGame.Output;

namespace FishingGame.Input
{
    public static class UserInput
    {
        /// <summary>
        /// Gets the selected item from a list.  Validation occurs in ValidateAgainstList to ensure the input is a valid option in the list.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string GetUserInputFromList(List<string> list)
        {

            DisplayToPlayer.ShowSingleLine("Please select an option");

            string userInput = "";

            do
            {
               
                DisplayToPlayer.ShowList(list);

                userInput = UserInput.GetInputFromUser();

            } while (ValidateUserInput.ValidateAgainstList(userInput, list) == false);

            return userInput;
        }

        public static string GetInputFromUser()
        {
            string output = "";

            output = Console.ReadLine();

            DisplayToPlayer.ShowBlankLine();

            return output;
        }
    }

   
}

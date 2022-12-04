using FishingGame.Input;
namespace FishingGame.Prompts
{
    public abstract class PromptBaseClass
    {
        public List<string> PromptsForUser { get; set; }

        public delegate void ChooseOption(string input);

        public virtual void PromptUser(ChooseOption chooseMethod, string exitNumber)
        {
            string selectedOption = "";

            do
            {
                selectedOption = UserInput.GetUserInputFromList(PromptsForUser);

                chooseMethod(selectedOption);

            } while (selectedOption != exitNumber);

        }
    }
}

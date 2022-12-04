using FishingGame.Character;
using FishingGame.Output;

namespace FishingGame.Prompts
{
    public class CharacterInfoPrompt : PromptBaseClass, ICharacterInfoPrompt
    {
        #region Variables

        private ICharacter _character;

        #endregion

        #region Constructor

        public CharacterInfoPrompt(ICharacter character)
        {
            _character = character;

            PromptsForUser = new List<string>();

            PromptsForUser.Add("1: Display Stats");
            PromptsForUser.Add("2: Save Progress");
            PromptsForUser.Add("3: Reset Progress");
            PromptsForUser.Add("4: Load Progress");
            PromptsForUser.Add("5: Exit");
        }

        #endregion

        #region Methods

        public void PromptUser()
        {
            base.PromptUser(CharacterOptions, "5");
        }

        private void CharacterOptions(string input)
        {
            switch (input)
            {
                case "1":
                    _character.DisplayStats();
                    break;
                case "2":
                    _character.SaveAllProgress();
                    break;
                case "3":
                    _character.ResetProgress();
                    break;
                case "4":
                    _character.LoadDataFromAppSettings();
                    break;
                case "5":
                    return;

            }
        }

        #endregion






    }
}

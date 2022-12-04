using FishingGame.Output;
using FishingGame.Character;
using FishingGame.Prompts;


namespace FishingGame
{
    public class GameLogic : IGameLogic
    {

        private IMainMenuPrompt _mainMenuPrompt;
        private ICharacter _character;

        public GameLogic(IMainMenuPrompt mainMenuPrompt, ICharacter character)
        {
            _mainMenuPrompt = mainMenuPrompt;
            _character = character;
        }

        public void StartGame()
        {
            if (_character.Name == "")
                _character.SetPlayerName();
            

            DisplayToPlayer.ShowSingleLineDecorated("Welcome To Port Sarim...  What would you like to do?");

            _mainMenuPrompt.PromptUser();
       
        }

    }
}

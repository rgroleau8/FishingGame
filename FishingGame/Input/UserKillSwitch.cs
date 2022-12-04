
namespace FishingGame.Input
{
    public class UserKillSwitch : IUserKillSwitch
    {
        #region Constructor
        public UserKillSwitch()
        {

        }

        #endregion

        #region Methods

        public bool IsKillSwitchEnabled()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.Q)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion



    }
}

using FishingGame.Character;
using FishingGame.Output;

namespace FishingGame.EXP_Calc
{
    public class ExperienceUtil : IExperienceUtil
    {
        #region Variables

        private ICharacter _character;
        private int _nextEperienceAmountToLvlUp;

        #endregion

        #region Constructor

        public ExperienceUtil(ICharacter character)
        {
            this._character = character;
            UpdateNextExperienceVariable();
        }

        #endregion

        #region Methods

        public void AddExp(int _expToAdd)
        {
            _character.CurrentFishingEXP += _expToAdd;

            if (HasUserReachedNextLevel())
            {
                _character.FishingLvl += 1;

                _character.SaveFishingLevel(); //saves to app.config

                UpdateNextExperienceVariable(); //changes the private int _nextExperienceToLvlUp to what _character.CurrentFishingEXP has to get to inccrease to the next lvl.

                DisplayToPlayer.ShowSingleLineDecorated($"Congratulations!  You're Fishing level has increased to {_character.FishingLvl}");

            }

        }

        private bool HasUserReachedNextLevel()
        {
            if (_character.CurrentFishingEXP > _nextEperienceAmountToLvlUp)
                return true;

            return false;
        }


        /// <summary>
        /// Prevents the code equation from GetNExtLevelExpNeeded from being run every single time,
        /// Updates the private variable only when needed to after a new fishing level occures or upon app startup as this is run as a single instance
        /// </summary>
        private void UpdateNextExperienceVariable()
        {
            _nextEperienceAmountToLvlUp = CalculateExperience.GetExpNeededForNextLevel(_character.FishingLvl);
        }

        #endregion







    }
}

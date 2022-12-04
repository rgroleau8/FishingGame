using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.EXP_Calc
{
    public static class CalculateExperience
    {
        /// <summary>
        /// Formula to calculate the needed experience amount the user has to reach to progress to the next level.
        /// </summary>
        /// <param name="currentLvl">Users current fishing lvl</param>
        /// <returns>Exp amount to reach next fising level</returns>
        public static int GetExpNeededForNextLevel(int currentLvl)
        {
            //EXP to go from lvl1 to lvl2 is 83.         
            int output = 83;
            int points = 0;
            int level = currentLvl + 1; //next level to get exp amount for

            //formula to calculate the number of exp needed to get to the next level
            //the amount difference between levels goes up 10% each time
            //lvl 1 - 83 83
            //lvl 2 - 174 91
            //lvl 3 388 102

            //
            for (int lvl = 1; lvl <= level; lvl++)
            {
                points += (int)Math.Floor(lvl + 300.0 * Math.Pow(2.0, lvl / 7.0));

                if (lvl >= level || level == 1)
                {

                    return output;
                }

                output = (int)(points / 4);

            }

            return output;
        }

    }
}

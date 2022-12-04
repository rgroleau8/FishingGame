using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.Helper
{
    public static class BackpackSerialization
    {
        private static string splitChar = "*";

        public static string SerializeBackpack(List<string> backpack)
        {
            string outputString = "";

            foreach (string item in backpack)
            {
                outputString = outputString + item + splitChar;
            }

            return outputString;
        }

        public static List<string> DeserializeBackpack(string backpack)
        {
            List<string> outputList = new List<string>();

            outputList = backpack.Split(splitChar).ToList();

            return outputList;

        }
    }
}

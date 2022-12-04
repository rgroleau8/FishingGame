using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.Output
{
    public static class DisplayToPlayer
    {

        public static void ShowSingleLineDecorated(string message)
        {
            Console.WriteLine();
            Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");
            Console.WriteLine();
        }

        public static void ShowSingleLine(string message)
        {
            Console.WriteLine(message);
        }

        public static void ShowList(List<string> listOfOptions)
        {
            foreach (var option in listOfOptions)
            {
                ShowSingleLine(option);
            }
        }

        public static void ShowBlankLine()
        {
            ShowSingleLine("");
        }
    }
}

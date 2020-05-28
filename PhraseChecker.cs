using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningC
{
    public class PhraseChecker : Program
    {
        public static void CallMe()
        {
            bool isPhraseCheckerRunning = true;

            while (isPhraseCheckerRunning == true)
            {
                Console.WriteLine($"\nPhrase Checker\r");
                Console.WriteLine("---------------------------" + "\n");
                Console.WriteLine("This option determines wheter or not your input contains uppercase characters!\n");
                Console.WriteLine("\t0. - Back");
                Console.WriteLine("\t1. - Play Phrase Checker");
                Console.Write("\nYour option: ");

                switch (Console.ReadLine())
                {
                    case "0":
                        isPhraseCheckerRunning = false;
                        break;
                    case "1":
                        Console.Write("\nPlease enter your phrase: ");
                        string phrase = Console.ReadLine();
                        bool hasUpper = phrase.Any(char.IsUpper);
                        string firstRes = "\nYour phrase contains an uppercase letter! :-O";
                        string secondRes = "\nYour phrase does not contain any uppercase characters :-)";
                        if (hasUpper == true)
                        {
                            Console.WriteLine(firstRes + "\n");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(secondRes + "\n");
                            continue;
                        }
                    default:
                        Console.WriteLine("\nPlease select one of the menu options.\n");
                        break;
                }
            }
        }
    }
}

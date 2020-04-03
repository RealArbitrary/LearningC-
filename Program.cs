using System;
using System.Linq;

namespace learningC
{

    public class Program
    {

        static void Main(string[] args)
        {
            bool endApp = false;
            Console.Write("To get started, please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName} to De Wet's fun C# examples\r");
            Console.WriteLine("-----------------------------------" + "\n");
            while (!endApp)
            {
                Console.WriteLine("\t0. - Exit");
                Console.WriteLine("\t1. - Phrase checker.");
                Console.WriteLine("\t2. - Calculate your age in dog years.");
                Console.WriteLine("\t3. - What kind of cat are you?");
                Console.WriteLine("\n");
                Console.Write("Your option: ");
                switch (Console.ReadLine())
                {
                    case "0": 
                        endApp = true;
                        break;
                    case "1": 
                        PhraseChecker.CheckPhrase();
                        break;
                    case "2": 
                        DogYearCalculator.YearCalculator();
                        break;
                    case "3": 
                        WhichCatAreYou.CatCalculator();
                        break;
                    default:
                        Console.WriteLine("Whoops! That does not exist." + "\n");
                        break;

                }

            }
            
        }

    }

}

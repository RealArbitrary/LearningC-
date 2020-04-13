using System;
using System.Runtime.Serialization;
using System.Linq;

namespace learningC
{

    public class Program
    {
        //My "UI"

        static void Main(string[] args)
        {
            bool endApp = false;
            Console.Write("To get started, please enter your name: ");
            string userName = Console.ReadLine();
            
            while (!endApp)
            {
                Console.WriteLine($"\nWelcome {userName} to De Wet's fun C# examples\r");
                Console.WriteLine("-----------------------------------" + "\n");
                Console.WriteLine("Please select one of the following:\n");
                Console.WriteLine("\t0. - Exit");
                Console.WriteLine("\t1. - Phrase checker.");
                Console.WriteLine("\t2. - Dog Year Calculator");
                Console.WriteLine("\t3. - Kitten Cuisine");
                Console.WriteLine("\t4. - Exquisite Corpse");
                Console.WriteLine("\t5. - Caeser Cipher");
                Console.WriteLine("\n");
                Console.Write("Your option: ");
                switch (Console.ReadLine())
                {
                    case "0": 
                        endApp = true;
                        break;
                    case "1": 
                        PhraseChecker.CallMe();
                        break;
                    case "2": 
                        DogYearCalculator.CallMe();
                        break;
                    case "3": 
                        WhichCatAreYou.CallMe();
                        break;
                    case "4":
                        ExquisiteCorpse.CallMe();
                        break;
                    case "5":
                        CaeserCipher.CallMe();
                        break;
                    default:
                        Console.WriteLine("Whoops! That does not exist." + "\n");
                        break;

                }

            }
            
        }

    }

}

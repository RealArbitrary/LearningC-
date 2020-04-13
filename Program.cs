using System;
using System.Runtime.Serialization;
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
            
            while (!endApp)
            {
                Console.WriteLine($"\nWelcome {userName} to De Wet's fun C# examples\r");
                Console.WriteLine("-----------------------------------" + "\n");
                Console.WriteLine("\t0. - Exit");
                Console.WriteLine("\t1. - Phrase checker.");
                Console.WriteLine("\t2. - Calculate your age in dog years.");
                Console.WriteLine("\t3. - What kind of cat are you?");
                Console.WriteLine("\t4. - Exquisite Corpse");
                Console.WriteLine("\t5. - Method Bodied Defitions");
                Console.WriteLine("\t6. - Caeser Cipher");
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
                        MethodBodiedDefinitions.CallMe();
                        break;
                    case "6":
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

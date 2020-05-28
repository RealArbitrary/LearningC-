using System;
using System.Runtime.Serialization;
using System.Linq;

namespace learningC
{

    public class Program
    {
        //My "UI"
        //From here I call my inhereted classes. These classes are small projects that demonstrate the different uses of C#.

        static void Main(string[] args)
        {
            //A region to minize, try it, it looks cooler when there is less!
            #region
            bool endApp = false;
            Console.Write("To get started, please enter your name: ");
            string userName = Console.ReadLine();
            
            while (!endApp)
            {
                Console.WriteLine($"\nWelcome {userName} to De Wet's fun C# examples\r");
                Console.WriteLine("-----------------------------------" + "\n");
                Console.WriteLine("Please select one of the following:\n");
                Console.WriteLine("\t0. - Exit");
                //Phrase Checker is an introduction to using user input to do something, control flow and conditional logic.
                Console.WriteLine("\t1. - Phrase checker");
                //Dog Year Calculator is an introduction to ASCII art in C#.
                Console.WriteLine("\t2. - Dog Year Calculator");
                //Kitten Cuisine is a further exercise for program flow and using user input to do stuff.
                Console.WriteLine("\t3. - Kitten Cuisine");
                //Exquisite corpse is one of the more advanced ones, demonstrating how to use parameterless methods, methods with parameters,
                //user input, data conversions and essentially how easy it is to make a game in C#.
                Console.WriteLine("\t4. - Exquisite Corpse");
                //Caeser Cipher uses a very old way of encryption along with some technology to automate it!
                //Demonstrates how to use arrays and user input together.
                Console.WriteLine("\t5. - Caeser Cipher");
                //True or False uses boolean logic to make the end user write a small test. This demonstrates how easy it is to 
                //make basic and advanced decisions in C# using conditionals.
                Console.WriteLine("\t6. - True or False");
                //OOYA is Profile.cs - example of how to use a constructor.
                Console.WriteLine("\t7. - OOYA");
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
                    case "6":
                        TrueOrFalse.CallMe();
                        break;
                    case "7":
                        Profile.CallMe();
                        break;
                    default:
                        Console.WriteLine("Whoops! That does not exist." + "\n");
                        break;

                }

            }
            #endregion

        }

    }

}

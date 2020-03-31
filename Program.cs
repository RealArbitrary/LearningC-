using System;
using System.Linq;

namespace learningC
{
    class Program
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
                Console.WriteLine("\t4. - Password strength checker.");
                Console.WriteLine("\n");
                Console.Write("Your option: ");
                switch (Console.ReadLine())
                {
                    case "0": //Exit
                        endApp = true;
                        break;
                    case "1": //Phrase Checker
                        Console.WriteLine("\n");
                        Console.WriteLine("This option lets you enter any phrase. Then the system will tell you if your phrase contains an uppercase or not.\n");
                        Console.WriteLine("Please enter your phrase to continue");
                        string password = Console.ReadLine();
                        bool hasUpper = password.Any(char.IsUpper);
                        string firstRes = $"Your phrase contains an uppercase letter.";
                        string secondRes = "Your phrase does not contain an uppercase letter.";
                        if (hasUpper == true)
                        {
                            Console.WriteLine(firstRes + "\n");
                        }
                        else
                        {
                            Console.WriteLine(secondRes + "\n");
                        }

                        break;
                    case "2": //Dog year calculator
                        Console.WriteLine("\n");
                        Console.Write("Enter your age to find out what it will be in dog years: ");
                        int userAge = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"You entered {userAge}. Calculating....\n");
                        int dogYears = 7;
                        int userAgeInDogYears = userAge * dogYears;
                        Console.WriteLine($"Awesome! Your age in dog years is {userAgeInDogYears}!\n");
                        Console.WriteLine(@"  ___    ___");
                        Console.WriteLine(@" / / \__/ \ \");
                        Console.WriteLine(@" \/| /\/\ |\/");
                        Console.WriteLine(@"  _||o o ||_");
                        Console.WriteLine(@" /. .\__/. .\");
                        Console.WriteLine(@"/ . .(__) . .\");
                        Console.WriteLine(@"\ .  /__\  . /");
                        Console.WriteLine(@" \__/\__/\__/");
                        Console.WriteLine("\n");
                        break;
                    case "3":
                        Console.WriteLine("\n");
                        Console.WriteLine("Choose one of these fast foods and that will determine what kind of cat you are." + "\n");
                        Console.WriteLine("\t1. Pizza");
                        Console.WriteLine("\t2. Hamburger");
                        Console.WriteLine("\t3. Fish & Chips");
                        Console.WriteLine("\n");
                        Console.Write("Your option: ");
                        string fastFoodType = Console.ReadLine();
                        string writeTemplate = "You are a";
                        switch (fastFoodType)
                        {
                            case "1":
                                Console.WriteLine($"{writeTemplate} Bambino!" + "\n");
                                break;
                            case "2":
                                Console.WriteLine($"{writeTemplate} German Rex!" + "\n");
                                Console.WriteLine("\n");
                                break;
                            case "3":
                                Console.WriteLine($"{writeTemplate} Havana Brown!" + "\n");
                                break;
                            default:
                                Console.WriteLine("Whoops! That does not exist. Please enter something from the list." + "\n");
                                break;
                        }
                        break;
                    case "4":
                        Console.Write("Please enter a password to continue: ");
                        break;
                    default:
                        Console.WriteLine("Whoops! That does not exist." + "\n");
                        break;

                }

            }
            
        }

    }

}

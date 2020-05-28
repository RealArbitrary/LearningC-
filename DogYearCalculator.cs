using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace learningC
{
    class DogYearCalculator : Program
    {
        public static void CallMe()
        {
            bool isDogYearCalculatorRunning = true;

            while (isDogYearCalculatorRunning == true)
            {
                Console.WriteLine($"\nDog Year Calculator\r");
                Console.WriteLine("---------------------" + "\n");
                Console.WriteLine("This option calculates your age in dog years!\n");
                Console.WriteLine("\t0. - Back");
                Console.WriteLine("\t1. - Play Dog Year Calculator");
                Console.Write("\nYour option: ");

                switch (Console.ReadLine())
                {
                    case "0":
                        isDogYearCalculatorRunning = false;
                        break;
                    case "1":
                        Console.Write("\nEnter your age to find out what it will be in dog years: ");
                        int userAge = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"\nYou entered {userAge}. Calculating....\n");
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
                    default:
                        break;
                }
            }
        }
    }
}

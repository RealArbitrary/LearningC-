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
        }
    }
}

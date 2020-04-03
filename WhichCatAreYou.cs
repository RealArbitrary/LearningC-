using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningC
{
    class WhichCatAreYou : Program
    {
        public static void CatCalculator()
        {
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
        }
    }
}

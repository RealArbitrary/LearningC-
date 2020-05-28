using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningC
{
    class WhichCatAreYou : Program
    {
        public static void CallMe()
        {
            bool isKittenCuisineRunning = true;
            while (isKittenCuisineRunning == true)
            {
                Console.WriteLine($"\nKitten Cuisine\r");
                Console.WriteLine("---------------------" + "\n");
                Console.WriteLine("This option determines which cat you are based on your favorite fast food!\n");
                Console.WriteLine("\t0. - Back");
                Console.WriteLine("\t1. - Play Kitten Cuisine");
                Console.Write("\nYour option: ");

                switch (Console.ReadLine())
                {
                    case "0":
                        isKittenCuisineRunning = false;
                        break;
                    case "1":
                        Console.WriteLine("\nChoose one of these fast foods which determines what kind of cat you are." + "\n");
                        Console.WriteLine("\t1. Pizza");
                        Console.WriteLine("\t2. Hamburger");
                        Console.WriteLine("\t3. Fish & Chips");
                        Console.Write("\nYour option: ");
                        string fastFoodType = Console.ReadLine();
                        string writeTemplate = "\nYou are a";
                        switch (fastFoodType)
                        {
                            case "1":
                                Console.WriteLine($"{writeTemplate} Bambino!" + "\n");
                                break;
                            case "2":
                                Console.WriteLine($"{writeTemplate} German Rex!" + "\n");
                                break;
                            case "3":
                                Console.WriteLine($"{writeTemplate} Havana Brown!" + "\n");
                                break;
                            default:
                                Console.WriteLine("Whoops! That does not exist. Please enter something from the list." + "\n");
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

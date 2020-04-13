using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Credit Codeacademy for the idea and some of the base code

namespace learningC
{
    class ExquisiteCorpse : Program
    {
        public static void CallMe()
        {
            bool exquisiteCorpse = true;
            while (exquisiteCorpse == true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Welcome to Exquisite Corpse\r");
                Console.WriteLine("---------------------------" + "\n");
                Console.WriteLine("\t0. Back");
                Console.WriteLine("\t1. Build your own creature!");
                Console.WriteLine("\t2. Let the program create a random creature!");
                

                switch (Console.ReadLine())
                {
                    case "0":
                        exquisiteCorpse = false;
                        break;
                    case "1":
                        //Console.WriteLine("Select which head your creature must have:\n");
                        //Console.WriteLine("\t1. Bug Head");
                        //Console.WriteLine("\t2. Ghost Head");
                        //Console.WriteLine("\t3. Monster Head");
                        //Console.WriteLine("\n");
                        //string userHead = Console.ReadLine();
                        //Console.WriteLine($"You chose {userHead}");
                        //Console.WriteLine("Select which body your creature must have:\n");
                        //Console.WriteLine("\t1. Bug Body");
                        //Console.WriteLine("\t2. Ghost Body");
                        //Console.WriteLine("\t3. Monster Body");
                        //Console.WriteLine("\n");
                        //string userBody = Console.ReadLine();
                        //Console.WriteLine("Select which feet your creature must have:\n");
                        //Console.WriteLine("\t1. Bug Feet");
                        //Console.WriteLine("\t2. Ghost Feet");
                        //Console.WriteLine("\t3. Monster Feet");
                        //Console.WriteLine("\n");
                        //string userFeet = Console.ReadLine();
                        //BuildACreature(userHead, userBody, userFeet);
                        BuildACreature("ghost", "monster", "bug");
                        break;
                    case "2":
                        RandomMode();
                        break;
                    default:
                        break;
                }
            }
            
        }



        static void BuildACreature(string head, string body, string feet)
        {
            int headNum = TranslateToNumber("head");
            int bodyNum = TranslateToNumber("body");
            int feetNum = TranslateToNumber("feet");
            SwitchCase(headNum, bodyNum, feetNum);
        }

        static void RandomMode()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);

            SwitchCase(head, body, feet);
        }

        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    BugHead();
                    break;
                case 2:
                    GhostHead();
                    break;
                case 3:
                    MonsterHead();
                    break;
                default:
                    break;
            }

            switch (body)
            {
                case 1:
                    BugBody();
                    break;
                case 2:
                    GhostBody();
                    break;
                case 3:
                    MonsterBody();
                    break;
                default:
                    break;
            }

            switch (feet)
            {
                case 1:
                    BugFeet();
                    Console.WriteLine("\n");
                    break;
                case 2:
                    GhostFeet();
                    Console.WriteLine("\n");
                    break;
                case 3:
                    MonsterFeet();
                    Console.WriteLine("\n");
                    break;
                default:
                    break;
            }

        }

        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "bug":
                    return 1;
                case "ghost":
                    return 2;
                case "monster":
                    return 3;
                default:
                    return 1;
            }
        }

        


        #region
        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }
        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
        #endregion
    }
}

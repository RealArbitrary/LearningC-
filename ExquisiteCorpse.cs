using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningC
{
    class ExquisiteCorpse : Program
    {
        public static void CallMe()
        {
            bool exquisiteCorpse = true;
            while (exquisiteCorpse == true)
            {
                Console.WriteLine("\nExquisite Corpse\r");
                Console.WriteLine("---------------------------" + "\n");
                Console.WriteLine("\t0. Back");
                Console.WriteLine("\t1. Build your own creature!");
                Console.WriteLine("\t2. Let the program create a random creature!");
                Console.Write("\nYour option: ");

                switch (Console.ReadLine())
                {
                    case "0":
                        exquisiteCorpse = false;
                        break;
                    case "1":
                        HeadInstruction();
                        int userHead = Convert.ToInt32(Console.ReadLine());
                        BodyInstruction();
                        int userBody = Convert.ToInt32(Console.ReadLine());
                        FeetInstruction();
                        int userFeet = Convert.ToInt32(Console.ReadLine());
                        SwitchCase(userHead, userBody, userFeet);
                        break;
                    case "2":
                        RandomMode();
                        break;
                    default:
                        break;
                }
            }
            
        }
        //Console parameters for user
        #region
        static void HeadInstruction()
        {
            Console.WriteLine("Select which head your creature must have:\n");
            Console.WriteLine("\t1. Bug Head");
            Console.WriteLine("\t2. Ghost Head");
            Console.WriteLine("\t3. Monster Head");
            Console.WriteLine("\n");
        }

        static void BodyInstruction()
        {
            Console.WriteLine("Select which body your creature must have:\n");
            Console.WriteLine("\t1. Bug Body");
            Console.WriteLine("\t2. Ghost Body");
            Console.WriteLine("\t3. Monster Body");
            Console.WriteLine("\n");
        }

        static void FeetInstruction()
        {
            Console.WriteLine("Select which feet your creature must have:\n");
            Console.WriteLine("\t1. Bug Feet");
            Console.WriteLine("\t2. Ghost Feet");
            Console.WriteLine("\t3. Monster Feet");
            Console.WriteLine("\n");
        }
        #endregion

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

        //Cannot seem to get this working.. TODO: Try and implement this at some point.
        //This is code refactoring that is suppose to convert user selection to string.
        //But when I run it and select 1, 2, 3 - or any combination my TranslateToNumber
        //keeps returning default of 1.
        #region
        //static void BuildACreature(string head, string body, string feet)
        //{
        //    int headNum = TranslateToNumber("head");
        //    int bodyNum = TranslateToNumber("body");
        //    int feetNum = TranslateToNumber("feet");
        //    SwitchCase(headNum, bodyNum, feetNum);
        //}

        //static int TranslateToNumber(string creature)
        //{
        //    switch (creature)
        //    {
        //        case "bug":
        //            return 1;
        //        case "ghost":
        //            return 2;
        //        case "monster":
        //            return 3;
        //        default:
        //            return 1;
        //    }
        //}
        #endregion
    }
}

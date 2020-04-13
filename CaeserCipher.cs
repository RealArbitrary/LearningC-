using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningC
{
    class CaeserCipher : Program
    {
        public static void CallMe()
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        }

        static void UserAction()
        {
            Console.WriteLine("Please provide the message: ");
            string message = Console.ReadLine();
            char[] secretMessage = message.ToCharArray();
        }
    }
}

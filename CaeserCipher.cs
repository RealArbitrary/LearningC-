using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A cool CodeAcademy application

namespace learningC
{
    class CaeserCipher : Program
    {
        public static void CallMe()
        {
            bool caeserChiperIsRunning = true;
            while (caeserChiperIsRunning == true)
            {
                Console.WriteLine($"\nCaeser Cipher Encoding\r");
                Console.WriteLine("-----------------------------------" + "\n");
                Console.WriteLine("\t0. - Back");
                Console.WriteLine("\t1. - Caeser Cipher Encoding\n");

                switch (Console.ReadLine())
                {
                    case "0":
                        caeserChiperIsRunning = false;
                        break;
                    case "1":
                        Console.WriteLine("Caeser Cipher encoding encrypts your input.\n");
                        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                        Console.WriteLine("Please provide the message: ");
                        string input = Console.ReadLine();
                        string inputLowerCase = input.ToLower();
                        char[] secretMessage = inputLowerCase.ToCharArray();

                        char[] encryptedMessage = new char[secretMessage.Length];

                        for (int i = 0; i < secretMessage.Length; i++)
                        {
                            char letter = secretMessage[i];
                            int letterPosition = Array.IndexOf(alphabet, letter);
                            int newLetterPosition = letterPosition + 3 % 26;
                            char letterEncoded = alphabet[newLetterPosition];
                            encryptedMessage[i] = letterEncoded;
                        }

                        string encodedString = String.Join("", encryptedMessage);
                        Console.WriteLine($"Your encoded message is: {encodedString}");
                        break;
                    default:
                        break;
                }
                

            }
            

        }

    }
}

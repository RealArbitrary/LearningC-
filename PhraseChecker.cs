using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningC
{
    public class PhraseChecker : Program
    {

        public static void CheckPhrase()
        {
            Console.WriteLine("\n");
            Console.WriteLine("This option lets you enter any phrase. Then the system will tell you if your phrase contains an uppercase or not.\n");
            Console.WriteLine("Please enter your phrase to continue");
            string phrase = Console.ReadLine();
            bool hasUpper = phrase.Any(char.IsUpper);
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


        }
    }
}

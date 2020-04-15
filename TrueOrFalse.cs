using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningC
{
    class TrueOrFalse : Program
    {
        public static void CallMe()
        {
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            Console.ReadLine();

            string[] questions = new string[]
            { "\n12 x 4 = 48",
                "\n24 / 6 = 6",
                "\n1 + 1 = 3"
            };
            bool[] answers = new bool[] 
            {
                true,
                false,
                false
            };

            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Too many questions, too little answers...");
            }

            int askingIndex = 0;

            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine(question);
                Console.WriteLine("True or False?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("\n\"true\" or \"false\" only.\n");
                    Console.WriteLine(question);
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex++;

            }

            //Test responses
            #region
            //foreach (bool response in responses)
            //{
            //    Console.WriteLine(response);
            //}
            #endregion

            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.Write(scoringIndex + 1 + ". ");
                Console.WriteLine($"You said {response} | The answer is {answer}");

                if (response == answer)
                {
                    score++;

                }
                scoringIndex++;
            }
            Console.WriteLine($"You scored {score} out of {questions.Length}");
        }
    }
}

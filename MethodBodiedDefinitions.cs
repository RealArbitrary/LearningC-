using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningC
{
    class MethodBodiedDefinitions : Program
    {
        int[] numbers = { 1, 3, 5, 6, 7, 8 };

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static void CallMe() => Console.WriteLine(IsEven(5));
    }
}

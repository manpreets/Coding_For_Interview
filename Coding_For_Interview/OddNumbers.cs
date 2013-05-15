using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_For_Interview
{
    public static class OddNumbers
    {
        public static void PrintOddNumbersN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (IsOdd(i))
                    Console.WriteLine(i + " is Odd ");
            }
        }
        public static bool IsOdd(int val)
        {
            return val % 2 != 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_For_Interview
{
    public static class MultiplicationTable
    {
        public static void PrintMultiplicationTable(double n)
        {
            Console.WriteLine("");
            Console.WriteLine("_______________________________________");
            for (double i = 1; i <= n; i++)
            {
                for (double j = 1; j <= n; j++)
                {
                    Console.Write(i * j + "|");
                }
                Console.WriteLine("");
                Console.WriteLine("___________________________________");
            }
        }
    }
}

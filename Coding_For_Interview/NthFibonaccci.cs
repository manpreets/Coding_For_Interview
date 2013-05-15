using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_For_Interview
{
    public static class NthFibonaccci
    {
        public static int FibonacciN(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                b = a + b;
                a = b - a;
            }
            // a = 0 b = 1; b=1 a=1; b=2 a=1; b=3 a=2; b=5 a=3 
            return a;
        }
    }
}

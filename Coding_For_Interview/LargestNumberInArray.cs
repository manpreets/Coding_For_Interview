using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_For_Interview
{
    public static class LargestNumberInArray
    {
        public static int GetLargestNumberInArray(int[] a)
        {
            int largest = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > largest) largest = a[i];
            }

            return largest;
        }
    }
}

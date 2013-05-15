using System;
using System.Collections.Generic;

namespace Coding_For_Interview
{
    public static class SmalleastNumber
    {
        public static int GetIndexSmallestIntinArray(int[] A)
        {
            int smallestIndex = -1;
            int smallestNumber = int.MaxValue;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= smallestNumber)
                {
                    smallestIndex = i;
                    smallestNumber = A[i];
                }
            }
            return smallestIndex;
        }
    }
}

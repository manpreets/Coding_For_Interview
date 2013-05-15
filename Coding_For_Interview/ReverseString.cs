using System;
using System.Collections.Generic;

namespace Coding_For_Interview
{
    public static class ReverseString
    {
        public static string ReverseStringUsingChar(string str)
        {
            string result = "";

            char[] originalCharArray = str.ToCharArray();

            for (int i = originalCharArray.Length - 1; i >= 0; i--)
            {
                result += originalCharArray[i];
            }

            return result;
        }

        public static string ReverseStringUsingArrayReverse(string str)
        {
            char[] charArray = str.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
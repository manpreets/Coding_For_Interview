using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_For_Interview
{
    public static class StringOperations
    {
        private static Random _randomDateTimeTick = new Random((int)DateTime.Now.Ticks);
        private static Random _random = new Random();
        /// <summary>
        /// This method returns a random generted by tick of the DateTime.Now using n characters where n is int value input
        /// </summary>
        /// <param name="n"></param>
        /// <returns>string</returns>
        public static string GetRandomDateTimeTickNChars(int n)
        {
            StringBuilder sb = new StringBuilder();
            
            char ch;
            
            for (int i = 0; i < n; i++)
            { 
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * _randomDateTimeTick.NextDouble() + 65)));
                sb.Append(ch);
            }


            return sb.ToString();
        }
        /// <summary>
        /// This method use a Random object and generates charactor 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string GetRandomNChars(int n)
        {
            StringBuilder sb = new StringBuilder();

            char ch;

            for (int i = 0; i < n; i++)
            {
                int num = _random.Next(0, 26);
                ch = (char)('a' + num);
                sb.Append(ch);
            }

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>string</returns>
        public static string GetNumberofRepetitionsCharacter(string inputString)
        {
            StringBuilder sbOut = new StringBuilder();

            var result = new Dictionary<char, int>();
            foreach (var chr in inputString)
            {
                if (result.ContainsKey(chr))
                {
                    result[chr]++;
                    continue;
                }
                result.Add(chr, 1);
            }

            foreach (var item in result)
            {
                sbOut.AppendLine(String.Format("Char: {0}, Count: {1}", item.Key, item.Value));
            }

           return sbOut.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_For_Interview
{
    class Program
    {
        static void Main(string[] args)
        {


            ////Reverse a string using a char array
            //Console.WriteLine("ReverseStringUsingChar");
            //Console.WriteLine(ReverseString.ReverseStringUsingChar("Manpreet"));

            ////Reverse a string using Array objects method that reverse the elements in any array
            //Console.WriteLine("ReverseStringUsingArray");
            //Console.WriteLine(ReverseString.ReverseStringUsingArrayReverse("Manpreet"));

            ////Fibonecci series for 20

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(NthFibonaccci.FibonacciN(i));
            //}

            ////Print multiplication table for nxn
            //MultiplicationTable.PrintMultiplicationTable(12);

            ////Read file and get number of lines in it

            //Console.WriteLine("Number of lines in given file : " + ReadTextFile.LinesInTextFile("c:\\testcode.txt"));

            // Print number type from n numbers
            //OddNumbers.PrintOddNumbersN(199);

            //Get hex string from three bytes
            //Console.WriteLine(" HEX for (15, 234, 213) : " + FormatNumbers.GetRGBinHex(15, 234, 213));

            //TEst array for index of smallest item in int array
            
            //int[] A = {34234,1,3,55345,34234,3432423,3423,234,234234,234234,3423423,342342,3,454235,4,24352345,1,4545 };

            //Console.WriteLine(" Smallest index : " + SmalleastNumber.GetIndexSmallestIntinArray(A));

            Console.WriteLine(CamelCase.CamelCaseToLower("anotherCamelCaseZingfsdfFSdfsdfsDsdfsdfSDfSDAfSaDFSADFSAdFsDFdfSdfsdF"));



            Console.WriteLine(CardSurcharge.GetSurcharge("Visa", .0000000001m));

        }
    }
}

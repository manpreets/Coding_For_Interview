using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_For_Interview
{
    public static class ReadTextFile
    {
        public static int LinesInTextFile(string filepath)
        {
            int counter = 0;

            System.IO.StreamReader file = new System.IO.StreamReader(filepath);

            while (file.ReadLine() != null)
            {
                counter++;
            }

            return counter;
        }
    }
}

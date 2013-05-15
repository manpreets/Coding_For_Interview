using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_For_Interview
{
    public static class FormatNumbers
    {
        public static string GetRGBinHex(byte r, byte g, byte b)
        {
            byte[] data = {r,g,b};
            string hex = BitConverter.ToString(data);
            hex = hex.Replace("-", "");

            return hex;
        }
    }
}

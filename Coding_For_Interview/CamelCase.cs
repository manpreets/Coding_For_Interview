using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_For_Interview
{
    public class CamelCase
    {
        public static string CamelCaseToLower(string strCamel)
        {
            string strLower = "";

            char[] charCamel = strCamel.ToCharArray();

            for(int i=0; i<=charCamel.Length-1; i++)
            {
                if (char.IsUpper(charCamel[i]) && i != 0 )
                {
                    strLower = strLower + '-' + charCamel[i];
                }
                else
                {
                    strLower = strLower + charCamel[i];
                }
            }

            strLower = strLower.ToLower();

            return strLower;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTestingDLL
{
    public class Asccitohexa
    {

        public static int String2Hex(ref string S1, ref string sname2)
        {

            string result = String.Empty;

            foreach(char c in  S1.ToCharArray())
            {
                if (string.CompareOrdinal(c.ToString(), "\r") == 0)
                {
                    result = S1.Replace("\r", "[0D]\n");
                    sname2 = result;
                }
            }

            return 0;
        }

        public static void printstring(ref string s1)
        {

            Console.WriteLine(s1);
        }
    }
}

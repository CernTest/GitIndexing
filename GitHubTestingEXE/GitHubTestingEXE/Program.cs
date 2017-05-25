using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitHubTestingDLL;

namespace GitHubTestingEXE
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1 = "this is a string variable";
            string s2 = null;            

            Asccitohexa.String2Hex(ref s1, ref s2);

            Asccitohexa.printstring(ref s1);
            Asccitohexa.printstring(ref s2);

        }
    }
}

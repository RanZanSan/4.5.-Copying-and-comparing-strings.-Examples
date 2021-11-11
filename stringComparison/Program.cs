using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Josef";

            string t1 = "Jo";
            string t2 = "sef";
            string s2 = t1 + t2;

            Console.WriteLine(s1 == s2);
            Console.ReadKey();
        }
    }
}
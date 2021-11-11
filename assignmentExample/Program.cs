using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";
            string t = s;
            s += "!";

            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
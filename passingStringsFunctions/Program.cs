using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passingStringsFunctions
{
    class Program
    {
        static void Modify(string value)
        {
            value += "!";
        }

        static void Main(string[] args)
        {
            string s = "hello";
            Modify(s);

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
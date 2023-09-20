using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int newInt = 10;
            double newFloat = 8.4;
            string newStr = "True";

            double bigInt = newInt * 3.5;

            newFloat -= 1.0;

            Console.WriteLine(newInt / newFloat);

            Console.WriteLine(bigInt / newFloat);

            newStr = "NoNo" + newStr + "YesYesYes";

            Console.WriteLine("newInt: " + newInt);
            Console.WriteLine("newFloat: " + newFloat);
            Console.WriteLine("newStr: " + newStr);
        }
    }
}

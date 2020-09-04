using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // tutorial-07
            // KinderGarden Mathes
            Console.WriteLine("KinderGarden Mathes");
            Console.WriteLine("56 + 56 = " + (56 + 56));
            Console.WriteLine("6 - 56 = " + (6 - 56));
            Console.WriteLine("5 * 6 = " + (5 * 6));
            Console.WriteLine("56 / 56 = " + (56 / 56));
            Console.WriteLine("56 % 53 = " + (56 % 53) + "\n");

            // operator priority (precedence)
            Console.WriteLine("operator priority");
            Console.WriteLine("56 * 56 / 6 = " + (56 * 56 / 6));
            Console.WriteLine("56 * (56 / 6) = " + (56 * (56 / 6)) + "\n");

            // Conditions for implicit type convertion
            Console.WriteLine("Conditions for implicit type convertion");
            Console.WriteLine("5 / 2 = " + (5 / 2));
            Console.WriteLine("5 / 2.0 = " + (5 / 2.0) + "\n");

            // Uranary operators
            int i = 0;
            Console.WriteLine("Uranary operators");
            Console.WriteLine("int i = 0;");
            Console.WriteLine("i++ => " + (i++)); // returns before adding 1
            Console.WriteLine("i => " + i);
            Console.WriteLine("++i => " + (++i)); // returns after adding 1
            Console.WriteLine("i => " + i);
            Console.WriteLine("--i => " + (--i)); // returns after subtracting 1
            Console.WriteLine("i => " + i);
            Console.WriteLine("i-- => " + (i--)); // returns before subtracting 1
            Console.WriteLine("i => " + i + "\n");

            // Math methods
            Console.WriteLine("Math methods");
            Console.WriteLine("Math.Abs(-59) => " + Math.Abs(-59)); // absolute value
            Console.WriteLine("Math.Pow(25,0.5) => " + Math.Pow(25, 0.5)); // power
            Console.WriteLine("Math.Sqrt(25) => " + Math.Sqrt(25)); // square-root
            Console.WriteLine("Math.Max(25, 625) => " + Math.Max(25, 625)); // Max of two 32 bit numbers
            Console.WriteLine("Math.Min(25, 625) => " + Math.Min(25, 625)); // Min of two 32 bit numbers
            Console.WriteLine("Math.Round(3.14159265359, 2) => " + Math.Round(3.14159265359, 2));
            Console.WriteLine("Math.Round(3.14159265359, 3) => " + Math.Round(3.14159265359, 3));
            // round of of Ist parameter upto IInd parameter
            // and in absence of IInd parameter, it's assumed to be 0.
            Console.WriteLine("Math.Round(3.14159265359) => " + Math.Round(3.14159265359));
            Console.ReadLine(); // to make cmd stay on-screen
        }
    }
}

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
            // tutorial-10
            Console.Write("Enter a number :");
            double num1 = Convert.ToDouble(Console.ReadLine()) ; // String to 32Bit number
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            //// Try Uncomment this one.
            //Console.WriteLine("Sum of " + num1 + " and " + num2 + " is " + num1 + num2); 
            Console.WriteLine("Sum of " + num1+ " and " + num2 + " is " + (num1+num2));

            Console.ReadLine(); // to make cmd stay on-screen
        }
    }
}

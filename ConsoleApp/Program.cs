using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //tutorial-39
            decimal num1, num2, result;
            try
            {
                Console.Write("Num1: ");
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Num2: ");
                num2 = Convert.ToDecimal(Console.ReadLine());
                result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} == {result}");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine(e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Can not divide by zero.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Have a nice day!");
            }
            Console.ReadLine(); // to make cmd stay on-screen
        }
           

    }
}

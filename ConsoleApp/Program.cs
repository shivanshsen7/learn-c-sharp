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
            //tutorial-35
            double num1, num2, result;
            Console.Write("Num1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Num2: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            result = num1 / num2;
            Console.WriteLine($"{num1} / {num2} == {result}");
            Console.ReadLine(); // to make cmd stay on-screen
        }
           

    }
}

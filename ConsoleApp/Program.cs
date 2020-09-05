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
            //tutorial-26
            double num1, num2;
            char operate;

            Console.Write("Enter a number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a Operator(single-character): ");
            operate = Convert.ToChar(Console.ReadLine());


            if ((operate != '*') && (operate != '/') && (operate != '-') && (operate != '+'))
            {
                Console.WriteLine("Invalid Operator," + operate + " Result is Invalid");
            }   
            Console.Write("Enter another number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("result: " + Calc(num1, operate, num2));
            Console.ReadLine(); // to make cmd stay on-screen
        }
        static double Calc(double a, char t, double b)
        {
            if (t == '+')
                return a + b;
            else if (t == '-')
                return a - b;
            else if (t == '*')
                return a * b;
            else if (t == '/')
                return a / b;
            else
                return 0;
        }
    }
}

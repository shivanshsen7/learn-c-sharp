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
            // task-01-completed
            // Complete "reMax" method that accept two integer and 
            // return the greater integer of the two
            // in case of equality return any of the two :)
            int num1 = 7, num2 = 77;
            int maxNum = reMax(num1, num2);
            Console.WriteLine("Max of " + num1 + " and " + num2 + " is " + maxNum);

            Console.ReadLine(); // to make cmd stay on-screen
        }
        // complete the method below
        static int reMax(int a, int b)
        {
            // approach 1
            if (a >= b)
                return a;
            else
                return b;


            // You can approach anyway you like. 
            // approach 2
            //if (a >= b) { return a; }
            //else { return b; }

            //// approach 3 
            //if (a > b)
            //{
            //    return a;
            //}
            //else if (b < a)
            //{
            //    return b;
            //}
            //else
            //{
            //    return a;
            //}
        }
    }
}

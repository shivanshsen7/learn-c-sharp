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
            // tutorial-18 
            int num, numCube; 
          
            Console.Write("Enter a integer: ");
            num = Convert.ToInt32(Console.ReadLine());
            numCube = Cube(num);
            // need to use so assigned to a variable
            // while it will return nothing seems to happen unless wee use the return data
            Console.WriteLine(numCube);
            Console.ReadLine(); // to make cmd stay on-screen
        }

        static int Cube(int number) 
        {
            return number * number * number;
            // can't use Math.Pow(number, 3)
            // as that requires doubles
            // wait can we do that?

        }
    }
}

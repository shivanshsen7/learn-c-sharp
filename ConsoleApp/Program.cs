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
            // tutorial-19
            int num, numCube; 
          
            Console.Write("Enter a integer: ");
            num = Convert.ToInt32(Console.ReadLine());
            numCube = Cube(num);
            Console.WriteLine(numCube);
            Console.ReadLine(); // to make cmd stay on-screen
        }

        static int Cube(int number) 
        {
            // return Math.Pow(Convert.ToDouble(number), 3);// can not implict convert
            return Convert.ToInt32(Math.Pow(Convert.ToDouble(number), 3));
            // can't use Math.Pow(number, 3)
            // as that requires doubles
            // wait can we do that?
            // Oh Yeah!, we did it. But man what a drag!

        }
    }
}

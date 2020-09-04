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
            // tutorial-03
            string charName = "John";
            int charAge;
            charAge = 56;

            Console.WriteLine("There once was man named " + charName + ".");
            Console.WriteLine("He was " + charAge + " years old.");
            Console.WriteLine("He really liked his name " + charName + ",");
            Console.WriteLine("But he didn't like being " + charAge + " years old");
            Console.ReadLine(); // to make cmd stay on-screen
        }
    }
}

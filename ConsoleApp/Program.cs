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
            // tutorial-11
            string color, pluralNoun, celebrity;

            Console.Write("Enter a Color: ");
            color = Console.ReadLine();
            Console.Write("Enter a Plural Noun: ");
            pluralNoun = Console.ReadLine(); 
            Console.Write("Enter a  celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color + ".");
            Console.WriteLine( pluralNoun + " are Blue.");
            Console.WriteLine("I love " + celebrity + ".");


            Console.ReadLine(); // to make cmd stay on-screen
        }
    }
}

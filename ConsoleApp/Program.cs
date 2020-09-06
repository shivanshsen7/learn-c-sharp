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
            //tutorial-41
            Book HPOne = new Book();
            HPOne.title = "Harry Potter and the Philosopher's Stone";
            HPOne.author = "J.K. Rowling";
            HPOne.pages = 223; // Original U.K. Edition
            string HPOneFull = "First Harry Potter Book";
            Console.WriteLine($"{HPOneFull}'s Title is \"{HPOne.title}\""); 
            Console.WriteLine($"{HPOneFull}'s Author is \"{HPOne.author}\"");
            Console.WriteLine($"{HPOneFull}'s number of pages is \"{HPOne.pages}\"");
            Console.ReadLine(); // to make cmd stay on-screen
        }
           

    }
}

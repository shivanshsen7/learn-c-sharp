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
            //tutorial-43
            Book HPOne = new Book
            {
                title = "Harry Potter and the Philosopher's Stone",
                author = "J.K. Rowling",
                pages = 223 // Original U.K. Edition
            };
            string HPOneFull = "First Harry Potter Book";
            Console.WriteLine($"{HPOneFull}'s Title is \"{HPOne.title}\""); 
            Console.WriteLine($"{HPOneFull}'s Author is \"{HPOne.author}\"");
            Console.WriteLine($"{HPOneFull}'s number of pages is \"{HPOne.pages}\"");
            Console.WriteLine();

            Book HPTwo = new Book
            {
                title = "Harry Potter and the Chamber of Secrets",
                author = "J.K. Rowling",
                
            };
            HPTwo.pages = 251; // Original U.K. Edition
            string HPTwoFull = "Second Harry Potter Book";
            Console.WriteLine($"{HPTwoFull}'s Title is \"{HPTwo.title}\"");
            Console.WriteLine($"{HPTwoFull}'s Author is \"{HPTwo.author}\"");
            Console.WriteLine($"{HPTwoFull}'s number of pages is \"{HPTwo.pages}\"");

            Console.ReadLine(); // to make cmd stay on-screen
        }
           

    }
}

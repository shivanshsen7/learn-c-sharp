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
            //tutorial-31
            for(int i = 0; i<5; ++i)
            {
                Console.WriteLine(i+1);
            }
           
            Console.ReadLine(); // to make cmd stay on-screen
        }
        
    }
}

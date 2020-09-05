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
            //tutorial-33
            Console.WriteLine(GetPow(9, 3));
            Console.ReadLine(); // to make cmd stay on-screen
        }
        static int GetPow(int a,int b)
        {
            int result = 1;
            for(int i = 0; i < b; ++i)
            {
                result *= a;
            }
            return result;
        }   

    }
}

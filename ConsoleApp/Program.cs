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
            //tutorial-32
            int[] luckyNums = { 4, 8, 15, 16, 23, 42 };
            for(int i = 0; i<luckyNums.Length; ++i)
            {
                Console.WriteLine("luckyNums[" + i + "] = " + luckyNums[i]);
            }
            Console.ReadLine(); // to make cmd stay on-screen
        }
        
    }
}

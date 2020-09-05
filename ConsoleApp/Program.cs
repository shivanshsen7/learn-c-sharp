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
            // tutorial-12
            int[] luckyNumbers = { 1, 2, 3, 5 };
                   // indexing =>  0  1  2  3
            Console.WriteLine(luckyNumbers[0]); // first element
            luckyNumbers[0] = 11; // arrays are mutable
            Console.WriteLine(luckyNumbers[0]); // first element

            string[] usrNames = new string[5]; // 5 is limit of number of elements
            usrNames[0] = "USER00";
            usrNames[1] = "USER01";
            usrNames[2] = "USER02";
            usrNames[3] = "USER03";
            usrNames[4] = "USER04";
            Console.WriteLine(usrNames[0]);
            Console.WriteLine(usrNames[1]);
            Console.WriteLine(usrNames[2]);
            Console.WriteLine(usrNames[3]);
            Console.WriteLine(usrNames[4]);
            // invalid assignment
            //usrNames[5] = "USER05"; // string out of bounds
            //Console.WriteLine(usrNames[5]);
            Console.ReadLine(); // to make cmd stay on-screen
        }
    }
}

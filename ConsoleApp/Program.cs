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
            //tutorial-34
            int[,] twoD = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i=0; i<3; ++i)
            {
                for(int j = 0; j < 3; ++j)
                {
                    Console.WriteLine("twoD[i, j] = " + twoD[i, j]);
                }
            }
            // int[,,] threeD = new int[3, 4, 6];
            int[,,] threeD = {
                        { { 1,2,3,4,5,6},{ 7,8,9,10,11,12},{ 13,14,15,16,17,18,}, { 19,20,21,22,23,24} },
                        { { 1,2,3,4,5,6},{ 7,8,9,10,11,12},{ 13,14,15,16,17,18,}, { 19,20,21,22,23,24} },
                        { { 1,2,3,4,5,6},{ 7,8,9,10,11,12},{ 13,14,15,16,17,18,}, { 19,20,21,22,23,24} },
            };
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    for(int k = 0; k < 6; ++k)
                    {

                        Console.WriteLine("threeD[i, j, k] = " + threeD[i, j, k]);

                    }
                }
            }

            Console.ReadLine(); // to make cmd stay on-screen
        }
           

    }
}

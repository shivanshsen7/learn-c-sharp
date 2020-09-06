using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Book
    {
        public string author;
        public string title;
        public int pages;
        public Book(string author_, string title_, int pages_)
        {
            Console.WriteLine("New Book Created");
            author = author_;
            title = title_;
            pages = pages_;

        }
    }
}

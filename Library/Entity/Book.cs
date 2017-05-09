using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public int idBook { set; get; }
        public string title { set; get; }
        public int numPages { set; get; }
        public int numExem { set; get; }
        /*
        public Book() { }
        public Book(int id, string tname, int pages, int count)
        {
            idBook = id;
            title = tname;
            numPages = pages;
            numExem = count;
        }
        */
    }
}

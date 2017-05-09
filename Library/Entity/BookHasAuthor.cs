using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookHasAuthor
    {
        public int idAuthor { set; get; }
        public int idBook { set; get; }
        public BookHasAuthor() { }
        public BookHasAuthor(int idAuth, int idB)
        {
            idAuthor = idAuth;
            idBook = idB;
        }
    }
}

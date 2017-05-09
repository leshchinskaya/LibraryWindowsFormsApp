using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Author
    {
        public int idAuthor { set; get; }
        public string fio { set; get; }
        public Author() { }
        public Author(int id, string flsname)
        {
            idAuthor = id;
            fio = flsname;
        }
    }
}

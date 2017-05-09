using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Bookones
    {
        public int idBookone { set; get; }
        public string injury { set; get; }
        public int idBook { set; get; }
        public int idBank { set; get; }
        public Bookones() { }
        public Bookones(string inj, int idB, int idBn)
        {
            injury = inj;
            idBook = idB;
            idBank = idBn;
        }
    }
}

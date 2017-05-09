using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Student
    {
        public int idStudent { set; get; }
        public string name { set; get; }
        public string surname { set; get; }
        public string faculty { set; get; }
        public int course { set; get; }
        public int groupp { set; get; }
        public int cardNum { set; get; }
        public Student() { }
        public Student(string fname, string sname, string facultet, int cours, int group, int cardNumber)
        {
            //idStudent = id;
            name = fname;
            surname = sname;
            faculty = facultet;
            course = cours;
            groupp = group;
            cardNum = cardNumber;
        }
    }
}

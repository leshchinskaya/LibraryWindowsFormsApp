using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Getbook
    {
        public int idGetbook { set; get; }
        public DateTime giveDate { set; get; }
        public DateTime returnDate { set; get; }
        public DateTime realReturnDate { set; get; }
        public int cardNum { set; get; }
        public int idBookone { set; get; }
        public int idStudent { set; get; }
        public Getbook() { }
        public Getbook(DateTime gDate, DateTime rtrnDate, DateTime realRtrnDate, int cardNumber, int idBook1, int idStud)
        {
            //idGetbook = id;
            giveDate = gDate;
            returnDate = rtrnDate;
            realReturnDate = realRtrnDate;
            cardNum = cardNumber;
            idBookone = idBook1;
            idStudent = idStud;
        }
    }
}

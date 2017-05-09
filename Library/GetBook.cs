using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class GetBook : Form
    {
        DBController libDB = new DBController();
        int cardNumber;
        int idB;
        public GetBook()
        {
            InitializeComponent();
            Combobox_load();
        }

        public void Combobox_load()
        {
            comboBoxStudent.DataSource = libDB.GetAsTable("select * from Student");
            comboBoxStudent.DisplayMember = "surname";
            comboBoxStudent.ValueMember = "cardNum";
            cardNumber = Convert.ToInt32(comboBoxStudent.SelectedValue);
            comboBoxStudent.ValueMember = "idStudent";

            comboBoxBook.DataSource = libDB.GetAsTable("select * from Book");
            comboBoxBook.DisplayMember = "title";
            comboBoxBook.ValueMember = "idBook";
            idB = Convert.ToInt32(comboBoxBook.SelectedValue);

            comboBoxBookone.DataSource = libDB.GetAsTable("SELECT * FROM Bookones FULL OUTER JOIN Book ON Bookones.idBook = Book.idBook WHERE Bookones.idBook=" + idB + ";");
            comboBoxBookone.DisplayMember = "injury";
            comboBoxBookone.ValueMember = "idBookone";

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DateTime realRD = dateTimeGive.Value;
            DBController getbook = new DBController();
            DBController bk = new DBController();
            //Bookones bookone1 = new Bookones() { injury = this.textBoxInjury.Text, idBook = Convert.ToInt32(comboBoxBook.SelectedValue), idBank = Convert.ToInt32(comboBoxBank.SelectedValue) };

          
            int res2 = bk.UpdateBookminus(Convert.ToInt32(comboBoxBook.SelectedValue));
            int res1 = getbook.InsertGetbook(new Getbook(dateTimeGive.Value, dateTimeReturn.Value, realRD, cardNumber, Convert.ToInt32(comboBoxBookone.SelectedValue), Convert.ToInt32(comboBoxStudent.SelectedValue)));
            if (res1 > 0 && res2 >0)
            {
                MessageBox.Show("Done", "Successed", MessageBoxButtons.OK);
                this.Close();
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            comboBoxBook.ValueMember = "idBook";
            idB = Convert.ToInt32(comboBoxBook.SelectedValue);
            comboBoxBookone.DataSource = libDB.GetAsTable("SELECT * FROM Bookones FULL OUTER JOIN Book ON Bookones.idBook = Book.idBook WHERE Bookones.idBook=" + idB + ";");
            comboBoxBookone.DisplayMember = "injury";
            comboBoxBookone.ValueMember = "idBookone";
        }
    }
}

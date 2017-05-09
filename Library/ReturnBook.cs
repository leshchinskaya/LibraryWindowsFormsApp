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
    public partial class ReturnBook : Form
    {
        DBController libDB = new DBController();
        int idB;
        int idSt;

        public ReturnBook()
        {
            InitializeComponent();
            Combobox_load();
        }

        private void Combobox_load()
        {
            comboBoxStudent.DataSource = libDB.GetAsTable("select * from Student");
            comboBoxStudent.DisplayMember = "surname";
            comboBoxStudent.ValueMember = "idStudent";
  
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            DBController gb = new DBController();
            DBController bk = new DBController();

            int res2 = bk.UpdateBook(Convert.ToInt32(comboBoxBook.SelectedValue));
            int res = gb.UpdateGetbook(Convert.ToInt32(comboBoxBookone.SelectedValue), Convert.ToInt32(comboBoxStudent.SelectedValue), dateTimeRealReturnDate.Value);
            if (res > 0 && res2 > 0)
            {
                MessageBox.Show("Done", "Successed", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            comboBoxBook.ValueMember = "idBook";
            idB = Convert.ToInt32(comboBoxBook.SelectedValue);
            comboBoxBookone.DataSource = libDB.GetAsTable("SELECT * FROM  dbo.STUDENT INNER JOIN dbo.GETBOOK ON dbo.STUDENT.idStudent = dbo.GETBOOK.idStudent INNER JOIN dbo.BOOKONES ON dbo.GETBOOK.idBookone = dbo.BOOKONES.idBookone INNER JOIN dbo.BOOK ON dbo.BOOKONES.idBook = dbo.BOOK.idBook where dbo.Student.idStudent = " + idSt + "AND dbo.Book.idBook="+ idB + ";" );
            comboBoxBookone.DisplayMember = "injury";
            comboBoxBookone.ValueMember = "idBookone";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxStudent.ValueMember = "idStudent";
            idSt = Convert.ToInt32(comboBoxStudent.SelectedValue);

            comboBoxBook.DataSource = libDB.GetAsTable("SELECT * FROM  dbo.STUDENT INNER JOIN dbo.GETBOOK ON dbo.STUDENT.idStudent = dbo.GETBOOK.idStudent INNER JOIN dbo.BOOKONES ON dbo.GETBOOK.idBookone = dbo.BOOKONES.idBookone INNER JOIN dbo.BOOK ON dbo.BOOKONES.idBook = dbo.BOOK.idBook where dbo.Student.idStudent=" + idSt + ";");
            comboBoxBook.DisplayMember = "title";
            comboBoxBook.ValueMember = "idBook";
            idB = Convert.ToInt32(comboBoxBook.SelectedValue);

            comboBoxBookone.DataSource = libDB.GetAsTable("SELECT * FROM  dbo.STUDENT INNER JOIN dbo.GETBOOK ON dbo.STUDENT.idStudent = dbo.GETBOOK.idStudent INNER JOIN dbo.BOOKONES ON dbo.GETBOOK.idBookone = dbo.BOOKONES.idBookone INNER JOIN dbo.BOOK ON dbo.BOOKONES.idBook = dbo.BOOK.idBook where dbo.Student.idStudent = " + idSt + "AND dbo.Book.idBook=" + idB + ";");
            comboBoxBookone.DisplayMember = "injury";
            comboBoxBookone.ValueMember = "idBookone";
        }
    }
}

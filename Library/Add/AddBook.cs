using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBook : Form
    {
        DBController libDB = new DBController();
        public static int idB;
        public static int idAuth;
        //Boolean chek = false;
        public string fioAuth;

        public AddBook()
        {
            InitializeComponent();
            Combobox_load();
        }

        private void Combobox_load()
        {
            comboBoxAddBookFIOAuthor.DataSource = libDB.GetAsTable("select * from Author");
            comboBoxAddBookFIOAuthor.DisplayMember = "fio";
            //comboBoxAddBookFIOAuthor.ValueMember = "fio";
            //fioAuth = Convert.ToString(comboBoxAddBookFIOAuthor.SelectedValue);
            comboBoxAddBookFIOAuthor.ValueMember = "idAuthor";
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
                DBController book = new DBController();
                DBController bookauthor = new DBController();
                Book book1 = new Book() { title = this.textBoxTitle.Text, numPages = Convert.ToInt32(this.textBoxPages.Text), numExem = 1 };


                //int resBook = book.InsertBook(new Book(10, this.textBoxTitle.Text, Convert.ToInt32(this.textBoxPages.Text), 1));
                int resBook = book.InsertBook(book1);
                //MessageBox.Show(resBook.ToString());
                int resBookAuthor = bookauthor.InsertBookHasAuthor(new BookHasAuthor(Convert.ToInt32(this.comboBoxAddBookFIOAuthor.SelectedValue), resBook));

                if (resBook > 0)
                {
                    MessageBox.Show("Done", "Successed", MessageBoxButtons.OK);
                    this.Close();
                }
            using (var bookone = new AddBookone()) bookone.ShowDialog(this);
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            using (var author = new AddAuthor()) author.ShowDialog(this);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //chek = true;
            comboBoxAddBookFIOAuthor.ValueMember = "idAuthor";
            Combobox_load();
        }
    }
}

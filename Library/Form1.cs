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
    public partial class Form1 : Form
    {
        DBController db = new DBController();
        public Form1()
        {
            InitializeComponent();
            NuchLoad();
        }

        private void NuchLoad()
        {
            buttonAddAuthor.Enabled = false;
            buttonAddBank.Enabled = false;
            buttonAddBook.Enabled = false;
            buttonAddBookAuthor.Enabled = false;
            buttonAddBookone.Enabled = false;
            buttonGetBook.Enabled = false;
            buttonReturnBook.Enabled = false;
            addStudent.Enabled = false;

        }

        private void allStudents_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.LoadView("SELECT * FROM[Library3].[dbo].[AllStudent]");
        }

        private void allAuthors_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.LoadView("SELECT * FROM[Library3].[dbo].[AllAuthor]");
        }

        private void allBooks_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.LoadView("SELECT * FROM[Library3].[dbo].[AllBook]");
        }

        private void allStudentsAMM_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.LoadView("SELECT * FROM[Library3].[dbo].[SelectAMM]");
        }

        private void allStudentsAt1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.LoadView("SELECT * FROM[Library3].[dbo].[SelectFirstcourse]");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.LoadView("SELECT * FROM[Library3].[dbo].[AuthorBook]");
        }

        private void buttonStudentGetBook_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.LoadView("SELECT * FROM[Library3].[dbo].[StudentGetbook]");
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            using (var student = new AddStudent()) student.ShowDialog(this);
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            using (var book = new AddBook()) book.ShowDialog(this);
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            using (var author = new AddAuthor()) author.ShowDialog(this);
        }

        private void buttonGetBook_Click(object sender, EventArgs e)
        {
            using (var getBook = new GetBook()) getBook.ShowDialog(this);
        }

        private void buttonAddBank_Click(object sender, EventArgs e)
        {
            using (var bank = new AddBank()) bank.ShowDialog(this);
        }

        private void buttonAddBookone_Click(object sender, EventArgs e)
        {
            using (var bookone = new AddBookone()) bookone.ShowDialog(this);
        }

        private void buttonBookBookone_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.LoadView("SELECT * FROM[Library3].[dbo].[BookBookones]");
        }

        private void button2_Click(object sender, EventArgs e) //все библиотеки
        {
            dataGridView1.DataSource = db.LoadView("SELECT * FROM[Library3].[dbo].[AllBank]");
        }

        private void buttonAddBookAuthor_Click(object sender, EventArgs e)
        {
            using (var bookauthor = new AddBookAuthor()) bookauthor.ShowDialog(this);
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            using (var returnBook = new ReturnBook()) returnBook.ShowDialog(this);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string CurUserName =
                    System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            labelCurName.Text = CurUserName;

            // проверяем членство текущего пользователя
            bool InRoleDBO = (bool)db.CheckRole("dbo");
            bool InRoleOperators = (bool)db.CheckRole("operators");
            // если не ДБО и не оператор (менеджеров пока опустим)
            if (!(InRoleDBO | InRoleOperators))
            {
                MessageBox.Show("ERROR");
            }

            if (InRoleOperators)
            {
                MessageBox.Show("Operator");
                buttonAddAuthor.Enabled = false;
                buttonAddBank.Enabled = false;
                buttonAddBook.Enabled = false;
                buttonAddBookAuthor.Enabled = false;
                buttonAddBookone.Enabled = false;
                buttonGetBook.Enabled = false;
                buttonReturnBook.Enabled = false;
                addStudent.Enabled = false;
            }

            if (InRoleDBO)
            {
                MessageBox.Show("DBO");
                buttonAddAuthor.Enabled = true;
                buttonAddBank.Enabled = true;
                buttonAddBook.Enabled = true;
                buttonAddBookAuthor.Enabled = true;
                buttonAddBookone.Enabled = true;
                buttonGetBook.Enabled = true;
                buttonReturnBook.Enabled = true;
                addStudent.Enabled = true;

            }
        }
    }
}

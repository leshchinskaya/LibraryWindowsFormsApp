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
    public partial class AddBookAuthor : Form
    {
        DBController libDB = new DBController();
        public AddBookAuthor()
        {
            InitializeComponent();
            Combobox_load();
        }

        private void Combobox_load()
        {
            comboBoxBook.DataSource = libDB.GetAsTable("select * from Book");
            comboBoxBook.DisplayMember = "title";
            comboBoxBook.ValueMember = "idBook";

            comboBoxAuthor.DataSource = libDB.GetAsTable("select * from Author");
            comboBoxAuthor.DisplayMember = "fio";
            comboBoxAuthor.ValueMember = "idAuthor";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DBController bookauthor = new DBController();
            int resBookHasAuthor = bookauthor.InsertBookHasAuthor(new BookHasAuthor(Convert.ToInt32(this.comboBoxAuthor.SelectedValue), (Convert.ToInt32(this.comboBoxBook.SelectedValue))));

            if (resBookHasAuthor > 0)
            {
                MessageBox.Show("Done", "Successed", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}

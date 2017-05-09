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
    public partial class AddBookone : Form
    {
        DBController libDB = new DBController();
        public AddBookone()
        {
            InitializeComponent();
            Combobox_load();
        }

        private void Combobox_load()
        {
            comboBoxBook.DataSource = libDB.GetAsTable("select * from Book");
            comboBoxBook.DisplayMember = "title";
            comboBoxBook.ValueMember = "idBook";

            comboBoxBank.DataSource = libDB.GetAsTable("select * from Bank");
            comboBoxBank.DisplayMember = "placeName";
            comboBoxBank.ValueMember = "idBank";
            //id = Convert.ToInt32(comboBoxBook.ValueMember);
        }

        private void buttonAddBookone_Click(object sender, EventArgs e)
        {
            DBController bookones = new DBController();
            DBController bk = new DBController();
            //Bookones bookone1 = new Bookones() { injury = this.textBoxInjury.Text, idBook = Convert.ToInt32(comboBoxBook.SelectedValue), idBank = Convert.ToInt32(comboBoxBank.SelectedValue) };

            int res1 = bookones.InsertBookone(new Bookones(this.textBoxInjury.Text, Convert.ToInt32(comboBoxBook.SelectedValue), Convert.ToInt32(comboBoxBank.SelectedValue)));
            int res2 = bk.UpdateBook(Convert.ToInt32(comboBoxBook.SelectedValue));
            //int res = bookones.InsertBookone(bookone1);
            if (res1 > 0 && res2 > 0)
            {
                MessageBox.Show("Done", "Successed", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}

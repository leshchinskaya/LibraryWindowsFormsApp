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
    public partial class AddBank : Form
    {
        public AddBank()
        {
            InitializeComponent();
        }

        private void buttonAddBank_Click(object sender, EventArgs e)
        {
            DBController bank = new DBController();
            Bank bank1 = new Bank() {placeName = this.textBoxNamePlace.Text, numOfPlace= this.textBoxNumOfPlace.Text};
            int res = bank.InsertBank(bank1);
            //int res = bank.InsertBank(new Bank(10, this.textBoxNamePlace.Text, this.textBoxNumOfPlace.Text));
            if (res > 0)
            {
                MessageBox.Show("Done", "Successed", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}

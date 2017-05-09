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
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            DBController author = new DBController();
            int idauth = 71;
            int res = author.InsertAuthor(new Author(idauth, this.textBoxFIOAuthor.Text));
            if (res > 0)
            {
                MessageBox.Show("Done", "Successed", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}

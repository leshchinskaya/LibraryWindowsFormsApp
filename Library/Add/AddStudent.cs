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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            DBController student = new DBController();
            int res = student.InsertStudent(new Student(this.textBoxName.Text, this.textBoxSurname.Text, this.textBoxFaculty.Text, Convert.ToInt32(this.textBoxCourse.Text), Convert.ToInt32(this.textBoxGroup.Text), Convert.ToInt32(this.textBoxCardNum.Text)));
            if (res > 0)
            {
                MessageBox.Show("Done", "Successed", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}

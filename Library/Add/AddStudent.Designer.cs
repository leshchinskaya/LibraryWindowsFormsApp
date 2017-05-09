namespace Library
{
    partial class AddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelCardNum = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxFaculty = new System.Windows.Forms.TextBox();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.textBoxCardNum = new System.Windows.Forms.TextBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(35, 63);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(68, 25);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(35, 107);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(98, 25);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Surname";
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Location = new System.Drawing.Point(35, 151);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(82, 25);
            this.labelFaculty.TabIndex = 2;
            this.labelFaculty.Text = "Faculty";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(35, 203);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(81, 25);
            this.labelCourse.TabIndex = 3;
            this.labelCourse.Text = "Course";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(35, 250);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(71, 25);
            this.labelGroup.TabIndex = 4;
            this.labelGroup.Text = "Group";
            // 
            // labelCardNum
            // 
            this.labelCardNum.AutoSize = true;
            this.labelCardNum.Location = new System.Drawing.Point(35, 301);
            this.labelCardNum.Name = "labelCardNum";
            this.labelCardNum.Size = new System.Drawing.Size(139, 25);
            this.labelCardNum.TabIndex = 5;
            this.labelCardNum.Text = "Card Number";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(241, 57);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(322, 31);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(241, 101);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(322, 31);
            this.textBoxSurname.TabIndex = 7;
            // 
            // textBoxFaculty
            // 
            this.textBoxFaculty.Location = new System.Drawing.Point(241, 145);
            this.textBoxFaculty.Name = "textBoxFaculty";
            this.textBoxFaculty.Size = new System.Drawing.Size(322, 31);
            this.textBoxFaculty.TabIndex = 8;
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(241, 197);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(322, 31);
            this.textBoxCourse.TabIndex = 9;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(241, 244);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(322, 31);
            this.textBoxGroup.TabIndex = 10;
            // 
            // textBoxCardNum
            // 
            this.textBoxCardNum.Location = new System.Drawing.Point(241, 295);
            this.textBoxCardNum.Name = "textBoxCardNum";
            this.textBoxCardNum.Size = new System.Drawing.Size(322, 31);
            this.textBoxCardNum.TabIndex = 11;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(429, 349);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(134, 42);
            this.buttonAddStudent.TabIndex = 12;
            this.buttonAddStudent.Text = "ADD";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 403);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.textBoxCardNum);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.textBoxFaculty);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelCardNum);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.labelFaculty);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.LabelName);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelCardNum;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxFaculty;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.TextBox textBoxCardNum;
        private System.Windows.Forms.Button buttonAddStudent;
    }
}
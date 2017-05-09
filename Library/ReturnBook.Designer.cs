namespace Library
{
    partial class ReturnBook
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
            this.labelStudent = new System.Windows.Forms.Label();
            this.labelBook = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeRealReturnDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            this.labelBookone = new System.Windows.Forms.Label();
            this.comboBoxBookone = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(19, 41);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(86, 25);
            this.labelStudent.TabIndex = 0;
            this.labelStudent.Text = "Student";
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Location = new System.Drawing.Point(19, 155);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(61, 25);
            this.labelBook.TabIndex = 1;
            this.labelBook.Text = "Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Real return Date";
            // 
            // dateTimeRealReturnDate
            // 
            this.dateTimeRealReturnDate.Location = new System.Drawing.Point(243, 305);
            this.dateTimeRealReturnDate.Name = "dateTimeRealReturnDate";
            this.dateTimeRealReturnDate.Size = new System.Drawing.Size(280, 31);
            this.dateTimeRealReturnDate.TabIndex = 3;
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(243, 33);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(280, 33);
            this.comboBoxStudent.TabIndex = 4;
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(243, 147);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(280, 33);
            this.comboBoxBook.TabIndex = 5;
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.Location = new System.Drawing.Point(395, 351);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(128, 50);
            this.buttonReturnBook.TabIndex = 6;
            this.buttonReturnBook.Text = "OK";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // labelBookone
            // 
            this.labelBookone.AutoSize = true;
            this.labelBookone.Location = new System.Drawing.Point(19, 263);
            this.labelBookone.Name = "labelBookone";
            this.labelBookone.Size = new System.Drawing.Size(97, 25);
            this.labelBookone.TabIndex = 7;
            this.labelBookone.Text = "Bookone";
            // 
            // comboBoxBookone
            // 
            this.comboBoxBookone.FormattingEnabled = true;
            this.comboBoxBookone.Location = new System.Drawing.Point(243, 255);
            this.comboBoxBookone.Name = "comboBoxBookone";
            this.comboBoxBookone.Size = new System.Drawing.Size(280, 33);
            this.comboBoxBookone.TabIndex = 8;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(307, 192);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(216, 50);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Update Bookone";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Update Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxBookone);
            this.Controls.Add(this.labelBookone);
            this.Controls.Add(this.buttonReturnBook);
            this.Controls.Add(this.comboBoxBook);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.dateTimeRealReturnDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.labelStudent);
            this.Name = "ReturnBook";
            this.Text = "ReturnBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeRealReturnDate;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.Label labelBookone;
        private System.Windows.Forms.ComboBox comboBoxBookone;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button button1;
    }
}
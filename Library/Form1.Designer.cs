namespace Library
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.allStudents = new System.Windows.Forms.Button();
            this.allAuthors = new System.Windows.Forms.Button();
            this.allBooks = new System.Windows.Forms.Button();
            this.allStudentsAMM = new System.Windows.Forms.Button();
            this.allStudentsAt1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.buttonGetBook = new System.Windows.Forms.Button();
            this.buttonStudentGetBook = new System.Windows.Forms.Button();
            this.buttonAddBank = new System.Windows.Forms.Button();
            this.buttonAddBookone = new System.Windows.Forms.Button();
            this.buttonBookBookone = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAddBookAuthor = new System.Windows.Forms.Button();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelCurName = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // allStudents
            // 
            this.allStudents.Location = new System.Drawing.Point(12, 12);
            this.allStudents.Name = "allStudents";
            this.allStudents.Size = new System.Drawing.Size(172, 75);
            this.allStudents.TabIndex = 0;
            this.allStudents.Text = "DB Students";
            this.allStudents.UseVisualStyleBackColor = true;
            this.allStudents.Click += new System.EventHandler(this.allStudents_Click);
            // 
            // allAuthors
            // 
            this.allAuthors.Location = new System.Drawing.Point(12, 93);
            this.allAuthors.Name = "allAuthors";
            this.allAuthors.Size = new System.Drawing.Size(172, 75);
            this.allAuthors.TabIndex = 1;
            this.allAuthors.Text = "DB Authors";
            this.allAuthors.UseVisualStyleBackColor = true;
            this.allAuthors.Click += new System.EventHandler(this.allAuthors_Click);
            // 
            // allBooks
            // 
            this.allBooks.Location = new System.Drawing.Point(12, 174);
            this.allBooks.Name = "allBooks";
            this.allBooks.Size = new System.Drawing.Size(172, 75);
            this.allBooks.TabIndex = 2;
            this.allBooks.Text = "DB Books";
            this.allBooks.UseVisualStyleBackColor = true;
            this.allBooks.Click += new System.EventHandler(this.allBooks_Click);
            // 
            // allStudentsAMM
            // 
            this.allStudentsAMM.Location = new System.Drawing.Point(12, 579);
            this.allStudentsAMM.Name = "allStudentsAMM";
            this.allStudentsAMM.Size = new System.Drawing.Size(172, 75);
            this.allStudentsAMM.TabIndex = 3;
            this.allStudentsAMM.Text = "Students AMM";
            this.allStudentsAMM.UseVisualStyleBackColor = true;
            this.allStudentsAMM.Click += new System.EventHandler(this.allStudentsAMM_Click);
            // 
            // allStudentsAt1
            // 
            this.allStudentsAt1.Location = new System.Drawing.Point(12, 660);
            this.allStudentsAt1.Name = "allStudentsAt1";
            this.allStudentsAt1.Size = new System.Drawing.Size(172, 75);
            this.allStudentsAt1.TabIndex = 4;
            this.allStudentsAt1.Text = "Students at 1 course";
            this.allStudentsAt1.UseVisualStyleBackColor = true;
            this.allStudentsAt1.Click += new System.EventHandler(this.allStudentsAt1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(190, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(902, 642);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 75);
            this.button1.TabIndex = 6;
            this.button1.Text = "DB Author-Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(1098, 12);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(172, 75);
            this.addStudent.TabIndex = 7;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(1098, 93);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(172, 75);
            this.buttonAddBook.TabIndex = 8;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(1098, 174);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(172, 75);
            this.buttonAddAuthor.TabIndex = 9;
            this.buttonAddAuthor.Text = "Add Author";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // buttonGetBook
            // 
            this.buttonGetBook.Location = new System.Drawing.Point(1098, 498);
            this.buttonGetBook.Name = "buttonGetBook";
            this.buttonGetBook.Size = new System.Drawing.Size(172, 75);
            this.buttonGetBook.TabIndex = 10;
            this.buttonGetBook.Text = "Get Book";
            this.buttonGetBook.UseVisualStyleBackColor = true;
            this.buttonGetBook.Click += new System.EventHandler(this.buttonGetBook_Click);
            // 
            // buttonStudentGetBook
            // 
            this.buttonStudentGetBook.Location = new System.Drawing.Point(12, 417);
            this.buttonStudentGetBook.Name = "buttonStudentGetBook";
            this.buttonStudentGetBook.Size = new System.Drawing.Size(172, 75);
            this.buttonStudentGetBook.TabIndex = 12;
            this.buttonStudentGetBook.Text = "DB Student GetBook";
            this.buttonStudentGetBook.UseVisualStyleBackColor = true;
            this.buttonStudentGetBook.Click += new System.EventHandler(this.buttonStudentGetBook_Click);
            // 
            // buttonAddBank
            // 
            this.buttonAddBank.Location = new System.Drawing.Point(1098, 255);
            this.buttonAddBank.Name = "buttonAddBank";
            this.buttonAddBank.Size = new System.Drawing.Size(172, 75);
            this.buttonAddBank.TabIndex = 13;
            this.buttonAddBank.Text = "Add Bank";
            this.buttonAddBank.UseVisualStyleBackColor = true;
            this.buttonAddBank.Click += new System.EventHandler(this.buttonAddBank_Click);
            // 
            // buttonAddBookone
            // 
            this.buttonAddBookone.Location = new System.Drawing.Point(1098, 336);
            this.buttonAddBookone.Name = "buttonAddBookone";
            this.buttonAddBookone.Size = new System.Drawing.Size(172, 75);
            this.buttonAddBookone.TabIndex = 14;
            this.buttonAddBookone.Text = "Add Bookone";
            this.buttonAddBookone.UseVisualStyleBackColor = true;
            this.buttonAddBookone.Click += new System.EventHandler(this.buttonAddBookone_Click);
            // 
            // buttonBookBookone
            // 
            this.buttonBookBookone.Location = new System.Drawing.Point(12, 498);
            this.buttonBookBookone.Name = "buttonBookBookone";
            this.buttonBookBookone.Size = new System.Drawing.Size(172, 75);
            this.buttonBookBookone.TabIndex = 15;
            this.buttonBookBookone.Text = "DB Book-Bookone";
            this.buttonBookBookone.UseVisualStyleBackColor = true;
            this.buttonBookBookone.Click += new System.EventHandler(this.buttonBookBookone_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 75);
            this.button2.TabIndex = 16;
            this.button2.Text = "DB Banks";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAddBookAuthor
            // 
            this.buttonAddBookAuthor.Location = new System.Drawing.Point(1098, 417);
            this.buttonAddBookAuthor.Name = "buttonAddBookAuthor";
            this.buttonAddBookAuthor.Size = new System.Drawing.Size(172, 75);
            this.buttonAddBookAuthor.TabIndex = 17;
            this.buttonAddBookAuthor.Text = "Add Book-Author";
            this.buttonAddBookAuthor.UseVisualStyleBackColor = true;
            this.buttonAddBookAuthor.Click += new System.EventHandler(this.buttonAddBookAuthor_Click);
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.Location = new System.Drawing.Point(1098, 579);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(172, 75);
            this.buttonReturnBook.TabIndex = 18;
            this.buttonReturnBook.Text = "Return Book";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1098, 660);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(172, 75);
            this.buttonClose.TabIndex = 19;
            this.buttonClose.Text = "Close ALL";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelCurName
            // 
            this.labelCurName.AutoSize = true;
            this.labelCurName.Location = new System.Drawing.Point(437, 37);
            this.labelCurName.Name = "labelCurName";
            this.labelCurName.Size = new System.Drawing.Size(102, 25);
            this.labelCurName.TabIndex = 20;
            this.labelCurName.Text = "CurName";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(713, 20);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(128, 58);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 751);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelCurName);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonReturnBook);
            this.Controls.Add(this.buttonAddBookAuthor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonBookBookone);
            this.Controls.Add(this.buttonAddBookone);
            this.Controls.Add(this.buttonAddBank);
            this.Controls.Add(this.buttonStudentGetBook);
            this.Controls.Add(this.buttonGetBook);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.allStudentsAt1);
            this.Controls.Add(this.allStudentsAMM);
            this.Controls.Add(this.allBooks);
            this.Controls.Add(this.allAuthors);
            this.Controls.Add(this.allStudents);
            this.Name = "Form1";
            this.Text = "LibraryDB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button allStudents;
        private System.Windows.Forms.Button allAuthors;
        private System.Windows.Forms.Button allBooks;
        private System.Windows.Forms.Button allStudentsAMM;
        private System.Windows.Forms.Button allStudentsAt1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonGetBook;
        private System.Windows.Forms.Button buttonStudentGetBook;
        private System.Windows.Forms.Button buttonAddBank;
        private System.Windows.Forms.Button buttonAddBookone;
        private System.Windows.Forms.Button buttonBookBookone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAddBookAuthor;
        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelCurName;
        private System.Windows.Forms.Button buttonUpdate;
    }
}


namespace Library
{
    partial class AddBook
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
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPages = new System.Windows.Forms.Label();
            this.labelAddBookFIOAuthor = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.comboBoxAddBookFIOAuthor = new System.Windows.Forms.ComboBox();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(497, 292);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(132, 48);
            this.buttonAddBook.TabIndex = 0;
            this.buttonAddBook.Text = "ADD";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(28, 40);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(53, 25);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title";
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(28, 87);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(160, 25);
            this.labelPages.TabIndex = 2;
            this.labelPages.Text = "Count of Pages";
            // 
            // labelAddBookFIOAuthor
            // 
            this.labelAddBookFIOAuthor.AutoSize = true;
            this.labelAddBookFIOAuthor.Location = new System.Drawing.Point(29, 145);
            this.labelAddBookFIOAuthor.Name = "labelAddBookFIOAuthor";
            this.labelAddBookFIOAuthor.Size = new System.Drawing.Size(115, 25);
            this.labelAddBookFIOAuthor.TabIndex = 4;
            this.labelAddBookFIOAuthor.Text = "FIO Author";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(399, 34);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(230, 31);
            this.textBoxTitle.TabIndex = 8;
            // 
            // textBoxPages
            // 
            this.textBoxPages.Location = new System.Drawing.Point(399, 81);
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(230, 31);
            this.textBoxPages.TabIndex = 9;
            // 
            // comboBoxAddBookFIOAuthor
            // 
            this.comboBoxAddBookFIOAuthor.FormattingEnabled = true;
            this.comboBoxAddBookFIOAuthor.Location = new System.Drawing.Point(399, 128);
            this.comboBoxAddBookFIOAuthor.Name = "comboBoxAddBookFIOAuthor";
            this.comboBoxAddBookFIOAuthor.Size = new System.Drawing.Size(230, 33);
            this.comboBoxAddBookFIOAuthor.TabIndex = 14;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(191, 127);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(188, 43);
            this.buttonAddAuthor.TabIndex = 15;
            this.buttonAddAuthor.Text = "Add Author";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(33, 292);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(132, 48);
            this.buttonUpdate.TabIndex = 20;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 365);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.comboBoxAddBookFIOAuthor);
            this.Controls.Add(this.textBoxPages);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelAddBookFIOAuthor);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonAddBook);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Label labelAddBookFIOAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.ComboBox comboBoxAddBookFIOAuthor;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
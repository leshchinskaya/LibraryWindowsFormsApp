namespace Library
{
    partial class AddBookone
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
            this.labelChooseBook = new System.Windows.Forms.Label();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.labelInjury = new System.Windows.Forms.Label();
            this.textBoxInjury = new System.Windows.Forms.TextBox();
            this.labelBank = new System.Windows.Forms.Label();
            this.comboBoxBank = new System.Windows.Forms.ComboBox();
            this.buttonAddBookone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChooseBook
            // 
            this.labelChooseBook.AutoSize = true;
            this.labelChooseBook.Location = new System.Drawing.Point(43, 31);
            this.labelChooseBook.Name = "labelChooseBook";
            this.labelChooseBook.Size = new System.Drawing.Size(141, 25);
            this.labelChooseBook.TabIndex = 0;
            this.labelChooseBook.Text = "Choose Book";
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(275, 28);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(220, 33);
            this.comboBoxBook.TabIndex = 1;
            // 
            // labelInjury
            // 
            this.labelInjury.AutoSize = true;
            this.labelInjury.Location = new System.Drawing.Point(43, 73);
            this.labelInjury.Name = "labelInjury";
            this.labelInjury.Size = new System.Drawing.Size(64, 25);
            this.labelInjury.TabIndex = 2;
            this.labelInjury.Text = "Injury";
            // 
            // textBoxInjury
            // 
            this.textBoxInjury.Location = new System.Drawing.Point(275, 73);
            this.textBoxInjury.Name = "textBoxInjury";
            this.textBoxInjury.Size = new System.Drawing.Size(219, 31);
            this.textBoxInjury.TabIndex = 3;
            // 
            // labelBank
            // 
            this.labelBank.AutoSize = true;
            this.labelBank.Location = new System.Drawing.Point(43, 121);
            this.labelBank.Name = "labelBank";
            this.labelBank.Size = new System.Drawing.Size(61, 25);
            this.labelBank.TabIndex = 4;
            this.labelBank.Text = "Bank";
            // 
            // comboBoxBank
            // 
            this.comboBoxBank.FormattingEnabled = true;
            this.comboBoxBank.Location = new System.Drawing.Point(273, 118);
            this.comboBoxBank.Name = "comboBoxBank";
            this.comboBoxBank.Size = new System.Drawing.Size(220, 33);
            this.comboBoxBank.TabIndex = 5;
            // 
            // buttonAddBookone
            // 
            this.buttonAddBookone.Location = new System.Drawing.Point(365, 167);
            this.buttonAddBookone.Name = "buttonAddBookone";
            this.buttonAddBookone.Size = new System.Drawing.Size(128, 46);
            this.buttonAddBookone.TabIndex = 6;
            this.buttonAddBookone.Text = "ADD";
            this.buttonAddBookone.UseVisualStyleBackColor = true;
            this.buttonAddBookone.Click += new System.EventHandler(this.buttonAddBookone_Click);
            // 
            // AddBookone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 235);
            this.Controls.Add(this.buttonAddBookone);
            this.Controls.Add(this.comboBoxBank);
            this.Controls.Add(this.labelBank);
            this.Controls.Add(this.textBoxInjury);
            this.Controls.Add(this.labelInjury);
            this.Controls.Add(this.comboBoxBook);
            this.Controls.Add(this.labelChooseBook);
            this.Name = "AddBookone";
            this.Text = "AddBookone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseBook;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.Label labelInjury;
        private System.Windows.Forms.TextBox textBoxInjury;
        private System.Windows.Forms.Label labelBank;
        private System.Windows.Forms.ComboBox comboBoxBank;
        private System.Windows.Forms.Button buttonAddBookone;
    }
}
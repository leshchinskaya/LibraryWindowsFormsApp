namespace Library
{
    partial class AddBank
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
            this.labelNamePlace = new System.Windows.Forms.Label();
            this.labelNumOfPlace = new System.Windows.Forms.Label();
            this.textBoxNamePlace = new System.Windows.Forms.TextBox();
            this.textBoxNumOfPlace = new System.Windows.Forms.TextBox();
            this.buttonAddBank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNamePlace
            // 
            this.labelNamePlace.AutoSize = true;
            this.labelNamePlace.Location = new System.Drawing.Point(29, 29);
            this.labelNamePlace.Name = "labelNamePlace";
            this.labelNamePlace.Size = new System.Drawing.Size(134, 25);
            this.labelNamePlace.TabIndex = 0;
            this.labelNamePlace.Text = "LibraryName";
            // 
            // labelNumOfPlace
            // 
            this.labelNumOfPlace.AutoSize = true;
            this.labelNumOfPlace.Location = new System.Drawing.Point(29, 76);
            this.labelNumOfPlace.Name = "labelNumOfPlace";
            this.labelNumOfPlace.Size = new System.Drawing.Size(183, 25);
            this.labelNumOfPlace.TabIndex = 1;
            this.labelNumOfPlace.Text = "Number at Library";
            // 
            // textBoxNamePlace
            // 
            this.textBoxNamePlace.Location = new System.Drawing.Point(243, 23);
            this.textBoxNamePlace.Name = "textBoxNamePlace";
            this.textBoxNamePlace.Size = new System.Drawing.Size(234, 31);
            this.textBoxNamePlace.TabIndex = 2;
            // 
            // textBoxNumOfPlace
            // 
            this.textBoxNumOfPlace.Location = new System.Drawing.Point(243, 70);
            this.textBoxNumOfPlace.Name = "textBoxNumOfPlace";
            this.textBoxNumOfPlace.Size = new System.Drawing.Size(234, 31);
            this.textBoxNumOfPlace.TabIndex = 3;
            // 
            // buttonAddBank
            // 
            this.buttonAddBank.Location = new System.Drawing.Point(336, 121);
            this.buttonAddBank.Name = "buttonAddBank";
            this.buttonAddBank.Size = new System.Drawing.Size(141, 47);
            this.buttonAddBank.TabIndex = 4;
            this.buttonAddBank.Text = "ADD";
            this.buttonAddBank.UseVisualStyleBackColor = true;
            this.buttonAddBank.Click += new System.EventHandler(this.buttonAddBank_Click);
            // 
            // AddBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 199);
            this.Controls.Add(this.buttonAddBank);
            this.Controls.Add(this.textBoxNumOfPlace);
            this.Controls.Add(this.textBoxNamePlace);
            this.Controls.Add(this.labelNumOfPlace);
            this.Controls.Add(this.labelNamePlace);
            this.Name = "AddBank";
            this.Text = "AddBank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamePlace;
        private System.Windows.Forms.Label labelNumOfPlace;
        private System.Windows.Forms.TextBox textBoxNamePlace;
        private System.Windows.Forms.TextBox textBoxNumOfPlace;
        private System.Windows.Forms.Button buttonAddBank;
    }
}
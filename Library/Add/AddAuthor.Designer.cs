namespace Library
{
    partial class AddAuthor
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
            this.labelFIOAuthor = new System.Windows.Forms.Label();
            this.textBoxFIOAuthor = new System.Windows.Forms.TextBox();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFIOAuthor
            // 
            this.labelFIOAuthor.AutoSize = true;
            this.labelFIOAuthor.Location = new System.Drawing.Point(25, 27);
            this.labelFIOAuthor.Name = "labelFIOAuthor";
            this.labelFIOAuthor.Size = new System.Drawing.Size(115, 25);
            this.labelFIOAuthor.TabIndex = 0;
            this.labelFIOAuthor.Text = "FIO Author";
            // 
            // textBoxFIOAuthor
            // 
            this.textBoxFIOAuthor.Location = new System.Drawing.Point(195, 24);
            this.textBoxFIOAuthor.Name = "textBoxFIOAuthor";
            this.textBoxFIOAuthor.Size = new System.Drawing.Size(234, 31);
            this.textBoxFIOAuthor.TabIndex = 1;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(298, 74);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(131, 43);
            this.buttonAddAuthor.TabIndex = 2;
            this.buttonAddAuthor.Text = "ADD";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 139);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.textBoxFIOAuthor);
            this.Controls.Add(this.labelFIOAuthor);
            this.Name = "AddAuthor";
            this.Text = "AddAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIOAuthor;
        private System.Windows.Forms.TextBox textBoxFIOAuthor;
        private System.Windows.Forms.Button buttonAddAuthor;
    }
}
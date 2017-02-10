namespace CGKSBibliothouris.View
{
    partial class NewRental
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.INSS = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.Label();
            this.rentBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // INSS
            // 
            this.INSS.AutoSize = true;
            this.INSS.Location = new System.Drawing.Point(66, 60);
            this.INSS.Name = "INSS";
            this.INSS.Size = new System.Drawing.Size(32, 13);
            this.INSS.TabIndex = 2;
            this.INSS.Text = "INSS";
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(66, 95);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(32, 13);
            this.ISBN.TabIndex = 3;
            this.ISBN.Text = "ISBN";
            // 
            // rentBook
            // 
            this.rentBook.Location = new System.Drawing.Point(156, 162);
            this.rentBook.Name = "rentBook";
            this.rentBook.Size = new System.Drawing.Size(75, 23);
            this.rentBook.TabIndex = 4;
            this.rentBook.Text = "Rent Book";
            this.rentBook.UseVisualStyleBackColor = true;
            // 
            // NewRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rentBook);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.INSS);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "NewRental";
            this.Text = "NewRental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label INSS;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Button rentBook;
    }
}
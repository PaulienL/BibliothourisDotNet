namespace CGKSBibliothouris.View
{
    partial class AddMember
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
            this.components = new System.ComponentModel.Container();
            this.firstName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.zipcode = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zipcodeField = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inssField = new System.Windows.Forms.Label();
            this.inss = new System.Windows.Forms.TextBox();
            this.saveMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(113, 19);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(118, 20);
            this.firstName.TabIndex = 0;
            this.firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(113, 47);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(118, 20);
            this.lastName.TabIndex = 4;
            this.lastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(113, 99);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(118, 20);
            this.number.TabIndex = 5;
            this.number.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // zipcode
            // 
            this.zipcode.Location = new System.Drawing.Point(113, 125);
            this.zipcode.Name = "zipcode";
            this.zipcode.Size = new System.Drawing.Size(118, 20);
            this.zipcode.TabIndex = 6;
            this.zipcode.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(113, 73);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(118, 20);
            this.street.TabIndex = 7;
            this.street.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(113, 151);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(118, 20);
            this.city.TabIndex = 8;
            this.city.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Street";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // zipcodeField
            // 
            this.zipcodeField.AutoSize = true;
            this.zipcodeField.Location = new System.Drawing.Point(24, 132);
            this.zipcodeField.Name = "zipcodeField";
            this.zipcodeField.Size = new System.Drawing.Size(46, 13);
            this.zipcodeField.TabIndex = 11;
            this.zipcodeField.Text = "Zipcode";
            this.zipcodeField.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "City";
            // 
            // inssField
            // 
            this.inssField.AutoSize = true;
            this.inssField.Location = new System.Drawing.Point(25, 184);
            this.inssField.Name = "inssField";
            this.inssField.Size = new System.Drawing.Size(32, 13);
            this.inssField.TabIndex = 13;
            this.inssField.Text = "INSS";
            // 
            // inss
            // 
            this.inss.Location = new System.Drawing.Point(113, 177);
            this.inss.Name = "inss";
            this.inss.Size = new System.Drawing.Size(118, 20);
            this.inss.TabIndex = 14;
            // 
            // saveMember
            // 
            this.saveMember.Location = new System.Drawing.Point(156, 218);
            this.saveMember.Name = "saveMember";
            this.saveMember.Size = new System.Drawing.Size(75, 23);
            this.saveMember.TabIndex = 15;
            this.saveMember.Text = "Save Member";
            this.saveMember.UseVisualStyleBackColor = true;
            this.saveMember.Click += new System.EventHandler(this.saveMember_Click);
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.saveMember);
            this.Controls.Add(this.inss);
            this.Controls.Add(this.inssField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zipcodeField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.city);
            this.Controls.Add(this.street);
            this.Controls.Add(this.zipcode);
            this.Controls.Add(this.number);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstName);
            this.Name = "AddMember";
            this.Text = "AddMember";
            this.Load += new System.EventHandler(this.AddMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox zipcode;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label zipcodeField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label inssField;
        private System.Windows.Forms.TextBox inss;
        private System.Windows.Forms.Button saveMember;
    }
}
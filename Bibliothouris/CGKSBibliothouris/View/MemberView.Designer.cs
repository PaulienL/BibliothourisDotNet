namespace CGKSBibliothouris.View
{
    partial class MemberView
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
            this.memberList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memberList
            // 
            this.memberList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Firstname,
            this.Lastname});
            this.memberList.Location = new System.Drawing.Point(12, 12);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(252, 206);
            this.memberList.TabIndex = 0;
            this.memberList.UseCompatibleStateImageBehavior = false;
            this.memberList.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Firstname
            // 
            this.Firstname.Text = "Firstname";
            // 
            // Lastname
            // 
            this.Lastname.Text = "Lastname";
            // 
            // addMember
            // 
            this.addMember.Location = new System.Drawing.Point(186, 224);
            this.addMember.Name = "addMember";
            this.addMember.Size = new System.Drawing.Size(75, 23);
            this.addMember.TabIndex = 1;
            this.addMember.Text = "Add Member";
            this.addMember.UseVisualStyleBackColor = true;
            this.addMember.Click += new System.EventHandler(this.addMember_Click_1);
            // 
            // MemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.addMember);
            this.Controls.Add(this.memberList);
            this.Name = "MemberView";
            this.Text = "MemberView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView memberList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Firstname;
        private System.Windows.Forms.ColumnHeader Lastname;
        private System.Windows.Forms.Button addMember;
    }
}
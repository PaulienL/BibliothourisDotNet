namespace CGKSBibliothouris.View
{
    partial class BookSearchResults
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
            this.BookOverview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BookOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // BookOverview
            // 
            this.BookOverview.AllowUserToAddRows = false;
            this.BookOverview.AllowUserToDeleteRows = false;
            this.BookOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.BookOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookOverview.Location = new System.Drawing.Point(12, 12);
            this.BookOverview.Name = "BookOverview";
            this.BookOverview.ReadOnly = true;
            this.BookOverview.Size = new System.Drawing.Size(391, 247);
            this.BookOverview.TabIndex = 0;
            this.BookOverview.DoubleClick += new System.EventHandler(this.BookOverview_DoubleClick);
            // 
            // BookSearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 271);
            this.Controls.Add(this.BookOverview);
            this.Name = "BookSearchResults";
            this.Text = "BookSearchResults";
            ((System.ComponentModel.ISupportInitialize)(this.BookOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookOverview;
    }
}
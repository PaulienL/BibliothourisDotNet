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
            this.lstSearchResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstSearchResult
            // 
            this.lstSearchResult.FormattingEnabled = true;
            this.lstSearchResult.Location = new System.Drawing.Point(13, 13);
            this.lstSearchResult.MultiColumn = true;
            this.lstSearchResult.Name = "lstSearchResult";
            this.lstSearchResult.Size = new System.Drawing.Size(335, 238);
            this.lstSearchResult.TabIndex = 0;
            this.lstSearchResult.DoubleClick += new System.EventHandler(this.lstSearchResult_DoubleClick);
            // 
            // BookSearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 271);
            this.Controls.Add(this.lstSearchResult);
            this.Name = "BookSearchResults";
            this.Text = "BookSearchResults";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSearchResult;
    }
}
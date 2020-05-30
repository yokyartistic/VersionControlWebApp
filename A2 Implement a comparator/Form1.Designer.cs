namespace A2_Implement_a_comparator
{
    partial class FrmMain
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
            this.lblText = new System.Windows.Forms.Label();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(458, 90);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(46, 17);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "label1";
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 16;
            this.lstBox.Location = new System.Drawing.Point(461, 110);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(120, 84);
            this.lstBox.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(1106, 472);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.lblText);
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.ListBox lstBox;
    }
}


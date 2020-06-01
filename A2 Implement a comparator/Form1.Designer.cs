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
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblText3 = new System.Windows.Forms.Label();
            this.lblPrint3 = new System.Windows.Forms.Label();
            this.btnPrint3 = new System.Windows.Forms.Button();
            this.lblPrint1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(202, 42);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(46, 17);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "label1";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(205, 360);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(163, 47);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Display Songs in array";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblText3
            // 
            this.lblText3.AutoSize = true;
            this.lblText3.Location = new System.Drawing.Point(551, 42);
            this.lblText3.Name = "lblText3";
            this.lblText3.Size = new System.Drawing.Size(46, 17);
            this.lblText3.TabIndex = 7;
            this.lblText3.Text = "label3";
            // 
            // lblPrint3
            // 
            this.lblPrint3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrint3.Location = new System.Drawing.Point(551, 78);
            this.lblPrint3.Name = "lblPrint3";
            this.lblPrint3.Size = new System.Drawing.Size(268, 268);
            this.lblPrint3.TabIndex = 8;
            // 
            // btnPrint3
            // 
            this.btnPrint3.Location = new System.Drawing.Point(554, 360);
            this.btnPrint3.Name = "btnPrint3";
            this.btnPrint3.Size = new System.Drawing.Size(201, 47);
            this.btnPrint3.TabIndex = 9;
            this.btnPrint3.Text = "Display Songs sort by length";
            this.btnPrint3.UseVisualStyleBackColor = true;
            this.btnPrint3.Click += new System.EventHandler(this.btnPrint3_Click);
            // 
            // lblPrint1
            // 
            this.lblPrint1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrint1.Location = new System.Drawing.Point(202, 78);
            this.lblPrint1.Name = "lblPrint1";
            this.lblPrint1.Size = new System.Drawing.Size(257, 268);
            this.lblPrint1.TabIndex = 10;
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(1010, 472);
            this.Controls.Add(this.lblPrint1);
            this.Controls.Add(this.btnPrint3);
            this.Controls.Add(this.lblPrint3);
            this.Controls.Add(this.lblText3);
            this.Controls.Add(this.btnPrint);
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblText3;
        private System.Windows.Forms.Label lblPrint3;
        private System.Windows.Forms.Button btnPrint3;
        private System.Windows.Forms.Label lblPrint1;
    }
}


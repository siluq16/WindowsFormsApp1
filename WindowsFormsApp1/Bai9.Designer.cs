namespace WindowsFormsApp1
{
    partial class Bai9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai9));
            this.label1 = new System.Windows.Forms.Label();
            this.cboOdia = new System.Windows.Forms.ComboBox();
            this.cboThuMuc = new System.Windows.Forms.ComboBox();
            this.lstTapTin = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ổ đĩa";
            // 
            // cboOdia
            // 
            this.cboOdia.FormattingEnabled = true;
            this.cboOdia.Location = new System.Drawing.Point(134, 36);
            this.cboOdia.Name = "cboOdia";
            this.cboOdia.Size = new System.Drawing.Size(399, 28);
            this.cboOdia.TabIndex = 1;
            this.cboOdia.SelectedIndexChanged += new System.EventHandler(this.cboOdia_SelectedIndexChanged);
            // 
            // cboThuMuc
            // 
            this.cboThuMuc.FormattingEnabled = true;
            this.cboThuMuc.Location = new System.Drawing.Point(134, 92);
            this.cboThuMuc.Name = "cboThuMuc";
            this.cboThuMuc.Size = new System.Drawing.Size(399, 28);
            this.cboThuMuc.TabIndex = 2;
            this.cboThuMuc.SelectedIndexChanged += new System.EventHandler(this.cboThuMuc_SelectedIndexChanged);
            // 
            // lstTapTin
            // 
            this.lstTapTin.FormattingEnabled = true;
            this.lstTapTin.ItemHeight = 20;
            this.lstTapTin.Location = new System.Drawing.Point(38, 150);
            this.lstTapTin.Name = "lstTapTin";
            this.lstTapTin.Size = new System.Drawing.Size(495, 184);
            this.lstTapTin.TabIndex = 3;
            this.lstTapTin.SelectedIndexChanged += new System.EventHandler(this.lstTapTin_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(557, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(498, 768);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(495, 449);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Location = new System.Drawing.Point(38, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 449);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thư mục";
            // 
            // Bai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 825);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lstTapTin);
            this.Controls.Add(this.cboThuMuc);
            this.Controls.Add(this.cboOdia);
            this.Controls.Add(this.label1);
            this.Name = "Bai9";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Bai9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOdia;
        private System.Windows.Forms.ComboBox cboThuMuc;
        private System.Windows.Forms.ListBox lstTapTin;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}
namespace WindowsFormsApp1
{
    partial class Bai10
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnMoTapTin = new System.Windows.Forms.Button();
            this.btnLuuTapTin = new System.Windows.Forms.Button();
            this.btnLuuTenKhac = new System.Windows.Forms.Button();
            this.btnFontChu = new System.Windows.Forms.Button();
            this.btnMauSac = new System.Windows.Forms.Button();
            this.btnInAn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(602, 601);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnMoTapTin
            // 
            this.btnMoTapTin.Location = new System.Drawing.Point(655, 41);
            this.btnMoTapTin.Name = "btnMoTapTin";
            this.btnMoTapTin.Size = new System.Drawing.Size(122, 47);
            this.btnMoTapTin.TabIndex = 1;
            this.btnMoTapTin.Text = "Mở tập tin";
            this.btnMoTapTin.UseVisualStyleBackColor = true;
            this.btnMoTapTin.Click += new System.EventHandler(this.btnMoTapTin_Click);
            // 
            // btnLuuTapTin
            // 
            this.btnLuuTapTin.Location = new System.Drawing.Point(655, 94);
            this.btnLuuTapTin.Name = "btnLuuTapTin";
            this.btnLuuTapTin.Size = new System.Drawing.Size(122, 47);
            this.btnLuuTapTin.TabIndex = 2;
            this.btnLuuTapTin.Text = "Lưu Tập Tin";
            this.btnLuuTapTin.UseVisualStyleBackColor = true;
            this.btnLuuTapTin.Click += new System.EventHandler(this.btnLuuTapTin_Click);
            // 
            // btnLuuTenKhac
            // 
            this.btnLuuTenKhac.Location = new System.Drawing.Point(655, 147);
            this.btnLuuTenKhac.Name = "btnLuuTenKhac";
            this.btnLuuTenKhac.Size = new System.Drawing.Size(122, 47);
            this.btnLuuTenKhac.TabIndex = 3;
            this.btnLuuTenKhac.Text = "Lưu Tên Khác";
            this.btnLuuTenKhac.UseVisualStyleBackColor = true;
            this.btnLuuTenKhac.Click += new System.EventHandler(this.btnLuuTenKhac_Click);
            // 
            // btnFontChu
            // 
            this.btnFontChu.Location = new System.Drawing.Point(655, 200);
            this.btnFontChu.Name = "btnFontChu";
            this.btnFontChu.Size = new System.Drawing.Size(122, 47);
            this.btnFontChu.TabIndex = 4;
            this.btnFontChu.Text = "Font Chữ";
            this.btnFontChu.UseVisualStyleBackColor = true;
            this.btnFontChu.Click += new System.EventHandler(this.btnFontChu_Click);
            // 
            // btnMauSac
            // 
            this.btnMauSac.Location = new System.Drawing.Point(655, 253);
            this.btnMauSac.Name = "btnMauSac";
            this.btnMauSac.Size = new System.Drawing.Size(122, 47);
            this.btnMauSac.TabIndex = 5;
            this.btnMauSac.Text = "Màu Sắc";
            this.btnMauSac.UseVisualStyleBackColor = true;
            this.btnMauSac.Click += new System.EventHandler(this.btnMauSac_Click);
            // 
            // btnInAn
            // 
            this.btnInAn.Location = new System.Drawing.Point(655, 306);
            this.btnInAn.Name = "btnInAn";
            this.btnInAn.Size = new System.Drawing.Size(122, 47);
            this.btnInAn.TabIndex = 6;
            this.btnInAn.Text = "In Ấn";
            this.btnInAn.UseVisualStyleBackColor = true;
            this.btnInAn.Click += new System.EventHandler(this.btnInAn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(655, 359);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 47);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 668);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInAn);
            this.Controls.Add(this.btnMauSac);
            this.Controls.Add(this.btnFontChu);
            this.Controls.Add(this.btnLuuTenKhac);
            this.Controls.Add(this.btnLuuTapTin);
            this.Controls.Add(this.btnMoTapTin);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnMoTapTin;
        private System.Windows.Forms.Button btnLuuTapTin;
        private System.Windows.Forms.Button btnLuuTenKhac;
        private System.Windows.Forms.Button btnFontChu;
        private System.Windows.Forms.Button btnMauSac;
        private System.Windows.Forms.Button btnInAn;
        private System.Windows.Forms.Button btnThoat;
    }
}
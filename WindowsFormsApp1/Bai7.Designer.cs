namespace WindowsFormsApp1
{
    partial class Bai7
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxMatHang = new System.Windows.Forms.ListBox();
            this.listBoxHangDat = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTheTinDung = new System.Windows.Forms.RadioButton();
            this.radSec = new System.Windows.Forms.RadioButton();
            this.radTienMat = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDienThoai = new System.Windows.Forms.CheckBox();
            this.chkFax = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.Dongy = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(27, 39);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Họ tên khách";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Location = new System.Drawing.Point(461, 39);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(57, 20);
            this.adressLabel.TabIndex = 1;
            this.adressLabel.Text = "Địa chỉ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 41);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(570, 24);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 67);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách mặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hàng đã đặt";
            // 
            // listBoxMatHang
            // 
            this.listBoxMatHang.CausesValidation = false;
            this.listBoxMatHang.FormattingEnabled = true;
            this.listBoxMatHang.ItemHeight = 20;
            this.listBoxMatHang.Items.AddRange(new object[] {
            "Kỹ năng lập trình Visual Basic 6.0",
            "Tự học ASP trong 21 ngày",
            "Tự học PHP & MySQL trong 21 ngày",
            "Bài tập Visual Basic 6.0",
            "Tin học căn bản",
            "Đến với Word 2000",
            "Đến với Excel 2000",
            "Bài tập C cơ bản và nâng cao",
            "SQL Server"});
            this.listBoxMatHang.Location = new System.Drawing.Point(31, 165);
            this.listBoxMatHang.Name = "listBoxMatHang";
            this.listBoxMatHang.Size = new System.Drawing.Size(381, 144);
            this.listBoxMatHang.TabIndex = 6;
            this.listBoxMatHang.DoubleClick += new System.EventHandler(this.listBoxMatHang_SelectedIndexChanged);
            // 
            // listBoxHangDat
            // 
            this.listBoxHangDat.FormattingEnabled = true;
            this.listBoxHangDat.ItemHeight = 20;
            this.listBoxHangDat.Location = new System.Drawing.Point(465, 165);
            this.listBoxHangDat.Name = "listBoxHangDat";
            this.listBoxHangDat.Size = new System.Drawing.Size(295, 144);
            this.listBoxHangDat.TabIndex = 7;
            this.listBoxHangDat.DoubleClick += new System.EventHandler(this.listBoxHangDat_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radTheTinDung);
            this.groupBox1.Controls.Add(this.radSec);
            this.groupBox1.Controls.Add(this.radTienMat);
            this.groupBox1.Location = new System.Drawing.Point(64, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 148);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương thức thanh toán";
            // 
            // radTheTinDung
            // 
            this.radTheTinDung.AutoSize = true;
            this.radTheTinDung.Location = new System.Drawing.Point(19, 118);
            this.radTheTinDung.Name = "radTheTinDung";
            this.radTheTinDung.Size = new System.Drawing.Size(131, 24);
            this.radTheTinDung.TabIndex = 2;
            this.radTheTinDung.TabStop = true;
            this.radTheTinDung.Text = "Thẻ tính dung";
            this.radTheTinDung.UseVisualStyleBackColor = true;
            // 
            // radSec
            // 
            this.radSec.AutoSize = true;
            this.radSec.Location = new System.Drawing.Point(19, 78);
            this.radSec.Name = "radSec";
            this.radSec.Size = new System.Drawing.Size(62, 24);
            this.radSec.TabIndex = 1;
            this.radSec.TabStop = true;
            this.radSec.Text = "Séc";
            this.radSec.UseVisualStyleBackColor = true;
            // 
            // radTienMat
            // 
            this.radTienMat.AutoSize = true;
            this.radTienMat.Location = new System.Drawing.Point(19, 38);
            this.radTienMat.Name = "radTienMat";
            this.radTienMat.Size = new System.Drawing.Size(95, 24);
            this.radTienMat.TabIndex = 0;
            this.radTienMat.TabStop = true;
            this.radTienMat.Text = "Tiền mặt";
            this.radTienMat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkEmail);
            this.groupBox2.Controls.Add(this.chkFax);
            this.groupBox2.Controls.Add(this.chkDienThoai);
            this.groupBox2.Location = new System.Drawing.Point(496, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 142);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình th liên lạc";
            // 
            // chkDienThoai
            // 
            this.chkDienThoai.AutoSize = true;
            this.chkDienThoai.Location = new System.Drawing.Point(16, 26);
            this.chkDienThoai.Name = "chkDienThoai";
            this.chkDienThoai.Size = new System.Drawing.Size(107, 24);
            this.chkDienThoai.TabIndex = 0;
            this.chkDienThoai.Text = "Điện thoại";
            this.chkDienThoai.UseVisualStyleBackColor = true;
            // 
            // chkFax
            // 
            this.chkFax.AutoSize = true;
            this.chkFax.Location = new System.Drawing.Point(16, 57);
            this.chkFax.Name = "chkFax";
            this.chkFax.Size = new System.Drawing.Size(61, 24);
            this.chkFax.TabIndex = 1;
            this.chkFax.Text = "Fax";
            this.chkFax.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(16, 88);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(74, 24);
            this.chkEmail.TabIndex = 2;
            this.chkEmail.Text = "Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // Dongy
            // 
            this.Dongy.Location = new System.Drawing.Point(261, 519);
            this.Dongy.Name = "Dongy";
            this.Dongy.Size = new System.Drawing.Size(76, 37);
            this.Dongy.TabIndex = 10;
            this.Dongy.Text = "Đồng ý";
            this.Dongy.UseVisualStyleBackColor = true;
            this.Dongy.Click += new System.EventHandler(this.Dongy_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(435, 519);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 37);
            this.thoat.TabIndex = 11;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.Dongy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxHangDat);
            this.Controls.Add(this.listBoxMatHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxMatHang;
        private System.Windows.Forms.ListBox listBoxHangDat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radTheTinDung;
        private System.Windows.Forms.RadioButton radSec;
        private System.Windows.Forms.RadioButton radTienMat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkFax;
        private System.Windows.Forms.CheckBox chkDienThoai;
        private System.Windows.Forms.Button Dongy;
        private System.Windows.Forms.Button thoat;
    }
}
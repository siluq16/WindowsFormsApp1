namespace WindowsFormsApp1
{
    partial class Bai8
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
            this.RedBar = new System.Windows.Forms.HScrollBar();
            this.BlueBar = new System.Windows.Forms.HScrollBar();
            this.GreenBar = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RedValue = new System.Windows.Forms.Label();
            this.GreenValue = new System.Windows.Forms.Label();
            this.BlueValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RedBar
            // 
            this.RedBar.Location = new System.Drawing.Point(108, 241);
            this.RedBar.Maximum = 264;
            this.RedBar.Name = "RedBar";
            this.RedBar.Size = new System.Drawing.Size(569, 26);
            this.RedBar.TabIndex = 0;
            this.RedBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RedBar_Scroll);
            // 
            // BlueBar
            // 
            this.BlueBar.Location = new System.Drawing.Point(108, 382);
            this.BlueBar.Maximum = 264;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Size = new System.Drawing.Size(569, 26);
            this.BlueBar.TabIndex = 1;
            this.BlueBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BlueBar_Scroll);
            // 
            // GreenBar
            // 
            this.GreenBar.Location = new System.Drawing.Point(116, 310);
            this.GreenBar.Maximum = 264;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Size = new System.Drawing.Size(569, 26);
            this.GreenBar.TabIndex = 2;
            this.GreenBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GreenBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue";
            // 
            // RedValue
            // 
            this.RedValue.AutoSize = true;
            this.RedValue.Location = new System.Drawing.Point(737, 241);
            this.RedValue.Name = "RedValue";
            this.RedValue.Size = new System.Drawing.Size(18, 20);
            this.RedValue.TabIndex = 6;
            this.RedValue.Text = "0";
            // 
            // GreenValue
            // 
            this.GreenValue.AutoSize = true;
            this.GreenValue.Location = new System.Drawing.Point(737, 316);
            this.GreenValue.Name = "GreenValue";
            this.GreenValue.Size = new System.Drawing.Size(18, 20);
            this.GreenValue.TabIndex = 7;
            this.GreenValue.Text = "0";
            // 
            // BlueValue
            // 
            this.BlueValue.AutoSize = true;
            this.BlueValue.Location = new System.Drawing.Point(737, 388);
            this.BlueValue.Name = "BlueValue";
            this.BlueValue.Size = new System.Drawing.Size(18, 20);
            this.BlueValue.TabIndex = 8;
            this.BlueValue.Text = "0";
            // 
            // Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BlueValue);
            this.Controls.Add(this.GreenValue);
            this.Controls.Add(this.RedValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GreenBar);
            this.Controls.Add(this.BlueBar);
            this.Controls.Add(this.RedBar);
            this.Name = "Bai8";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar RedBar;
        private System.Windows.Forms.HScrollBar BlueBar;
        private System.Windows.Forms.HScrollBar GreenBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RedValue;
        private System.Windows.Forms.Label GreenValue;
        private System.Windows.Forms.Label BlueValue;
    }
}
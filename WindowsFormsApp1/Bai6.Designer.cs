namespace WindowsFormsApp1
{
    partial class Bai6
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
            this.groupCountry = new System.Windows.Forms.GroupBox();
            this.radUK = new System.Windows.Forms.RadioButton();
            this.radBrazil = new System.Windows.Forms.RadioButton();
            this.radArgentina = new System.Windows.Forms.RadioButton();
            this.radItalia = new System.Windows.Forms.RadioButton();
            this.radUSA = new System.Windows.Forms.RadioButton();
            this.radTurkey = new System.Windows.Forms.RadioButton();
            this.radSpain = new System.Windows.Forms.RadioButton();
            this.radHungary = new System.Windows.Forms.RadioButton();
            this.radJapan = new System.Windows.Forms.RadioButton();
            this.radFrance = new System.Windows.Forms.RadioButton();
            this.groupCapital = new System.Windows.Forms.GroupBox();
            this.radParis = new System.Windows.Forms.RadioButton();
            this.radBrasilia = new System.Windows.Forms.RadioButton();
            this.radBudapest = new System.Windows.Forms.RadioButton();
            this.radAnkara = new System.Windows.Forms.RadioButton();
            this.radLondon = new System.Windows.Forms.RadioButton();
            this.radMarid = new System.Windows.Forms.RadioButton();
            this.radWashington = new System.Windows.Forms.RadioButton();
            this.radRome = new System.Windows.Forms.RadioButton();
            this.radTokyo = new System.Windows.Forms.RadioButton();
            this.radBuenosAires = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupCountry.SuspendLayout();
            this.groupCapital.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupCountry
            // 
            this.groupCountry.Controls.Add(this.radUK);
            this.groupCountry.Controls.Add(this.radBrazil);
            this.groupCountry.Controls.Add(this.radArgentina);
            this.groupCountry.Controls.Add(this.radItalia);
            this.groupCountry.Controls.Add(this.radUSA);
            this.groupCountry.Controls.Add(this.radTurkey);
            this.groupCountry.Controls.Add(this.radSpain);
            this.groupCountry.Controls.Add(this.radHungary);
            this.groupCountry.Controls.Add(this.radJapan);
            this.groupCountry.Controls.Add(this.radFrance);
            this.groupCountry.Location = new System.Drawing.Point(39, 30);
            this.groupCountry.Name = "groupCountry";
            this.groupCountry.Size = new System.Drawing.Size(202, 369);
            this.groupCountry.TabIndex = 0;
            this.groupCountry.TabStop = false;
            this.groupCountry.Text = "Country";
            // 
            // radUK
            // 
            this.radUK.AutoSize = true;
            this.radUK.Location = new System.Drawing.Point(31, 309);
            this.radUK.Name = "radUK";
            this.radUK.Size = new System.Drawing.Size(56, 24);
            this.radUK.TabIndex = 9;
            this.radUK.TabStop = true;
            this.radUK.Text = "UK";
            this.radUK.UseVisualStyleBackColor = true;
            this.radUK.CheckedChanged += new System.EventHandler(this.radUK_CheckedChanged);
            // 
            // radBrazil
            // 
            this.radBrazil.AutoSize = true;
            this.radBrazil.Location = new System.Drawing.Point(31, 279);
            this.radBrazil.Name = "radBrazil";
            this.radBrazil.Size = new System.Drawing.Size(73, 24);
            this.radBrazil.TabIndex = 8;
            this.radBrazil.TabStop = true;
            this.radBrazil.Text = "Brazil";
            this.radBrazil.UseVisualStyleBackColor = true;
            this.radBrazil.CheckedChanged += new System.EventHandler(this.radBrazil_CheckedChanged);
            // 
            // radArgentina
            // 
            this.radArgentina.AutoSize = true;
            this.radArgentina.Location = new System.Drawing.Point(31, 249);
            this.radArgentina.Name = "radArgentina";
            this.radArgentina.Size = new System.Drawing.Size(103, 24);
            this.radArgentina.TabIndex = 7;
            this.radArgentina.TabStop = true;
            this.radArgentina.Text = "Argentina";
            this.radArgentina.UseVisualStyleBackColor = true;
            this.radArgentina.CheckedChanged += new System.EventHandler(this.radArgentina_CheckedChanged);
            // 
            // radItalia
            // 
            this.radItalia.AutoSize = true;
            this.radItalia.Location = new System.Drawing.Point(31, 219);
            this.radItalia.Name = "radItalia";
            this.radItalia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radItalia.Size = new System.Drawing.Size(68, 24);
            this.radItalia.TabIndex = 6;
            this.radItalia.TabStop = true;
            this.radItalia.Text = "Italia";
            this.radItalia.UseVisualStyleBackColor = true;
            this.radItalia.CheckedChanged += new System.EventHandler(this.radItalia_CheckedChanged);
            // 
            // radUSA
            // 
            this.radUSA.AutoSize = true;
            this.radUSA.Location = new System.Drawing.Point(31, 189);
            this.radUSA.Name = "radUSA";
            this.radUSA.Size = new System.Drawing.Size(68, 24);
            this.radUSA.TabIndex = 5;
            this.radUSA.TabStop = true;
            this.radUSA.Text = "USA";
            this.radUSA.UseVisualStyleBackColor = true;
            this.radUSA.CheckedChanged += new System.EventHandler(this.radUSA_CheckedChanged);
            // 
            // radTurkey
            // 
            this.radTurkey.AutoSize = true;
            this.radTurkey.Location = new System.Drawing.Point(31, 159);
            this.radTurkey.Name = "radTurkey";
            this.radTurkey.Size = new System.Drawing.Size(76, 24);
            this.radTurkey.TabIndex = 4;
            this.radTurkey.TabStop = true;
            this.radTurkey.Text = "Tủkey";
            this.radTurkey.UseVisualStyleBackColor = true;
            this.radTurkey.CheckedChanged += new System.EventHandler(this.radTurkey_CheckedChanged);
            // 
            // radSpain
            // 
            this.radSpain.AutoSize = true;
            this.radSpain.Location = new System.Drawing.Point(31, 129);
            this.radSpain.Name = "radSpain";
            this.radSpain.Size = new System.Drawing.Size(75, 24);
            this.radSpain.TabIndex = 3;
            this.radSpain.TabStop = true;
            this.radSpain.Text = "Spain";
            this.radSpain.UseVisualStyleBackColor = true;
            this.radSpain.CheckedChanged += new System.EventHandler(this.radSpain_CheckedChanged);
            // 
            // radHungary
            // 
            this.radHungary.AutoSize = true;
            this.radHungary.Location = new System.Drawing.Point(31, 99);
            this.radHungary.Name = "radHungary";
            this.radHungary.Size = new System.Drawing.Size(94, 24);
            this.radHungary.TabIndex = 2;
            this.radHungary.TabStop = true;
            this.radHungary.Text = "Hungary";
            this.radHungary.UseVisualStyleBackColor = true;
            this.radHungary.CheckedChanged += new System.EventHandler(this.radHungary_CheckedChanged);
            // 
            // radJapan
            // 
            this.radJapan.AutoSize = true;
            this.radJapan.Location = new System.Drawing.Point(31, 69);
            this.radJapan.Name = "radJapan";
            this.radJapan.Size = new System.Drawing.Size(78, 24);
            this.radJapan.TabIndex = 1;
            this.radJapan.TabStop = true;
            this.radJapan.Text = "Japan";
            this.radJapan.UseVisualStyleBackColor = true;
            this.radJapan.CheckedChanged += new System.EventHandler(this.radJapan_CheckedChanged);
            // 
            // radFrance
            // 
            this.radFrance.AutoSize = true;
            this.radFrance.Location = new System.Drawing.Point(31, 39);
            this.radFrance.Name = "radFrance";
            this.radFrance.Size = new System.Drawing.Size(84, 24);
            this.radFrance.TabIndex = 0;
            this.radFrance.TabStop = true;
            this.radFrance.Text = "France";
            this.radFrance.UseVisualStyleBackColor = true;
            this.radFrance.CheckedChanged += new System.EventHandler(this.radFrance_CheckedChanged);
            // 
            // groupCapital
            // 
            this.groupCapital.Controls.Add(this.radParis);
            this.groupCapital.Controls.Add(this.radBrasilia);
            this.groupCapital.Controls.Add(this.radBudapest);
            this.groupCapital.Controls.Add(this.radAnkara);
            this.groupCapital.Controls.Add(this.radLondon);
            this.groupCapital.Controls.Add(this.radMarid);
            this.groupCapital.Controls.Add(this.radWashington);
            this.groupCapital.Controls.Add(this.radRome);
            this.groupCapital.Controls.Add(this.radTokyo);
            this.groupCapital.Controls.Add(this.radBuenosAires);
            this.groupCapital.Location = new System.Drawing.Point(454, 30);
            this.groupCapital.Name = "groupCapital";
            this.groupCapital.Size = new System.Drawing.Size(199, 369);
            this.groupCapital.TabIndex = 1;
            this.groupCapital.TabStop = false;
            this.groupCapital.Text = "Capital";
            // 
            // radParis
            // 
            this.radParis.AutoSize = true;
            this.radParis.Location = new System.Drawing.Point(35, 309);
            this.radParis.Name = "radParis";
            this.radParis.Size = new System.Drawing.Size(69, 24);
            this.radParis.TabIndex = 19;
            this.radParis.TabStop = true;
            this.radParis.Text = "Paris";
            this.radParis.UseVisualStyleBackColor = true;
            this.radParis.CheckedChanged += new System.EventHandler(this.Capital_CheckedChanged);
            // 
            // radBrasilia
            // 
            this.radBrasilia.AutoSize = true;
            this.radBrasilia.Location = new System.Drawing.Point(35, 279);
            this.radBrasilia.Name = "radBrasilia";
            this.radBrasilia.Size = new System.Drawing.Size(85, 24);
            this.radBrasilia.TabIndex = 18;
            this.radBrasilia.TabStop = true;
            this.radBrasilia.Text = "Brasilia";
            this.radBrasilia.UseVisualStyleBackColor = true;
            this.radBrasilia.CheckedChanged += new System.EventHandler(this.Capital_CheckedChanged);
            // 
            // radBudapest
            // 
            this.radBudapest.AutoSize = true;
            this.radBudapest.Location = new System.Drawing.Point(35, 249);
            this.radBudapest.Name = "radBudapest";
            this.radBudapest.Size = new System.Drawing.Size(103, 24);
            this.radBudapest.TabIndex = 17;
            this.radBudapest.TabStop = true;
            this.radBudapest.Text = "Budapest";
            this.radBudapest.UseVisualStyleBackColor = true;
            this.radBudapest.CheckedChanged += new System.EventHandler(this.Capital_CheckedChanged);
            // 
            // radAnkara
            // 
            this.radAnkara.AutoSize = true;
            this.radAnkara.Location = new System.Drawing.Point(35, 219);
            this.radAnkara.Name = "radAnkara";
            this.radAnkara.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radAnkara.Size = new System.Drawing.Size(85, 24);
            this.radAnkara.TabIndex = 16;
            this.radAnkara.TabStop = true;
            this.radAnkara.Text = "Ankara";
            this.radAnkara.UseVisualStyleBackColor = true;
            this.radAnkara.CheckedChanged += new System.EventHandler(this.Capital_CheckedChanged);
            // 
            // radLondon
            // 
            this.radLondon.AutoSize = true;
            this.radLondon.Location = new System.Drawing.Point(35, 189);
            this.radLondon.Name = "radLondon";
            this.radLondon.Size = new System.Drawing.Size(88, 24);
            this.radLondon.TabIndex = 15;
            this.radLondon.TabStop = true;
            this.radLondon.Text = "London";
            this.radLondon.UseVisualStyleBackColor = true;
            this.radLondon.CheckedChanged += new System.EventHandler(this.Capital_CheckedChanged);
            // 
            // radMarid
            // 
            this.radMarid.AutoSize = true;
            this.radMarid.Location = new System.Drawing.Point(35, 159);
            this.radMarid.Name = "radMarid";
            this.radMarid.Size = new System.Drawing.Size(73, 24);
            this.radMarid.TabIndex = 14;
            this.radMarid.TabStop = true;
            this.radMarid.Text = "Marid";
            this.radMarid.UseVisualStyleBackColor = true;
            this.radMarid.CheckedChanged += new System.EventHandler(this.Capital_CheckedChanged);
            // 
            // radWashington
            // 
            this.radWashington.AutoSize = true;
            this.radWashington.Location = new System.Drawing.Point(35, 129);
            this.radWashington.Name = "radWashington";
            this.radWashington.Size = new System.Drawing.Size(119, 24);
            this.radWashington.TabIndex = 13;
            this.radWashington.TabStop = true;
            this.radWashington.Text = "Washington";
            this.radWashington.UseVisualStyleBackColor = true;
            this.radWashington.CheckedChanged += new System.EventHandler(this.Capital_CheckedChanged);
            // 
            // radRome
            // 
            this.radRome.AutoSize = true;
            this.radRome.Location = new System.Drawing.Point(35, 99);
            this.radRome.Name = "radRome";
            this.radRome.Size = new System.Drawing.Size(77, 24);
            this.radRome.TabIndex = 12;
            this.radRome.TabStop = true;
            this.radRome.Text = "Rome";
            this.radRome.UseVisualStyleBackColor = true;
            this.radRome.CheckedChanged += new System.EventHandler(this.Capital_CheckedChanged);
            // 
            // radTokyo
            // 
            this.radTokyo.AutoSize = true;
            this.radTokyo.Location = new System.Drawing.Point(35, 69);
            this.radTokyo.Name = "radTokyo";
            this.radTokyo.Size = new System.Drawing.Size(76, 24);
            this.radTokyo.TabIndex = 11;
            this.radTokyo.TabStop = true;
            this.radTokyo.Text = "Tokyo";
            this.radTokyo.UseVisualStyleBackColor = true;
            this.radTokyo.CheckedChanged += new System.EventHandler(this.Capital_CheckedChanged);
            // 
            // radBuenosAires
            // 
            this.radBuenosAires.AutoSize = true;
            this.radBuenosAires.Location = new System.Drawing.Point(35, 39);
            this.radBuenosAires.Name = "radBuenosAires";
            this.radBuenosAires.Size = new System.Drawing.Size(129, 24);
            this.radBuenosAires.TabIndex = 10;
            this.radBuenosAires.TabStop = true;
            this.radBuenosAires.Text = "Buenos Aires";
            this.radBuenosAires.UseVisualStyleBackColor = true;
            this.radBuenosAires.CheckedChanged += new System.EventHandler(this.Capital_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupCapital);
            this.Controls.Add(this.groupCountry);
            this.Name = "Bai6";
            this.Text = "Capital of Country";
            this.groupCountry.ResumeLayout(false);
            this.groupCountry.PerformLayout();
            this.groupCapital.ResumeLayout(false);
            this.groupCapital.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCountry;
        private System.Windows.Forms.GroupBox groupCapital;
        private System.Windows.Forms.RadioButton radUK;
        private System.Windows.Forms.RadioButton radBrazil;
        private System.Windows.Forms.RadioButton radArgentina;
        private System.Windows.Forms.RadioButton radItalia;
        private System.Windows.Forms.RadioButton radUSA;
        private System.Windows.Forms.RadioButton radTurkey;
        private System.Windows.Forms.RadioButton radSpain;
        private System.Windows.Forms.RadioButton radHungary;
        private System.Windows.Forms.RadioButton radJapan;
        private System.Windows.Forms.RadioButton radFrance;
        private System.Windows.Forms.RadioButton radParis;
        private System.Windows.Forms.RadioButton radBrasilia;
        private System.Windows.Forms.RadioButton radBudapest;
        private System.Windows.Forms.RadioButton radAnkara;
        private System.Windows.Forms.RadioButton radLondon;
        private System.Windows.Forms.RadioButton radMarid;
        private System.Windows.Forms.RadioButton radWashington;
        private System.Windows.Forms.RadioButton radRome;
        private System.Windows.Forms.RadioButton radTokyo;
        private System.Windows.Forms.RadioButton radBuenosAires;
        private System.Windows.Forms.Label label1;
    }
}
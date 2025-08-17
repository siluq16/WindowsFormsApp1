using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void radFrance_CheckedChanged(object sender, EventArgs e)
        {
            if (radFrance.Checked)
            {
                label1.Text = "Hãy chọn thành phố cho France";
                EmptyOption();
            }
        }

        private void radJapan_CheckedChanged(object sender, EventArgs e)
        {
            if (radJapan.Checked)
            {
                label1.Text = "Hãy chọn thành phố cho Japan";
                EmptyOption();
            }
        }

        private void radHungary_CheckedChanged(object sender, EventArgs e)
        {
            if (radHungary.Checked)
            {
                label1.Text = "Hãy chọn thành phố cho Hungary";
                EmptyOption() ;
            }
        }

        private void radSpain_CheckedChanged(object sender, EventArgs e)
        {
            if (radSpain.Checked)
            {
                label1.Text = "Hãy chọn thành phố cho Spain";
                EmptyOption();
            }
        }

        private void radTurkey_CheckedChanged(object sender, EventArgs e)
        {
            if (radTurkey.Checked)
            {
                label1.Text = "Hãy chọn thành phố cho Turkey";
                EmptyOption() ;
            }
        }

        private void radUSA_CheckedChanged(object sender, EventArgs e)
        {
            if (radUSA.Checked)
            {
                label1.Text = "Hãy chọn thành phố cho The USA";
                EmptyOption();
            }
        }

        private void radItalia_CheckedChanged(object sender, EventArgs e)
        {
            if (radItalia.Checked)
            {
                label1.Text = "Hãy chọn thành phố cho Italia";
                EmptyOption();
            }
        }

        private void radArgentina_CheckedChanged(object sender, EventArgs e)
        {
            if (radArgentina.Checked)
            {
                label1.Text = "Hãy chọn thành phố cho Argentina";
                EmptyOption();
            }
        }

        private void radBrazil_CheckedChanged(object sender, EventArgs e)
        {
            if (radBrazil.Checked)
            {
                label1.Text = "Hãy chọn thành phố cho Brazil";
                EmptyOption();
            }
        }

        private void radUK_CheckedChanged(object sender, EventArgs e)
        {
            if (radUK.Checked)
            {
                label1.Text = "Hãy chọn thành phố cho The UK";
                EmptyOption();
            }
        }
        private void EmptyOption()
        {
            foreach (Control ctrl in groupCapital.Controls)
            {
                if (ctrl is RadioButton)
                {
                    ((RadioButton)ctrl).Checked = false;
                }
            }
        }

        private void Capital_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = sender as RadioButton;
            if (rad == null || !rad.Checked) return;

            string country = "";
            string capital = rad.Text;
            string correctCapital = "";

            if (radFrance.Checked) { country = "France"; correctCapital = "Paris"; }
            else if (radJapan.Checked) { country = "Japan"; correctCapital = "Tokyo"; }
            else if (radHungary.Checked) { country = "Hungary"; correctCapital = "Budapest"; }
            else if (radSpain.Checked) { country = "Spain"; correctCapital = "Madrid"; }
            else if (radTurkey.Checked) { country = "Turkey"; correctCapital = "Ankara"; }
            else if (radUK.Checked) { country = "The UK"; correctCapital = "London"; }
            else if (radItalia.Checked) { country = "Italia"; correctCapital = "Rome"; }
            else if (radArgentina.Checked) { country = "Argentina"; correctCapital = "Buenos Aires"; }
            else if (radBrazil.Checked) { country = "Brazil"; correctCapital = "Brasilia"; }
            else if (radUSA.Checked) { country = "The USA"; correctCapital = "Washington"; }

            if (capital == correctCapital)
                MessageBox.Show($"Chúc mừng bạn, thủ đô của {country} là {capital}");
            else
                MessageBox.Show($"Bạn sai rồi, thủ đô của {country} không phải là {capital}");
        }
    }
}
    

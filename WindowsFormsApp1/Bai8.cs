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
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void UpdateColor()
        {
            this.BackColor = Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value);
        }

        private void RedBar_Scroll(object sender, ScrollEventArgs e)
        {
            RedValue.Text = RedBar.Value.ToString();
            UpdateColor();
        }

        private void GreenBar_Scroll(object sender, ScrollEventArgs e)
        {
            GreenValue.Text = GreenBar.Value.ToString();
            UpdateColor();
        }

        private void BlueBar_Scroll(object sender, ScrollEventArgs e)
        {
            BlueValue.Text = BlueBar.Value.ToString();
            UpdateColor();
        }
    }
}
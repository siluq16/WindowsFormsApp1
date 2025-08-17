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
    public partial class Bai11 : Form
    {
        public Bai11()
        {
            InitializeComponent();
        }


        private void baitapdientu1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bai11_FrmDienTu frm = new Bai11_FrmDienTu(1);
            frm.ShowDialog();
        }

        private void baitapdientu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai11_FrmDienTu frm = new Bai11_FrmDienTu(2);
            frm.ShowDialog();
        }

        private void baitapdientu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai11_FrmDienTu frm = new Bai11_FrmDienTu(3);
            frm.ShowDialog();
        }

        private void biendoicauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai11_FrmBienDoiCau frm = new Bai11_FrmBienDoiCau();
            frm.ShowDialog();
        }
    }
}

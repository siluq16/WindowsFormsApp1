using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bai10 : Form
    {
        public Bai10()
        {
            InitializeComponent();
        }

        private void btnMoTapTin_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Rich Text Format|*.rtf|Text File|*.txt|All files|*.*";
            openFile.FilterIndex = 3;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (openFile.FilterIndex == 1)
                    richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
                else
                {
                    string content = File.ReadAllText(openFile.FileName, Encoding.UTF8);
                    richTextBox1.Text = content;
                }
            }
        }

        private void btnLuuTapTin_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Rich Text Format|*.rtf|Text File|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (saveFile.FilterIndex == 1)
                    richTextBox1.SaveFile(saveFile.FileName, RichTextBoxStreamType.RichText);
                else
                    richTextBox1.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void btnLuuTenKhac_Click(object sender, EventArgs e)
        {
            btnLuuTapTin_Click(sender, e);
        }

        private void btnFontChu_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDlg.Font;
            }
        }

        private void btnMauSac_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDlg.Color;
            }
        }

        private void btnInAn_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("In tài liệu thành công!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

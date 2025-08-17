using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
        }

        private void Bai9_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                    cboOdia.Items.Add(drive.Name);
            }
        }

        private void cboOdia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboThuMuc.Items.Clear();
            string selectedDrive = cboOdia.SelectedItem.ToString();

            try
            {
                string[] dirs = Directory.GetDirectories(selectedDrive);
                foreach (string dir in dirs)
                {
                    cboThuMuc.Items.Add(dir);
                }
            }
            catch { }
        }

        private void cboThuMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTapTin.Items.Clear();
            string folder = cboThuMuc.SelectedItem.ToString();

            try
            {
                string[] mp3Files = Directory.GetFiles(folder, "*.mp3");
                string[] txtFiles = Directory.GetFiles(folder, "*.txt");
                var allFiles = mp3Files.Concat(txtFiles);
                foreach (string file in allFiles)
                {
                    lstTapTin.Items.Add(file);
                }
            }
            catch { }
        }

        private void lstTapTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTapTin.SelectedItem == null) return;

            string folder = cboThuMuc.SelectedItem.ToString();
            string fileName = lstTapTin.SelectedItem.ToString();
            string fullPath = Path.Combine(folder, fileName);

            if (fullPath.EndsWith(".mp3"))
            {
                axWindowsMediaPlayer1.URL = fullPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();

                string lyricTxt = Path.ChangeExtension(fullPath, ".txt");
                string lyricRtf = Path.ChangeExtension(fullPath, ".rtf");

                if (File.Exists(lyricTxt))
                {
                    richTextBox1.Text = File.ReadAllText(lyricTxt, Encoding.UTF8);
                }
                else if (File.Exists(lyricRtf))
                {
                    richTextBox1.LoadFile(lyricRtf, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "Không tìm thấy lời bài hát!";
                }
            }
        }
    }
}

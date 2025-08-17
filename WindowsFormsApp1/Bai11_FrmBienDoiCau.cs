using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{

    public partial class Bai11_FrmBienDoiCau : Form
    {
        private List<string[]> questions = new List<string[]>();

        public Bai11_FrmBienDoiCau()
        {
            InitializeComponent();
            LoadData("data\\bai2.txt");
            ShowQuestions();
        }
        private void LoadData(string path)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("Không tìm thấy file: " + path);
                return;
            }

            string[] lines = File.ReadAllLines(path, System.Text.Encoding.UTF8);
            for (int i = 0; i < lines.Length; i += 3) 
            {
                if (i + 1 < lines.Length)
                {
                    string question = lines[i];
                    string hint = lines[i + 1];
                    questions.Add(new string[] { question, hint });
                }
            }
        }

        private void ShowQuestions()
        {
            panel1.Controls.Clear();
            int y = 10;

            for (int i = 0; i < questions.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = (i + 1) + ". " + questions[i][0];
                lbl.AutoSize = true;
                lbl.Location = new System.Drawing.Point(10, y);
                panel1.Controls.Add(lbl);

                TextBox txt = new TextBox();
                txt.Text = questions[i][1];
                txt.Name = "txtAnswer" + i;   
                txt.Width = panel1.Width - 20;
                txt.Location = new System.Drawing.Point(10, y + 20);
                panel1.Controls.Add(txt);

                y += 60; 
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}

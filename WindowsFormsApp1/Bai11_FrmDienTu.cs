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
    public partial class Bai11_FrmDienTu : Form
    {
        private string[] currentAnswers;
        private int currentId;
        public Bai11_FrmDienTu(int id)
        {
            InitializeComponent();
            currentId = id;
            LoadExercise(id);
        }

        private void LoadExercise(int id)
        {
            string filePath = Path.Combine(Application.StartupPath, "data", $"bai{id}.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Không tìm thấy file {filePath}");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            string passage = "";
            List<string> answerList = new List<string>();
            bool isAnswerSection = false;

            foreach (var line in lines)
            {
                if (line.StartsWith("ANSWERS:"))
                {
                    isAnswerSection = true;
                    continue;
                }

                if (!isAnswerSection)
                {
                    if (!line.StartsWith("PASSAGE:"))
                        passage += line + Environment.NewLine;
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(line))
                        answerList.Add(line.Trim());
                }
            }

            richTextBox1.Text = passage;
            currentAnswers = answerList.ToArray();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int score = 0;
            TextBox[] textBoxes = { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10 };

            for (int i = 0; i < currentAnswers.Length && i < textBoxes.Length; i++)
            {
                if (string.Equals(textBoxes[i].Text.Trim(), currentAnswers[i], StringComparison.OrdinalIgnoreCase))
                {
                    textBoxes[i].BackColor = System.Drawing.Color.LightGreen; // đúng
                    score++;
                }
                else
                {
                    textBoxes[i].BackColor = System.Drawing.Color.LightPink; // sai
                }
            }

            MessageBox.Show($"Bạn được {score}/{currentAnswers.Length} điểm");
        }

        private void BtnDapAn_Click(object sender, EventArgs e)
        {
            string answerText = "Đáp án đúng:\n";
            for (int i = 0; i < currentAnswers.Length; i++)
            {
                answerText += $"{i + 1}. {currentAnswers[i]}\n";
            }
            MessageBox.Show(answerText, "Đáp án");
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10 };

            foreach (var tb in textBoxes)
            {
                tb.Text = "";
                tb.BackColor = System.Drawing.Color.White;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

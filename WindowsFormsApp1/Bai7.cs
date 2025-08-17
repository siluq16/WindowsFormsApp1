using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void listBoxMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMatHang.SelectedItem != null)
            {
                string matHang = listBoxMatHang.SelectedItem.ToString();

                if (!listBoxHangDat.Items.Contains(matHang))
                {
                    listBoxHangDat.Items.Add(matHang);
                }
                else
                {
                    MessageBox.Show("Mặt hàng này đã được đặt rồi!", "Thông báo");
                }
            }
        }

        private void listBoxHangDat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHangDat.SelectedItems != null)
            {
                string matHang = listBoxHangDat.SelectedItem.ToString();
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xoá '{matHang}' không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    listBoxHangDat.Items.Remove(matHang);
                }
            }
        }

        private void Dongy_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Họ tên: " + textBox1.Text);
            sb.AppendLine("Địa chỉ: " + textBox2.Text);

            sb.AppendLine("\nCác mặt hàng đã đặt:");
            foreach (var item in listBoxHangDat.Items)
            {
                sb.AppendLine("- " + item.ToString());
            }

            string thanhToan = "";
            if (radTienMat.Checked) thanhToan = "Tiền mặt";
            else if (radSec.Checked) thanhToan = "Séc";
            else if (radTheTinDung.Checked) thanhToan = "Thẻ tín dụng";
            sb.AppendLine("\nPhương thức thanh toán: " + thanhToan);

            sb.AppendLine("\nHình thức liên lạc:");
            if (chkDienThoai.Checked) sb.AppendLine("- Điện thoại");
            if (chkFax.Checked) sb.AppendLine("- Fax");
            if (chkEmail.Checked) sb.AppendLine("- Email");

            MessageBox.Show(sb.ToString(), "Thông tin khách hàng");
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

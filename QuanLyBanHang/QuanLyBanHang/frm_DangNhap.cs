using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frm_DangNhap: Form
    {
        KetNoiDatabase ketNoi = new KetNoiDatabase();
        SqlConnection connect;
        string captcha = "";
        public frm_DangNhap()
        {
            InitializeComponent();
            connect = ketNoi.getConnect();
            Captcha();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT COUNT(*) FROM TAIKHOAN " +
                "WHERE TaiKhoan = '" + txt_TaiKhoan.Text + "' and MatKhau = '" + txt_MatKhau.Text + "'";
            SqlCommand command = new SqlCommand(sqlQuery, connect);
            connect.Open();
            int kiemTra = Convert.ToInt32(command.ExecuteScalar());
            connect.Close();
            if (txt_Captcha.Text != captcha.ToString())
            {
                MessageBox.Show("Sai captcha!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Captcha();
            }
            else if (kiemTra >= 1)
            {
                this.Hide();
                frm_Menu frm = new frm_Menu();
                frm.ShowDialog();
                this.Show();
            } else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void check_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_ShowPass.Checked)
            {
                txt_MatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_MatKhau.UseSystemPasswordChar = true;
            }
        }

        public string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void Captcha()
        {
            ////    Cách 1
            Random r1 = new Random();
            captcha = RandomString(4); // chữ và số
                                       //captcha = r1.Next(999, 100000).ToString();//r1.Next(999, 10000); //số
            var image = new Bitmap(this.ptb_Captcha.Width, this.ptb_Captcha.Height);
            var font = new Font("Lucida Handwriting", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(captcha.ToString(), font, Brushes.Green, new Point(0, 4));
            int count = 0;
            // vẽ đường gạch ngang
            while (count < 10)
            {
                graphics.DrawLine(new Pen(Color.Red), r1.Next(0, image.Width), r1.Next(0, image.Height), r1.Next(0, image.Width), r1.Next(0, image.Height));
                count++;
            }
            ptb_Captcha.Image = image;
        }

        private void frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
            {
                e.Cancel = true; // Hủy thao tác đóng Form
            }
        }

    }
}

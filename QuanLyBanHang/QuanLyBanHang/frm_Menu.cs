using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frm_Menu: Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_QuanLyKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QuanLyKhachHang frm = new frm_QuanLyKhachHang();
            frm.ShowDialog();
            this.Show();
        }

        private void btn_QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QuanLyNhanVien frm = new frm_QuanLyNhanVien();
            frm.ShowDialog();
            this.Show();
        }

        private void btn_QuanLySanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QuanLySanPham frm = new frm_QuanLySanPham();
            frm.ShowDialog();
            this.Show();
        }

        private void btn_QuanLyHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QuanLyHoaDon frm = new frm_QuanLyHoaDon();
            frm.ShowDialog();
            this.Show();
        }

        private void frm_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

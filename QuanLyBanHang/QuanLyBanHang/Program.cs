using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_DangNhap());
            //Application.Run(new frm_Menu());
            //Application.Run(new frm_QuanLyNhanVien());
            //Application.Run(new frm_QuanLyKhachHang());
            //Application.Run(new frm_QuanLyHoaDon());
            //Application.Run(new frm_QuanLySanPham());
            //Application.Run(new frm_ChiTietHoaDon(1));
        }
    }
}

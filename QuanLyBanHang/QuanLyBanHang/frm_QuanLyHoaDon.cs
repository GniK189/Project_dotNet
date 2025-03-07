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
    public partial class frm_QuanLyHoaDon : Form
    {
        KetNoiDatabase ketNoi = new KetNoiDatabase();
        SqlConnection connect;
        public frm_QuanLyHoaDon()
        {
            InitializeComponent();
            connect = ketNoi.getConnect();
            LoadNhanVien();
            LoadKhachHang();
        }

        public void LoadHD()
        {
            string sqlQuery = "SELECT * FROM HOADON";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgv_DanhSachHD.DataSource = dataTable;
        }

        private void frm_QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadHD();
        }

        public void LoadNhanVien()
        {
            string sqlQuery = "SELECT * FROM NHANVIEN WHERE VaiTro = N'Nhân viên bán hàng'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            DataRow emptyRow = dataTable.NewRow();
            emptyRow["MaNhanVien"] = DBNull.Value;
            emptyRow["TenNhanVien"] = "-- Chọn nhân viên --";
            dataTable.Rows.InsertAt(emptyRow, 0);

            cb_NhanVien.DataSource = dataTable;
            cb_NhanVien.DisplayMember = "TenNhanVien";
            cb_NhanVien.ValueMember = "MaNhanVien";

            cb_NhanVien.SelectedIndex = 0;
            lbl_MaNhanVien.Text = "";
        }

        private void cb_NhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_NhanVien.SelectedIndex > 0 && cb_NhanVien.SelectedValue != null)
            {
                lbl_MaNhanVien.Text = cb_NhanVien.SelectedValue.ToString();
            }
            else
            {
                lbl_MaNhanVien.Text = "";
            }
        }



        public void LoadKhachHang()
        {
            string sqlQuery = "SELECT * FROM KHACHHANG";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            DataRow emptyRow = dataTable.NewRow();
            emptyRow["MaKhachHang"] = DBNull.Value;
            emptyRow["TenKhachHang"] = "-- Chọn khách hàng --";
            dataTable.Rows.InsertAt(emptyRow, 0);

            cb_KhachHang.DataSource = dataTable;
            cb_KhachHang.DisplayMember = "TenKhachHang";
            cb_KhachHang.ValueMember = "MaKhachHang";

            cb_KhachHang.SelectedIndex = 0;
            lbl_MaKhachHang.Text = "";
        }

        private void cb_KhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_KhachHang.SelectedIndex > 0 && cb_KhachHang.SelectedValue != null)
            {
                lbl_MaKhachHang.Text = cb_KhachHang.SelectedValue.ToString();
            }
            else
            {
                lbl_MaKhachHang.Text = "";
            }
        }

        private void dgv_DanhSachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_DanhSachHD.CurrentRow == null || dgv_DanhSachHD.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lbl_HoaDonHienTai.Text = "HOÁ ĐƠN ĐANG CHỌN: " + dgv_DanhSachHD.CurrentRow.Cells["MaHoaDon"].Value.ToString();
            btn_ChiTietHoaDon.Text = "XEM CHI TIẾT HOÁ ĐƠN " + dgv_DanhSachHD.CurrentRow.Cells["MaHoaDon"].Value.ToString();
            cb_KhachHang.SelectedValue = dgv_DanhSachHD.CurrentRow.Cells["MaKhachHang"].Value.ToString();
            cb_NhanVien.SelectedValue = dgv_DanhSachHD.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            dtp_NgayLapHD.Text = dgv_DanhSachHD.CurrentRow.Cells["NgayLap"].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            String sqlQuery = "INSERT INTO HOADON " +
                "VALUES" +
                "('" + lbl_MaKhachHang.Text + "', " +
                "'" + lbl_MaNhanVien.Text + "', " +
                "Convert(Datetime, '" + dtp_NgayLapHD.Value + "', 103))";
            SqlCommand command = new SqlCommand(sqlQuery, connect);
            connect.Open();
            try
            {
                int ketQua = command.ExecuteNonQuery();
                if (ketQua >= 1)
                {
                    MessageBox.Show("Thêm thành công!!");
                    LoadHD();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btn_HienThiTatCa_Click(object sender, EventArgs e)
        {
            LoadHD();
        }

        private void btn_ChiTietHoaDon_Click(object sender, EventArgs e)
        {
            int maHoaDon = Convert.ToInt32(dgv_DanhSachHD.CurrentRow.Cells["MaHoaDon"].Value);
            frm_ChiTietHoaDon chiTietHoaDon = new frm_ChiTietHoaDon(maHoaDon);
            chiTietHoaDon.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn xoá hoá đơn này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                string sqlQueryChiTiet = "DELETE FROM CHITIETHOADON WHERE MaHoaDon = '" + dgv_DanhSachHD.CurrentRow.Cells["MaHoaDon"].Value + "'";
                string sqlQuery = "DELETE FROM HOADON WHERE MaHoaDon = '" + dgv_DanhSachHD.CurrentRow.Cells["MaHoaDon"].Value +"'";
                SqlCommand command = new SqlCommand(sqlQuery, connect);
                SqlCommand command2 = new SqlCommand(sqlQueryChiTiet, connect);
                connect.Open();
                try
                {
                    int ketQua2 = command2.ExecuteNonQuery();
                    int ketQua1 = command.ExecuteNonQuery();
                    if (ketQua1 >= 1 || ketQua2 >= 1)
                    {
                        MessageBox.Show("Xoá thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadHD();
                    }
                    else MessageBox.Show("Xoá thất bại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

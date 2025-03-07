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
    public partial class frm_ChiTietHoaDon: Form
    {
        KetNoiDatabase ketNoi = new KetNoiDatabase();
        SqlConnection connect;
        int maHoaDon;
        public frm_ChiTietHoaDon()
        {
            InitializeComponent();
            connect = ketNoi.getConnect();
        }

        public frm_ChiTietHoaDon(int maHoaDon)
        {
            connect = ketNoi.getConnect();
            InitializeComponent();
            this.maHoaDon = maHoaDon;
        }

        public void LoadHoaDon()
        {
            this.Text = "CHI TIẾT HOÁ ĐƠN SỐ " + maHoaDon;
            lbl_TieuDe.Text = "CHI TIẾT HOÁ ĐƠN SỐ " + maHoaDon;

            string sqlQuery = "SELECT KH.TenKhachHang, " +
                              "COALESCE(NV.TenNhanVien, N'Đã nghỉ việc') AS TenNhanVien " +
                              "FROM HOADON HD " +
                              "JOIN KHACHHANG KH ON HD.MaKhachHang = KH.MaKhachHang " +
                              "LEFT JOIN NHANVIEN NV ON HD.MaNhanVien = NV.MaNhanVien " +
                              "WHERE HD.MaHoaDon = '" + maHoaDon + "'";
            try
            {
                connect.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connect);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                connect.Close();

                if (dataTable.Rows.Count > 0)
                {
                    lbl_TenKhachHang.Text = dataTable.Rows[0]["TenKhachHang"].ToString();
                    lbl_TenNhanVien.Text = dataTable.Rows[0]["TenNhanVien"].ToString();
                }
                else
                {
                    lbl_TenKhachHang.Text = "";
                    lbl_TenNhanVien.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu: " + ex.Message);
            }
        }



        public void LoadChiTietHoaDon()
        {
            string sqlQuery = "SELECT * FROM CHITIETHOADON WHERE MaHoaDon = '"+maHoaDon+"'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgv_ChiTietHoaDon.DataSource = dataTable;
        }

        public void LoadSP() {
            string sqlQuery = "SELECT * FROM SANPHAM";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            cb_SanPham.DataSource = dataTable;
            cb_SanPham.DisplayMember = "TenSanPham";
            cb_SanPham.ValueMember = "MaSanPham";
            lbl_GiaTien.Text = dataTable.Rows[0]["DonGia"].ToString();
        }

        public void TongHoaDon()
        {
            string sqlQuery = "SELECT SUM(SoLuong * DonGia) FROM CHITIETHOADON WHERE MaHoaDon = '" + maHoaDon + "'";
            SqlCommand command = new SqlCommand(sqlQuery, connect);

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                object result = command.ExecuteScalar();
                double tongHoaDon = (result != DBNull.Value && result != null) ? Convert.ToDouble(result) : 0;

                lbl_TongHoaDon.Text = tongHoaDon.ToString() + " VNĐ";
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính tổng hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frm_ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            LoadChiTietHoaDon();
            LoadSP();
            TongHoaDon();
        }

        private void cb_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_SanPham.SelectedValue == null) return;

            string maSanPham = cb_SanPham.SelectedValue.ToString();

            if (connect == null)
            {
                MessageBox.Show("Lỗi: Kết nối CSDL chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sqlQuery = "SELECT * FROM SANPHAM WHERE MaSanPham = '" + maSanPham + "'";

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connect);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    lbl_GiaTien.Text = dataTable.Rows[0]["DonGia"].ToString();
                }
                else
                {
                    lbl_GiaTien.Text = "0" + " VNĐ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(txt_SoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlQuery = "INSERT INTO CHITIETHOADON " +
                              "VALUES ('" + maHoaDon + "', '" + cb_SanPham.SelectedValue.ToString() + "', '" + Convert.ToInt16(txt_SoLuong.Text)+ "', '" + Convert.ToDouble(lbl_GiaTien.Text) + "')";
            SqlCommand command = new SqlCommand(sqlQuery, connect);
            connect.Open();
            try
            {
                int ketQua = command.ExecuteNonQuery();
                if (ketQua >= 1)
                {
                    MessageBox.Show("Thêm thành công!!");
                    LoadChiTietHoaDon();
                    TongHoaDon();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!! Có thể bạn đã thêm sản phẩm này rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn xoá sản phẩm <" + cb_SanPham.Text + "> ra khỏi hoá đơn không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                string sqlQuery = "DELETE FROM CHITIETHOADON WHERE MaHoaDon = '" + maHoaDon + "' and MaSanPham = '" + cb_SanPham.SelectedValue.ToString() + "'";
                SqlCommand command = new SqlCommand(sqlQuery, connect);
                connect.Open();
                try
                {
                    int ketQua = command.ExecuteNonQuery();
                    if (ketQua >= 1)
                    {
                        MessageBox.Show("Xoá thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadChiTietHoaDon();
                        TongHoaDon();
                    }
                    else MessageBox.Show("Xoá thất bại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void dgv_ChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_SanPham.SelectedValue = dgv_ChiTietHoaDon.CurrentRow.Cells["MaSanPham"].Value.ToString();
            txt_SoLuong.Text = dgv_ChiTietHoaDon.CurrentRow.Cells["SoLuong"].Value.ToString(); 
        }
    }
}

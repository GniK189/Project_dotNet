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
    public partial class frm_QuanLyKhachHang: Form
    {
        KetNoiDatabase ketNoi = new KetNoiDatabase();
        int chon = 0;
        SqlConnection connect;

        public frm_QuanLyKhachHang()
        {
            InitializeComponent();
            connect = ketNoi.getConnect();
        }

        public void LoadKH()
        {
            String sqlQuery = "SELECT * FROM KHACHHANG";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgv_DanhSachKH.DataSource = dataTable;
        }

        private void frm_QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void dgv_DanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKhachHang.Text = dgv_DanhSachKH.CurrentRow.Cells["MaKhachHang"].Value.ToString();
            txt_TenKhachHang.Text = dgv_DanhSachKH.CurrentRow.Cells["TenKhachHang"].Value.ToString();
            txt_SoDienThoai.Text = dgv_DanhSachKH.CurrentRow.Cells["SoDienThoai"].Value.ToString();
            chon = 1;
            cb_GioiTinh.SelectedItem = dgv_DanhSachKH.CurrentRow.Cells["GioiTinh"].Value.ToString();
            cb_DiaChi.SelectedItem = dgv_DanhSachKH.CurrentRow.Cells["DiaChi"].Value.ToString();
            chon = 0;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            String sqlQuery = "INSERT INTO KHACHHANG " +
                "VALUES('" + txt_MaKhachHang.Text + "', " +
                "N'" + txt_TenKhachHang.Text + "', " +
                "N'" + cb_GioiTinh.SelectedItem + "', " +
                "N'" + cb_DiaChi.SelectedItem + "', " +
                "'" + txt_SoDienThoai.Text + "'" +
                ")";
            SqlCommand command = new SqlCommand(sqlQuery, connect);
            connect.Open();
            try
            {
                int ketQua = command.ExecuteNonQuery();
                if (ketQua >= 1)
                {
                    MessageBox.Show("Thêm thành công!!");
                    LoadKH();
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult diaglog = MessageBox.Show("Bạn có muốn xoá khách hàng <" + txt_TenKhachHang.Text + "> hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(diaglog == DialogResult.Yes)
            {
                String sqlQuery = "DELETE FROM KHACHHANG WHERE MaKhachHang = '"+txt_MaKhachHang.Text+"'";
                SqlCommand command = new SqlCommand(sqlQuery, connect);
                connect.Open();
                int ketQua = command.ExecuteNonQuery();
                connect.Close();
                if (ketQua >= 1)
                {
                    MessageBox.Show("Xoá thành công!!");
                    LoadKH();
                }
                else MessageBox.Show("Xoá thất bại!!");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            String sqlQuery = "UPDATE KHACHHANG " +
                "SET " +
                "TenKhachHang = N'"+txt_TenKhachHang.Text+"', " +
                "GioiTinh = N'"+cb_GioiTinh.SelectedItem+"', " +
                "DiaChi = N'"+cb_DiaChi.SelectedItem+"', " +
                "SoDienThoai = '"+txt_SoDienThoai.Text+"' " +
                "WHERE MaKhachHang = '"+txt_MaKhachHang.Text+"'";
            SqlCommand command = new SqlCommand(sqlQuery, connect);
            connect.Open();
            try
            {
                int ketQua = command.ExecuteNonQuery();
                if (ketQua >= 1)
                {
                    MessageBox.Show("Sửa thành công!!");
                    LoadKH();
                }
                else MessageBox.Show("Sửa thất bại!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception)
            {
                MessageBox.Show("Lỗi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            String sqlQuery = "SELECT * FROM KHACHHANG " +
                "WHERE MaKhachHang like '%" + txt_Tim.Text + "%' " +
                "or TenKhachHang like N'%" + txt_Tim.Text + "%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgv_DanhSachKH.DataSource = dataTable;
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            String sqlQuery = "SELECT COUNT(*) FROM KHACHHANG";
            SqlCommand command = new SqlCommand(sqlQuery, connect);
            connect.Open();
            int dem = Convert.ToInt32(command.ExecuteScalar());
            connect.Close();
            lbl_Dem.Text = dem.ToString() + " \n khách hàng";
        }

        private void rdo_Tang_CheckedChanged(object sender, EventArgs e)
        {
            dgv_DanhSachKH.Sort(dgv_DanhSachKH.Columns["MaKhachHang"], ListSortDirection.Ascending);
        }

        private void rdo_Giam_CheckedChanged(object sender, EventArgs e)
        {
            dgv_DanhSachKH.Sort(dgv_DanhSachKH.Columns["MaKhachHang"], ListSortDirection.Descending);
        }

        private void cb_DiaChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chon == 0)
            {
                string sqlQuery = "SELECT * FROM KHACHHANG " +
                "WHERE DiaChi = N'" + cb_DiaChi.SelectedItem.ToString() + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connect);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv_DanhSachKH.DataSource = dataTable;
            }
        }

        private void btn_HienThiTatCa_Click(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

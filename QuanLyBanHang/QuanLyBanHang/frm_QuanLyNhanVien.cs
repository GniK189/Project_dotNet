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
    public partial class frm_QuanLyNhanVien: Form
    {
        KetNoiDatabase ketNoi = new KetNoiDatabase();
        SqlConnection connect;
        int chon = 0;
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
            connect = ketNoi.getConnect();
        }

        public void LoadNV()
        {
            string sqlQuery = "SELECT * FROM NHANVIEN";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgv_DanhSachNV.DataSource = dataTable;
        }

        private void frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlQuery = "UPDATE NHANVIEN " +
                "SET TenNhanVien = N'"+txt_TenNhanVien.Text+"', " +
                "GioiTinh = N'"+cb_GioiTinh.SelectedItem+"', " +
                "NgaySinh = Convert(Datetime, '"+dtp_NgaySinh.Text+"',103), " +
                "DiaChi = N'"+cb_DiaChi.SelectedItem+"', " +
                "SoDienThoai = '"+txt_SoDienThoai.Text+"', " +
                "VaiTro = N'"+cb_VaiTro.SelectedItem+"' " +
                "WHERE MaNhanVien = '"+txt_MaNhanVien.Text+"'";
            SqlCommand command = new SqlCommand(sqlQuery, connect);
            connect.Open();
            try
            {
                int ketQua = command.ExecuteNonQuery();
                if (ketQua >= 1)
                {
                    MessageBox.Show("Sửa thành công!!");
                    LoadNV();
                }
                else MessageBox.Show("Sửa thất bại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                connect.Close();
            }
        }

        private void dgv_DanhSachNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNhanVien.Text = dgv_DanhSachNV.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txt_TenNhanVien.Text = dgv_DanhSachNV.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            dtp_NgaySinh.Text = dgv_DanhSachNV.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_SoDienThoai.Text = dgv_DanhSachNV.CurrentRow.Cells["SoDienThoai"].Value.ToString();
            chon = 1;
            cb_GioiTinh.SelectedItem = dgv_DanhSachNV.CurrentRow.Cells["GioiTinh"].Value.ToString();
            cb_DiaChi.SelectedItem = dgv_DanhSachNV.CurrentRow.Cells["DiaChi"].Value.ToString();
            cb_VaiTro.SelectedItem = dgv_DanhSachNV.CurrentRow.Cells["VaiTro"].Value.ToString();
            chon = 0;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO NHANVIEN " +
                "VALUES(" +
                "'"+txt_MaNhanVien.Text+"', " +
                "N'"+txt_TenNhanVien.Text+"', " +
                "N'"+cb_GioiTinh.SelectedItem+"', " +
                "Convert(Datetime, '"+dtp_NgaySinh.Text+"',103), " +
                "N'"+cb_DiaChi.SelectedItem+"', " +
                "'"+txt_SoDienThoai.Text+"', " +
                "N'"+cb_VaiTro.SelectedItem+"')";
            SqlCommand command = new SqlCommand(sqlQuery, connect);
            connect.Open();
            try
            {
                int ketQua = command.ExecuteNonQuery();
                if (ketQua >= 1)
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNV();
                }
                else MessageBox.Show("Thêm thất bại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {            
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn xoá nhân viên <" + txt_TenNhanVien.Text.ToString() + "> không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                string sqlQueryMain = "DELETE FROM NHANVIEN WHERE MaNhanVien = '" + txt_MaNhanVien.Text + "'";
                string sqlQuerySub = "UPDATE HOADON SET MaNhanVien = N'"+txt_MaNhanVien.Text+" (Da Nghi Viec)' WHERE MaNhanVien = '"+txt_MaNhanVien.Text+"'";
                SqlCommand command = new SqlCommand(sqlQueryMain, connect);
                SqlCommand commandSub = new SqlCommand(sqlQuerySub, connect);
                connect.Open();
                try
                {
                    int ketQua = command.ExecuteNonQuery();
                    int ketQuaSub = commandSub.ExecuteNonQuery();
                    if (ketQua >= 1 || ketQuaSub >= 1)
                    {
                        MessageBox.Show("Xoá thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNV();
                    }
                    else MessageBox.Show("Xoá thất bại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!!\n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void rdo_Tang_CheckedChanged(object sender, EventArgs e)
        {
            dgv_DanhSachNV.Sort(dgv_DanhSachNV.Columns["MaNhanVien"], ListSortDirection.Ascending);
        }

        private void rdo_Giam_CheckedChanged(object sender, EventArgs e)
        {
            dgv_DanhSachNV.Sort(dgv_DanhSachNV.Columns["MaNhanVien"], ListSortDirection.Descending);
        }

        private void cb_DiaChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chon == 0)
            {
                string sqlQuery = "SELECT * FROM NHANVIEN " +
                "WHERE DiaChi = N'" + cb_DiaChi.SelectedItem.ToString() + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connect);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv_DanhSachNV.DataSource = dataTable;
            }
        }

        private void cb_VaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chon == 0)
            {
                string sqlQuery = "SELECT * FROM NHANVIEN " +
                "WHERE VaiTro = N'" + cb_VaiTro.SelectedItem.ToString() + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connect);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv_DanhSachNV.DataSource = dataTable;
            }
        }

        private void btn_HienThiTatCa_Click(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

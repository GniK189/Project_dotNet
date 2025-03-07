using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QuanLyBanHang
{
    public partial class frm_QuanLySanPham: Form
    {
        KetNoiDatabase ketNoi = new KetNoiDatabase();
        SqlConnection connect;
        string duongDanAnh = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HinhAnh\\";
        public frm_QuanLySanPham()
        {
            InitializeComponent();
            connect = ketNoi.getConnect();
        }

        public void LoadSP()
        {
            string sqlQuery = "SELECT MaSanPham, TenSanPham, DonViTinh, DonGia FROM SANPHAM";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgv_SanPham.DataSource = dataTable;
        }

        private void frm_QuanLySanPham_Load(object sender, EventArgs e)
        {
            LoadSP();
        }

        private void txt_DonGia_TextChanged(object sender, EventArgs e)
        {
            txt_DonGia.Text = System.Text.RegularExpressions.Regex.Replace(txt_DonGia.Text, "[^0-9]", "");
            txt_DonGia.SelectionStart = txt_DonGia.Text.Length;
        }

        private void btn_HienToanBo_Click(object sender, EventArgs e)
        {
            LoadSP();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO SANPHAM " +
                "VALUES" +
                "('" + txt_MaSanPham.Text.ToUpper() + "', " +
                "N'" + txt_TenSanPham.Text + "', " +
                "N'" + cb_DonViTinh.SelectedItem + "', " +
                "'" + Convert.ToDouble(txt_DonGia.Text) + "', " +
                "N'"+txt_TenSanPham.Text+".png')";
            SqlCommand command = new SqlCommand(sqlQuery, connect);
            connect.Open();
            try
            {
                int ketQua = command.ExecuteNonQuery();
                if (ketQua >= 1)
                {
                    ptb_SanPham.Image.Save(duongDanAnh + txt_TenSanPham.Text+ ".png");
                    MessageBox.Show("Thêm thành công!!");
                    LoadSP();
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            String sqlQuery = "UPDATE SANPHAM " +
                "SET " +
                "TenSanPham = N'"+txt_TenSanPham.Text+"', " +
                "DonViTinh = N'"+cb_DonViTinh.SelectedItem+"', " +
                "DonGia = '"+Convert.ToDouble(txt_DonGia.Text)+"'," +
                "HinhAnh = N'"+ duongDanAnh + txt_TenSanPham.Text + ".png" + "' " +
                "WHERE MaSanPham = '"+txt_MaSanPham.Text+"'";
            SqlCommand command = new SqlCommand(sqlQuery, connect);
            connect.Open();
            try
            {
                int ketQua = command.ExecuteNonQuery();
                if (ketQua >= 1)
                {
                    MessageBox.Show("Sửa thành công!!");
                    LoadSP();
                }
                else MessageBox.Show("Sửa thất bại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSanPham.Text = dgv_SanPham.CurrentRow.Cells["MaSanPham"].Value.ToString();
            txt_TenSanPham.Text = dgv_SanPham.CurrentRow.Cells["TenSanPham"].Value.ToString();
            txt_DonGia.Text = dgv_SanPham.CurrentRow.Cells["DonGia"].Value.ToString();
            cb_DonViTinh.SelectedItem = dgv_SanPham.CurrentRow.Cells["DonViTinh"].Value.ToString();
            ptb_SanPham.ImageLocation =duongDanAnh + txt_TenSanPham.Text + ".png";
        }

        private void MENU_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xoá sản phẩm <" + txt_TenSanPham.Text + "> hay không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                string sqlQuery = "DELETE FROM SANPHAM WHERE MaSanPham = '" + txt_MaSanPham.Text + "'";
                SqlCommand command = new SqlCommand(sqlQuery, connect);
                connect.Open();
                try
                {
                    int ketQua = command.ExecuteNonQuery();
                    if(ketQua >= 1)
                    {
                        File.Delete(duongDanAnh + duongDanAnh + txt_TenSanPham.Text + ".png" + ".png");
                        MessageBox.Show("Thành công");
                        LoadSP();
                    } else
                    {
                        MessageBox.Show("Thất bại");
                    }
                } catch
                {
                    MessageBox.Show("Lỗi", "Thông báo");
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void ptb_SanPham_Click(object sender, EventArgs e)
        {
            OpenFileDialog odf = new OpenFileDialog();
            odf.Title = "Hãy chọn hình";
            odf.Filter = "Tất cả đuôi|*.*|JPG|*.jpg|PNG|*.png|JPEG|*.jpeg";
            if (odf.ShowDialog() == DialogResult.OK)
            {
                ptb_SanPham.Image = Image.FromFile(odf.FileName);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    class KetNoiDatabase
    {
        string diaChi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\NPTrungHieu\\source\\repos\\QuanLyBanHang\\QuanLyBanHang\\DB_QuanLyBanHang.mdf;Integrated Security=True";
        SqlConnection connect;
        public KetNoiDatabase()
        {
            connect = new SqlConnection(diaChi);
        }
        public SqlConnection getConnect()
        {
            return connect;
        }
    }
}

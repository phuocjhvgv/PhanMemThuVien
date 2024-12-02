using DOAN.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DOAN.BLL
{
    internal class BLL_QLTAIKHOAN
    {
        DAL.DAL_QLTAIKHOAN dal_QLTK;
        public BLL_QLTAIKHOAN()
        {
            dal_QLTK = new DAL.DAL_QLTAIKHOAN();
        }
        public DataTable loadtk()
        {
            return dal_QLTK.loaddtgrvtk();
        }
        public bool KiemTraTaiKhoan(string idtaikhoan, string tentk)
        {
     
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE idTaiKhoan = @idtaikhoan AND tentk = @tentk";

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\source\repos\PhanMemThuVien\DOAN\QLThuVien.mdf;Integrated Security=True"))
            {
                conn.Open(); 
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idtaikhoan", idtaikhoan);
                    cmd.Parameters.AddWithValue("@tentk", tentk);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }


        public bool CapNhatTaiKhoan(string idtaikhoan, string tentk, string mk)
        {
            string query = "UPDATE TaiKhoan SET idtaikhoan = @idtaikhoan, tentk = @tentk, mk = @mk WHERE idtaikhoan = @idtaikhoan";

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\source\repos\PhanMemThuVien\DOAN\QLThuVien.mdf;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idtaikhoan", idtaikhoan);
                    cmd.Parameters.AddWithValue("@tentk", tentk);
                    cmd.Parameters.AddWithValue("@mk", mk);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public bool XoaTaiKhoan(string idtaikhoan)
        {
            string query = "DELETE FROM TaiKhoan WHERE idtaikhoan = @idtaikhoan";

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\source\repos\PhanMemThuVien\DOAN\QLThuVien.mdf;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idtaikhoan", idtaikhoan);


                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public void Themtk(string idtaikhoan, string tentk, string mk)
        {
            string query = "INSERT INTO TaiKhoan (idtaikhoan, tentk, mk) VALUES (@idtaikhoan, @tentk, @mk)";

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\source\repos\PhanMemThuVien\DOAN\QLThuVien.mdf;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idtaikhoan", idtaikhoan);
                    cmd.Parameters.AddWithValue("@tentk", tentk);
                    cmd.Parameters.AddWithValue("@mk", mk);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Xoatk(string idtaikhoan)
        {
            string query = "DELETE FROM TaiKhoan WHERE idtaikhoan = @idtaikhoan";

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\source\repos\PhanMemThuVien\DOAN\QLThuVien.mdf;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idtaikhoan", idtaikhoan);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void updatetk(string idtaikhoan, string tentk, string mk)
        {
            string query = "UPDATE TaiKhoan SET tentk = @tentk, mk = @mk WHERE idtaikhoan = @idtaikhoan";

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\source\repos\PhanMemThuVien\DOAN\QLThuVien.mdf;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idtaikhoan", idtaikhoan);
                    cmd.Parameters.AddWithValue("@tentk", tentk);
                    cmd.Parameters.AddWithValue("@mk", mk);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

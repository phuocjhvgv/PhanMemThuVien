using DOAN.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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
     
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE idTaiKhoan = @idtaikhoan AND TenTaiKhoan = @tentk";

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
            string query = "UPDATE TaiKhoan SET TenTaiKhoan = @tentk, MatKhau = @mk WHERE IdTaiKhoan = @idtaikhoan";

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
            string query = "DELETE FROM TaiKhoan WHERE idTaiKhoan = @idtaikhoan";

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
            dal_QLTK.Themtk(idtaikhoan,tentk,mk);
        }
        public void Xoatk(string idtaikhoan)
        {
            dal_QLTK.Xoatk(idtaikhoan);
        }
        public void updatetk(string idtaikhoan, string tentk, string mk)
        {
            dal_QLTK.updatetk(idtaikhoan, tentk, mk);
        }
    }
}

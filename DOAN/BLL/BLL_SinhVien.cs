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
    internal class BLL_SinhVien
    {
        DAL.DAL_SinhVien dal_SinhVien;
        public BLL_SinhVien()
        {
            dal_SinhVien = new DAL.DAL_SinhVien();
        }
        public bool KiemTraSinhVien(string id, string maSv, string email)
        {

            string query = "SELECT COUNT(*) FROM SinhVien WHERE Id = @Id AND MaSV = @MaSV AND Email = @Email";

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Source\Repos\PhanMemThuVien\DOAN\QLThuVien.mdf;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@MaSV", maSv);
                    cmd.Parameters.AddWithValue("@Email", email);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }
        private bool KhongChuaKyTuDacBiet(string input)
        {

            string pattern = @"^[a-zA-Z0-9_]+$";
            return Regex.IsMatch(input, pattern);
        }
        public DataTable loadStudent()
        {
            return dal_SinhVien.loadStudent();
        }
        public void addStudent(string id,string maSv, string tenSv, string lop, string khoa, int sdt, string email)
        {
            dal_SinhVien.addStudent(id,maSv, tenSv, lop, khoa, sdt, email);
        }
        public void deleteStudent(string maSV)
        {
            dal_SinhVien.deleteStudent(maSV);
        }
        public void updateStudent(string id, string maSv, string tenSv, string lop, string khoa, int sdt, string email)
        {
            dal_SinhVien.updateStudent(id,maSv, tenSv, lop, khoa, sdt, email);
        }
        public DataTable searchSinhVien(string maSv)
        {
            return dal_SinhVien.searchSinhVien(maSv);
        }
    }
}

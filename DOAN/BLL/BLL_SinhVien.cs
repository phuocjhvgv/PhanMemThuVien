using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
        public DataTable loadStudent()
        {
            return dal_SinhVien.loadStudent();
        }
        public void addStudent(string maSv, string tenSv, string lop, string khoa, int sdt, string email)
        {
            dal_SinhVien.addStudent(maSv, tenSv, lop, khoa, sdt, email);
        }
        public void deleteStudent(string maSV)
        {
            dal_SinhVien.deleteStudent(maSV);
        }
        public void updateStudent(string maSv, string tenSv, string lop, string khoa, int sdt, string email)
        {
            dal_SinhVien.updateStudent(maSv, tenSv, lop, khoa, sdt, email);
        }
        public DataTable searchSinhVien(string maSv)
        {
            return dal_SinhVien.searchSinhVien(maSv);
        }
    }
}

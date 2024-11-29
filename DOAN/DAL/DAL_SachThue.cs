using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN.DAL
{
    internal class DAL_SachThue
    {
        LopDungChung lopchung;
        public DAL_SachThue()
        {
            lopchung = new LopDungChung();
        }
        public DataTable loadCbSach()
        {
            string loadCb = "Select *from SACH";
            return lopchung.loadGrid(loadCb);
        }
        public DataTable loadBook()
        {
            string loadBook = "Select *from SachThue";
            return lopchung.loadGrid(loadBook);
        }
        public DataTable CompleteBookDetails_Loadnull()
        {
            string loadIssuebok = "select *from SachThue where NgayTra is null";
            return lopchung.loadGrid(loadIssuebok);

        }
        public DataTable CompleteBookDetails_Loadnotnull()
        {
            string loadReturnBook = "select *from SachThue where NgayTra is not null";
            return lopchung.loadGrid(loadReturnBook);
        }
        public DataTable LoadData()
        {
            string sqlTim = "Select *from SachThue";
            return lopchung.loadGrid(sqlTim);
        }
        public DataTable searchSinhVienThueSach(String maSv)
        {
            string sqlTim = "Select *from SachThue Where (MaSV = '" + maSv + "') and (NgayTra is null)";
            return lopchung.loadGrid(sqlTim);
        }
        public DataTable searchSinhVienTraSach(String maSv)
        {
            string sqlTim = "Select *from SachThue Where (MaSV = '" + maSv + "') and (NgayTra is not null)";
            return lopchung.loadGrid(sqlTim);
        }
        public DataTable searchSinhVien(string maSv)
        {
            string sqlTim = "Select *from SinhVien Where MaSV = '" + maSv + "'";
            return lopchung.loadGrid(sqlTim);
        }
        public int DemSachMuon()
        {
            string sqlDemSachMuon = "SELECT COUNT (*) FROM SachThue WHERE NgayTra is null";
            int count = (int)lopchung.Scalar(sqlDemSachMuon);
            return count;
        }
        public int DemSachTra()
        {
            string sqlDemSachMuon = "SELECT COUNT (*) FROM SachThue WHERE NgayTra is not null";
            int count = (int)lopchung.Scalar(sqlDemSachMuon);
            return count;
        }
        public int Dem(string maSv)
        {
            string sqlDemSachMuon = "SELECT COUNT (*) FROM SachThue WHERE MaSV = '" + maSv + "'";
            int count = (int)lopchung.Scalar(sqlDemSachMuon);
            return count;
        }
        public void insertThueSach(string maSv, string tenSv, string lop, string khoa, int sdt, string email, string tenSach, string bookDate)
        {
            string sqlLuu = "INSERT INTO SachThue (MaSv, TenSv, Lop, Khoa, SoDienThoai, Email, TenSach, NgayThue, NgayTra) " +
                       "VALUES ('" + maSv + "','" + tenSv + "','" + lop + "','" + khoa + "'," + sdt + ",'" + email + "','" + tenSach + "','" + bookDate + "', null)";
            lopchung.nonQuery(sqlLuu);
        }
        public DataTable timReturn(string maSv)
        {
            string loadReturn = "Select * from SachThue where (MaSV LIKE '%" + maSv + "%' or TenSinhVien LIKE '%" + maSv + "%') and (NgayTra IS NULL)";
            return lopchung.loadGrid(loadReturn);
        }
        public void returnBook(string ngayTra, string maSv, int rowid)
        {
            string sqlreturn = "update SachThue set NgayTra= '" + ngayTra + "' where MaSV= '" + maSv + "' and Id = '" + rowid + "'";
            lopchung.nonQuery(sqlreturn);
        }
    }
}

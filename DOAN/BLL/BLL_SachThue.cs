using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN.BLL
{
    internal class BLL_SachThue
    {
        DAL.DAL_SachThue dal_SachThue;
        public BLL_SachThue()
        {
            dal_SachThue = new DAL.DAL_SachThue();
        }
        public DataTable loadCbSach()
        {
            return dal_SachThue.loadCbSach();
        }
        public DataTable loadBook()
        {
            return dal_SachThue.loadBook();
        }
        public DataTable CompleteBookDetails_Loadnull()
        {
            return dal_SachThue.CompleteBookDetails_Loadnull();
        }
        public DataTable searchSinhVienThueSach(String sql)
        {
            return dal_SachThue.searchSinhVienThueSach(sql);
        }
        public int demSachThue()
        {
            return dal_SachThue.DemSachMuon();
        }
        public int demSachTra()
        {
            return dal_SachThue.DemSachTra();
        }
        public DataTable searchSinhVienTraSach(String sql)
        {
            return dal_SachThue.searchSinhVienTraSach(sql);
        }
        public DataTable CompleteBookDetails_Loadnotnull()
        {
            return dal_SachThue.CompleteBookDetails_Loadnotnull();
        }
        public DataTable LoadData()
        {
            return dal_SachThue.LoadData();
        }
        public DataTable searchSinhVien(string maSv)
        {
            return dal_SachThue.searchSinhVien(maSv);
        }
        public int Dem(string maSv)
        {
            return dal_SachThue.Dem(maSv);
        }
        public void insertThueSach(string maSv, string tenSv, string lop, string khoa, int sdt, string email, string tenSach, string bookDate)
        {
            dal_SachThue.insertThueSach(maSv, tenSv, lop, khoa, sdt, email, tenSach, bookDate);
        }
        public DataTable timReturn(string maSv)
        {
            return dal_SachThue.timReturn(maSv);
        }
        public void returnBook(string ngayTra, string maSv, int rowid)
        {
            dal_SachThue.returnBook(ngayTra, maSv, rowid);
        }
    }
}

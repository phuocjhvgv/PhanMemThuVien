using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN.BLL
{
    internal class BLL_Sach
    {
        DAL.DAL_Sach dal_Sach;
        public BLL_Sach()
        {
            dal_Sach = new DAL.DAL_Sach();
        }
        public DataTable loadBook()
        {
            return dal_Sach.loadBook();
        }
        public void ThemBook(string maSach, string tenSach, string tenTacGia, string NhaXuatBan, string ngayMua, int giaSach, int soLuong)
        {
            dal_Sach.ThemBook(maSach, tenSach, tenTacGia, NhaXuatBan, ngayMua, giaSach, soLuong);
        }
        public void XoaBook(string maSach)
        {
            dal_Sach.XoaBook(maSach);
        }
        public void updateBook(string maSach, string tenSach, string tenTacGia, string NhaXuatBan, string ngayMua, int giaSach, int soLuong)
        {
            dal_Sach.updateBook(maSach, tenSach, tenTacGia, NhaXuatBan, ngayMua, giaSach, soLuong);
        }
        public DataTable timSach(string maSach)
        {
            return dal_Sach.timSach(maSach);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN.DAL
{
    internal class DAL_Sach
    {
        LopDungChung lopchung;
        public DAL_Sach()
        {
            lopchung = new LopDungChung();
        }
        public DataTable loadBook()
        {
            string loadBook = "Select *from Sach";
            return lopchung.loadGrid(loadBook);
        }
        public void ThemBook(string maSach, string tenSach, string tenTacGia, string NhaXuatBan, string ngayMua, int giaSach, int soLuong)
        {
            string Save = "INSERT INTO SACH (MaSach, TenSach, TenTacGia, NhaXuatBan, NgayMua, GiaSach, SoLuong) VALUES " +
                "('" + maSach + "','" + tenSach + "', '" + tenTacGia + "', '" + NhaXuatBan + "', '" + ngayMua + "', " + giaSach + ", " + soLuong + ")";
            lopchung.nonQuery(Save);
        }
        public void XoaBook(string maSach)
        {
            string sqlDelete = "Delete Sach Where MaSach= '" + maSach + "'";
            lopchung.nonQuery(sqlDelete);
        }
        public void updateBook(string maSach, string tenSach, string tenTacGia, string NhaXuatBan, string ngayMua, int giaSach, int soLuong)
        {
            string sqlUpdate = "Update Sach set TenSach= '" + tenSach + "', TenTacGia= '" + tenTacGia + "', NhaXuatBan= '" + NhaXuatBan + "', NgayMua= '" + ngayMua + "'" +
                ", GiaSach= '" + giaSach + "', SoLuong= '" + soLuong + "' Where MaSach= '" + maSach + "' ";
            lopchung.nonQuery(sqlUpdate);
        }
        public DataTable timSach(string maSach)
        {
            string sqltim = "Select * from SACH where MaSach LIKE '%" + maSach + "%' or TenSach LIKE '%" + maSach + "%'";
            return lopchung.loadGrid(sqltim);
        }
    }
}

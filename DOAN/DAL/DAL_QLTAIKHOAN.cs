using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DOAN.DAL
{
    internal class DAL_QLTAIKHOAN
    {
        LopDungChung lopchung;
        public DAL_QLTAIKHOAN()
        {
            lopchung = new LopDungChung();
        }
        public DataTable loaddtgrvtk()
        {
            string loadtk = "Select *from TaiKhoan";
            return lopchung.loadGrid(loadtk);
        }
        public void Themtk(string idtaikhoan, string tentk, string mk)
        {
            string Save = "INSERT INTO TaiKhoan (idtaikhoan, tentk, mk) VALUES " +
                "('" + idtaikhoan + "','" + tentk + "', '" + mk  + ")";
            lopchung.nonQuery(Save);
        }
        public void Xoatk(string maSach)
        {
            string sqlDelete = "Delete Sach Where MaSach= '" + maSach + "'";
            lopchung.nonQuery(sqlDelete);
        }
        public void updatetk(string idtaikhoan, string tentk, string mk)
        {
            string sqlUpdate = "Update TaiKhoan set tentk= '" + idtaikhoan + "','" + tentk + "', '" + mk + "' Where idtaikhoan= '" + idtaikhoan + "' ";
            lopchung.nonQuery(sqlUpdate);
        }
    }
}

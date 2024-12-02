using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN.DAL
{
    internal class DAL_NhaXuatBan
    {

        LopDungChung lopchung;
        public DAL_NhaXuatBan()
        {
            lopchung = new LopDungChung();
        }
        public DataTable loadNXB()
        {
            string loadStudent = "Select *from NhaXuatBan";
            return lopchung.loadGrid(loadStudent);
        }
        public void addNXB(string idNxb, string tenNxb)
        {
            string sqlSave = "Insert into NhaXuatBan (ID_NHAXB, TEN_NHAXB) Values ('" + idNxb + "','" + tenNxb + "')";
            lopchung.nonQuery(sqlSave);
        }
        public void deleteNXB(string idNxb)
        {
            string sqlDelete = "Delete SinhVien Where ID_NHAXB= '" + idNxb + "'";
            lopchung.nonQuery(sqlDelete);
        }
        public void updateNXB(string idNxb, string tenNxb)
        {
            string sqlUpdate = "Update NhaXuatBan Set TEN_NHAXB= '" + tenNxb + "'";
            lopchung.nonQuery(sqlUpdate);
        }
        public DataTable searchNXB(string idNxb)
        {
            string sqltim = "Select * from NhaXuatBan where ID_NHAXB LIKE '%" + idNxb + "%'";
            return lopchung.loadGrid(sqltim);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN.GUI;

namespace DOAN.DAL
{
    internal class DAL_TacGia
    {
        LopDungChung lopchung;
        public DAL_TacGia()
        {
            lopchung = new LopDungChung();
        }
        public DataTable loadTG()
        {
            string loadTG = "Select *from TacGia";
            return lopchung.loadGrid(loadTG);
        }
        public void addTG(string idTG, string tenTG, string diachi)
        {
            string sqlSave = "Insert into TacGia (ID_TACGIA, TEN_TACGIA, DIA_CHI) Values ('" + idTG + "','" + tenTG + "','" + diachi + "')";
            lopchung.nonQuery(sqlSave);
        }
        public void deleteTG(string idTG)
        {
            string sqlDelete = "Delete TacGia Where ID_TACGIA= '" + idTG + "'";
            lopchung.nonQuery(sqlDelete);
        }
        public void updateTG(string idTG, string tenTG, string diaChi)
        {
            string sqlUpdate = "Update TacGia Set TEN_TACGIA= '" + tenTG + "'";
            lopchung.nonQuery(sqlUpdate);
        }
        public DataTable searchTG(string idTG)
        {
            string sqltim = "Select * from TacGia where ID_TACGIA LIKE '%" + idTG + "%'";
            return lopchung.loadGrid(sqltim);
        }
    }
}

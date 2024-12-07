using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN.BLL
{
    internal class BLL_TacGia
    {
        DAL.DAL_TacGia dal_TacGia;
        public BLL_TacGia()
        {
            dal_TacGia = new DAL.DAL_TacGia();
        }
        public DataTable loadTG()
        {
            return dal_TacGia.loadTG();
        }
        public void addTG(string idTG, string tenTG, string diaChi)
        {
            dal_TacGia.addTG(idTG, tenTG, diaChi);
        }
        public void deleteTG(string idTG)
        {
            dal_TacGia.deleteTG(idTG);
        }
        public void updateTG(string idTG, string tenTG, string diaChi)
        {
            dal_TacGia.updateTG(idTG, tenTG, diaChi);
        }
        public DataTable searchTG(string idTG)
        {
            return dal_TacGia.searchTG(idTG);
        }
    }
}

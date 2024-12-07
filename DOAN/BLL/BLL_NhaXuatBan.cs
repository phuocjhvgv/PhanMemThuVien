using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN.BLL
{
    internal class BLL_NhaXuatBan
    {
        DAL.DAL_NhaXuatBan dal_NhaXuatBan;
        public BLL_NhaXuatBan()
        {
            dal_NhaXuatBan = new DAL.DAL_NhaXuatBan();
        }
        public DataTable loadNXB()
        {
            return dal_NhaXuatBan.loadNXB();
        }
        public void addNXB(string idNxb, string tenNxb)
        {
            dal_NhaXuatBan.addNXB(idNxb, tenNxb);
        }
        public void deleteNXB(string idNxb)
        {
            dal_NhaXuatBan.deleteNXB(idNxb);
        }
        public void updateNXB(string idNxb, string tenNxb)
        {
            dal_NhaXuatBan.updateNXB(idNxb, tenNxb);
        }
        public DataTable searchNXB(string idNxb)
        {
            return dal_NhaXuatBan.searchNXB(idNxb);
        }
    }
}

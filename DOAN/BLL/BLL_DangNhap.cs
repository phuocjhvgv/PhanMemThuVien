using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN.BLL
{
    internal class BLL_DangNhap
    {
        DAL.DAL_DangNhap dangnhap;
        public BLL_DangNhap()
        {
            dangnhap = new DAL.DAL_DangNhap();
        }

        public int DangNhap(String user, String matkhau)
        {
            return dangnhap.DangNhap(user, matkhau);
        }
    }
}

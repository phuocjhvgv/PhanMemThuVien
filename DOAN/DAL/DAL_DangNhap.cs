﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN.DAL
{
    internal class DAL_DangNhap
    {
        LopDungChung lopchung;
        public DAL_DangNhap()
        {
            lopchung = new LopDungChung();
        }

        public int DangNhap(String user, String matkhau)
        {
            string sqldn = "Select count(*) from DangNhap where TenDangNhap = '" + user + "'and MatKhau= '" + matkhau + "'";
            int kq = (int)lopchung.Scalar(sqldn);
            return kq;
        }
    }
}
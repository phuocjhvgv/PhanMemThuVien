﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DOAN.DAL
{
    internal class DAL_SinhVien
    {
        LopDungChung lopchung;
        public DAL_SinhVien()
        {
            lopchung = new LopDungChung();
        }
        public DataTable loadStudent()
        {
            string loadStudent = "Select *from SinhVien";
            return lopchung.loadGrid(loadStudent);
        }
        
        public void addStudent(string id, string maSv, string tenSv, string lop, string khoa, int sdt, string email)
        {
            string sqlSave = "Insert into SinhVien (Id,MaSV, TenSinhVien, Lop, Khoa, SDT, Email) Values ('" + id + "','" + maSv + "','" + tenSv + "','" + lop + "','" + khoa + "','" + sdt + "','" + email + "')";
            lopchung.nonQuery(sqlSave);
        }
        public void deleteStudent(string maSV)
        {
            string sqlDelete = "Delete SinhVien Where MaSV= '" + maSV + "'";
            lopchung.nonQuery(sqlDelete);
        }
        public void updateStudent(string id, string maSv, string tenSv, string lop, string khoa, int sdt, string email)
        {
            string sqlUpdate = "Update SinhVien Set TenSinhVien= '" + tenSv + "',Lop= '" + lop + "',Khoa= '" + khoa + "',SDT= '" + sdt + "',Email= '" + email + "' where MaSV= '" + maSv + "'";
            lopchung.nonQuery(sqlUpdate);
        }
        public DataTable searchSinhVien(string maSv)
        {
            string sqltim = "Select * from SinhVien where MaSV LIKE '%" + maSv + "%'";
            return lopchung.loadGrid(sqltim);
        }
    }
}

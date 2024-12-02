using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN.DAL
{
	internal class DAL_TheLoaiSach
	{
		LopDungChung lopchung;
		public DAL_TheLoaiSach()
		{
			lopchung = new LopDungChung();
		}
		public DataTable loadType()
		{
			string loadType = "Select *from TheLoaiSach";
			return lopchung.loadGrid(loadType);
		}
		public void addType(string maTl, string tenTl)
		{
			string sqladd = "Insert into TheLoaiSach (ID_THELOAI, TEN_THELOAI) Values ('" + maTl + "','" + tenTl + "')";
			lopchung.nonQuery(sqladd);
		}
		public void deleteType(string maTl)
		{
			string sqlDelete = "Delete TheLoaiSach Where ID_THELOAI= '" + maTl + "'";
			lopchung.nonQuery(sqlDelete);
		}
		public void updateType(string maTl, string tenTl)
		{
			string sqlUpdate = "Update TheLoaiSach Set TEN_THELOAI= '" + tenTl + "' where ID_THELOAI= '" + maTl + "'";
			lopchung.nonQuery(sqlUpdate);
		}
		public void check(string maTl)
		{
			string query = "SELECT COUNT(*) FROM TheLoaiSach WHERE ID_THELOAI = @idtheloai AND TEN_THELOAI = @tentheloai";
			lopchung.Scalar(query);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace DOAN.BLL
	{
		internal class BLL_TheLoai
		{
			DAL.DAL_TheLoaiSach dal_theloai;
			public BLL_TheLoai()
			{
				dal_theloai = new DAL.DAL_TheLoaiSach();
			}
			public DataTable loadType()
			{
				return dal_theloai.loadType();
			}
			public void addType(string maTl, string tenTl)
			{
				dal_theloai.addType(maTl, tenTl);
			}
			public void deleteType(string maTl)
			{
				dal_theloai.deleteType(maTl);
			}
			public void updateType(string maTl, string tenTl)
			{
				dal_theloai.updateType(maTl, tenTl);
			}
			public void check(string idtheloai)
		{
			dal_theloai.check(idtheloai);
			//string query = "SELECT COUNT(*) FROM TheLoaiSach WHERE ID_THELOAI = @idtheloai AND TEN_THELOAI = @tentheloai";

			//using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\win\source\repos\PhanMemThuVien\DOAN\QLThuVien.mdf;Integrated Security=True"))
			//{
			//	conn.Open();
			//	using (SqlCommand cmd = new SqlCommand(query, conn))
			//	{
			//		cmd.Parameters.AddWithValue("@idtheloai", idtheloai);
			//		cmd.Parameters.AddWithValue("@tentheloai", tentheloai);

			//		int count = (int)cmd.ExecuteScalar();

			//		return count > 0;
			//	}
			//}

		}

	}
	}


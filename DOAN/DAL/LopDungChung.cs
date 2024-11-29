	using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN.DAL
{
    internal class LopDungChung
    {
        string ketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Coding\.net\backup\DOAN\DOAN\QLThuVien.mdf;Integrated Security=True";
        SqlConnection conn;

        public LopDungChung()
        {
            conn = new SqlConnection(ketnoi);
        }
        public void nonQuery(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Success!!!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        public DataTable loadGrid(string sqlLoad)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlLoad, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public Object Scalar(string sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DOAN.GUI
{
    public partial class frm_DangKy : Form
    {
        public frm_DangKy()
        {
            InitializeComponent();
        }
		DAL.LopDungChung lopchung;
		private void button2_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Ban Co Muon Thoat Khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Application.Exit();
		}

		private void btn_Dky_Click(object sender, EventArgs e)
		{
			string tenDangNhap = txt_TaiKhoan.Text;
			string matKhau = txt_MatKhau.Text;

			if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Coding\.net\backup\DOAN\DOAN\QLThuVien.mdf;Integrated Security=True";
		
			string query = "INSERT INTO DangNhap (TenDangNhap, MatKhau) VALUES (@TenDangNhap, @MatKhau)";
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				try
				{
					conn.Open();

					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
						cmd.Parameters.AddWithValue("@MatKhau", matKhau);

						int result = cmd.ExecuteNonQuery();

						if (result > 0)
						{
							MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Đăng ký thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi kết nối: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void frm_DangKy_Load(object sender, EventArgs e)
		{

		}
	}
	}


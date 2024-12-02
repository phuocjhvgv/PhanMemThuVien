using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DOAN.GUI
{
	public partial class TheLoaiSach : Form
	{

		BLL.BLL_TheLoai blTL;
		public TheLoaiSach()
		{
			InitializeComponent();
			blTL = new BLL.BLL_TheLoai();
		}
		public void loadType()
		{

			dtgr_TheLoaiSach.DataSource = blTL.loadType();
		}


		public bool check()
		{
			if (txt_MaTL.Text == "" && txt_TenTL.Text == "")
			{
				return false;
			}
			return true;
		}
		private void TheLoaiSach_Load_1(object sender, EventArgs e)
		{
			this.CenterToParent();
			loadType();
		}

		private void btn_Thoat_Click_1(object sender, EventArgs e)
		{
			if (MessageBox.Show("Ban Co Muon Thoat Quan Ly The Loai Sach?", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				this.Close();
			}
		}
		private bool KhongChuaKyTuDacBiet(string input)
		{
			string pattern = @"[^a-zA-Z0-9\s]";
			return Regex.IsMatch(input, pattern);
		}
		private void btn_ThemTL_Click_1(object sender, EventArgs e)
		{
			try
			{
				string maTheLoai = txt_MaTL.Text.Trim();
				string tenTheLoai = txt_TenTL.Text.Trim();

				// Kiểm tra nếu để trống Mã Thể Loại
				if (string.IsNullOrEmpty(maTheLoai))
				{
					MessageBox.Show("Vui lòng nhập mã thể loại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txt_MaTL.Focus(); // Đưa con trỏ chuột về ô nhập Mã Thể Loại
					return;
				}
				
				// neu ten the loai nhap ki tu dac biet
				if (KhongChuaKyTuDacBiet(tenTheLoai))
				{
					MessageBox.Show("Tên the loai không được chứa ký tự đặc biệt!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Kiểm tra ký tự đặc biệt trong mã the loai
				if (KhongChuaKyTuDacBiet(maTheLoai))
				{
					MessageBox.Show("Mã the loai không được chứa ký tự đặc biệt!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				// Kiểm tra nếu để trống Tên Thể Loại
				if (string.IsNullOrEmpty(tenTheLoai))
				{
					MessageBox.Show("Vui lòng nhập tên thể loại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txt_TenTL.Focus(); // Đưa con trỏ chuột về ô nhập Tên Thể Loại
					return;
				}
				//kiem tra neu trung ma
				

			}
			catch (Exception ex)
			{
				MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (check())
			{
				string maTl = txt_MaTL.Text;
				string tenTl = txt_TenTL.Text;
				blTL.addType(maTl, tenTl);
				loadType();

			}
			else MessageBox.Show("Ban hay nhap Day Du Thong Tin", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);

		}

		private void btn_XoaTL_Click_1(object sender, EventArgs e)
		{
			try
			{
				string maTheLoai = txt_MaTL.Text.Trim();
				string tenTheLoai = txt_TenTL.Text.Trim();

				// Kiểm tra nếu để trống Mã Thể Loại
				if (string.IsNullOrEmpty(maTheLoai))
				{
					MessageBox.Show("Vui lòng nhập mã thể loại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txt_MaTL.Focus(); // Đưa con trỏ chuột về ô nhập Mã Thể Loại
					return;
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			string maTl = txt_MaTL.Text;
			blTL.deleteType(maTl);
			loadType();
		}

		private void btn_SuaTL_Click_1(object sender, EventArgs e)
		{
			string maTl = txt_MaTL.Text;
			string tenTl = txt_TenTL.Text;
			blTL.updateType(maTl, tenTl);
			loadType();
		}

		private void dtgr_TheLoaiSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txt_MaTL.Text = dtgr_TheLoaiSach.CurrentRow.Cells["ID_THELOAI"].Value.ToString();
			txt_TenTL.Text = dtgr_TheLoaiSach.CurrentRow.Cells["TEN_THELOAI"].Value.ToString();
		}
	}
}

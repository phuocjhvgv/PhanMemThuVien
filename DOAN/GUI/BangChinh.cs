using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN.GUI
{
	public partial class frm_BangChinh : Form
	{
		public frm_BangChinh()
		{
			InitializeComponent();
		}

		private void frm_BangChinh_Load(object sender, EventArgs e)
		{
			this.CenterToScreen();
			this.IsMdiContainer = true;
		}


		private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_ThemSach themSach = new frm_ThemSach();
			themSach.ShowDialog();
		}

		private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_ThemSinhVien themSinhVien = new frm_ThemSinhVien();
			themSinhVien.ShowDialog();
		}


		private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_ThongTinSach tt = new frm_ThongTinSach();
			tt.ShowDialog();
		}

		private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_ThongTinSinhVien tt = new frm_ThongTinSinhVien();
			tt.ShowDialog();
		}

		private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (MessageBox.Show("Ban Co Muon Thoat Khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Application.Exit();
		}


		private void menuitem_QLTL_Click_1(object sender, EventArgs e)
		{
			foreach (Form form in this.MdiChildren)
			{
				if (form is TheLoaiSach)
				{
					form.Activate(); // Kích hoạt form con nếu đã mở
					return;
				}
			}
			TheLoaiSach formTheLoai = new TheLoaiSach
			{
				MdiParent = this,
				StartPosition = FormStartPosition.Manual
			};

			// Đặt vị trí form con (không cách lề trên)
			formTheLoai.Location = new Point(
				(this.ClientSize.Width - formTheLoai.Width) / 2, // Căn giữa ngang
				0 // Sát lề trên
			);
			formTheLoai.Show();
		}
	}
}

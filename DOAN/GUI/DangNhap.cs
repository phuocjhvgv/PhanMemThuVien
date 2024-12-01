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
    public partial class frm_DangNhap : Form
    {
        BLL.BLL_DangNhap dangnhap;

        public frm_DangNhap()
        {
            InitializeComponent();
            dangnhap = new BLL.BLL_DangNhap();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        int dem = 0;

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            int kq = dangnhap.DangNhap(txt_TaiKhoan.Text, txt_MatKhau.Text);
            if (kq > 0)
            {
                MessageBox.Show("Đăng Nhập thành công");
                Hide();
                frm_BangChinh bc = new frm_BangChinh();
                bc.ShowDialog();
                dem = 0;
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                dem++;
            }
            if (dem == 3)
            {
                MessageBox.Show("Nhập sai 3 lần, hệ thống thoát");
                Close();
            }
        }

		private void pictureBox6_Click_1(object sender, EventArgs e)
		{
			if (MessageBox.Show("Ban Co Muon Thoat Khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Application.Exit();
		}

		private void btn_DangKy_Click_1(object sender, EventArgs e)
		{
			frm_DangKy dk = new frm_DangKy();
			dk.ShowDialog();
		}

		private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
		{
			if (chkHienMatKhau.Checked)
			{
				
				txt_MatKhau.UseSystemPasswordChar = false;
			}
			else
			{
				txt_MatKhau.UseSystemPasswordChar = true;
			}
		}
	}
}

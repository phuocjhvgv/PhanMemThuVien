using DOAN.BLL;
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
    public partial class frm_ThemSach : Form
    {
        BLL.BLL_Sach blSach;
        public frm_ThemSach()
        {
            InitializeComponent();
            blSach = new BLL.BLL_Sach();
        }

        public bool check()
        {
            if (txt_MaSach.Text == "" && txt_TenSach.Text == "" && txt_TacGia.Text == "" && txt_NXB.Text == "" && dateTimePicker1.Text == "" && txt_GiaSach.Text == "" && txt_SoLuong.Text == "")
            {
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void frm_ThemSach_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Muon Thoat Khong?", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			if (check())
			{
				string maSach = textBox6.Text;
				string tenSach = textBox5.Text;
				string tenTacGia = textBox4.Text;
				string NhaXuatBan = textBox3.Text;
				string ngayMua = dateTimePicker2.Text;
				int giaSach = int.Parse(textBox2.Text);
				int soLuong = int.Parse(textBox1.Text);

				blSach.ThemBook(maSach, tenSach, tenTacGia, NhaXuatBan, ngayMua, giaSach, soLuong);
				button1_Click(sender, e);
			}
			else MessageBox.Show("Nhap Day Du Thong Tin", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}

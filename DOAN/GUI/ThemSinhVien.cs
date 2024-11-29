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
    public partial class frm_ThemSinhVien : Form
    {
        BLL.BLL_SinhVien blSV;
        public frm_ThemSinhVien()
        {
            InitializeComponent();
            blSV = new BLL.BLL_SinhVien();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            txt_MaSv.Clear();
            txt_TenSv.Clear();
            txt_Lop.Clear();
            txt_Khoa.Clear();
            txt_Sdt.Clear();
            txt_Email.Clear();
        }

        public bool check()
        {
            if (txt_MaSv.Text == "" && txt_TenSv.Text == "" && txt_Lop.Text == "" && txt_Khoa.Text == "" && txt_Sdt.Text == "" && txt_Email.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
           
                if (check())
                {
                    string maSv = txt_MaSv.Text;
                    string tenSv = txt_TenSv.Text;
                    string lop = txt_Lop.Text;
                    string khoa = txt_Khoa.Text;
                    int sdt = int.Parse(txt_Sdt.Text);
                    string email = txt_Email.Text;

                    blSV.addStudent(maSv, tenSv, lop, khoa, sdt, email);
                }
                else MessageBox.Show("Nhap Day Du Thong Tin", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void frm_ThemSinhVien_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Muon Thoat AddStudent?", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

		
	}
}

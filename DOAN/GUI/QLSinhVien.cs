using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DOAN.GUI
{
    public partial class QLSinhVien : Form
    {
        BLL.BLL_SinhVien blSV;
        public QLSinhVien()
        {
            InitializeComponent();
            blSV = new BLL.BLL_SinhVien();
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Muon Thoat Khong?", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
        public bool check()
        {
            if (txt_masv.Text == "" && txt_tensv.Text == "" && txt_lop.Text == "" && txt_khoa.Text == "" && txt_sdt.Text == "" && txt_email.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string maSv = txt_masv.Text;
                string tenSv = txt_tensv.Text;
                string lop = txt_lop.Text;
                string khoa = txt_khoa.Text;
                int sdt = int.Parse(txt_sdt.Text);
                string email = txt_email.Text;

                blSV.updateStudent(maSv, tenSv, lop, khoa, sdt, email);
                loadStudent();
            }
            else MessageBox.Show("Nhap Day Du Thong Tin", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string maSv = txt_masv.Text;
                string tenSv = txt_tensv.Text;
                string lop = txt_lop.Text;
                string khoa = txt_khoa.Text;
                int sdt = int.Parse(txt_sdt.Text);
                string email = txt_email.Text;

                blSV.addStudent(maSv, tenSv, lop, khoa, sdt, email);
                loadStudent();
            }
            else MessageBox.Show("Nhap Day Du Thong Tin", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        

        private void QLSinhVien_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            loadStudent();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maSV = txt_masv.Text;
            blSV.deleteStudent(maSV);
            loadStudent();
        }

        public void loadStudent()
        {

            dt_GridQLSV.DataSource = blSV.loadStudent();
        }

       

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text != "")
            {
                dt_GridQLSV.DataSource = blSV.searchSinhVien(txt_timkiem.Text);
            }
            else
            {
                loadStudent();
            }
        }
    }
}

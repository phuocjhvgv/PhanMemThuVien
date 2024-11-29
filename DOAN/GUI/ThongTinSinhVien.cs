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
    public partial class frm_ThongTinSinhVien : Form
    {

        BLL.BLL_SinhVien sinhVien;
        public frm_ThongTinSinhVien()
        {
            InitializeComponent();
            sinhVien = new BLL.BLL_SinhVien();
        }

        public void loadStudent()
        {
            
            dataGridView1.DataSource = sinhVien.loadStudent();
        }

        private void frm_ThongTinSinhVien_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            loadStudent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_TenSV.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Lop.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_KHOA.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_SDT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_EMAIL.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text != "")
            {
                dataGridView1.DataSource = sinhVien.searchSinhVien(txt_TimKiem.Text);
            }
            else
            {
                loadStudent();
            }
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            string maSv = txt_MaSV.Text;
            string tenSv = txt_TenSV.Text;
            string lop = txt_Lop.Text;
            string khoa = txt_KHOA.Text;
            int sdt = int.Parse(txt_SDT.Text);
            string email = txt_EMAIL.Text;

            sinhVien.updateStudent(maSv, tenSv, lop, khoa, sdt, email);
            loadStudent();
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            string maSV = txt_MaSV.Text;
            sinhVien.deleteStudent(maSV);
            loadStudent();
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Muon Thoat ViewStudent?", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            txt_TimKiem.Clear();
        }
    }
}

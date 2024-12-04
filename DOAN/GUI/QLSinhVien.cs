using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private bool KhongChuaKyTuDacBiet(string input)
        {
            string pattern = @"[^a-zA-Z0-9\s]";
            return Regex.IsMatch(input, pattern);
        }
        public bool check()
        {
            if (txt_id.Text == "" && txt_masv.Text == "" && txt_tensv.Text == "" && txt_lop.Text == "" && txt_khoa.Text == "" && txt_sdt.Text == "" && txt_email.Text == "")
            {
                return false;
            }
            return true;
        }
        public void loadStudent()
        {

            dt_Grid.DataSource = blSV.loadStudent();
        }
        private void QLSinhVien_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            loadStudent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Muon Thoat ?", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
        

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string id = txt_id.Text;
                string maSv = txt_masv.Text;
                string tenSv = txt_tensv.Text;
                string lop = txt_lop.Text;
                string khoa = txt_khoa.Text;
                int sdt = int.Parse(txt_sdt.Text);
                string email = txt_email.Text;
                if (!KhongChuaKyTuDacBiet(id) || !KhongChuaKyTuDacBiet(maSv) || !KhongChuaKyTuDacBiet(tenSv) || !KhongChuaKyTuDacBiet(khoa))
                {
                    MessageBox.Show("Không được nhập ký tự đặc biệt trong ID,Mã sinh viên,Tên sinh viên,Khoa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (blSV.KiemTraSinhVien( id, maSv, email))
                {
                    MessageBox.Show("Mã đã tồn tại. Vui lòng nhập mã sách khác.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    blSV.addStudent(id, maSv, tenSv, lop, khoa, sdt, email);
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt_Grid.DataSource = blSV.loadStudent();
                }
                
                

            }
            else MessageBox.Show("Nhap Day Du Thong Tin", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string id = txt_id.Text;
                string maSv = txt_masv.Text;
                string tenSv = txt_tensv.Text;
                string lop = txt_lop.Text;
                string khoa = txt_khoa.Text;
                int sdt = int.Parse(txt_sdt.Text);
                string email = txt_email.Text;

                blSV.updateStudent(id, maSv, tenSv, lop, khoa, sdt, email);
                loadStudent();

            }
            else MessageBox.Show("Nhap Day Du Thong Tin", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maSV = txt_masv.Text;
            blSV.deleteStudent(maSV);
            loadStudent();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text != "")
            {
                dt_Grid.DataSource = blSV.searchSinhVien(txt_timkiem.Text);
            }
            else
            {
                loadStudent();
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_masv.Clear();
            txt_tensv.Clear();
            txt_lop.Clear();
            txt_khoa.Clear();
            txt_sdt.Clear();
            txt_email.Clear();
        }
    }
}

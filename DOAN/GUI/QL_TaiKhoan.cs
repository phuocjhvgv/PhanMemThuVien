using DevExpress.XtraWaitForm;
using DOAN.BLL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DOAN.GUI
{
    public partial class QL_TaiKhoan : Form
    {
        BLL.BLL_QLTAIKHOAN QLTK;
        public QL_TaiKhoan()
        {
            InitializeComponent();
            QLTK = new BLL.BLL_QLTAIKHOAN();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QL_TaiKhoan_Load(object sender, EventArgs e)
        {
            dtgrv.DataSource = QLTK.loadtk();
        }
        public bool check()
        {
            if (txtmatk.Text == "" && txttentk.Text == "" && txtmk.Text == "" )
            {
                return false;
            }
            return true;
        }
        private bool KhongChuaKyTuDacBiet(string input)
        {
            string pattern = @"^[a-zA-Z0-9_]+$";
            return Regex.IsMatch(input, pattern);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string idtaikhoan   = txtmatk.Text;
                string tentk = txttentk.Text;
                string mk = txtmk.Text;
                if (!KhongChuaKyTuDacBiet(idtaikhoan) || !KhongChuaKyTuDacBiet(tentk))
                {
                    MessageBox.Show("Không được nhập ký tự đặc biệt trong ID tài khoản hoặc Tên tài khoản.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (QLTK.KiemTraTaiKhoan(idtaikhoan,tentk))
                {
                    MessageBox.Show("Mã đã tồn tại. Vui lòng nhập mã sách khác.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    QLTK.Themtk(idtaikhoan,tentk,mk);
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgrv.DataSource = QLTK.loadtk();
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool checksua()
        {
            return !string.IsNullOrWhiteSpace(txtmatk.Text) &&
                   !string.IsNullOrWhiteSpace(txttentk.Text) &&
                   !string.IsNullOrWhiteSpace(txtmk.Text);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (checksua()) 
            {

                string idtaikhoan = txtmatk.Text;
                string tentk = txttentk.Text;
                string mk = txtmk.Text;

                bool isUpdated = QLTK.CapNhatTaiKhoan(idtaikhoan, tentk, mk);

                if (!KhongChuaKyTuDacBiet(idtaikhoan) || !KhongChuaKyTuDacBiet(tentk))
                {
                    MessageBox.Show("Không được nhập ký tự đặc biệt trong ID tài khoản hoặc Tên tài khoản.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dtgrv.DataSource = QLTK.loadtk();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản cần cập nhật.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string idtaikhoan = txtmatk.Text.Trim();

            if (string.IsNullOrEmpty(idtaikhoan))
            {
                MessageBox.Show("Vui lòng nhập mã tài khoản để xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KhongChuaKyTuDacBiet(idtaikhoan))
            {
                MessageBox.Show("Mã tài khoản không được chứa ký tự đặc biệt.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?",
                                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {

                    QLTK.Xoatk(idtaikhoan);


                    MessageBox.Show("Tài khoản đã được xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgrv.DataSource = QLTK.loadtk();
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Bạn có chắc chắn muốn thoát không?",
       "Xác nhận thoát",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (result == DialogResult.Yes)
            {

                this.Close();
            }
            else
            {

            }
        }
    }
}

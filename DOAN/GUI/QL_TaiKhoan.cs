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
            if (string.IsNullOrWhiteSpace(txtmatk.Text))
            {
                MessageBox.Show("Vui lòng nhập mã tài khoản!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmatk.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txttentk.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttentk.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtmk.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmk.Focus();
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
            if (!check()) return; // Dừng nếu không thỏa mãn điều kiện nhập

            string idtaikhoan = txtmatk.Text.Trim();
            string tentk = txttentk.Text.Trim();
            string mk = txtmk.Text.Trim();

            if (!KhongChuaKyTuDacBiet(idtaikhoan) || !KhongChuaKyTuDacBiet(tentk))
            {
                MessageBox.Show("Không được nhập ký tự đặc biệt trong ID tài khoản hoặc Tên tài khoản.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (QLTK.KiemTraTaiKhoan(idtaikhoan, tentk))
            {
                MessageBox.Show("Mã tài khoản hoặc tên tài khoản đã tồn tại. Vui lòng nhập giá trị khác.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            QLTK.Themtk(idtaikhoan, tentk, mk);
            MessageBox.Show("Thêm tài khoản thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtgrv.DataSource = QLTK.loadtk();
        }
        private bool checksua()
        {
            if (string.IsNullOrWhiteSpace(txtmatk.Text))
            {
                MessageBox.Show("Vui lòng nhập mã tài khoản cần sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmatk.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txttentk.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản cần sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttentk.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtmk.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmk.Focus();
                return false;
            }
            return true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (!checksua()) return; 

            string idtaikhoan = txtmatk.Text.Trim();
            string tentk = txttentk.Text.Trim();
            string mk = txtmk.Text.Trim();

            if (!KhongChuaKyTuDacBiet(idtaikhoan) || !KhongChuaKyTuDacBiet(tentk))
            {
                MessageBox.Show("Không được nhập ký tự đặc biệt trong ID tài khoản hoặc Tên tài khoản.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isUpdated = QLTK.CapNhatTaiKhoan(idtaikhoan, tentk, mk);
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string idtaikhoan = txtmatk.Text.Trim();

            if (string.IsNullOrWhiteSpace(idtaikhoan))
            {
                MessageBox.Show("Vui lòng nhập mã tài khoản để xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmatk.Focus();
                return;
            }

            if (!KhongChuaKyTuDacBiet(idtaikhoan))
            {
                MessageBox.Show("Mã tài khoản không được chứa ký tự đặc biệt.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

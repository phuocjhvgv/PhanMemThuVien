using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DOAN.GUI
{
    public partial class frm_DangKy : Form
    {
        BLL.BLL_QLTAIKHOAN QLTK;
        public frm_DangKy()
        {
            InitializeComponent();
            QLTK = new BLL.BLL_QLTAIKHOAN();
        }
        DAL.LopDungChung lopchung;
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frm_DangNhap frmDangNhap = new frm_DangNhap();
                frmDangNhap.ShowDialog();
                this.Close();
            }
        }
        private void frm_DangKy_Load(object sender, EventArgs e)
        {

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

        private void txtidtaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool KhongChuaKyTuDacBiet(string input)
        {
            string pattern = @"^[a-zA-Z0-9_]+$";
            return Regex.IsMatch(input, pattern);
        }
        private void btn_Dky_Click_1(object sender, EventArgs e)
        {
            string idtaikhoan = txtidtaikhoan.Text;
            string tenDangNhap = txt_TaiKhoan.Text;
            string matKhau = txt_MatKhau.Text;

            
             if (!KhongChuaKyTuDacBiet(idtaikhoan) || !KhongChuaKyTuDacBiet(tenDangNhap))
            {
                MessageBox.Show("Không được nhập ký tự đặc biệt trong ID tài khoản hoặc Tên tài khoản.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (QLTK.KiemTraTaiKhoan(idtaikhoan, tenDangNhap))
            {
                MessageBox.Show("Mã đã tồn tại. Vui lòng nhập mã sách khác.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(idtaikhoan) || string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\source\repos\PhanMemThuVien\DOAN\QLThuVien.mdf;Integrated Security=True";


            string query = "INSERT INTO TaiKhoan (idtaikhoan, tentk, mk) VALUES (@idtaikhoan, @tentk, @mk)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idtaikhoan", idtaikhoan);
                        cmd.Parameters.AddWithValue("@tentk", tenDangNhap);
                        cmd.Parameters.AddWithValue("@mk", matKhau);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frm_DangNhap frmDangNhap = new frm_DangNhap();
                frmDangNhap.ShowDialog();
                this.Close();
            }
        }

        private void chkHienMatKhau_CheckedChanged_1(object sender, EventArgs e)
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


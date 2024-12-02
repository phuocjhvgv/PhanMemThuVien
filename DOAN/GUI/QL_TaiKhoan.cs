using DOAN.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string idtaikhoan   = txtmatk.Text;
                string tentk = txttentk.Text;
                string mk = txtmk.Text;
                
                if (QLTK.KiemTraTaiKhoan(idtaikhoan,tentk))
                {
                    MessageBox.Show("Mã sách đã tồn tại. Vui lòng nhập mã sách khác.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    QLTK.Themtk(idtaikhoan,tentk,mk);
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
            if (dtgrv.SelectedRows.Count > 0)
            {
                string idtaikhoan = dtgrv.SelectedRows[0].Cells["IdTaiKhoan"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?",
                                                       "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool isDeleted = QLTK.XoaTaiKhoan(idtaikhoan);

                    if (isDeleted)
                    {
                        MessageBox.Show("Tài khoản đã được xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dtgrv.DataSource = QLTK.loadtk();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản cần xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

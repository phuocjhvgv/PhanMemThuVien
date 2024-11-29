using DOAN.BLL;
using DOAN.DAL;
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
    public partial class frm_ThongTinSach : Form
    {
        BLL.BLL_Sach Sach;
        BLL.BLL_SachThue SachThue;
        public frm_ThongTinSach()
        {
            InitializeComponent();
            SachThue = new BLL_SachThue();
            Sach = new BLL.BLL_Sach();
        }

        public void loadGric()
        {
            dataGridView1.DataSource = Sach.loadBook();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_Tim.Clear();
        }

        private void frm_ThongTinSach_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            loadGric();
            cb_TenSach.DataSource = SachThue.loadCbSach();
            cb_TenSach.DisplayMember = "TenSach";
            cb_TenSach.ValueMember = "MaSach";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            txt_Ma.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb_TenSach.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_TenTG.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_NXB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTime.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_Gia.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_SL.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void txt_MaSach_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Sach.timSach(txt_Tim.Text);
        }

        
        

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Muon Thoat Khong?", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            string maSach = txt_Ma.Text;
            string tenSach = cb_TenSach.Text;
            string tenTacGia = txt_TenTG.Text;
            string NhaXuatBan = txt_NXB.Text;
            string ngayMua = dateTime.Text;
            int giaSach = int.Parse(txt_Gia.Text);
            int soLuong = int.Parse(txt_SL.Text);

            Sach.updateBook(maSach, tenSach, tenTacGia, NhaXuatBan, ngayMua, giaSach, soLuong);
            loadGric();
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Chac Muon Xoa Khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sach.XoaBook(txt_Ma.Text);
                loadGric();
            }
            else return;
        }
    }
}

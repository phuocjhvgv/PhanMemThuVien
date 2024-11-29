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
    public partial class frm_SachDaThue : Form
    {
        BLL.BLL_SachThue blST;
        public frm_SachDaThue()
        {
            InitializeComponent();
            blST = new BLL.BLL_SachThue();
        }

        private void frm_SachDaThue_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            dataGridView1.DataSource = blST.CompleteBookDetails_Loadnull(); 
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DataTable result = blST.searchSinhVienThueSach(txt_Search.Text);

            if (result.Rows.Count > 0)
            {
                dataGridView1.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên có mã số " + txt_Search.Text);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Muon Thoat AddStudent?", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
        }

        private void lbl_SoLuong_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tongSo = blST.demSachThue();
            lbl_SoLuong.Text = tongSo.ToString();
        }
    }
}

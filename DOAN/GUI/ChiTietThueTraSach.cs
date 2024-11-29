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
    public partial class frm_ChiTietThueTraSach : Form
    {
        BLL.BLL_SachThue blST;

        public frm_ChiTietThueTraSach()
        {
            InitializeComponent();
            blST = new BLL.BLL_SachThue();
        }

        private void frm_ChiTietThueTraSach_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            dataGridView_ThueSach.DataSource = blST.CompleteBookDetails_Loadnull();
            dataGridView_TraSach.DataSource = blST.CompleteBookDetails_Loadnotnull();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Muon Thoat Khong?", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

		private void dataGridView_ThueSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}

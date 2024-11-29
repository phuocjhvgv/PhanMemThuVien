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
    public partial class frm_BangChinh : Form
    {
        public frm_BangChinh()
        {
            InitializeComponent();
        }

        private void frm_BangChinh_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Muon Thoat Khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThemSach themSach = new frm_ThemSach();
            themSach.ShowDialog();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThemSinhVien themSinhVien = new frm_ThemSinhVien();
            themSinhVien.ShowDialog();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SachDaThue sachDaThue = new frm_SachDaThue();
            sachDaThue.ShowDialog();
        }

        private void completeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ChiTietThueTraSach ct = new frm_ChiTietThueTraSach();
            ct.ShowDialog();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SachDaTra dt = new frm_SachDaTra();
            dt.ShowDialog();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThongTinSach tt = new frm_ThongTinSach();
            tt.ShowDialog();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThongTinSinhVien tt = new frm_ThongTinSinhVien();
            tt.ShowDialog();
        }
    }
}

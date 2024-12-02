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

        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void completeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Muon Thoat Khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            QL_TaiKhoan QLTK = new QL_TaiKhoan();
            QLTK.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }
    }
    }


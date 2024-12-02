using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOAN.DAL;

namespace DOAN.GUI
{
    public partial class QLTacGia : Form
    {
        BLL.BLL_TacGia QL_TacGia;
        public QLTacGia()
        {
            InitializeComponent();
            QL_TacGia = new BLL.BLL_TacGia();
        }

        LopDungChung lopchung = new LopDungChung();
        private void btn_timkiemTG_Click(object sender, EventArgs e)
        {
            string sql = "select * FROM TacGia WHERE TEN_NHAXB LIKE '%" + txt_timkiemTG.Text + "%'";
            DataTable kq = (DataTable)lopchung.loadGrid(sql);
            dgrd_TG.DataSource = kq;
        }

        private void btn_themTG_Click(object sender, EventArgs e)
        {
            string sql = "Insert into TacGia values ('" + txt_MaTG.Text + "','" + txt_TenTG.Text
                + "','" + txt_DiaChi.Text + "')";

            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Thêm tác giả thành công");
            }
            else MessageBox.Show("Thêm tác giả thất bại");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE TacGia SET " + "ID_TACGIA= '" + txt_MaTG.Text + "',TEN_TACGIA= '" +
                txt_TenTG.Text + "DIA_CHI= '" + txt_DiaChi.Text + "'";


            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("SUA thanh cong");

            }
            else MessageBox.Show("SUA that bai");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM TacGia WHERE ID_TACGIA='" + txt_MaTG.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Xoa thanh cong");

            }
            else MessageBox.Show("Xoa that bai");
        }

        private void QLTacGia_Load(object sender, EventArgs e)
        {
            dgrd_TG.DataSource = QL_TacGia.loadTG();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Ban thuc su co muon thoat khong?", "Canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
    }
}

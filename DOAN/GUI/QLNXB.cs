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
    public partial class QLNXB : Form
    {
        BLL.BLL_NhaXuatBan QL_NXB;
        public QLNXB()
        {
            InitializeComponent();
            QL_NXB = new BLL.BLL_NhaXuatBan();
        }
        LopDungChung lopchung = new LopDungChung();
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sql = "select * FROM NhaXuatBan WHERE TEN_NHAXB LIKE '%" + txt_TìmKiem.Text + "%'";
            DataTable kq = (DataTable)lopchung.loadGrid(sql);
            dgrd_NXB.DataSource = kq;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NhaXuatBan values ('" + txt_MaNXB.Text + "','" + txt_TenNXB.Text
                + "')";

            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Thêm NXB thành công");
            }
            else MessageBox.Show("Thêm NXB thất bại");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE NhaXuatBan SET " + "ID_NHAXB= '" + txt_MaNXB.Text + "',TENHANG= '" +
                txt_TenNXB.Text + "'";


            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("SUA thanh cong");

            }
            else MessageBox.Show("SUA that bai");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM NhaXuatBan WHERE ID_NHAXB='" + txt_MaNXB.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Xoa thanh cong");

            }
            else MessageBox.Show("Xoa that bai");
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

        private void QLNXB_Load(object sender, EventArgs e)
        {
            dgrd_NXB.DataSource = QL_NXB.loadNXB();
        }
    }
}

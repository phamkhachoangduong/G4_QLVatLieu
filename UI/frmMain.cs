using G4_QLVatLieu.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G4_QLVatLieu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnsMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChatLieu f = new frmChatLieu();
            f.MdiParent = this;
            f.Show();
        }

        private void nộiThấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMNoiThat f = new frmDMNoiThat();
            f.MdiParent = this;
            f.Show();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTheLoai f = new frmTheLoai();
            f.MdiParent = this;
            f.Show();
        }

        private void màuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMauSac f = new frmMauSac();
            f.MdiParent = this;
            f.Show();
        }

        private void nướcSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuocSX f = new frmNuocSX();
            f.MdiParent = this;
            f.Show();
        }

        private void caLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaLam f = new frmCaLam();
            f.MdiParent = this;
            f.Show();
        }

        private void chứcVụCôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCongViec f = new frmCongViec();
            f.MdiParent = this;
            f.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.MdiParent = this;
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void nhậpHàngHợpĐồngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap f = new frmHoaDonNhap();
            f.MdiParent = this;
            f.Show();
        }
    }

    }


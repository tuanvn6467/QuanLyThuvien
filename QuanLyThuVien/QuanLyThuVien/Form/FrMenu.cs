using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FrMenu : Form
    {
        public FrMenu()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrLstDocGia FrDocGia = new FrLstDocGia();
            FrDocGia.ShowDialog();
            FrMenu FrMn = new FrMenu();
            FrMn.Hide();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrDangNhap FrDN = new FrDangNhap();
            FrDN.ShowDialog();
            this.Hide();
        }

        private void FrMenu_Load(object sender, EventArgs e)
        {
            //khôiPhụcDữLiệuToolStripMenuItem.Enabled = false;
            //đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            //thêmNgườiDùngToolStripMenuItem.Enabled = false;
            //nhàCungCấpToolStripMenuItem.Enabled = false;
            //độcGiảToolStripMenuItem.Enabled = false;
            //sáchToolStripMenuItem.Enabled = false;
            //nhânViênToolStripMenuItem.Enabled = false;
            //mượnSáchToolStripMenuItem.Enabled = false;
            //trảSáchToolStripMenuItem.Enabled = false;
            //xửLýViPhạmToolStripMenuItem.Enabled = false;
        }

        private void thêmNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrCapNhatSach FrDocGia = new FrCapNhatSach();
            FrDocGia.ShowDialog();
            FrMenu FrMn = new FrMenu();
            FrMn.Hide();
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xửLýViPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}

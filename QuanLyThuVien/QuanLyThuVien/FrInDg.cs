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
    public partial class FrInDg : Form
    {
        string _madg;
        public FrInDg(string madg)
        {
            InitializeComponent();
            _madg = madg;
        }

        private void FrInDg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLTVDataSetDg.LstDocGia' table. You can move, or remove it, as needed.
            this.LstDocGiaTableAdapter.Fill(this.QLTVDataSetDg.LstDocGia,_madg);

            this.reportViewer1.RefreshReport();
        }
    }
}

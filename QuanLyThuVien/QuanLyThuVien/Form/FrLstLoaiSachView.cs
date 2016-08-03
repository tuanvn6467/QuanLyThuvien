using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class FrLstLoaiSachView : Form
    {
        public FrLstLoaiSachView()
        {
            InitializeComponent();
            hienthi(GrLoaiSach);
        }
        public static string strConn = Constants.Connection;
        public void hienthi(DataGridView Gr)
        {
            string strSQL = "SELECT * FROM LoaiSach";
            DataSet objDs = new DataSet();
            objDs = QuanLyThuVien.ClsSQL.SqlSelect(strSQL, strConn);
            Gr.DataSource = objDs.Tables[0];
            GrLoaiSach.Columns["Ma_LoaiSach"].HeaderText = "Mã Loại Sách";
            GrLoaiSach.Columns["Ten_LoaiSach"].HeaderText = "Tên Loại Sách";
            //Thay đổi độ rộng cột
            GrLoaiSach.Columns["Ma_LoaiSach"].Width = 100;
            GrLoaiSach.Columns["Ten_LoaiSach"].Width = 150;
            GrLoaiSach.Columns[GrLoaiSach.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //đặt nền cho tiêu đề
            GrLoaiSach.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            GrLoaiSach.EnableHeadersVisualStyles = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrLstLoaiSachEdit frm = new FrLstLoaiSachEdit();
            frm.Tag = ""; //Tín hiệu cho biết thêm mới
            frm.ShowDialog();
            hienthi(GrLoaiSach);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrLstLoaiSachEdit fr = new FrLstLoaiSachEdit();
            fr = new FrLstLoaiSachEdit();
            fr.Tag = this.GrLoaiSach.CurrentRow.Cells["Ma_LoaiSach"].Value.ToString(); //Tín hiệu sửa
            fr.txtMaLoaiSach.Text = this.GrLoaiSach.CurrentRow.Cells["Ma_LoaiSach"].Value.ToString();
            fr.txtTenMaLoaiSach.Text = this.GrLoaiSach.CurrentRow.Cells["Ten_LoaiSach"].Value.ToString();
            fr.ShowDialog();
            hienthi(GrLoaiSach);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //string strS = "SET DATEFORMAT DMY; \r\n";
            string strSQL ="DELETE FROM LoaiSach WHERE Ma_LoaiSach = '" + this.GrLoaiSach.CurrentRow.Cells["Ma_LoaiSach"].Value.ToString() + "'";
           
            if (QuanLyThuVien.ClsSQL.Connect(strConn) == true)
                QuanLyThuVien.ClsSQL.SqlExecute(strSQL, strConn);
            hienthi(GrLoaiSach);
        }

        private void GrLoaiSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

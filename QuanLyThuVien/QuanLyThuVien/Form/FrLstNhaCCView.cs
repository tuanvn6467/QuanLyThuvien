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
    public partial class FrLstNhaCC : Form
    {
        public FrLstNhaCC()
        {
            InitializeComponent();
        }
        public static string strConn = Constants.Connection;
        public static void HienThiLstNCC(DataGridView GrNhaCC)
        {
            string strSQL = "SELECT * FROM LstNhaCC";
            DataSet objDs = new DataSet();
            objDs = QuanLyThuVien.ClsSQL.SqlSelect(strSQL, strConn);
            GrNhaCC.DataSource = objDs.Tables[0];
            GrNhaCC.Columns["Ma_NhaCC"].HeaderText = "Mã Nhà Cung Cấp";
            GrNhaCC.Columns["Ten_NhaCC"].HeaderText = "Tên Nhà Cung Cấp";
            GrNhaCC.Columns["Dia_Chi"].HeaderText = "Địa Chỉ";
            GrNhaCC.Columns["Sdt"].HeaderText = "Số Điện Thoại";
            //Thay đổi độ rộng cột
            GrNhaCC.Columns["Ma_NhaCC"].Width = 100;
            GrNhaCC.Columns["Ten_NhaCC"].Width = 150;
            GrNhaCC.Columns["Dia_Chi"].Width = 200;
            GrNhaCC.Columns[GrNhaCC.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //đặt nền cho tiêu đề
            GrNhaCC.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            GrNhaCC.EnableHeadersVisualStyles = false;
        }

        private void FrLstNhaCC_Load(object sender, EventArgs e)
        {
            HienThiLstNCC(GrNhaCC);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrLstNhaCCEdit frm = new FrLstNhaCCEdit();
            frm.Tag = ""; //Tín hiệu cho biết thêm mới
            frm.ShowDialog();
            HienThiLstNCC(GrNhaCC);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrLstNhaCCEdit fr = new FrLstNhaCCEdit();
            fr = new FrLstNhaCCEdit();
            fr.Tag = this.GrNhaCC.CurrentRow.Cells["Ma_NhaCC"].Value.ToString(); //Tín hiệu sửa
            fr.txtMaNCC.Text = this.GrNhaCC.CurrentRow.Cells["Ma_NhaCC"].Value.ToString();
            fr.txtTenNCC.Text = this.GrNhaCC.CurrentRow.Cells["Ten_NhaCC"].Value.ToString();
            fr.txtDiaChi.Text = this.GrNhaCC.CurrentRow.Cells["Dia_Chi"].Value.ToString();
            fr.txtSDT.Text = this.GrNhaCC.CurrentRow.Cells["Sdt"].Value.ToString();
            fr.ShowDialog();
            HienThiLstNCC(GrNhaCC);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string strSQL = "DELETE FROM LstNhaCC WHERE Ma_NhaCC = '" + this.GrNhaCC.CurrentRow.Cells["Ma_NhaCC"].Value.ToString() + "'";
            if (QuanLyThuVien.ClsSQL.Connect(strConn) == true)
                QuanLyThuVien.ClsSQL.SqlExecute(strSQL, strConn);
            HienThiLstNCC(GrNhaCC);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

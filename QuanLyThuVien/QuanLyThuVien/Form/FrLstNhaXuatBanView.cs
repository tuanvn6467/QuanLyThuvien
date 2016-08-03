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
    public partial class FrLstNhaXuatBanView : Form
    {
        public FrLstNhaXuatBanView()
        {
            InitializeComponent();
        }
        public static string strConn = Constants.Connection;
        public static void HienThiLstNhaXuatBan(DataGridView Gr)
        {
            string strSQL = "SELECT * FROM LstNhaXuatBan";
            DataSet objDs = new DataSet();
            objDs = QuanLyThuVien.ClsSQL.SqlSelect(strSQL, strConn);
            Gr.DataSource = objDs.Tables[0];
            Gr.Columns["Ma_NhaXuatBan"].HeaderText = "Mã Nhà Xuất Bản";
            Gr.Columns["Ten_NhaXuatBan"].HeaderText = "Tên Nhà Xuất Bản";
            Gr.Columns["Dia_Chi"].HeaderText = "Địa Chỉ";
            //Thay đổi độ rộng cột
            Gr.Columns["Ma_NhaXuatBan"].Width = 100;
            Gr.Columns["Ten_NhaXuatBan"].Width = 150;
            Gr.Columns["Dia_Chi"].Width = 200;
            Gr.Columns[Gr.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //đặt nền cho tiêu đề
            Gr.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            Gr.EnableHeadersVisualStyles = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrLstNhaXuatBanEdit frm = new FrLstNhaXuatBanEdit();
            frm.Tag = ""; //Tín hiệu cho biết thêm mới
            frm.ShowDialog();
            HienThiLstNhaXuatBan(Gr);
        }

        private void FrLstNhaXuatBanView_Load(object sender, EventArgs e)
        {
            HienThiLstNhaXuatBan(Gr);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrLstNhaXuatBanEdit fr = new FrLstNhaXuatBanEdit();
            fr = new FrLstNhaXuatBanEdit();
            fr.Tag = this.Gr.CurrentRow.Cells["Ma_NhaXuatBan"].Value.ToString(); //Tín hiệu sửa
            fr.txtMaNXB.Text = this.Gr.CurrentRow.Cells["Ma_NhaXuatBan"].Value.ToString();
            fr.txtTenNXB.Text = this.Gr.CurrentRow.Cells["Ten_NhaXuatBan"].Value.ToString();
            fr.txtDiaChi.Text = this.Gr.CurrentRow.Cells["Dia_Chi"].Value.ToString();
            fr.ShowDialog();
            HienThiLstNhaXuatBan(Gr);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string strSQL = "DELETE FROM LstNhaXuatBan WHERE Ma_NhaXuatBan = '" + this.Gr.CurrentRow.Cells["Ma_NhaXuatBan"].Value.ToString() + "'";
            if (QuanLyThuVien.ClsSQL.Connect(strConn) == true)
                QuanLyThuVien.ClsSQL.SqlExecute(strSQL, strConn);
            HienThiLstNhaXuatBan(Gr);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}

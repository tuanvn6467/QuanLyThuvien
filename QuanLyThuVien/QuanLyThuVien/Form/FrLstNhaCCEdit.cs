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
    public partial class FrLstNhaCCEdit : Form
    {
        public FrLstNhaCCEdit()
        {
            InitializeComponent();
        }
        public static string strConn = Constants.Connection;
        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            string strSQL = "SET DATEFORMAT DMY; \r\n";
            if (this.Tag.ToString() == "")
            {
                //Ghi thêm
                strSQL = strSQL + "INSERT INTO LstNhaCC(Ma_NhaCC,Ten_NhaCC,Dia_Chi,Sdt) VALUES ('" + this.txtMaNCC.Text + "', N'" + this.txtTenNCC.Text + "', N'" + this.txtDiaChi.Text + "', '" + this.txtSDT.Text + "')";
            }
            else
            {
                //Ghi sửa
                strSQL = strSQL + "UPDATE LstNhaCC SET Ma_NhaCC = '" + this.txtMaNCC.Text + "', Ten_NhaCC = N'" + this.txtTenNCC.Text + "', Dia_Chi = N'" + this.txtDiaChi.Text + "', Sdt = '" + this.txtSDT.Text + "' where Ma_NhaCC = '" + this.Tag + "'";
            }
            if (QuanLyThuVien.ClsSQL.SqlExecute(strSQL, strConn) == true)
                //MessageBox.Show("Them / sua thanh cong");
                this.Dispose();
            QuanLyThuVien.ClsSQL.Disconnect();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FrDoiMatKhau : Form
    {
        public FrDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtMkCu.Text == "") MessageBox.Show("Chưa nhập Pass Cũ");
            else if (txtMkMoi.Text == "") MessageBox.Show("Chưa nhập Pass Mới");
            else if (txtMkNhapLai.Text == "") MessageBox.Show("Chưa nhập lại Pass");
            else if (txtMkNhapLai.Text != txtMkMoi.Text) MessageBox.Show("Pass không trùng khớp");
            //else if (txtPassCu.Text != Program.password) MessageBox.Show("Pass cũ không chính xác");
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Constants.Connection;
                con.Open();
                string strSql="SELECT * FROM LstNhanVien WHERE Ma_NV ='" + txtTDN.Text.ToString() + "' and Mat_Khau ='" + txtMkCu.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(strSql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
             
                if (dt.Rows.Count > 0 )
                {
                    string sql = "UPDATE LstNhanVien SET Mat_Khau=N'" + txtMkMoi.Text.Trim() + "' WHERE Ma_NV =N'" + txtTDN.Text.Trim() + "'";
                    SqlCommand command = new SqlCommand(sql, con);
                    //command.CommandType = CommandType.Text;                                
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                    con.Close();
                }
            }
        }
    }
}


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
    public partial class FrDangNhap : Form
    {
        public FrDangNhap()
        {
            InitializeComponent();
        }
        DataTable dt;
        SqlConnection conn = new SqlConnection(Constants.Connection);
        public DataTable checkLogin( string Ten_NV,string Mat_Khau,string Quyen)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "KiemTraTK";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("Ten_NV", SqlDbType.NChar)).Value =Ten_NV;
            cmd.Parameters.Add(new SqlParameter("Mat_Khau", SqlDbType.NVarChar)).Value = Mat_Khau;
            cmd.Parameters.Add(new SqlParameter("Quyen", SqlDbType.NVarChar)).Value = Quyen;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            conn.Open();
            dt = new DataTable();
            dt = checkLogin(txtDangNhap.Text,txtMatKhau.Text,cbQuyen.Text);
            if (dt.Rows.Count > 0)
            {
                FrMenu f = new FrMenu();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nhập sai, nhập lại");
                FrDangNhap fDN=new FrDangNhap();
                fDN.Show();
                this.Hide();
            }
            conn.Close();
        }
        private void FrDangNhap_Load(object sender, EventArgs e)
        {
            this.cbQuyen.Items.Add("admin");
            this.cbQuyen.Items.Add("Độc giả");
            this.cbQuyen.Items.Add("Nhân viên");
        }
 
    }
}

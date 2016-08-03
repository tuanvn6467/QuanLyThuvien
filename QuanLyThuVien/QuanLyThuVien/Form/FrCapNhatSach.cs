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
    public partial class FrCapNhatSach : Form
    {
        public FrCapNhatSach()
        {
            InitializeComponent();
        }

        ketnoi kn = new ketnoi();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter Da;
        DataSet Ds;
        public void loadCbSach()
        {
            //kn.open();
            string strconn = Constants.Connection;
            conn = new SqlConnection(strconn);
            cmd = new SqlCommand("Select Ma_Sach,Ten_Sach from LstSach",conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Da.Fill(Ds);
            cbTenSach.DataSource = Ds.Tables[0];
            cbTenSach.DisplayMember = "Ma_Sach";
            cbTenSach.ValueMember = "Ma_Sach";
            //txtTenSach.Text = cbTenSach.SelectedValue;
        }
        public void loadCbNhanVien()
        {
            string strconn = Constants.Connection;
            conn = new SqlConnection(strconn);
            cmd = new SqlCommand("Select Ma_NV,Ten_NV from LstNhanVien", conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Da.Fill(Ds);
            cbNhanVien.DataSource = Ds.Tables[0];
            cbNhanVien.DisplayMember = "Ma_NV";
            cbNhanVien.ValueMember = "Ma_NV";
        }
        public void loadCbNCC()
        {
            string strconn = Constants.Connection;
            conn = new SqlConnection(strconn);
            cmd = new SqlCommand("Select Ma_NhaCC,Ten_NhaCC from LstNhaCC", conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Da.Fill(Ds);
            cbNhaCC.DataSource = Ds.Tables[0];
            cbNhaCC.DisplayMember = "Ma_NhaCC";
            cbNhaCC.ValueMember = "Ma_NhaCC";
        }
        private void FrCapNhatSach_Load(object sender, EventArgs e)
        {
            this.loadCbSach();
            this.loadCbNhanVien();
            this.loadCbNCC();
            grCapNhatSach.DataSource = kn.select_procedure("select_capNhatSach");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSP.Text == "" || txtSoLuong.Text == "" || cbTenSach.Text == "" || dtNgayLap.Text == "" || cbNhanVien.Text == "" || cbNhaCC.Text=="")
            {
                MessageBox.Show("Không được để trống dữ liệu");
                txtSP.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = kn.truyvan("select * from CTMuonTra where So_Phieu='" + txtSP.Text+ "' ");
                if(dt.Rows.Count>0)
                {
                    MessageBox.Show("Đã tồn tại số phiếu, nhập lại");
                }
                else
                {
                    kn.add_CapNhatSach(txtSP.Text, cbTenSach.Text, DateTime.Parse(dtNgayLap.Text), int.Parse(txtSoLuong.Text), cbNhanVien.Text, cbNhaCC.Text, txtGhiChu.Text);
                    grCapNhatSach.DataSource = kn.select_procedure("select_capNhatSach");
                    xoachu();
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = cbTenSach.SelectedItem as DataRowView;
            if (row != null)
            {
                txtTenSach.Text = row["Ten_Sach"].ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            if (this.txtSP.Text== "")
                {
                    MessageBox.Show("Phải chọn Mã Số Phiếu");
            }
            else
            {
                kn.delete_CapNhatSach(this.txtSP.Text);
                grCapNhatSach.DataSource = kn.select_procedure("select_capNhatSach");
                xoachu();
            }
        }

        private void grCapNhatSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = grCapNhatSach.CurrentCell.RowIndex;
            btnThem.Enabled = false;
            txtSP.Enabled = false;
            //this.Tag = grCapNhatSach.CurrentRow.Cells["So_Phieu"].Value.ToString();
            this.txtSP.Text = grCapNhatSach.Rows[r].Cells["So_Phieu"].Value.ToString();
            this.txtSoLuong.Text = grCapNhatSach.Rows[r].Cells["So_Luong"].Value.ToString();
            //this.txtSoLuong.Text = grCapNhatSach.CurrentRow.Cells["So_Luong"].Value.ToString();
            this.dtNgayLap.Text = grCapNhatSach.Rows[r].Cells["Ngay_Lap"].Value.ToString().Substring(0, 10);
            //this.txtGhiChu.Text = grCapNhatSach.Rows[r].Cells["Ghi_Chu"].Value.ToString();
            this.txtTenNCC.Text = grCapNhatSach.Rows[r].Cells["Ma_NhaCC"].Value.ToString();
            this.txtTenNV.Text = grCapNhatSach.Rows[r].Cells["Ma_NV"].Value.ToString();
            this.txtTenSach.Text = grCapNhatSach.Rows[r].Cells["Ma_Sach"].Value.ToString();
            this.txtGhiChu.Text = grCapNhatSach.Rows[r].Cells["Ghi_Chu"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSP.Text == "" || txtSoLuong.Text == "" || cbTenSach.Text == "" || dtNgayLap.Text == "" || cbNhanVien.Text == "" || cbNhaCC.Text == "")
            {
                MessageBox.Show("Phải chọn dữ liệu cần sửa");
                txtSP.Focus();
            }
                else
                {
                    kn.update_CapNhatSach(txtSP.Text, cbTenSach.Text, DateTime.Parse(dtNgayLap.Text), int.Parse(txtSoLuong.Text), cbNhanVien.Text, cbNhaCC.Text, txtGhiChu.Text);
                    grCapNhatSach.DataSource = kn.select_procedure("select_capNhatSach");
                    xoachu();
                }
            }

        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = cbNhanVien.SelectedItem as DataRowView;
            if (row != null)
            {
                txtTenNV.Text = row["Ten_NV"].ToString();
            }
        }

        private void cbNhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = cbNhaCC.SelectedItem as DataRowView;
            if (row != null)
            {
                txtTenNCC.Text = row["Ten_NhaCC"].ToString();
            }
        }
        public void xoachu()
        {
            btnThem.Enabled = true;
            txtSP.Enabled = true;
            txtTenSach.ResetText();
            txtTenNV.ResetText();
            txtTenNCC.ResetText();
            txtSoLuong.ResetText();
            txtGhiChu.ResetText();
            cbTenSach.ResetText();
            cbNhanVien.ResetText();
            cbNhaCC.ResetText();
            dtNgayLap.ResetText();
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kn.search_CapNhatSach(txtTimKiem.Text);
            grCapNhatSach.DataSource = dt;
        }
    }
}

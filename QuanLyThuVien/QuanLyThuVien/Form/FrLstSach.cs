using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FrLstSach : Form
    {

        SqlConnection con = new SqlConnection(Constants.Connection);
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public FrLstSach()
        {
            InitializeComponent();
            DisplayData();  
        }
        private DataTable getListView()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT LstSach.Ma_Sach, LstSach.Ten_Sach, LstSach.So_Trang, LstSach.Ma_NhaXuatBan, LstSach.Ma_TacGia,LstSach.Ma_LoaiSach, LstNhaXuatBan.Ten_NhaXuatBan,LstTacGia.Ten_TacGia,LoaiSach.Ten_LoaiSach FROM LstSach  INNER JOIN LstNhaXuatBan on LstSach.Ma_NhaXuatBan = LstNhaXuatBan.Ma_NhaXuatBan INNER JOIN LstTacGia on LstSach.Ma_TacGia = LstTacGia.Ma_TacGia INNER JOIN LoaiSach on LstSach.Ma_LoaiSach = LoaiSach.Ma_LoaiSach;", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }

        private DataTable getList_MaNXB()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from LstNhaXuatBan", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }

        private DataTable getList_MaSach()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from LoaiSach", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }

        private DataTable getList_MaTG()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from lstTacGia", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }

        private void DisplayData()
        {
            DataTable dt = new DataTable();
            dt = getListView();
            grLstSach.DataSource = dt;
            grLstSach.Columns["Ma_NhaXuatBan"].Visible = false;
            grLstSach.Columns["Ma_TacGia"].Visible = false;
            grLstSach.Columns["Ma_LoaiSach"].Visible = false;

            DataTable lstMaSach = new DataTable();
            lstMaSach = getList_MaSach();
            foreach (DataRow row in lstMaSach.Rows)
            {
                cbMaLoai.Items.Add(row.Field<string>(0));
            }

            DataTable lstNXB = new DataTable();
            lstNXB = getList_MaNXB();
            foreach (DataRow row in lstNXB.Rows)
            {
                cbMaNXB.Items.Add(row.Field<string>(0));
            }

            DataTable lstTG = new DataTable();
            lstTG = getList_MaTG();
            foreach (DataRow row in lstTG.Rows)
            {
                cbMaTacGia.Items.Add(row.Field<string>(0));
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grLstSach_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaSach.Text = grLstSach.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenSach.Text = grLstSach.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoTrang.Text = grLstSach.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbMaLoai.Text = grLstSach.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbMaNXB.Text= grLstSach.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbMaTacGia.Text= grLstSach.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtMaSach.ReadOnly = true;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void grLstSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Text = grLstSach.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenSach.Text = grLstSach.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoTrang.Text = grLstSach.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbMaLoai.Text = grLstSach.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbMaNXB.Text = grLstSach.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbMaTacGia.Text = grLstSach.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtMaSach.ReadOnly = true;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }


        private void ClearData()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtSoTrang.Text = "";
            txtTenNXB.Text = "";
            txtTenTacGia.Text = "";
            txtTenLoai.Text = "";
            cbMaLoai.Text = "";
            cbMaNXB.Text = "";
            cbMaTacGia.Text = "";
            txtMaSach.ReadOnly = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("update LstSach set Ma_Sach=@masach,Ten_Sach=@tensach,So_Trang=@sotrang,Ma_NhaXuatBan=@manxb,Ma_TacGia=@matg,Ma_LoaiSach= @mals where Ma_sach=@masach", con);
            cmd.Parameters.AddWithValue("@masach", txtMaSach.Text);
            cmd.Parameters.AddWithValue("@tensach", txtTenSach.Text);
            cmd.Parameters.AddWithValue("@sotrang", txtSoTrang.Text);
            cmd.Parameters.AddWithValue("@manxb", cbMaNXB.Text);
            cmd.Parameters.AddWithValue("@matg", cbMaTacGia.Text);
            cmd.Parameters.AddWithValue("@mals", cbMaLoai.Text);
            cmd.ExecuteNonQuery();
            ClearData();
            con.Close();
            DisplayData();
            MessageBox.Show("Sửa thành công");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into LstSach(Ma_Sach,Ten_Sach,So_Trang,Ma_NhaXuatBan,Ma_TacGia,Ma_LoaiSach) values(@masach,@tensach,@sotrang,@manxb,@matg,@mals)", con);
            cmd.Parameters.AddWithValue("@masach", txtMaSach.Text);
            cmd.Parameters.AddWithValue("@tensach", txtTenSach.Text);
            cmd.Parameters.AddWithValue("@sotrang", txtSoTrang.Text);
            cmd.Parameters.AddWithValue("@manxb", cbMaNXB.Text);
            cmd.Parameters.AddWithValue("@matg", cbMaTacGia.Text);
            cmd.Parameters.AddWithValue("@mals", cbMaLoai.Text);
            cmd.ExecuteNonQuery();
            ClearData();
            con.Close();
            DisplayData();
            MessageBox.Show("Thêm thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete LstSach where Ma_Sach=@masach", con);
            cmd.Parameters.AddWithValue("@masach", txtMaSach.Text);
            cmd.ExecuteNonQuery();
            ClearData();
            con.Close();
            DisplayData();
            MessageBox.Show("Xóa thành công");
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void cbMaTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable lstTG = new DataTable();
            lstTG = getList_MaTG();
            foreach (DataRow row in lstTG.Rows)
            {
                if (cbMaTacGia.Text == row.Field<string>(0))
                {
                    txtTenTacGia.Text = row.Field<string>(1);
                }
            }
        }

        private void cbMaNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable lstNXB = new DataTable();
            lstNXB = getList_MaNXB();
            foreach (DataRow row in lstNXB.Rows)
            {
                if (cbMaNXB.Text == row.Field<string>(0))
                {
                    txtTenNXB.Text = row.Field<string>(1);
                }
            }
        }

        private void cbMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable lstMaSach = new DataTable();
            lstMaSach = getList_MaSach();
            foreach (DataRow row in lstMaSach.Rows)
            {
                if (cbMaLoai.Text == row.Field<string>(0))
                {
                    txtTenLoai.Text = row.Field<string>(1);
                }
            }
        }

        private void FrLstSach_Load(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FrInLstSach frInSach = new FrInLstSach();
            frInSach.ShowDialog();
        }

    }
}

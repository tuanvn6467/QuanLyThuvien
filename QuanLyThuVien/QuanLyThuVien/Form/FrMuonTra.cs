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
    public partial class FrMuonTra : Form
    {
        public FrMuonTra()
        {
            InitializeComponent();
            DisplayData();
            DataTable lstNV = new DataTable();
            lstNV = getList_NhanVien();
            foreach (DataRow row in lstNV.Rows)
            {
                cbMaNV.Items.Add(row.Field<string>(0));
            }

            DataTable lstDG = new DataTable();
            lstDG = getList_MaDG();
            foreach (DataRow row in lstDG.Rows)
            {
                cbMaDG.Items.Add(row.Field<string>(0));
            }
        }
        SqlConnection con = new SqlConnection(Constants.Connection);
        SqlCommand cmd;
        SqlDataAdapter adapt;

        private DataTable getListView()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select So_Phieu,CTMuonTra.Ma_NV,CTMuonTra.Ma_DocGia,LstDocGia.Ngay_Lap,LstDocGia.Ten_DocGia, LstNhanVien.Ten_NV,Ngay_Muon, Ngay_TraDuKien,Ghi_Chu from CTMuonTra inner join LstDocGia on CTMuonTra.Ma_DocGia = LstDocGia.Ma_DocGia inner join LstNhanVien on CTMuonTra.Ma_NV = LstNhanVien.Ma_NV", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }

        private DataTable GetListMuonTra(string sophieu)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from MuonTra WHERE So_Phieu = '" + sophieu + "'", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }

        private DataTable getList_NhanVien()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from LstNhanVien", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }

        private DataTable getList_MaDG()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from LstDocGia", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }
        private void DisplayData()
        {
            DataTable dt = new DataTable();
            dt = getListView();
            grMuonTra.DataSource = dt;

        }
        private void ClearData()
        {
            txtSoPhieu.Text = "";
            txtTenDG.Text = "";
            txtTenNV.Text = "";
            txtNgayLap.Text = "";
            cbMaNV.Text = "";
            cbMaDG.Text = "";
            txtNgayTra.Text = "";
            txtNgayMuon.Text = "";
            txtGhiChu.Text = "";
            txtSoPhieu.ReadOnly = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            DataTable dt = new DataTable();
            grSachMuon.DataSource = dt;
        }
        private void grMuonTra_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtSoPhieu.Text = grMuonTra.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNgayLap.Text = grMuonTra.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbMaNV.Text = grMuonTra.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbMaDG.Text = grMuonTra.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNgayTra.Text = grMuonTra.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtGhiChu.Text = grMuonTra.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtSoPhieu.ReadOnly = true;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            DataTable dt = new DataTable();
            dt = GetListMuonTra(txtSoPhieu.Text);
            grSachMuon.DataSource = dt;
            grSachMuon.Columns["So_Phieu"].Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into CTMuonTra(So_Phieu,Ma_NV,Ngay_Lap,Ma_DocGia,Ngay_Muon,Ngay_TraDuKien,Ghi_Chu) values(@sophieu,@manv,@ngaylap,@madg,@ngaymuon,@ngaytra,@ghichu)", con);
            cmd.Parameters.AddWithValue("@sophieu", txtSoPhieu.Text);
            cmd.Parameters.AddWithValue("@manv", cbMaNV.Text);
            cmd.Parameters.AddWithValue("@ngaylap", txtNgayLap.Text);
            cmd.Parameters.AddWithValue("@madg", cbMaDG.Text);
            cmd.Parameters.AddWithValue("@ngaymuon", txtNgayMuon.Text);
            cmd.Parameters.AddWithValue("@ngaytra", txtNgayTra.Text);
            cmd.Parameters.AddWithValue("@ghichu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            DataGridViewRow row = grSachMuon.CurrentRow;
            for (int i =1; i < grSachMuon.Rows.Count; i++)
            {
                //string sophieu1 = txtSoPhieu.Text;
                //string masach1 = row.Cells["Ma_Sach1"].Value.ToString();
                //string soluong1 = row.Cells["So_Luong1"].Value.ToString();
                //Console.WriteLine(row.Cells["Ma_Sach1"].Value.ToString());
                //Console.WriteLine(row.Cells["So_Luong1"].Value.ToString());

                con.Open();
                cmd = new SqlCommand("insert into MuonTra(So_Phieu,Ma_Sach,So_Luong) values(@sophieu,@masach,@soluong)", con);
                cmd.Parameters.AddWithValue("@sophieu", txtSoPhieu.Text);
                cmd.Parameters.AddWithValue("@masach", row.Cells["Ma_Sach1"].Value);
                cmd.Parameters.AddWithValue("@soluong", row.Cells["So_Luong1"].Value);
                cmd.ExecuteNonQuery();
                con.Close();  

            }

            ClearData();
            DisplayData();
            MessageBox.Show("Thêm thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete MuonTra where So_Phieu=@sophieu", con);
            cmd.Parameters.AddWithValue("@sophieu", txtSoPhieu.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            cmd = new SqlCommand("delete CTMuonTra where So_Phieu=@sophieu", con);
            cmd.Parameters.AddWithValue("@sophieu", txtSoPhieu.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            ClearData();
            DisplayData();
            MessageBox.Show("Xóa thành công");
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable lstNXB = new DataTable();
            lstNXB = getList_NhanVien();
            foreach (DataRow row in lstNXB.Rows)
            {
                if (cbMaNV.Text == row.Field<string>(0))
                {
                    txtTenNV.Text = row.Field<string>(1);
                }
            }
        }

        private void cbMaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable lstDG = new DataTable();
            lstDG = getList_MaDG();
            foreach (DataRow row in lstDG.Rows)
            {
                if (cbMaDG.Text == row.Field<string>(0))
                {
                    txtTenDG.Text = row.Field<string>(1);
                }
            }
        }

        private void grMuonTra_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = grMuonTra.CurrentCell.RowIndex;
            txtSoPhieu.Text = grMuonTra.Rows[r].Cells["So_Phieu"].Value.ToString();
            txtNgayMuon.Text = grMuonTra.Rows[e.RowIndex].Cells["Ngay_Muon"].Value.ToString();
            cbMaNV.Text = grMuonTra.Rows[e.RowIndex].Cells["Ma_NV"].Value.ToString();
            cbMaDG.Text = grMuonTra.Rows[e.RowIndex].Cells["Ma_DocGia"].Value.ToString();
            txtNgayLap.Text = grMuonTra.Rows[e.RowIndex].Cells["Ngay_Lap"].Value.ToString();
            txtNgayTra.Text = grMuonTra.Rows[e.RowIndex].Cells["Ngay_Tra"].Value.ToString();
            txtGhiChu.Text = grMuonTra.Rows[e.RowIndex].Cells["Ghi_Chu"].Value.ToString();
            txtSoPhieu.ReadOnly = true;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            DataTable dt = new DataTable();
            dt = GetListMuonTra(txtSoPhieu.Text);
            grSachMuon.DataSource = dt;
            grSachMuon.Columns["So_Phieu"].Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("update CTMuonTra set Ma_NV=@manv,Ma_DocGia=@madg,Ngay_Lap= @ngaylap,Ngay_Muon=@ngaymuon,Ngay_TraDuKien=@ngaytra,Ghi_Chu=@ghichu where So_Phieu=@sophieu", con);
            cmd.Parameters.AddWithValue("@sophieu", txtSoPhieu.Text);
            cmd.Parameters.AddWithValue("@manv", cbMaNV.Text);
            cmd.Parameters.AddWithValue("@madg", cbMaDG.Text);
            cmd.Parameters.AddWithValue("@ngaylap", txtNgayLap.Text);
            cmd.Parameters.AddWithValue("@ngaytra", txtNgayTra.Text);
            cmd.Parameters.AddWithValue("@ngaymuon", txtNgayMuon.Text);
            cmd.Parameters.AddWithValue("@ghichu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            con.Close();
          

            DataTable dt = new DataTable();
            dt = GetListMuonTra(txtSoPhieu.Text);

            DataGridViewRow row = grSachMuon.CurrentRow;
            for (int i = 1; i < grSachMuon.Rows.Count; i++)
            {

                con.Open();
                cmd = new SqlCommand("update MuonTra set Ma_Sach=@masach,So_Luong=@soluong where So_Phieu=@sophieu", con);
                cmd.Parameters.AddWithValue("@sophieu", txtSoPhieu.Text);
                cmd.Parameters.AddWithValue("@masach", row.Cells["Ma_Sach1"].Value);
                cmd.Parameters.AddWithValue("@soluong", row.Cells["So_Luong1"].Value);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            ClearData();
            DisplayData();
            MessageBox.Show("Sửa thành công");
        }


    }
}

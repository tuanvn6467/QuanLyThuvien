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
        SqlConnection con = new SqlConnection(Constants.Connection);
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public FrMuonTra()
        {
            InitializeComponent();
            DisplayData();
            DataTable lstNV = new DataTable();
            lstNV = Utils.getList_NhanVien();
            foreach (DataRow row in lstNV.Rows)
            {
                cbMaNV.Items.Add(row.Field<string>(0));
            }

            DataTable lstDG = new DataTable();
            lstDG = Utils.getList_MaDG();
            foreach (DataRow row in lstDG.Rows)
            {
                cbMaDG.Items.Add(row.Field<string>(0));
            }
            DataGridViewComboBoxColumn com = (DataGridViewComboBoxColumn) grSachMuon.Columns["Ma_Sach1"];

            DataTable lstSachTonKho = new DataTable();
            lstSachTonKho = Utils.getList_SachTonKho();
            com.DisplayMember = "Ma_Sach";
            com.ValueMember = "Ma_Sach";
            com.DataSource = lstSachTonKho;

            grSachMuon.CellValueChanged += new DataGridViewCellEventHandler(grSachMuon_CellValueChanged);
            grSachMuon.CurrentCellDirtyStateChanged += new EventHandler(grSachMuon_CurrentCellDirtyStateChanged);
        }

        void grSachMuon_CurrentCellDirtyStateChanged(object sender,
        EventArgs e)
        {
            if (this.grSachMuon.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                grSachMuon.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void grSachMuon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // My combobox column is the second one so I hard coded a 1, flavor to taste
            DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)grSachMuon.Rows[e.RowIndex].Cells["Ma_Sach1"];
            if (cb.Value != null)
            {
                grSachMuon.Columns["Ton_Kho"].Visible = true;
                var tonkho = grSachMuon.Rows[e.RowIndex].Cells["Ton_Kho"];
                var sachtonkho = Utils.get_SachTonKho(cb.Value.ToString());
                foreach (DataRow row in sachtonkho.Rows)
                {
                    tonkho.Value = row.Field<int>(6);
                }
                // do stuff
                grSachMuon.Invalidate();
            }
        }
        
        private void DisplayData()
        {
            DataTable dt = new DataTable();
            dt = Utils.getListView();
            grMuonTra.DataSource = dt;

        }
        private void ClearData()
        {
            txtSoPhieu.Text = "";
            txtTenDG.Text = "";
            txtTenNV.Text = "";
            cbMaNV.Text = "";
            cbMaDG.Text = "";
            txtNgayLap.Value = DateTime.Now;
            txtNgayMuon.Value = DateTime.Now;
            txtNgayTra.Value = DateTime.Now;
            txtGhiChu.Text = "";
            txtSoPhieu.ReadOnly = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            DataTable dt = new DataTable();
            grSachMuon.DataSource = dt;
            grSachMuon.Columns["Ton_Kho"].Visible = true;
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
            dt = Utils.GetListMuonTra(txtSoPhieu.Text);
            grSachMuon.DataSource = dt;
            grSachMuon.Columns["So_Phieu"].Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoPhieu.Text.Length == 0 || cbMaNV.Text.Length == 0 || cbMaDG.Text.Length == 0)
            {
                MessageBox.Show(@"Nhập đầy đủ các trường yêu cầu!", Constants.QLTV, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (grSachMuon.Rows.Count == 0)
            {
                MessageBox.Show(@"Nhập thông tin sách mượn!", Constants.QLTV, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (grSachMuon.Rows.Count > 0)
            {
                var ok = true;
                for (int i = 0; i < grSachMuon.Rows.Count; i++)
                {
                    if (grSachMuon.Rows[i].Cells["So_Luong1"] != null &&
                        grSachMuon.Rows[i].Cells["So_Luong1"].Value != null &&
                        grSachMuon.Rows[i].Cells["So_Luong1"].Value != "" &&
                        Convert.ToInt32(grSachMuon.Rows[i].Cells["So_Luong1"].Value) == 0)
                    {
                        ok = false;
                        break;
                    }
                    if ((grSachMuon.Rows[i].Cells["So_Luong1"].Value == "" || grSachMuon.Rows[i].Cells["So_Luong1"].Value == null) && grSachMuon.Rows[i].Cells["Ma_Sach1"].Value != "" && grSachMuon.Rows[i].Cells["Ma_Sach1"].Value!=null)
                    {
                        ok = false;
                        break;
                    }
                }
                if (!ok)
                {
                    MessageBox.Show(@"Nhập số lượng sách mượn!", Constants.QLTV, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("insert into CTMuonTra(" +
                                         "So_Phieu," +
                                         "Ma_NV," +
                                         "Ngay_Lap," +
                                         "Ma_DocGia," +
                                         "Ngay_Muon," +
                                         "Ngay_TraDuKien," +
                                         "Ghi_Chu) " +
                                         "values(@sophieu,@manv,@ngaylap,@madg,@ngaymuon,@ngaytra,@ghichu)", con);
                    cmd.Parameters.AddWithValue("@sophieu", txtSoPhieu.Text);
                    cmd.Parameters.AddWithValue("@manv", cbMaNV.Text);
                    cmd.Parameters.AddWithValue("@ngaylap", txtNgayLap.Value);
                    cmd.Parameters.AddWithValue("@madg", cbMaDG.Text);
                    cmd.Parameters.AddWithValue("@ngaymuon", txtNgayMuon.Value);
                    cmd.Parameters.AddWithValue("@ngaytra", txtNgayTra.Value);
                    cmd.Parameters.AddWithValue("@ghichu", txtGhiChu.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    DataGridViewRow row = grSachMuon.CurrentRow;
                    for (int i = 1; i < grSachMuon.Rows.Count; i++)
                    {
                        if (grSachMuon.Rows[i].Cells["Ma_Sach1"].Value != null)
                        {
                            //string sophieu1 = txtSoPhieu.Text;
                            //string masach1 = row.Cells["Ma_Sach1"].Value.ToString();
                            //string soluong1 = row.Cells["So_Luong1"].Value.ToString();
                            //Console.WriteLine(row.Cells["Ma_Sach1"].Value.ToString());
                            //Console.WriteLine(row.Cells["So_Luong1"].Value.ToString());

                            con.Open();
                            cmd = new SqlCommand("insert into MuonTra(So_Phieu,Ma_Sach,So_Luong) values(@sophieu,@masach,@soluong)", con);
                            cmd.Parameters.AddWithValue("@sophieu", txtSoPhieu.Text);
                            cmd.Parameters.AddWithValue("@masach", grSachMuon.Rows[i].Cells["Ma_Sach1"].Value);
                            cmd.Parameters.AddWithValue("@soluong", grSachMuon.Rows[i].Cells["So_Luong1"].Value);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            con.Open();
                            cmd = new SqlCommand("update LstSach set Ton_Kho = Ton_Kho - @soluong where Ma_Sach = @masach", con);
                            cmd.Parameters.AddWithValue("@masach", grSachMuon.Rows[i].Cells["Ma_Sach1"].Value);
                            cmd.Parameters.AddWithValue("@soluong", grSachMuon.Rows[i].Cells["So_Luong1"].Value);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    ClearData();
                    DisplayData();
                    MessageBox.Show(@"Thêm mới thành công", Constants.QLTV, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("update LstSach set Ton_Kho = Ton_Kho + (select Sum(So_Luong) from MuonTra where So_Phieu = @sophieu)", con);
            cmd.Parameters.AddWithValue("@sophieu", txtSoPhieu.Text);
            cmd.ExecuteNonQuery();
            con.Close();

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
            lstNXB = Utils.getList_NhanVien();
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
            lstDG = Utils.getList_MaDG();
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
            dt = Utils.GetListMuonTra(txtSoPhieu.Text);
            grSachMuon.AutoGenerateColumns = false;
            grSachMuon.DataSource = dt;
            //grSachMuon.Columns["So_Phieu"].Visible = false;
            //grSachMuon.Columns["Ton_Kho"].Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSoPhieu.Text.Length == 0 || cbMaNV.Text.Length == 0 || cbMaDG.Text.Length == 0)
            {
                MessageBox.Show(@"Nhập đầy đủ các trường yêu cầu!", Constants.QLTV, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (grSachMuon.Rows.Count == 0)
            {
                MessageBox.Show(@"Nhập thông tin sách mượn!", Constants.QLTV, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (grSachMuon.Rows.Count > 0)
            {
                var ok = true;
                for (int i = 0; i < grSachMuon.Rows.Count; i++)
                {
                    if (grSachMuon.Rows[i].Cells["So_Luong1"] != null &&
                        grSachMuon.Rows[i].Cells["So_Luong1"].Value != null &&
                        grSachMuon.Rows[i].Cells["So_Luong1"].Value != "" &&
                        Convert.ToInt32(grSachMuon.Rows[i].Cells["So_Luong1"].Value) == 0)
                    {
                        ok = false;
                        break;
                    }
                    if ((grSachMuon.Rows[i].Cells["So_Luong1"].Value == "" ||
                         grSachMuon.Rows[i].Cells["So_Luong1"].Value == null) &&
                        grSachMuon.Rows[i].Cells["Ma_Sach1"].Value != "" &&
                        grSachMuon.Rows[i].Cells["Ma_Sach1"].Value != null)
                    {
                        ok = false;
                        break;
                    }
                }
                if (!ok)
                {
                    MessageBox.Show(@"Nhập số lượng sách mượn!", Constants.QLTV, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    cmd =
                        new SqlCommand(
                            "update CTMuonTra set Ma_NV=@manv,Ma_DocGia=@madg,Ngay_Lap= @ngaylap,Ngay_Muon=@ngaymuon,Ngay_TraDuKien=@ngaytra,Ghi_Chu=@ghichu where So_Phieu=@sophieu",
                            con);
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
                    dt = Utils.GetListMuonTra(txtSoPhieu.Text);

                    //DataGridViewRow row = grSachMuon.CurrentRow;

                    con.Open();
                    cmd =
                        new SqlCommand(
                            "update LstSach set Ton_Kho = Ton_Kho + (select Sum(So_Luong) from MuonTra where So_Phieu = @sophieu)",
                            con);
                    cmd.Parameters.AddWithValue("@sophieu", txtSoPhieu.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd = new SqlCommand("delete from MuonTra where So_Phieu=@sophieu", con);
                    cmd.Parameters.AddWithValue("@sophieu", txtSoPhieu.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    for (int i = 0; i < grSachMuon.Rows.Count; i++)
                    {
                        if (grSachMuon.Rows[i].Cells["Ma_Sach1"].Value != null)
                        {
                            con.Open();
                            cmd = new SqlCommand("insert MuonTra values(@sophieu, @masach, @soluong)", con);
                            cmd.Parameters.AddWithValue("@sophieu", txtSoPhieu.Text);
                            cmd.Parameters.AddWithValue("@masach", grSachMuon.Rows[i].Cells["Ma_Sach1"].Value);
                            cmd.Parameters.AddWithValue("@soluong", grSachMuon.Rows[i].Cells["So_Luong1"].Value);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            con.Open();
                            cmd =
                                new SqlCommand(
                                    "update LstSach set Ton_Kho = Ton_Kho - @soluong where Ma_Sach = @masach", con);
                            cmd.Parameters.AddWithValue("@masach", grSachMuon.Rows[i].Cells["Ma_Sach1"].Value);
                            cmd.Parameters.AddWithValue("@soluong", grSachMuon.Rows[i].Cells["So_Luong1"].Value);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            con.Close();
                        }
                    }

                    ClearData();
                    DisplayData();
                    MessageBox.Show("Sửa thành công");
                }
            }
        }

        private void grSachMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var text = txtTimKiem.Text;
            if (!string.IsNullOrEmpty(text))
            {
                DataTable dt = new DataTable();
                dt = Utils.timkiemMuonTra(text);
                grMuonTra.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Nhap lai du lieu
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtSoPhieu.ReadOnly = false;
            txtSoPhieu.Text = "";
            cbMaNV.Text = "";
            txtTenNV.Text = "";
            cbMaDG.Text = "";
            txtTenDG.Text = "";
            txtGhiChu.Text = "";
            txtNgayLap.Value = DateTime.Now;
            txtNgayMuon.Value = DateTime.Now;
            txtNgayTra.Value = DateTime.Now;
            grSachMuon.Columns["Ton_Kho"].Visible = true;
        }

        private void grSachMuon_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grSachMuon.CurrentRow;
            var masach = row.Cells["Ma_Sach1"].Value;
            var soluong = row.Cells["So_Luong1"].Value;
            var sophieu = txtSoPhieu.Text;

        }

        private void txtTimKiem_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Then Do your Thang
                var text = txtTimKiem.Text;
                if (!string.IsNullOrEmpty(text))
                {
                    DataTable dt = new DataTable();
                    dt = Utils.timkiemMuonTra(text);
                    grMuonTra.DataSource = dt;
                }
            }
        }


    }
}

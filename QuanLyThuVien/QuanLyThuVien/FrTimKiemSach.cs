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
    public partial class FrTimKiemSach : Form
    {
        public FrTimKiemSach()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(Constants.Connection);

        public DataTable HienDL(string sql)
        {
            Con.Open();
            SqlDataAdapter Da = new SqlDataAdapter(sql, Con);
            DataTable dt = new DataTable();
            Da.Fill(dt);
            Con.Close();
            return dt;
        }﻿
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrTimKiemSach_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Mã Sách");
            comboBox1.Items.Add("Tên Sách");
            comboBox1.Items.Add("Loại Sách");
            comboBox1.Items.Add("Tên Tác Giả");
            comboBox1.Items.Add("Nội Dung tóm tắt");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mã Sách")
            {
                dataGridView1.DataSource = HienDL("select *from ViewSelectLstSach where Ma_Sach like '%" + textBox1.Text.Trim() + "%'");
            }
            if (comboBox1.Text == "Tên Sách")
            {
                dataGridView1.DataSource = HienDL("select *from ViewSelectLstSach where Ten_Sach like '%" + textBox1.Text.Trim() + "%'");
            }
        }
    }
}

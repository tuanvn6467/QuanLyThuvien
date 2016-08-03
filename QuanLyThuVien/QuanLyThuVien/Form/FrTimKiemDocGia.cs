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
    public partial class FrTimKiemDocGia : Form
    {
        public FrTimKiemDocGia()
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

        private void FrTimKiemDocGia_Load(object sender, EventArgs e)
        {
            //comboBox1.Text = "Mã Độc Giả";
            comboBox1.Items.Add("Mã Độc Giả");
            comboBox1.Items.Add("Tên Độc Giả");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Mã Độc Giả")
            {
                dataGridView1.DataSource = HienDL("select *from LstDocGia where Ma_DocGia like '%"+textBox1.Text.Trim()+"%'");
            }
            if (comboBox1.Text=="Tên Độc Giả")
            {
                dataGridView1.DataSource = HienDL("select *from LstDocGia where Ten_DocGia like '%" + textBox1.Text.Trim() + "%'");
            }
        }
    }
}

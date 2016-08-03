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
using System.IO;

namespace QuanLyThuVien
{
    public partial class Anh : Form
    {
        public Anh()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg|All files(*.*)|*.*";
            OpenFileDialog1.FilterIndex = 1;
            OpenFileDialog1.RestoreDirectory = true;
            if (OpenFileDialog1.ShowDialog()==DialogResult.OK )
            {
                pictureBox1.ImageLocation = OpenFileDialog1.FileName;
                textBox2.Text = OpenFileDialog1.FileName;
            }
        }
        private byte[] convertImgTobyte()
        {
            FileStream a;
            a = new FileStream(textBox2.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[a.Length];
            a.Read(picbyte,0,System.Convert.ToInt32(a.Length));
            return picbyte;
        }

        private void buthton2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Constants.Connection);
                con.Open();
                string sql = "insert into LstDocGia (Ma_DocGia,AnhDG) values(@madg,@anh)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@madg", textBox1.Text);
                cmd.Parameters.AddWithValue("@anh", convertImgTobyte());
                cmd.ExecuteNonQuery();
                con.Close();
                textBox1.Text = textBox2.Text = "";
                MessageBox.Show("thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constants.Connection);
            con.Open();
            SqlDataAdapter Da = new SqlDataAdapter();
            Da.SelectCommand = new SqlCommand("Select * From LstDocGia",con);
            DataTable dt = new DataTable();
            Da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constants.Connection);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("update LstDocGia set Ma_DocGia=@madg,AnhDG=@anh where Ma_DocGia=@madg", con);
            cmd.Parameters.AddWithValue("@madg",textBox1.Text);
            //cmd.Parameters.AddWithValue("@anh", convertImgTobyte());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sửa thành công");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}

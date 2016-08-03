using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    class DataConn
    {
        private static string source;
        private static SqlConnection Con;
        private static SqlCommand Cmd;
        private static SqlDataAdapter da;
        private static DataSet ds;
        static DataConn()
        {
            source = Constants.Connection;
            Con = new SqlConnection(source);
            try
            {
                Con.Open();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối!Hãy xem trợ giúp");
            }
        }
        public static void DongKetNoi()
        {
            Cmd.Dispose();
            try
            {
                Con.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Lỗi CSDL, xem trợ giúp");
            }
            finally
            {
                Con.Dispose();
            }
        }
        public static void ThucHienCmd(string select)
        {
            Cmd = new SqlCommand(select, Con);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch(SqlException)
            {
                MessageBox.Show("Lỗi CSDL, Xem lại");
            }
        }
        public static DataSet GrdSource(string select)
        {
            da = new SqlDataAdapter(select, Con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static SqlDataReader ThucHienReader(string select)
        {
            Cmd = new SqlCommand(select, Con);
            try 
            {
                return Cmd.ExecuteReader();
            }
            catch(SqlException)
            {
                return null;
            }
        }
    }
}

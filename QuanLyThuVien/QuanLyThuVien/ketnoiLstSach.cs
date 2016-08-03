using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    class ketnoiLstSach
    {
        public static string strKetNoi = Constants.Connection;
        SqlConnection Conn;
        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable dt;
        public SqlConnection open()
        {
            Conn = new SqlConnection(strKetNoi);
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            return Conn;
        }
        public SqlConnection close()
        {
            Conn = new SqlConnection(strKetNoi);
            if (Conn.State == ConnectionState.Open)
                Conn.Close();
            return Conn;
        }
        public DataTable truyvan(string sql)
        {
            open();
            dt = new DataTable();
            Cmd = new SqlCommand(sql, Conn);
            Da = new SqlDataAdapter(Cmd);
            Da.Fill(dt);
            close();
            return dt;
        }
    }
}

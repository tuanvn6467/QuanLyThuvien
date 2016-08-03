using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QuanLyThuVien
{
    class ketnoi
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
            dt=new DataTable();
            Cmd = new SqlCommand(sql, Conn);
            Da = new SqlDataAdapter(Cmd);
            Da.Fill(dt);
            close();
            return dt;
        }
        public DataTable select_procedure(string tempro)
        {
            dt = new DataTable();
            open();
            Cmd = new SqlCommand(tempro, Conn);
            Cmd.CommandType = CommandType.StoredProcedure;
            Da = new SqlDataAdapter(Cmd);
            Da.Fill(dt);
            close();
            return dt;
        }
        public SqlCommand add_CapNhatSach(string So_Phieu,string Ma_Sach,DateTime Ngay_Lap,int So_Luong,string Ma_NV,string Ma_NhaCC,string Ghi_Chu)
        {
            open();
            Cmd = new SqlCommand("add_CapNhatSach",Conn);
            Cmd.Parameters.Add(new SqlParameter("@So_Phieu",So_Phieu));
            Cmd.Parameters.Add(new SqlParameter("@Ma_Sach",Ma_Sach));
            Cmd.Parameters.Add(new SqlParameter("@Ngay_Lap",Ngay_Lap));
            Cmd.Parameters.Add(new SqlParameter("@So_Luong", So_Luong));
            Cmd.Parameters.Add(new SqlParameter("@Ma_NV", Ma_NV));
            Cmd.Parameters.Add(new SqlParameter("@Ma_NhaCC",Ma_NhaCC));
            Cmd.Parameters.Add(new SqlParameter("@Ghi_Chu", Ghi_Chu));
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.ExecuteNonQuery();
            close();
            return Cmd;
        }
        public SqlCommand update_CapNhatSach(string So_Phieu, string Ma_Sach, DateTime Ngay_Lap, int So_Luong, string Ma_NV, string Ma_NhaCC, string Ghi_Chu)
        {
            open();
            Cmd = new SqlCommand("update_CapNhatSach", Conn);
            Cmd.Parameters.Add(new SqlParameter("@So_Phieu", So_Phieu));
            Cmd.Parameters.Add(new SqlParameter("@Ma_Sach", Ma_Sach));
            Cmd.Parameters.Add(new SqlParameter("@Ngay_Lap", Ngay_Lap));
            Cmd.Parameters.Add(new SqlParameter("@So_Luong", So_Luong));
            Cmd.Parameters.Add(new SqlParameter("@Ma_NV", Ma_NV));
            Cmd.Parameters.Add(new SqlParameter("@Ma_NhaCC", Ma_NhaCC));
            Cmd.Parameters.Add(new SqlParameter("@Ghi_Chu", Ghi_Chu));
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.ExecuteNonQuery();
            close();
            return Cmd;
        }
        public SqlCommand delete_CapNhatSach(string @So_Phieu)
        {
            open();
            Cmd = new SqlCommand("delete_CapNhatSach",Conn);
            Cmd.Parameters.Add(new SqlParameter("@So_Phieu", So_Phieu));
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.ExecuteNonQuery();
            close();
            return Cmd;
        }
        public DataTable search_CapNhatSach(string @chuoitimkiem)
        {
            open();
            dt = new DataTable();
            Cmd = new SqlCommand("search_CapNhatSach", Conn);
            Cmd.Parameters.Add(new SqlParameter("@chuoitimkiem", chuoitimkiem));
            Cmd.CommandType = CommandType.StoredProcedure;
            Da = new SqlDataAdapter(Cmd);
            Da.Fill(dt);
            //Cmd.ExecuteNonQuery();
            close();
            return dt;
        }
        
    }
} 

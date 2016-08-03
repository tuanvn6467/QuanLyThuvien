using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace QuanLyThuVien
{
    class ClsSQL
    {
        //Phương thức kết nối
        public static SqlConnection objConn = new SqlConnection();
        public static bool Connect(string strConn)
        {
            //Gọi phương thức đóng kết nối
            Disconnect();
            try
            {
                objConn.ConnectionString = strConn;
                objConn.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "SQL Server connection fail",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //2. Viết phương thức ngắt kết nối
        public static void Disconnect()
        {
            if (objConn != null)
            {
                if (objConn.State != System.Data.ConnectionState.Closed)
                    objConn.Close();
            }
        }
        //3.Viết phương thức SqlExecute - Thực thi câu lệnh SQL Insert, Update, Delete
        public static bool SqlExecute(string sQuery, string strConn)
        {
            using (SqlCommand oSqlComm = new SqlCommand())
            {
                oSqlComm.Connection = ClsSQL.objConn;
                oSqlComm.CommandText = "SET DATEFORMAT DMY;\r\n" + sQuery;
                oSqlComm.CommandTimeout = 60;
                //Kết nối
                ClsSQL.Connect(strConn);
                SqlTransaction oTran = ClsSQL.objConn.BeginTransaction();//Transaction
                oSqlComm.Transaction = oTran;
                try
                {
                    oSqlComm.ExecuteNonQuery();//Thực thi câu lệnh SQL
                    oTran.Commit();
                    ClsSQL.Disconnect();
                }
                catch
                {
                    oTran.Rollback();
                    ClsSQL.Disconnect();
                    Clipboard.SetText("SET DATEFORMAT DMY;\r\n" + sQuery);
                    MessageBox.Show("SET DATEFORMAT DMY;\r\n" + sQuery, "SQL Server execute fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }
        //4.SqlSelect - Thực thi câu lệnh Select trả về một Dataset
        public static DataSet SqlSelect(string sQuery, string strConn)
        {
            DataSet oDs = new DataSet();
            try
            {
                SqlDataAdapter oSqlDa = new SqlDataAdapter();
                oSqlDa.SelectCommand = new SqlCommand("SET DATEFORMAT DMY;\r\n" + sQuery);
                oSqlDa.SelectCommand.Connection = objConn;
                oSqlDa.SelectCommand.CommandTimeout = 60;
                if (ClsSQL.Connect(strConn) == true)//Ket noi
                    oSqlDa.Fill(oDs);
                ClsSQL.Disconnect();
            }
            catch
            {
                ClsSQL.Disconnect();
                Clipboard.SetText("SET DATEFORMAT DMY;\r\n" + sQuery);
                MessageBox.Show("SET DATEFORMAT DMY;\r\n" + sQuery, "SQL Server select fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return oDs;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    public static class Utils
    {

        static SqlConnection con = new SqlConnection(Constants.Connection);
        static SqlCommand cmd;
        static SqlDataAdapter adapt;

        public static DataTable getListView()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select So_Phieu,CTMuonTra.Ma_NV,CTMuonTra.Ma_DocGia,CTMuonTra.Ngay_Lap,LstDocGia.Ten_DocGia, LstNhanVien.Ten_NV,Ngay_Muon, Ngay_TraDuKien,Ghi_Chu from CTMuonTra inner join LstDocGia on CTMuonTra.Ma_DocGia = LstDocGia.Ma_DocGia inner join LstNhanVien on CTMuonTra.Ma_NV = LstNhanVien.Ma_NV", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable GetListMuonTra(string sophieu)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select So_Phieu,m.Ma_Sach,So_Luong,s.Ton_Kho from MuonTra m left join LstSach s on s.Ma_Sach = m.Ma_Sach WHERE So_Phieu = '" + sophieu + "'", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable getList_NhanVien()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from LstNhanVien", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable getList_MaDG()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from LstDocGia", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable getList_SachTonKho()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from LstSach where Ton_Kho > 0", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }
        public static DataTable get_SachTonKho(string masach)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from [LstSach] WHERE Ma_Sach = '" + masach + "'", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable timkiemMuonTra(string text)
        {
            con.Open();
            DataTable dt = new DataTable();
            var query = "select So_Phieu," +
                        "CTMuonTra.Ma_NV," +
                        "CTMuonTra.Ma_DocGia," +
                        "LstDocGia.Ngay_Lap," +
                        "LstDocGia.Ten_DocGia, " +
                        "LstNhanVien.Ten_NV," +
                        "Ngay_Muon," +
                        "Ngay_TraDuKien," +
                        "Ghi_Chu " +
                        "from CTMuonTra inner join LstDocGia " +
                        "on CTMuonTra.Ma_DocGia = LstDocGia.Ma_DocGia " +
                        "inner join LstNhanVien " +
                        "on CTMuonTra.Ma_NV = LstNhanVien.Ma_NV " +
                        "where lower(So_Phieu) like N'%" + text + "%' or " +
                        "lower(CTMuonTra.Ma_NV) like N'%" + text + "%' or " +
                        "lower(CTMuonTra.Ma_DocGia) like N'%" + text + "%' or " +
                        "lower(LstDocGia.Ngay_Lap) like N'%" + text + "%' or " +
                        "lower(LstDocGia.Ten_DocGia) like N'%" + text + "%' or " +
                        "lower(LstNhanVien.Ten_NV) like N'%" + text + "%' or " +
                        "lower(Ngay_Muon) like N'%" + text + "%' or " +
                        "lower(Ngay_TraDuKien) like N'%" + text + "%' or " +
                        "lower(Ghi_Chu) like N'%" + text + "%'" +
                        "";
            adapt = new SqlDataAdapter(query, con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable get_ThongTinDocGiaMuonSach()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select ctmt.So_Phieu,ctmt.Ma_DocGia, dg.Ten_DocGia, mt.Ma_Sach, mt.So_Luong, ls.Ten_Sach, ctmt.Ngay_Muon, ctmt.Ngay_TraDuKien from CTMuonTra ctmt left join LstDocGia dg on dg.Ma_DocGia = ctmt.Ma_DocGia left join MuonTra mt on mt.So_Phieu = ctmt.So_Phieu left join LstSach ls on ls.Ma_Sach = mt.Ma_Sach", con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }
    }
}

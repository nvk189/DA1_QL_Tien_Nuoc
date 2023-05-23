using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public  class ThanhToan_DAL
    {
        Config_DAL config_DAL = new Config_DAL();

        public DataTable Select_HD()
        {
            return config_DAL.GetDataTable("GetHoaDonAndCT_HoaDon");
        }

        public DataTable Select_MaKH()
        {
            return config_DAL.GetDataTable("select_MaKH_SC");
        }
        public DataTable Select_MaNV()
        {
            return config_DAL.GetDataTable("select_MaNV_SC");
        }
        public DataTable Show_TenKH_DiaChi(string a)
        {
            int So_luong = 1;
            string sql = "select_TenKH_DiaChi_SC";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MaKH";Values[0] = a;
            return config_DAL.ExecuteSearch(sql, Name, Values, So_luong);
        }

        public DataTable Show_Giatien(string b)
        {
            int So_luong = 1;
            string sql = "select_GiaTien_ThanhToan";
            string[] Name =new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MaKH";Values [0] = b;
            return config_DAL.ExecuteSearch(sql, Name, Values, So_luong);

        }

        public DataTable Show_SoCTS(string c)
        {

            int So_luong = 1;
            string sql = "GetSoCTS";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MaKH"; Values[0] = c;
            return config_DAL.ExecuteSearch(sql, Name, Values, So_luong);
        }

        public int Insert_TT( string maKH, string maNV, float soCTT, float soCTS, float giaTien, int thue, DateTime ngayTT, string hinhThucTT,  float tongTien)
        {
            int So_luong = 9;
            string sql = "InsertHoaDonAndCT_HoaDon";
            string[] Name =new string [So_luong];
            object[] Values= new object[So_luong];
            Name[0] = "@MaKH"; Values[0] = maKH;
            Name[1] = "@MaNV"; Values[1] = maNV;
            Name[2] = "@SoCTT"; Values[2] = soCTT;
            Name[3] = "@SoCTS"; Values[3] = soCTS;
            Name[4] = "@GiaTien"; Values[4] = giaTien;
            Name[5] = "@Thue"; Values[5] = thue;
            Name[6] = "@NgayThanhToan"; Values[6] = ngayTT;
            Name[7] = "@HinhThucTT"; Values[7] = hinhThucTT;
            Name[8] = "@TongTien"; Values[8] = tongTien;

            return config_DAL.Excute(sql, Name, Values, So_luong);
           
        }

        public int Update_TT(int maHD, string maKH, string maNV, float soCTT, float soCTS, float giaTien, int thue, DateTime ngayTT, string hinhThucTT,  float tongTien)
        {
            int So_luong = 10;
            string sql = "UpdateHoaDonAndCT_HoaDon";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
           
            Name[0] = "@MaHD"; Values[0] = maHD;
            Name[1] = "@MaKH"; Values[1] = maKH;
            Name[2] = "@MaNV"; Values[2] = maNV;
            Name[3] = "@SoCTT"; Values[3] = soCTT;
            Name[4] = "@SoCTS"; Values[4] = soCTS;
            Name[5] = "@GiaTien"; Values[5] = giaTien;
            Name[6] = "@Thue"; Values[6] = thue;
            Name[7] = "@NgayThanhToan"; Values[7] = ngayTT;
            Name[8] = "@HinhThucTT"; Values[8] = hinhThucTT;
            Name[9] = "@TongTien"; Values[9] = tongTien;

            return config_DAL.Excute(sql, Name, Values, So_luong);

        }

        public DataTable Search_TT(int a ,string b)
        {
            int So_luong = 2;
            string sql = "SearchHoaDonAndCT_HoaDon";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MaHD"; Values[0] = a;
            Name[1] = "@MaKH"; Values[1] = b; 

            return config_DAL.ExecuteSearch(sql,Name ,Values,So_luong);
        }
       
    }
}




 

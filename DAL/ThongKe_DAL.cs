using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public  class ThongKe_DAL
    {

        Config_DAL config_DAL = new Config_DAL();
        
        public DataTable Showdata()
        {
            return config_DAL.GetDataTable("GetHoaDonAndCT_HoaDon");

        }
        public DataTable ShowNV()
        {
            return config_DAL.GetDataTable("SoNV");
        }

        public DataTable Searchdt1(int a)
        {
            int So_luong = 1;
            string sql = "Search_TK_HD";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@ThoiGian"; Values[0] = a;
            return config_DAL.ExecuteSearch(sql, Name, Values, So_luong);
        }
        public DataTable Searchdt1(DateTime b)
        {
            int So_luong = 1;
            string sql = "Search_TK_DT";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@NgayThanhToan"; Values[0] = b;
            return config_DAL.ExecuteSearch(sql, Name, Values, So_luong);
        }
        public DataTable Searchdt(DateTime a)
        {
            int So_luong = 1;
            string sql = "ThongKeHoaDon";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@NgayThanhToan";Values[0] = a;
            return config_DAL.ExecuteSearch(sql,Name,Values,So_luong);
        }


        public DataTable SearchMY(int b)
        {
            int So_luong = 1;
            string sql = "ThongKeHoaDonTheoThang";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@ThoiGian"; Values[0] = b;
            return config_DAL.ExecuteSearch(sql, Name, Values, So_luong);
        }

        public DataTable TK_MaKH(string c)
        {
            int So_luong = 1;
            string sql = "ThongKeHoaDonMK";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MaKH"; Values[0] = c;
            return config_DAL.ExecuteSearch(sql, Name, Values, So_luong);
        }

    }
}

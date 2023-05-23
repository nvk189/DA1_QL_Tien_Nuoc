using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{

    
    public  class GIaNuoc_DAL
    {
        Config_DAL Config_DAL = new Config_DAL();

        public DataTable Select_MaKH()
        {
            return Config_DAL.GetDataTable("select_MaKH_GiaNuoc");
        }

        public DataTable ShowData()
        {
            return Config_DAL.GetDataTable("Select_GiaNuoc");
        }
        public  DataTable Show_TenKH (string a)
        {
            int So_luong = 1;
            string sql = "Select_KhachHang_GiaNuoc";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MaKH"; Values[0] = a;
            return Config_DAL.ExecuteSearch(sql, Name, Values, So_luong);
        }

        public int Insert_GN(string madk, string makh, string manuocsd, string giatien)
        {
            int So_luong = 4;
            string sql = "Insert_GiaNuoc";
            string[] Name= new string[So_luong];
            object[] Values = new string[So_luong];
            Name[0] = "@MaDK"; Values[0] = madk;
            Name[1] = "@MaKH"; Values[1] = makh;
            Name[2] = "@MaNuocSD"; Values[2] = manuocsd;
            Name[3] = "@GiaTien"; Values[3] = giatien;
            return Config_DAL.Excute(sql, Name, Values, So_luong); 
        }

        public int Update_Gn(string madk, string makh, string manuocsd, string giatien)
        {
            int So_luong = 4;
            string sql = "Update_GiaNuoc";
            string[] Name = new string[So_luong];
            object[] Values = new string[So_luong];
            Name[0] = "@MaDK"; Values[0] = madk;
            Name[1] = "@MaKH"; Values[1] = makh;
            Name[2] = "@MaNuocSD"; Values[2] = manuocsd;
            Name[3] = "@GiaTien"; Values[3] = giatien;
            return Config_DAL.Excute(sql, Name, Values, So_luong);
        }

        public int Delete_GN(string a)
        {
            int So_luong = 1;
            string sql = "Delete_GiaNuoc";
            string[] Name = new string[So_luong];
            object[] Values= new object[So_luong];
            Name[0] = "@MaDK";Values[0] = a;
            return Config_DAL.Excute(sql, Name, Values, So_luong);
        }


        public DataTable Search_GN(string a)
        {



            int So_luong = 1;
            string sql = "Search_GiaNuoc";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@TuKhoa"; Values[0] = a;
            return Config_DAL.ExecuteSearch(sql, Name, Values, So_luong);
        }

        public bool KiemtraMaT(string MaT)
        {
            int So_luong = 1;
            string sql = "MaDKTrung";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MaDK"; Values[0] = MaT;
            //return con.ExecuteSearch(sql, Name, Values, So_luong);
            DataTable result = Config_DAL.ExecuteSearch(sql, Name, Values, So_luong);

            int count = Convert.ToInt32(result.Rows[0][0]);

            if (count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

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
    public  class SuaChua_DAL
    {
        Config_DAL config_DAL = new Config_DAL();
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
            Name[0] = "@MaKH"; Values[0] = a;
            return config_DAL.ExecuteSearch(sql, Name, Values, So_luong);
        }

        public DataTable ShowData()
        {
            return config_DAL.GetDataTable("Select_SuaChua");
        }

        public int Insert_SC(string masc,string makh ,string tinhtrang, DateTime ngaysc ,string manv,string trangthai)
        {

            int So_luong = 6;
            string sql = "Insert_SuaChua";
            string[] Name =new string[So_luong];
            object [] Values = new object[So_luong];
            Name[0] = "@MaSC"; Values[0]= masc;
            Name[1] = "@MaKH"; Values[1] = makh;
            Name[2] = "@TinhTrang"; Values[2] = tinhtrang;
            Name[3] = "@NgaySC"; Values[3] = ngaysc;
            Name[4] = "@MaNV"; Values[4] = manv;
            Name[5] = "@TrangThai";Values[5] = trangthai ;
          

            return config_DAL.Excute(sql, Name, Values, So_luong);
        }

        public int Update_SC(string masc, string makh, string tinhtrang, DateTime ngaysc, string manv, string trangthai)
        {


            int So_luong = 6;
            string sql = "Update_SuaChua";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MaSC"; Values[0] = masc;
            Name[1] = "@MaKH"; Values[1] = makh;
            Name[2] = "@TinhTrang"; Values[2] = tinhtrang;
            Name[3] = "@NgaySC"; Values[3] = ngaysc;
            Name[4] = "@MaNV"; Values[4] = manv;
            Name[5] = "@TrangThai"; Values[5] = trangthai;


            return config_DAL.Excute(sql, Name, Values, So_luong);

        
        }

        public int Delete_KH(string a)
        {
            int So_luong = 1;
            string sql = "Delete_SuaChua";
            string[] Name = new string[So_luong];
            object[] Values = new string[So_luong];
            Name[0] = "@MaSC"; Values[0] = a;
            return config_DAL.Excute(sql, Name, Values, So_luong);
        }

        public DataTable Search_SC(string a)
        {



            int So_luong = 1;
            string sql = "Search_SC";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@TuKhoa"; Values[0] = a;
            return config_DAL.ExecuteSearch(sql, Name, Values, So_luong);
        }

        public bool KiemtraMaT(string MaT)
        {
            int So_luong = 1;
            string sql = "MaTrungSC";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MaSC"; Values[0] = MaT;
            //return con.ExecuteSearch(sql, Name, Values, So_luong);
            DataTable result = config_DAL.ExecuteSearch(sql, Name, Values, So_luong);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class KhachHang_DAL
    {


        Config_DAL Config_DAL = new Config_DAL();

        public DataTable ShowData()
        {
            return Config_DAL.GetDataTable("Select_KhachHang");
        }

        public DataTable Search(string a)
        {
            int So_luong = 1;
            string sql = "Search_KhachHang";
            string[] Name = new string[So_luong];
            object[] Values=new object[So_luong];
            Name[0] = "@TuKhoa"; Values[0] = a;
            return Config_DAL.ExecuteSearch(sql,Name,Values,So_luong);
        }

        public bool  KiemTraMa(string MaKH)
        {
            int So_Luong = 1;
            string sql = "MaTrungKH";
            string[] Name =new string[So_Luong];
            object[] Values= new object[So_Luong];
            Name[0] = "@MaKH";Values[0] = MaKH; 

            DataTable result =Config_DAL.ExecuteSearch(sql, Name,Values,So_Luong);
            int count = Convert.ToInt32(result.Rows[0][0]);

            if(count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool KiemTraSoDT(string SoDT)
        {
            int So_Luong = 1;
            string sql = "SoDTTrungKH";
            string[] Name = new string[So_Luong];
            object[] Values = new object[So_Luong];
            Name[0] = "@SoDT"; Values[0] = SoDT;

            DataTable result = Config_DAL.ExecuteSearch(sql, Name, Values, So_Luong);
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

        public int Insert_KH(string makh,string tenkh,string diachi,string sodt, string trangthai)
        {
            int So_luong = 5;
            string sql = "Insert_KhachHang";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MaKH";   Values[0] = makh;
            Name[1] = "@TenKH";  Values[1] = tenkh;
            Name[2] = "@DiaChi"; Values[2] = diachi;
            Name[3] = "@SoDT";   Values[3] = sodt;
            Name[4] = "@TrangThai";   Values[4] = trangthai;
            return Config_DAL.Excute(sql, Name, Values, So_luong);
        }
        public int Update_KH(string makh, string tenkh, string diachi, string sodt ,string trangthai) 
        {

            int So_luong = 5;
            string sql = "Update_KhachHang";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MaKH";   Values[0] = makh;
            Name[1] = "@TenKH";  Values[1] = tenkh;
            Name[2] = "@DiaChi"; Values[2] = diachi;
            Name[3] = "@SoDT";   Values[3] = sodt;
            Name[4] = "@TrangThai"; Values[4] = trangthai;
            return Config_DAL.Excute(sql, Name, Values, So_luong);
        }

        public int Delete(string MaKH)
        {
            int So_Luong = 1;
            string sql = "Delete_KhachHang";
            string[] Name = new string[So_Luong];
            object[] Values = new object[So_Luong];
            Name[0] = "@MaKH"; Values[0] = MaKH;

           return Config_DAL.Excute(sql, Name, Values, So_Luong);
        }
        


    }
}

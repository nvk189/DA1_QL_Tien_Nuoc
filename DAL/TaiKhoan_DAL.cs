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
    public  class TaiKhoan_DAL
    {
        Config_DAL Config_DAL = new Config_DAL();

        public DataTable Select_MaNV()
        {
            return Config_DAL.GetDataTable("select_MaNV_TaiKhoan");
        }
        public bool KiemtraMaT(string MaT)
        {
            int So_luong = 1;
            string sql = "MaTrungTK";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MaNV"; Values[0] = MaT; 
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

        public bool KiemtraMK(string MaT)
        {
            int So_luong = 1;
            string sql = "MatKhauTrung";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MatKhau"; Values[0] = MaT;
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
        public DataTable ShowData()
        {
            return Config_DAL.GetDataTable("Select_TK");
        }
        public DataTable Show_TenNV(string a)
        {
            int So_luong = 1;
            string sql = "select_TenNV_TaiKhoan";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MaNV"; Values[0] = a;
            return Config_DAL.ExecuteSearch(sql, Name, Values, So_luong);
        }

        public int Insert(string maNV, string tenDN, string matKhau, string chucVu, string trangThai)
        {
            int So_luong = 5;
            string sql = "Insert_TK";
            string[] Name = new string[So_luong];
            object[] Values = new string[So_luong];
            Name[0] = "@MaNV"; Values[0] = maNV;
            Name[1] = "@TenDN"; Values[1] = tenDN;
            Name[2] = "@MatKhau"; Values[2] = matKhau;
            Name[3] = "@ChucVu"; Values[3] = chucVu;
            Name[4] = "@TrangThai"; Values[4] = trangThai;
            return Config_DAL.Excute(sql, Name, Values, So_luong);
        }

        public int Update(string maNV, string tenDN, string matKhau, string chucVu, string trangThai)
        {
            int So_luong = 5;
            string sql = "Update_TaiKhoan";
            string[] Name = new string[So_luong];
            object[] Values = new string[So_luong];
            Name[0] = "@MaNV"; Values[0] = maNV;
            Name[1] = "@TenDN"; Values[1] = tenDN;
            Name[2] = "@MatKhau"; Values[2] = matKhau;
            Name[3] = "@ChucVu"; Values[3] = chucVu;
            Name[4] = "@TrangThai"; Values[4] = trangThai;
            return Config_DAL.Excute(sql, Name, Values, So_luong);
        }

        public int Delete(string a)
        {
            int So_luong = 1;
            string sql = "Delete_TaiKhoan";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MatKhau"; Values[0] = a;
            return Config_DAL.Excute(sql, Name, Values, So_luong);
        }


        public DataTable Search(string a)
        {

            int So_luong = 1;
            string sql = "Search_TaiKhoan";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@TuKhoa"; Values[0] = a;
            return Config_DAL.ExecuteSearch(sql, Name, Values, So_luong);
        }

    }
}

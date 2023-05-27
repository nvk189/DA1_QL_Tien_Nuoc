using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DangNhap_DAL
    {
        Config_DAL Config_DAL = new Config_DAL();
        

        public bool DangNhap(string a ,string b )
        {
            int So_luong = 2;
            string sql = "select_DangNhap";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@TenDN"; Values[0] = a;
            Name[1] = "@MatKhau"; Values[1] = b;
           
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
        public DataTable Quyen(string a, string b)
        {
            int So_luong = 2;
            string sql = "Quyen";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@TenDN"; Values[0] = a;
            Name[1] = "@MatKhau"; Values[1] = b;
            return Config_DAL.ExecuteSearch(sql, Name, Values, So_luong);
        }
    }
}

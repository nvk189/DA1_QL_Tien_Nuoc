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
    public  class NhanVien_DAL
    {
       
        Config_DAL config= new Config_DAL();

        public DataTable Select_NV()
        {
            return config.GetDataTable("Select_NhanVien");
        }

        public DataTable Search_NV(string TuKhoa)
        {
            int So_luong = 1;
            string sql = "Search_NhanVien";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@TuKhoa";Values[0] = TuKhoa ;
            return config.ExecuteSearch(sql, Name, Values, So_luong);
        }


        public bool KiemtraMaT(string MaT)
        {
            int So_luong = 1;
            string sql = "MaTrungNV";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@MaNV"; Values[0] = MaT;
            //return con.ExecuteSearch(sql, Name, Values, So_luong);
            DataTable result = config.ExecuteSearch(sql, Name, Values, So_luong);

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

        public bool KiemtraSoDT(string SoDT)
        {
            int So_luong = 1;
            string sql = "SoDTTrung";
            string[] Name = new string[So_luong];
            object[] Values = new object[So_luong];
            Name[0] = "@SoDT";Values [0] = SoDT;
            DataTable a= config.ExecuteSearch(sql, Name, Values, So_luong);
            int count =Convert.ToInt32(a.Rows[0][0]);
            if(count!= 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public int Insert_NV(string maNV, string tenNV, string diaChi, string soDT, DateTime ngaySinh, string gioiTinh, string trangthai)
        {
            int so_luong = 7;
            string sql = "Insert_NhanVien";
            string[] Name = new string[so_luong];
            object[] Values = new object[so_luong];

            // xet cac gia tri cho doi tuong
            Name[0] = "@MaNV"; Values[0] = maNV;
            Name[1] = "@TenNV"; Values[1] = tenNV;
            Name[2] = "@DiaChi"; Values[2] = diaChi;
            Name[3] = "@SoDT"; Values[3] = soDT;
            Name[4] = "@NgaySinh"; Values[4] = ngaySinh;
            Name[5] = "@GioiTinh"; Values[5] = gioiTinh;
            Name[6] = "@TrangThai"; Values[6] = trangthai;

            // thao tac voi database
            return config.Excute(sql, Name, Values, so_luong);
        }

        public int Upadate_NV(string manv, string tennv, string diachi, string sodt, DateTime ngaysinh, string gioitinh ,string trangthai)
        {
            

            int so_luong = 7;
            string sql = "Update_NhanVien";
            string[] Name = new string[so_luong];
            object[] Values = new object[so_luong];

            // xet cac gia tri cho doi tuong
            Name[0] = "@MaNV"; Values[0] = manv;
            Name[1] = "@TenNV"; Values[1] = tennv;
            Name[2] = "@DiaChi"; Values[2] = diachi;
            Name[3] = "@SoDT"; Values[3] = sodt;
            Name[4] = "@NgaySinh"; Values[4] = ngaysinh;
            Name[5] = "@GioiTinh"; Values[5] = gioitinh;
            Name[6] = "@TrangThai"; Values[6] = trangthai;

            // thao tac voi database
            return config.Excute(sql, Name, Values, so_luong);

        }

        public int Delete_NV(string MaNV)
        {
            int so_luong = 1;
            string sql = "Delete_NhanVien";
            string[] Name = new string[so_luong];
            object[] Values = new object[so_luong];
            Name[0] = "@MaNV"; Values[0] = MaNV;
            return config.Excute(sql, Name, Values, so_luong);



        }

    }
}

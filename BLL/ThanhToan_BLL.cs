using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ThanhToan_BLL
    {
        ThanhToan_DAL thanhToan_DAL = new ThanhToan_DAL();



        public DataTable ShowData()
        {
            return thanhToan_DAL.Select_HD();
        }

        public DataTable Search( int b,string a )
        {
            return thanhToan_DAL.Search_TT(b,a);
        }
        public DataTable Select_MaKH()
        {
            return thanhToan_DAL.Select_MaKH();
        }
        public DataTable Select_MaNV()
        {
            return thanhToan_DAL.Select_MaNV();
        }
        public DataTable Select_KH(string a)
        {
            return thanhToan_DAL.Show_TenKH_DiaChi(a);
        }

        public DataTable Select_GiaTien(string b)
        {
            return thanhToan_DAL.Show_Giatien(b);
        }
        public DataTable Select_SoCTS(string d)
        {
            return thanhToan_DAL.Show_SoCTS(d);
        }
        public int Insert(ThanhToan_DTO tt)
        {
            double a = TongTien((float)tt.SoCTT1, (float)tt.SoCTS1, (float)tt.GiaTien1, (int)tt.Thue1);
            if (a >0)
            {
                return thanhToan_DAL.Insert_TT(tt.MaKH1, tt.MaNV1, (float)tt.SoCTT1, (float)tt.SoCTS1, (float)tt.GiaTien1, (int)tt.Thue1, tt.NgayTT1, tt.HinhThucTT1, (float)a);
            }
            else
            {
                return -1;
            }

          

        }
        public int Update(ThanhToan_DTO tt)
        {
            //double a = TongTien((float)tt.SoCTT1, (float)tt.SoCTS1, (float)tt.GiaTien1, (int)tt.Thue1);
           
                return thanhToan_DAL.Update_TT(tt.MaHD1, tt.MaKH1, tt.MaNV1, (float)tt.SoCTT1, (float)tt.SoCTS1, (float)tt.GiaTien1, (int)tt.Thue1, tt.NgayTT1, tt.HinhThucTT1, (float) tt.TongTien1);
            


        }

        public double TongTien(float a, float b, float c, int d)
        {
            double TongTien;
            TongTien=(b-a)*c + (((b - a) * c)*d/100);
            return TongTien;
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    public  class ThanhToan_DTO
    {

        protected int MaHD;
        protected string MaKH;
        protected string MaNV;
        protected float SoCTT;
        protected float SoCTS;
        protected float GiaTien;
        protected int Thue;
        protected DateTime NgayTT;
        protected string HinhThucTT;
        protected int MaCTHD;
        protected float TongTien;



     
        public ThanhToan_DTO()
        {

        }

        public ThanhToan_DTO(ThanhToan_DTO dtott)
        {
            this.MaHD = dtott.MaHD;
            this.MaKH = dtott.MaKH;
            this.MaNV = dtott.MaNV;
            this.NgayTT = dtott.NgayTT;
            this.HinhThucTT = dtott.HinhThucTT;
            this.MaCTHD = dtott.MaCTHD;
            this.SoCTT = dtott.SoCTT;
            this.SoCTS = dtott.SoCTS;
            this.GiaTien = dtott.GiaTien;
            this.Thue= dtott.Thue;
            this.TongTien = dtott.TongTien;
           

        }

        public ThanhToan_DTO(string maKH, string maNV, float soCTT, float soCTS, float giaTien, int thue, DateTime ngayTT, string hinhThucTT, float tongTien)
        {
            
            this.MaKH = maKH;
            this.MaNV = maNV;
            this.SoCTT = soCTT;
            this.SoCTS = soCTS;
            this.GiaTien = giaTien;
            this.Thue = thue;
            this.NgayTT = ngayTT;
            this.HinhThucTT = hinhThucTT;
            this.TongTien = tongTien;
        }

        public ThanhToan_DTO(int maHD, string maKH, string maNV, float soCTT, float soCTS, float giaTien, int thue, DateTime ngayTT, string hinhThucTT, float tongTien)
        {
            this.MaHD = maHD;
            this.MaKH = maKH;
            this.MaNV = maNV;
            this.SoCTT = soCTT;
            this.SoCTS = soCTS;
            this.GiaTien = giaTien;
            this.Thue = thue;
            this.NgayTT = ngayTT;
            this.HinhThucTT = hinhThucTT;
            this.TongTien = tongTien;
        }

        public int MaHD1 { get => MaHD; set => MaHD = value; }
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public float SoCTT1 { get => SoCTT; set => SoCTT = value; }
        public float SoCTS1 { get => SoCTS; set => SoCTS = value; }
        public float GiaTien1 { get => GiaTien; set => GiaTien = value; }
        public int Thue1 { get => Thue; set => Thue = value; }
        public DateTime NgayTT1 { get => NgayTT; set => NgayTT = value; }
        public string HinhThucTT1 { get => HinhThucTT; set => HinhThucTT = value; }
        public int MaCTHD1 { get => MaCTHD; set => MaCTHD = value; }

        public float TongTien1 { get => TongTien; set => TongTien = value; }
    }
}

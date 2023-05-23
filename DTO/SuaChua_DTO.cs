using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class SuaChua_DTO
    {
        protected string MaSC;
        protected string MaKH;
        protected string TinhTrang;
        protected DateTime NgaySC;
        protected string MaNV;
        protected string TrangThai;

        public string MaSC1 { get => MaSC; set => MaSC = value; }
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string TinhTrang1 { get => TinhTrang; set => TinhTrang = value; }
        public DateTime NgaySC1 { get => NgaySC; set => NgaySC = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string TrangThai1 { get => TrangThai; set => TrangThai = value; }


        public SuaChua_DTO()
        {

        }
        public SuaChua_DTO(SuaChua_DTO sc)
        {
            this.MaSC=sc.MaSC;
            this.MaKH=sc.MaKH;
            this.TinhTrang=sc.TinhTrang;
            this.NgaySC=sc.NgaySC;
            this.MaNV=sc.MaNV;
            this.TrangThai = sc.TrangThai;
        }

        public SuaChua_DTO(string maSC, string maKH, string tinhTrang, DateTime ngaySC, string maNV, string trangThai)
        {
            this.MaSC = maSC;
            this.MaKH = maKH;
            this.TinhTrang = tinhTrang;
            this.NgaySC = ngaySC;
            this.MaNV = maNV;
            this.TrangThai = trangThai;
           
        }
    }
}

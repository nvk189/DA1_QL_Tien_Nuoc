using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        protected string MaKH;
        protected string TenKH;
        protected string DiaChi;
        protected string SoDT;

        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string TenKH1 { get => TenKH; set => TenKH = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SoDT1 { get => SoDT; set => SoDT = value; }

        public KhachHang_DTO()
        {

        }

        public KhachHang_DTO(KhachHang_DTO dtonv)
        {
            this.MaKH = dtonv.MaKH;
            this.TenKH = dtonv.TenKH;
            this.DiaChi = dtonv.DiaChi;
            this.SoDT = dtonv.SoDT;
           
        }
       
        public KhachHang_DTO(string maKH, string tenKH, string diaChi, string soDT)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.DiaChi = diaChi;
            this.SoDT = soDT;
        }
    }

   
}

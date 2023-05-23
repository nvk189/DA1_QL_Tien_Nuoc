using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class NhanVien_DTO
    {
        protected string MaNV;
        protected string TenNV;
        protected string DiaChi;
        protected string SoDT;
        protected DateTime NgaySinh;
        protected string GioiTinh;

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SoDT1 { get => SoDT; set => SoDT = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }

        public NhanVien_DTO()
        {

        }

        public NhanVien_DTO(NhanVien_DTO dtonv)
        {
            this.MaNV = dtonv.MaNV;
            this.TenNV = dtonv.TenNV;
            this.DiaChi = dtonv.DiaChi;
            this.SoDT = dtonv.SoDT;
            this.NgaySinh = dtonv.NgaySinh;
            this.GioiTinh = dtonv.GioiTinh;
        }
        public NhanVien_DTO(string maNV, string tenNV, string diaChi, string soDT, DateTime ngaySinh, string gioiTinh)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.DiaChi = diaChi;
            this.SoDT = soDT;
            this.NgaySinh=ngaySinh;
            this.GioiTinh = gioiTinh;
            
        }

      
        
    }
}

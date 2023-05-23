using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class TaiKhoan_DTO
    {
        protected string MaNV;
        protected string TenDN;
        protected string MatKhau;
        protected string ChucVu;
        protected string TrangThai;

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string TenDN1 { get => TenDN; set => TenDN = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        public string ChucVu1 { get => ChucVu; set => ChucVu = value; }
        public string TrangThai1 { get => TrangThai; set => TrangThai = value; }


        public TaiKhoan_DTO()
        {

        }

        public TaiKhoan_DTO(TaiKhoan_DTO dtonv)
        {
            this.MaNV = dtonv.MaNV;
            this.TenDN = dtonv.TenDN;
            this.MatKhau = dtonv.MatKhau;
            this.ChucVu = dtonv.ChucVu;
            this.TrangThai = dtonv.TrangThai;
           
        }
        public TaiKhoan_DTO(string maNV, string tenDN, string matKhau, string chucVu, string trangThai)
        {
            this.MaNV = maNV;
            this.TenDN = tenDN;
            this.MatKhau = matKhau;
            this.ChucVu = chucVu;
            this.TrangThai = trangThai;

        }

    }
}

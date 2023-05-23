using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class GiaNuoc_DTO
    {
        protected string MaDK;
        protected string MaKH;
        protected string MaNuocSD;
        protected string GiaTien;

        public string MaDK1 { get => MaDK; set => MaDK = value; }
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string MaNuocSD1 { get => MaNuocSD; set => MaNuocSD = value; }
        public string GiaTien1 { get => GiaTien; set => GiaTien = value; }

       
        public GiaNuoc_DTO()
        {

        }
        public GiaNuoc_DTO(GiaNuoc_DTO dtotk)
        {
            this.MaDK1 = dtotk.MaDK1;
            this.MaKH1 = dtotk.MaKH1;
            this.MaNuocSD1 = dtotk.MaNuocSD1;
            this.GiaTien1 = dtotk.GiaTien1;
           
        }

        public GiaNuoc_DTO(string madk,string makh ,string manuocsd,string giatien)
        {
            this.MaDK = madk;
            this.MaKH1 = makh;
            this.MaNuocSD1 = manuocsd;
            this.GiaTien1 = giatien;
        }
    }
}

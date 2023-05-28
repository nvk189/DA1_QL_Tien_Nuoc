using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
using Utility;
using DataTable = System.Data.DataTable;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;




//using DataTable = System.Data.DataTable;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace BLL
{
    public  class NhanVien_BLL
    {
        
        NhanVien_DAL dalnv = new NhanVien_DAL();
        NhanVien_DTO dtonv= new NhanVien_DTO();
        
        public DataTable Select()
        {
            return dalnv.Select_NV();
        }
        public bool MaT(string a)
        {
            
            return dalnv.KiemtraMaT(a);
        }
        public bool SoDTT(string a)
        {
            return dalnv.KiemtraSoDT(a);
        }
        public DataTable Search_NV(string a)
        {
            return dalnv.Search_NV(a);
        }

        public int Insert( NhanVien_DTO d)
        {

            if (MaT(d.MaNV1) == false & SoDTT(d.SoDT1) ==false & Tool.CheckWhitespace(d.MaNV1)==true & Tool.CheckWhitespace(d.SoDT1)==true & Tool.CheckStringLengthint(d.SoDT1))
            {
                return dalnv.Insert_NV(d.MaNV1, Tool.Chuan_Hoa_Chuoi(d.TenNV1), Tool.Chuan_Hoa_Chuoi(d.DiaChi1), d.SoDT1, d.NgaySinh1,d.GioiTinh1,d.TrangThai1);
            }
            else
            {
                return 1;
            }

        }
        public int Update(NhanVien_DTO d)
        {
            if (  Tool.CheckWhitespace(d.SoDT1) == true & Tool.CheckStringLengthint(d.SoDT1)==true)
            {
                return dalnv.Upadate_NV(d.MaNV1, Tool.Chuan_Hoa_Chuoi(d.TenNV1), Tool.Chuan_Hoa_Chuoi(d.DiaChi1), d.SoDT1, d.NgaySinh1, d.GioiTinh1,d.TrangThai1);
            }
            else
            {
                return 1;
            }

        }
        public int Delete(string c)
        {
            return dalnv.Delete_NV(c);
        }



      

        public DataTable Excel (DataGridView dataTable)
        {
            return Tool.GetDataTableFromDataGridView(dataTable);
        }

      
    }
}

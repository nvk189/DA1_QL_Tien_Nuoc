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
using System.Windows.Forms;

namespace BLL
{
    
    public class KhachHang_BLL
        
    {

        KhachHang_DAL dal = new KhachHang_DAL();
        public DataTable ShowData()
        {
            return dal.ShowData();
        }

        public bool MaTrung(string matrung)
        {
            return dal.KiemTraMa(matrung);
        }
        public bool SoDTTrung(string sodt)
        {
            return dal.KiemTraSoDT(sodt);
        }
        public DataTable Search(string makh)
        {
            
            return dal.Search(makh);
        }

        public int Insert(KhachHang_DTO kh)
        {
            if(  MaTrung(kh.MaKH1)==false & SoDTTrung(kh.SoDT1)== false & Tool.CheckStringLengthint(kh.SoDT1)==true & Tool.CheckWhitespace(kh.SoDT1)==true)
            {
                return dal.Insert_KH(kh.MaKH1, Tool.Chuan_Hoa_Chuoi(kh.TenKH1), Tool.Chuan_Hoa_Chuoi(kh.DiaChi1), kh.SoDT1);
            }
            else
            {
                return -1;
            }
        }

        public int Update(KhachHang_DTO kh)
        {
           
            if(  Tool.CheckStringLengthint(kh.SoDT1) == true & Tool.CheckWhitespace(kh.SoDT1) == true)
            {
                return dal.Update_KH(kh.MaKH1, Tool.Chuan_Hoa_Chuoi(kh.TenKH1), Tool.Chuan_Hoa_Chuoi(kh.DiaChi1), kh.SoDT1);
            }
            else
            {
                return 0;
            }
               
       
        }

        public int Delete(string makh)
        {
            return dal.Delete(makh); 
        }

        public DataTable Excel(DataGridView dataTable)
        {
            return Tool.GetDataTableFromDataGridView(dataTable);
        }

    }
}

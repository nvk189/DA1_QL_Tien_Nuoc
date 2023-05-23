using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using Utility;

namespace BLL
{
    public  class SuaChua_BLL
    {
        SuaChua_DAL dalsc=new SuaChua_DAL();
        public DataTable Select_MaKH()
        {
            return dalsc.Select_MaKH();
        }
        public DataTable Select_MaNV()
        {
            return dalsc.Select_MaNV();
        }
        public DataTable Select_KH(string a)
        {
            return dalsc.Show_TenKH_DiaChi(a);
        }
        public DataTable ShowData()
        {
            return dalsc.ShowData();
        }
        public DataTable Search_SC(string b)
        {
            return dalsc.Search_SC(b);
        }
        public int Insert(SuaChua_DTO sc)
        {
            if( MaT(sc.MaSC1) == false & Tool.CheckWhitespace(sc.MaSC1) == true )
            {
                return dalsc.Insert_SC(sc.MaSC1, sc.MaKH1, Tool.Chuan_Hoa_Chuoi(sc.TinhTrang1), sc.NgaySC1, sc.MaNV1, sc.TrangThai1);
            }
            else
            {
                return -1;
            }
          
        }
        public int Update(SuaChua_DTO sc)
        {
          
                return dalsc.Update_SC(sc.MaSC1, sc.MaKH1,Tool.Chuan_Hoa_Chuoi( sc.TinhTrang1), sc.NgaySC1, sc.MaNV1, sc.TrangThai1);
           
        }
        public int Delete(string a)
        {

          
                return dalsc.Delete_KH(a);
           
        }

        public bool MaT(string a)
        {
            return dalsc.KiemtraMaT(a);
        }
        public DataTable Excel(DataGridView dataTable)
        {
            return Tool.GetDataTableFromDataGridView(dataTable);
        }

    }

   
}

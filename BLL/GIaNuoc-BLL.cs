using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using Utility;

namespace BLL
{
    public  class GIaNuoc_BLL
    {
        GIaNuoc_DAL dalgn = new GIaNuoc_DAL();

        public bool MaT(string a)
        {
            return dalgn.KiemtraMaT(a);
        }

        public DataTable ShowData()
        {
            return dalgn.ShowData();
        }
        public DataTable Select_MaKH()
        {
            return dalgn.Select_MaKH();

            
         
        }

        public DataTable Select_TenKH(string a)
        {
            return dalgn.Show_TenKH(a);
        }

        public int Insert(GiaNuoc_DTO gn)
        {
            if(MaT(gn.MaDK1)== false & Tool.CheckWhitespace(gn.MaDK1) == true) 
            {
                return dalgn.Insert_GN(gn.MaDK1,gn.MaKH1,gn.MaNuocSD1,gn.GiaTien1);
            }
            else
            {
                return 1;
            }
          
        }

       public int Update(GiaNuoc_DTO gn)
        {
            if(MaT(gn.MaDK1)== true & Tool.CheckWhitespace(gn.MaDK1)==true)
            {
                return dalgn.Update_Gn(gn.MaDK1, gn.MaKH1, gn.MaNuocSD1, gn.GiaTien1);
            }
            else
            {
                return 1;
            }
        }
        public int Delete(string a)
        {
            return dalgn.Delete_GN(a);
        }
        public DataTable Search_Gn(string b)
        {
            return dalgn.Search_GN(b);
        }

        public DataTable Excel(DataGridView dataTable)
        {
            return Tool.GetDataTableFromDataGridView(dataTable);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using Utility;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace BLL
{
    public class ThongKe_BLL
    {
        ThongKe_DAL thongKe_DAL = new ThongKe_DAL();

        public DataTable ShowData()
        {
            return thongKe_DAL.Showdata();
        }
        public DataTable ShowNV()
        {
            return thongKe_DAL.ShowNV();
        }
        public DataTable Search(DateTime a)
        {
            return thongKe_DAL.Searchdt(a);
        }
        public DataTable Search1(DateTime s)
        {
            return thongKe_DAL.Searchdt1(s);
        }
        public DataTable Search1(int a)
        {
            return thongKe_DAL.Searchdt1(a);
        }

        public DataTable SearchMY(int b)
        {
            return  thongKe_DAL.SearchMY(b);
        }

        public DataTable TK_MaKH(string d)
        {
            return thongKe_DAL.TK_MaKH(d);
        }

        public DataTable Excel(DataGridView dataTable)
        {
            return Tool.GetDataTableFromDataGridView(dataTable);
        }

    }
}

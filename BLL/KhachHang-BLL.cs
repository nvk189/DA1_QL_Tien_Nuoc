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
using Microsoft.Office.Interop.Excel;


using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using Application = Microsoft.Office.Interop.Excel.Application;

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
                return dal.Insert_KH(kh.MaKH1, Tool.Chuan_Hoa_Chuoi(kh.TenKH1), Tool.Chuan_Hoa_Chuoi(kh.DiaChi1), kh.SoDT1,kh.TrangThai1);
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
                return dal.Update_KH(kh.MaKH1, Tool.Chuan_Hoa_Chuoi(kh.TenKH1), Tool.Chuan_Hoa_Chuoi(kh.DiaChi1), kh.SoDT1,kh.TrangThai1);
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



        //public void ExportToExcel(DataTable dataTable, string filePath)
        //{
        //    Application oExcel = new Application();
        //    oExcel.Visible = true;
        //    oExcel.DisplayAlerts = false;

        //    Workbook oBook = oExcel.Workbooks.Add(Type.Missing);
        //    Sheets oSheets = oBook.Worksheets;
        //    Worksheet oSheet = (Worksheet)oSheets.get_Item(1);

        //    int rowCount = 2;
        //    int colCount = 1;
        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        colCount = 1;
        //        foreach (var item in row.ItemArray)
        //        {
        //            oSheet.Cells[1, 1] = "Mã khách hàng";
        //            oSheet.Cells[1, 2] = "Họ và tên";
        //            oSheet.Cells[1, 3] = "Địa chỉ";
        //            oSheet.Cells[1, 4] = "Số điện thoại";

        //            oSheet.Cells[rowCount, colCount] = item.ToString();
        //            colCount++;
        //        }
        //        rowCount++;
        //    }

        //    oBook.SaveAs(filePath);
        //    oBook.Close();
        //    oExcel.Quit();
        //}
    }
}

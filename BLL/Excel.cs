using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using   Excel=Microsoft.Office.Interop.Excel;


namespace BLL
{
    public class Excel
    {


        public void ExportToExcel(DataTable dataTable, string filePath)
        {

            
             Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;

            // Tạo Workbook mới
            Microsoft.Office.Interop.Excel.Workbook oBook = oExcel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Sheets oSheets = oBook.Worksheets;
            Microsoft.Office.Interop.Excel.Worksheet oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
           

            // Ghi dữ liệu từ DataTable vào Worksheet
            int rowCount = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                for (int i = 1; i <= dataTable.Columns.Count; i++)
                {
                    oSheet.Cells[rowCount, i] = row[i - 1].ToString();
                }
                rowCount++;
            }

            // Lưu Workbook ra file Excel
            oBook.SaveAs(filePath);
            oBook.Close();
            oExcel.Quit();
            
        }
    }
}

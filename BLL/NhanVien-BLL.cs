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
                return dalnv.Insert_NV(d.MaNV1, Tool.Chuan_Hoa_Chuoi(d.TenNV1), Tool.Chuan_Hoa_Chuoi(d.DiaChi1), d.SoDT1, d.NgaySinh1, d.GioiTinh1);
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
                return dalnv.Upadate_NV(d.MaNV1, Tool.Chuan_Hoa_Chuoi(d.TenNV1), Tool.Chuan_Hoa_Chuoi(d.DiaChi1), d.SoDT1, d.NgaySinh1, d.GioiTinh1);
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



        // xuất Excel
       
        //public DataTable GetDataTableFromDataGridView(DataGridView dataGridView)
        //{
        //    DataTable dataTable = new DataTable();

        //    // Tạo cột trong DataTable từ các cột trong DataGridView
        //    foreach (DataGridViewColumn column in dataGridView.Columns)
        //    {
        //        dataTable.Columns.Add(column.HeaderText);
        //    }

        //    // Thêm dữ liệu từ DataGridView vào DataTable
        //    foreach (DataGridViewRow row in dataGridView.Rows)
        //    {
        //        DataRow dataRow = dataTable.NewRow();
        //        for (int i = 0; i < dataGridView.Columns.Count; i++)
        //        {
        //            dataRow[i] = row.Cells[i].Value;
        //        }
        //        dataTable.Rows.Add(dataRow);
        //    }

        //    return dataTable;
        //}

        public DataTable Excel (DataGridView dataTable)
        {
            return Tool.GetDataTableFromDataGridView(dataTable);
        }


    }
}

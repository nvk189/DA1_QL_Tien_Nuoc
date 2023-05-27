using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ThanhToan_BLL
    {
        ThanhToan_DAL thanhToan_DAL = new ThanhToan_DAL();



        public DataTable ShowData()
        {
            return thanhToan_DAL.Select_HD();
        }
      
        public DataTable Search(int b, string a)
        {
            return thanhToan_DAL.Search_TT(b, a);
        }
        public DataTable Select_MaKH()
        {
            return thanhToan_DAL.Select_MaKH();
        }
        public DataTable Select_MaNV()
        {
            return thanhToan_DAL.Select_MaNV();
        }
        public DataTable Select_KH(string a)
        {
            return thanhToan_DAL.Show_TenKH_DiaChi(a);
        }

        public DataTable Select_GiaTien(string b)
        {
            return thanhToan_DAL.Show_Giatien(b);
        }
        public DataTable Select_SoCTS(string d)
        {
            return thanhToan_DAL.Show_SoCTS(d);
        }
        public int Insert(ThanhToan_DTO tt)
        {
            float a = TongTien((float)tt.SoCTT1, (float)tt.SoCTS1, (float)tt.GiaTien1, (int)tt.Thue1);
            if (a >0 & (float)tt.SoCTS1 > (float)tt.SoCTT1)
            {
                return thanhToan_DAL.Insert_TT(tt.MaKH1, tt.MaNV1, (float)tt.SoCTT1, (float)tt.SoCTS1, (float)tt.GiaTien1, (int)tt.Thue1, tt.NgayTT1, tt.HinhThucTT1, a);
            }
            else
            {
                return -1;
            }



        }
        public int Update(ThanhToan_DTO tt)
        {
            float a = TongTien((float)tt.SoCTT1, (float)tt.SoCTS1, (float)tt.GiaTien1, (int)tt.Thue1);

            if (a >0 & (float)tt.SoCTS1 > (float)tt.SoCTT1)
            {
                return thanhToan_DAL.Update_TT(tt.MaHD1, tt.MaKH1, tt.MaNV1, (float)tt.SoCTT1, (float)tt.SoCTS1, (float)tt.GiaTien1, (int)tt.Thue1, tt.NgayTT1, tt.HinhThucTT1, a);
            }
            else
            {
                return 0;
            }
            

           



        }

        public float TongTien(float a, float b, float c, int d)
        {
            float TongTien;
            TongTien = (b - a) * c + (((b - a) * c) * d / 100);
            return TongTien;
        }

        public int Delete_HD(int a)
        {
            return thanhToan_DAL.Delete(a);
        }

        public void ExportInvoiceToNotepad(int maHD, string maKH, string tenkh, string diachi, string maNV, float soCTT, float soCTS, float soSD, float giaTien, int thue, DateTime ngayTT, string hinhThucTT, float tongTien)
        {
            // Tạo nội dung hóa đơn
            string invoiceContent = $"\t\tCÔNG TY NƯỚC SẠCH NGỌC TUẤN\n" +
            $"\tĐịa chỉ thị chấn Lương Bằng -Kim Động -Hưng Yên \n" +
            $"\tHotline: 01234567\r\n";

            invoiceContent += $"\n Hóa Đơn thanh toán tiền nước Ngọc Tuấn \r\n";            
            invoiceContent += $"\n";
            invoiceContent += $"Thông tin hóa đơn \n";
            invoiceContent += $"Mã HD:               {maHD}\r\n";
            invoiceContent += $"Mã KH:               {maKH}\r\n";
            invoiceContent += $"Họ và tên:           {tenkh}\r\n";
            invoiceContent += $"Địa Chỉ:             {diachi}\r\n";
            invoiceContent += $"Mã NV:               {maNV}\r\n";
            invoiceContent += $"Số cũ:               {soCTT}\r\n";
            invoiceContent += $"Số mới:              {soCTS}\r\n";
            invoiceContent += $"Số sử dụng:          {soSD}\r\n";
            invoiceContent += $"Giá tiền:            {giaTien}đ\r\n";
            invoiceContent += $"Thuế:                {thue}%\r\n";
            invoiceContent += $"Ngày thanh toán:     {ngayTT.ToShortDateString()}\r\n";
            invoiceContent += $"Hình thức thanh toán: {hinhThucTT}\r\n";
            invoiceContent += $"_____________________________________________________________\r\n";
            invoiceContent += $"Tổng :        {tongTien}đ\r\n";
            invoiceContent += $"\n \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t Ký Tên\r\n";

            // Lưu hóa đơn vào file Notepad
            string filePath = "ThanhToan.txt";
            File.WriteAllText(filePath, invoiceContent);

            // Mở file Notepad để hiển thị hóa đơn
            Process.Start("notepad.exe", filePath);
        }




    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using Utility;

namespace BLL
{
    public  class TaiKhoan_BLL
    {

        TaiKhoan_DAL daltk = new TaiKhoan_DAL();


        public bool MaT(string a)
        {
            return daltk.KiemtraMaT(a);
        }
        public bool KiemTraMK(string b)
        {
            return daltk.KiemtraMK(b);
        }
        public DataTable ShowData()
        {
            return daltk.ShowData();
        }
        public DataTable Select_MaNV()
        {
            return daltk.Select_MaNV();
        }

        public DataTable Select_TenNV(string a)
        {
            return daltk.Show_TenNV(a);
        }

        public int Insert(TaiKhoan_DTO tk)
        {
            if(KiemTraMK(tk.MatKhau1)==false & MaT(tk.MaNV1)== false & Tool.CheckStringLength(tk.MatKhau1)==true & Tool.CheckFirstCharacter(tk.TenDN1)==true & Tool.CheckWhitespace(tk.MatKhau1)==true & Tool.CheckWhitespace(tk.TenDN1)==true)
            {
                return daltk.Insert(tk.MaNV1,tk.TenDN1,tk.MatKhau1,tk.ChucVu1,tk.TrangThai1);
            }
            else
            {
                return 1;
            }
           
        }

        public int Update(TaiKhoan_DTO tk)
        {
            if (MaT(tk.MaNV1) == true  &Tool.CheckStringLength(tk.MatKhau1) == true & Tool.CheckFirstCharacter(tk.TenDN1) == true & Tool.CheckWhitespace(tk.MatKhau1) == true & Tool.CheckWhitespace(tk.TenDN1) == true & Tool.CheckStringLength(tk.TenDN1)==true)
            {
                return daltk.Update(tk.MaNV1, tk.TenDN1, tk.MatKhau1, tk.ChucVu1, tk.TrangThai1);
            }
            else
            {
                return 1;
            }
          
        }
        public int Delete(string a)
        {
            //if (MaT(a) == true)
            //{
            //    return daltk.Delete(a);
            //}
            //else
            //{
            //    return -1;
            //}
            return daltk.Delete(a);
        }
        public DataTable Search_Gn(string b)
        {
            return daltk.Search(b);
        }
    }
}

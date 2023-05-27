 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class DangNhap_BLL
    {
        DangNhap_DAL blldn=new DangNhap_DAL();

        public bool DangNhap(string a, string b)
        {

            return blldn.DangNhap(a, b );
        }
        public DataTable Quyen(string a, string b)
        {
            return blldn.Quyen(a, b);
        }
    }
}

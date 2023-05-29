using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BLL;
using DTO;

namespace TestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPassword1()
            
        {
            DangNhap_BLL dn = new DangNhap_BLL();
            string a = "admin23";
            string b = "_admin231";
            Assert.IsTrue(dn.DangNhap(a, b)); // nhập đúng tài khoản mật khẩu
            

        }


        [TestMethod]
        public void TestPassword2()

        {
            DangNhap_BLL dn = new DangNhap_BLL();
            string a = "admin234";
            string b = "_admin2";
            Assert.IsTrue(dn.DangNhap(a, b)); // nhập sai  tài khoản mật  khẩu


        }

        [TestMethod]
        public void TestPassword3()

        {
            DangNhap_BLL dn = new DangNhap_BLL();
            string a = "";
            string b = "";
            Assert.IsTrue(dn.DangNhap(a, b)); // nhập ko nhập


        }


        [TestMethod]
        public void TestTongTien1()

        {
            ThanhToan_BLL dn = new ThanhToan_BLL();
            double d = 120;
            double e;
             e = dn.TongTien(6, 7, 8, 9); // Nhập hết các trường
            Assert.AreEqual(d, e);




        }
        [TestMethod]
        public void TestTongTien2()

        {
            ThanhToan_BLL dn = new ThanhToan_BLL();
            double d = 120;
            double e;
            e = dn.TongTien(6, 7, 8, -5);      // 1 trường chứa dữ liệu âm
            Assert.AreEqual(d, e);




        }

        [TestMethod]
        public void TestTongTien3()

        {
            ThanhToan_BLL dn = new ThanhToan_BLL();
            double d = 120;
            double e;
            e = dn.TongTien(6, 7, 8, 0); // 1 trường chứa dữ liệu 0
            Assert.AreEqual(d, e);




        }

        [TestMethod]
        public void TestTongTien4()

        {
            ThanhToan_BLL dn = new ThanhToan_BLL();
            double d = 52500;
            double e;
            e = dn.TongTien(5, 10,10000 , 5); //  nhập đúng 
            Assert.AreEqual(d, e);




        }



        [TestMethod]
        public void TestMaTrung1()

        {

            NhanVien_BLL nv = new NhanVien_BLL();
            string a = "";

            Assert.IsTrue(nv.MaT(a)); // nhập ko nhập // nhập ko nhập


        }

        [TestMethod]
        public void TestMaTrung2()

        {
            NhanVien_BLL nv = new NhanVien_BLL();
            string a = "ávccc";
           
            Assert.IsTrue(nv.MaT(a)); // nhập sai 


        }



        [TestMethod]
        public void TestMaTrung3()

        {
            NhanVien_BLL nv = new NhanVien_BLL();
            string a = "NV01";

            Assert.IsTrue(nv.MaT(a)); // nhập đúng 


        }



        [TestMethod]
        public void TestThemKhachHang()

        { KhachHang_DTO dt = new KhachHang_DTO();
            KhachHang_BLL nv = new KhachHang_BLL();
            string a= "a";
            string b= "b";
            string c= "c";
            string d ="d";
            string e ="e";
           

            Assert.AreEqual(1,nv.Insert( new  KhachHang_DTO( a,b,c,d,e))); // nhập đúng 


        }
    }
}

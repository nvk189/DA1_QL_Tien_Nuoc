using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;


namespace GUI
{
    
    public partial class frm_DangNhap : Form
    {
        TaiKhoan_DTO dtotk = new TaiKhoan_DTO();
        DangNhap_BLL blldn=new DangNhap_BLL();
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        public void DangNhap()
        {
            dtotk.TenDN1 = txtTenDN.Text;
            dtotk.MatKhau1 = txtMatKhau.Text;
           
            if (blldn.DangNhap(dtotk.TenDN1, dtotk.MatKhau1) == true)
            {
                frm_TrangChu tc = new frm_TrangChu();
                tc.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
        public void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();


        }

        private void ckMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
               
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
                
        }

       
    }
}

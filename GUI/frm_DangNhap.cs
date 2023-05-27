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
            DataTable data= blldn.Quyen(txtTenDN.Text, txtMatKhau.Text);
            string a = data.ToString();

            if (blldn.DangNhap(dtotk.TenDN1, dtotk.MatKhau1) == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                frm_TrangChu tc = new frm_TrangChu(a);
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
       

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMatKhau_CheckedChanged(object sender, EventArgs e)
        {

            if (cbMatKhau.Checked)
                txtMatKhau.UseSystemPasswordChar = false;
            else
                txtMatKhau.UseSystemPasswordChar = true;
        }
    }
}

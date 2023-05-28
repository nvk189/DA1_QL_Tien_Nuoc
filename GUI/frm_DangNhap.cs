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
            txtMatKhau.UseSystemPasswordChar = false;
        }
       
        public string a;
        public void DangNhap()
        {
            dtotk.TenDN1 = txtTenDN.Text;
            dtotk.MatKhau1 = txtMatKhau.Text;
            DataTable data = blldn.Quyen(txtTenDN.Text, txtMatKhau.Text);
            if (data.Rows.Count > 0)
            {
                a = data.Rows[0]["ChucVu"].ToString(); 
            }
            else
            {
                a = string.Empty; // Không có dữ liệu trả về, gán giá trị rỗng cho "a"
            }

            if (blldn.DangNhap(dtotk.TenDN1, dtotk.MatKhau1))
            {
                MessageBox.Show("Đăng nhập thành công");
                frm_TrangChu tc = new frm_TrangChu(a);
                tc.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, Tài khoản hoặc mật khẩu không đúng");
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

        private void txtMatKhau_IconRightClick(object sender, EventArgs e)
        {
           
            txtMatKhau.UseSystemPasswordChar = !txtMatKhau.UseSystemPasswordChar;
            txtMatKhau.IconRight = txtMatKhau.UseSystemPasswordChar
                ? Properties.Resources._8674983_ic_fluent_eye_hide_regular_icon
                : Properties.Resources._3844476_eye_see_show_view_watch_icon;
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked)
                txtMatKhau.UseSystemPasswordChar = false;
            else
                txtMatKhau.UseSystemPasswordChar = true;
          
        }
    }
}

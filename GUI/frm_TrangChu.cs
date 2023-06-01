using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_TrangChu : Form
    {
        private string quyen1;

        public frm_TrangChu(string a)
        {
            quyen1= a;
            InitializeComponent();
            quyen();
        }

        public void quyen()
        {
            txtQuyen.Text = quyen1;
            if (txtQuyen.Text == "admin")
            {

                btnTaiKhoan.Enabled = true;
                btnThongKe.Enabled = true;
                btnNhanVien.Enabled = true;
                btnGiaNuoc.Enabled = true;
                btnKhachhang.Enabled = true;
                btnThanhToan.Enabled = true;
                btnQLSuaChua.Enabled = true;

            }

            else if (txtQuyen.Text == "user_1")
            {
                btnTaiKhoan.Enabled = false;
                btnThongKe.Enabled = true;
                btnNhanVien.Enabled = false;
                btnGiaNuoc.Enabled = true;
                btnKhachhang.Enabled = true;
                btnThanhToan.Enabled = true;
                btnQLSuaChua.Enabled = true;
            }
            else
            {
                btnTaiKhoan.Enabled = false;
                btnThongKe.Enabled = false;
                btnNhanVien.Enabled = false;
                btnGiaNuoc.Enabled = false;

            }
        }

        private Form currrentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currrentFormChild != null)
            {
                currrentFormChild.Close();
            }
            currrentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle=FormBorderStyle.None;
            childForm.Dock=DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_KhachHang());
            lblTrangChu.Text = btnKhachhang.Text;
           
          
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_NhanVien());
            lblTrangChu.Text = btnNhanVien.Text;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_TaiKhoan());
            lblTrangChu.Text = btnTaiKhoan.Text;
        }

        private void btnQLSuaChua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_SuaChua());
            lblTrangChu.Text = btnQLSuaChua.Text;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ThanhToan());
            lblTrangChu.Text = btnThanhToan.Text;
        }

        private void btnGiaNuoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_GiaNuoc());
            lblTrangChu.Text = btnGiaNuoc.Text;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ThongKe());
            lblTrangChu.Text = btnThongKe.Text;
        }

        private void ptHome_Click(object sender, EventArgs e)
        {
            if(currrentFormChild != null)
            {
                currrentFormChild.Close();
            }
            lblTrangChu.Text = "TRANG CHỦ";
        }

        private void ptExit_Click(object sender, EventArgs e)
        {
            Application.Exit();



        }
    }
}

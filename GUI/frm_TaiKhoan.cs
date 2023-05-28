using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_TaiKhoan : Form
    {
        TaiKhoan_BLL blltk = new TaiKhoan_BLL();
      
        TaiKhoan_DTO dtotk = new TaiKhoan_DTO();


        public frm_TaiKhoan()
        {
            InitializeComponent();
        }

        public void ShowData()
        {
            dgvTaiKhoan.DataSource = blltk.ShowData();
        }
        public void ShowMaNV()
        {
            DataTable data = blltk.Select_MaNV();
            cboMaNVTK.DataSource = data;
            cboMaNVTK.DisplayMember = "MaNV";
            cboMaNVTK.ValueMember = "MaNV";

        }

        private void cboMaNVTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TenNV = cboMaNVTK.SelectedValue.ToString();
            DataTable data = blltk.Select_TenNV(TenNV);
            if (data.Rows.Count > 0)
            {
                txtTenNVTK.Text = data.Rows[0][0].ToString();
            }
            else
            {
                txtTenNVTK.Text = "";
            }
        }

        public void Reset()
        {
            txtTenDN.Clear();
            txtTenNVTK.Clear();
            txtMatKhau.Clear();
            cboQuyen.SelectedIndex = -1;
            cbTrangThai.SelectedIndex = -1;
            txtSearchTK.Clear();
            //cboMaNVTK.SelectedIndex = -1;
            ShowData();
        }

        private void frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            ShowMaNV();
            ShowData();
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang=e.RowIndex;
            cboMaNVTK.Text = dgvTaiKhoan[0, hang].Value.ToString();
            txtTenDN.Text = dgvTaiKhoan[1, hang].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan[2, hang].Value.ToString();
            cboQuyen.Text = dgvTaiKhoan[3, hang].Value.ToString();
            cbTrangThai.Text = dgvTaiKhoan[4,hang].Value.ToString();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDN.Text == "" || txtMatKhau.Text == "" || cboQuyen.Text == "" || cbTrangThai.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn thêm thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //dtotk.MaNV1 = cboMaNVTK.Text;
                        //dtotk.TenDN1 = txtTenDN.Text;
                        //dtotk.MatKhau1 = txtMatKhau.Text;
                        //dtotk.ChucVu1 = cboQuyen.Text;
                        //dtotk.TrangThai1 = cbTrangThai.Text;

                        //if (blltk.MaT(dtotk.MaNV1) == true)
                        //{
                        //    MessageBox.Show("Mã nhân viên đã tồn tại ");
                        //}
                        //else
                        //{
                        //    blltk.Insert(dtotk);
                        //    MessageBox.Show("Thêm thành công");
                        //    Reset();
                        //}


                        int var = blltk.Insert(new TaiKhoan_DTO(cboMaNVTK.Text, txtTenDN.Text, txtMatKhau.Text, cboQuyen.Text, cbTrangThai.Text));
                        if (var == 1)
                        {
                            MessageBox.Show("Thêm thất bại, mã nhân viên tồn tại hoặc mật khẩu tồn tại  ,Mật khẩu, tên đăng nhập  số  ký tự >6 và  không chứa khoảng trắng , Tên dăng nhập bắt đầu bằng _ hoặc a-z hoặc A-Z ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //MessageBox.Show("Thêm dữ liệu  thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                          
                        }
                        else
                        {
                            MessageBox.Show("Thêm dữ liệu  thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //MessageBox.Show("Thêm thất bại, mã nhân viên tồn tại hoặc mật khẩu tồn tại  ,Mật khẩu, tên đăng nhập  số  ký tự >6 và  không chứa khoảng trắng , Tên dăng nhập bắt đầu bằng _ hoặc a-z hoặc A-Z " , "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        ShowData();
                       
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDN.Text == "" || txtMatKhau.Text == "" || cboQuyen.Text == "" || cbTrangThai.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //dtotk.MaNV1 = cboMaNVTK.Text;
                        //dtotk.TenDN1 = txtTenDN.Text;
                        //dtotk.MatKhau1 = txtMatKhau.Text;
                        //dtotk.ChucVu1 = cboQuyen.Text;
                        //dtotk.TrangThai1 = cbTrangThai.Text;
                        //blltk.Update(dtotk);
                        //MessageBox.Show("Sửa thành công");
                        //Reset();

                        int var = blltk.Update(new TaiKhoan_DTO(cboMaNVTK.Text, txtTenDN.Text, txtMatKhau.Text, cboQuyen.Text, cbTrangThai.Text));
                        if (var == 1)
                        {
                            MessageBox.Show("Sửa thất bại ,Mật khẩu, tên đăng nhập  số  ký tự >6 và  không chứa khoảng trắng , Tên dăng nhập bắt đầu bằng _ hoặc a-z hoặc A-Z", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //MessageBox.Show("Sửa dữ liệu  thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           
                        }
                        else
                        {
                            MessageBox.Show("Sửa dữ liệu  thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //MessageBox.Show("Sửa thất bại ,Mật khẩu, tên đăng nhập  số  ký tự >6 và  không chứa khoảng trắng , Tên dăng nhập bắt đầu bằng _ hoặc a-z hoặc A-Z", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        ShowData();
                        
                        
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "" || txtMatKhau.Text == "" || cboQuyen.Text == "" || cbTrangThai.Text == "")
            {
                MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn Xóa thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //dtotk.MatKhau1 = txtMatKhau.Text;
                    //blltk.Delete(dtotk.MatKhau1);
                    //MessageBox.Show("Xóa thành công");
                    //Reset();
                    blltk.Delete(txtMatKhau.Text);
                    MessageBox.Show("Xóa thành công");
                    ShowData();
                    Reset();
                }
            }
        }

        private void btnResetTK_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ptSearchTK_Click(object sender, EventArgs e)
        {

            //if (txtSearchTK.Text == "")
            //{
            //    MessageBox.Show("Nhập thông tin tìm kiếm");
            //}
            //else
            //{
            //    dtotk.MaNV1 = txtSearchTK.Text;
            //    dtotk.ChucVu1 = txtSearchTK.Text;
            //    dtotk.TrangThai1 = txtSearchTK.Text;


            //    dgvTaiKhoan.DataSource = blltk.Search_Gn(dtotk.MaNV1);
            //    dgvTaiKhoan.DataSource = blltk.Search_Gn(dtotk.ChucVu1);
            //    dgvTaiKhoan.DataSource = blltk.Search_Gn(dtotk.TrangThai1);


            //    cboMaNVTK.Text = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            //    txtTenDN.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString();
            //    txtMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString();
            //    cboQuyen.Text = dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString();
            //    cbTrangThai.Text = dgvTaiKhoan.CurrentRow.Cells[4].Value.ToString();
            //}

            if (string.IsNullOrWhiteSpace(txtSearchTK.Text))
            {
                MessageBox.Show("Nhập thông tin tìm kiếm");
            }
            else
            {


                DataTable data = blltk.Search_Gn(txtSearchTK.Text);



                if (data != null && data.Rows.Count > 0)
                {
                    dgvTaiKhoan.DataSource = data;

                    cboMaNVTK.Text = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString();
                    txtTenDN.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString();
                    txtMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString();
                    cboQuyen.Text = dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString();
                    cbTrangThai.Text = dgvTaiKhoan.CurrentRow.Cells[4].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Thông tin tìm kiếm không tồn tại");
                }
            }


        }
    }
}

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


using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace GUI
{
    public partial class frm_NhanVien : Form
    {
        NhanVien_BLL bllnv = new NhanVien_BLL();
        NhanVien_DTO dtonv = new NhanVien_DTO();
        private Excel excel;

        public DataTable Datagriview()
        {
            return bllnv.Excel(dgvNhanVien);
        }
        

       


        public frm_NhanVien()
        {
            InitializeComponent();
            excel = new Excel();
        }

        public void LoadData()
        {
            dgvNhanVien.DataSource = bllnv.Select();
        }
        public void Reset()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDiaChiNV.Text = "";
            txtSoDTNV.Text = "";
            dtNgaySinhNV.Text = "";
            cbGioiTinhNV.SelectedIndex = -1;
            LoadData();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void ptSearchNV_Click(object sender, EventArgs e)
        {
            dtonv.MaNV1 = txtSearchNV.Text;
            dgvNhanVien.DataSource = bllnv.Search_NV(dtonv.MaNV1);

            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtDiaChiNV.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtSoDTNV.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            dtNgaySinhNV.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            cbGioiTinhNV.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChiNV.Text == "" || txtSoDTNV.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Thêm thông tin khách hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        



                        try
                        {
                            int var = bllnv.Insert(new NhanVien_DTO(txtMaNV.Text, txtTenNV.Text, txtDiaChiNV.Text, txtSoDTNV.Text, dtNgaySinhNV.Value.Date, cbGioiTinhNV.Text));

                            if (var == 1)
                            {
                                MessageBox.Show("Thêm thất bại, xem lại mã hoặc số điện thoại đã tồn tại , mã và số điện thoại không  có khoảng trắng ,số điện thoại gồm 10 ký tự", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                //MessageBox.Show("Thêm dữ liệu  thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            else
                            {
                                MessageBox.Show("Thêm dữ liệu  thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                //MessageBox.Show("Thêm thất bại, xem lại mã hoặc số điện thoại đã tồn tại , mã và số điện thaoị không có khoảng trắng ,số điện thoại gồm 10 ký tự", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            LoadData();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaNV.Text = dgvNhanVien[0, hang].Value.ToString();
            txtTenNV.Text = dgvNhanVien[1, hang].Value.ToString();
            txtDiaChiNV.Text = dgvNhanVien[2, hang].Value.ToString();
            txtSoDTNV.Text = dgvNhanVien[3, hang].Value.ToString();
            dtNgaySinhNV.Text = dgvNhanVien[4, hang].Value.ToString();
            cbGioiTinhNV.Text = dgvNhanVien[5, hang].Value.ToString();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChiNV.Text == "" || txtSoDTNV.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Sửa thông tin khách hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        


                        int var = bllnv.Update(new NhanVien_DTO(txtMaNV.Text, txtTenNV.Text, txtDiaChiNV.Text, txtSoDTNV.Text, dtNgaySinhNV.Value.Date, cbGioiTinhNV.Text));

                        if (var == 1)
                        {
                            MessageBox.Show("Sửa thất bại, xem lại mã hoặc số điện thoại đã tồn tại , mã và số điện thoại không có khoảng trắng ,số điện thoại gồm 10 ký tự", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //MessageBox.Show("Sủa dữ liệu  thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {
                            MessageBox.Show("Sủa dữ liệu  thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //MessageBox.Show("Sửa thất bại, xem lại mã hoặc số điện thoại đã tồn tại , mã và số điện thaoị không có khoảng trắng ,số điện thoại gồm 10 ký tự", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        Reset();


                    }
                }
            }
            catch
            {
                MessageBox.Show("Không sửa được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChiNV.Text == "" || txtSoDTNV.Text == "")
            {
                MessageBox.Show("Chọn thong tin cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    bllnv.Delete(txtMaNV.Text);
                    MessageBox.Show("Xóa thành công");
                    Reset();
                }
            }

        }

        private void btnResetNV_Click(object sender, EventArgs e)
        {
            Reset();
        }


        
        
        private void btnExcelNV_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                DataTable dataTable = Datagriview();
                //DataTable dataTable = GetDataTableFromDataGridView(dgvNhanVien);
                excel.ExportToExcel(dataTable, filePath);
                MessageBox.Show("Dữ liệu đã được xuất ra file Excel.");
            }
        }
        
    }
}

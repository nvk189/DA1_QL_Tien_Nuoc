using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Drawing.Drawing2D;


namespace GUI
{

    public partial class frm_KhachHang : Form
    {

        KhachHang_DTO dtokh = new KhachHang_DTO();
        KhachHang_BLL bllkh = new KhachHang_BLL();
        private Excel excel;
       
        public frm_KhachHang()
        {
            InitializeComponent();
            excel = new Excel();


        }
        public DataTable Datagriview()
        {
            return bllkh.Excel(dgvKhachHang);
        }
        public void LoadData()
        {
            dgvKhachHang.DataSource = bllkh.ShowData();
        }

       
        private void Reset()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
            txtSearchKH.Clear();
            this.LoadData();
        }
        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            LoadData();



        }
        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaKH.Text = dgvKhachHang[0, hang].Value.ToString();
            txtTenKH.Text = dgvKhachHang[1, hang].Value.ToString();
            txtDiaChi.Text = dgvKhachHang[2, hang].Value.ToString();
            txtSoDT.Text = dgvKhachHang[3, hang].Value.ToString();


        }



        private void btnThemKH_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtDiaChi.Text == "" || txtSoDT.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Thêm thông tin khách hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {



                        int var = bllkh.Insert(new KhachHang_DTO(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSoDT.Text));

                       
                        if (var == -1)
                        {
                            MessageBox.Show("Thêm thất bại,mã hoặc số điện thoại đã tồn tại, số điện thoại gồm 10 số ,mã , số điện thoại không chứa khoảng trắng ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //MessageBox.Show("Thêm dữ liệu  thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {
                            MessageBox.Show("Thêm dữ liệu  thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //MessageBox.Show("Thêm thất bại,mã hoặc số điện thoại đã tồn tại, số điện thoại gồm 10 số ,mã , số điện thoại không chứa khoảng trắng ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        LoadData();
                    }

                }
            }
            catch
            {
                MessageBox.Show(" Lỗi hệ thống ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
          

        }

        private void btnResetKH_Click(object sender, EventArgs e)
        {
           
            Reset();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {



         
            try
            {
                if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtDiaChi.Text == "" || txtSoDT.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Sửa thông tin khách hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int var=bllkh.Update(new KhachHang_DTO(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSoDT.Text));
                        if(var == 0)
                        {
                            MessageBox.Show("Sửa dữ liệu  thất bại, hãy kiểm tra lại, số điện thoại đã tồn tại ,  số điện thoại gồm 10 số ,mã , số điện thoại không chứa khoảng trắng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //MessageBox.Show("Sửa dữ liệu  thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Sửa dữ liệu  thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //MessageBox.Show("Sửa dữ liệu  thất bại, hãy kiểm tra lại,  số điện thoại gồm 10 số ,mã , số điện thoại không chứa khoảng trắng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        LoadData();

                    }

                   
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Không sửa được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtDiaChi.Text == "" || txtSoDT.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    bllkh.Delete(txtMaKH.Text);
                    MessageBox.Show("Xóa thành công");
                    Reset();
                }
            }
        }


        
        private void ptSearchKH_Click(object sender, EventArgs e)
        {
            
           
            dgvKhachHang.DataSource = bllkh.Search(txtSearchKH.Text);
          


            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtSoDT.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnExcelKKH_Click(object sender, EventArgs e)
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

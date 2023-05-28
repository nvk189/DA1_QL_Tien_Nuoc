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
using BLL;
using DTO;
namespace GUI
{
    public partial class frm_SuaChua : Form
    {

        SuaChua_BLL bllsc = new SuaChua_BLL();
        SuaChua_DTO dtosc = new SuaChua_DTO();
        private Excel excel;
        public frm_SuaChua()
        {
            InitializeComponent();
            excel = new Excel();
        }
        public DataTable Datagriview()
        {
            return bllsc.Excel(dgvSuaChua);
        }


        public void Reset()
        {
            txtMaSC.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtTinhTrang.Clear();
            dtSuaChua.DataBindings.Clear();
            cboTrangThai.SelectedIndex = -1;
            txtSearchSC.Clear();
            ShowData();
        }
        public void ShowData()
        {
            dgvSuaChua.DataSource = bllsc.ShowData();
        }
        public void ShowMaKH()
        {
            DataTable data = bllsc.Select_MaKH();
            cboMaKH.DataSource = data;
            cboMaKH.DisplayMember = "MaKH";
            cboMaKH.ValueMember = "MaKH";

        }
        public void ShowMaNV()
        {
            DataTable data = bllsc.Select_MaNV();
            cboMaNV.DataSource = data;
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";

        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TenKH = cboMaKH.SelectedValue.ToString();
            DataTable data = bllsc.Select_KH(TenKH);
            if (data.Rows.Count > 0)
            {
                txtTenKH.Text = data.Rows[0][0].ToString();
                txtDiaChi.Text= data.Rows[0][1].ToString();
            }
            else
            {
                txtTenKH.Text = "";
                txtDiaChi.Text = "";
            }
        }

        private void frm_SuaChua_Load(object sender, EventArgs e)
        {
            ShowMaNV();
            ShowMaKH();
            ShowData();
        }

        private void btnThemSC_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSC.Text == "" || cboMaKH.Text == "" || cboMaNV.Text == "" || txtTinhTrang.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn thêm thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        
                       int var= bllsc.Insert(new SuaChua_DTO(txtMaSC.Text, cboMaKH.Text, txtTinhTrang.Text, dtSuaChua.Value.Date, cboMaNV.Text, cboTrangThai.Text));

                      if(var == -1)
                        {
                            MessageBox.Show("Thêm dữ liệu thất bại, mã đã tồn tại hoặc mã chứa khoảng trắng","Chú ý",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thành công", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnSuaSC_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSC.Text == "" || cboMaKH.Text == "" || cboMaNV.Text == "" || txtTinhTrang.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                }
                else 
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                         bllsc.Update(new SuaChua_DTO(txtMaSC.Text, cboMaKH.Text, txtTinhTrang.Text, dtSuaChua.Value.Date, cboMaNV.Text, cboTrangThai.Text));
                       
                      
                        MessageBox.Show("Sửa dữ liệu  thành công, hãy kiểm tra lại! ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                        
                        ShowData();
                    }

                }
            }
            catch 
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Không thêm được dữ liệu", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaSC_Click(object sender, EventArgs e)
        {
            if (txtMaSC.Text == "" || cboMaKH.Text == "" || cboMaNV.Text == "" || txtTinhTrang.Text == "")
            {
                MessageBox.Show("Chọn thông tin cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn Xóa thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    bllsc.Delete(txtMaSC.Text);
                    MessageBox.Show("Xóa thành công");
                    Reset();
                }
            }
        }

        private void btnResetSC_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ptSearchSC_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrWhiteSpace(txtSearchSC.Text))
            {
                MessageBox.Show("Nhập thông tin tìm kiếm");
            }
            else
            {
                
                DataTable data = bllsc.Search_SC(txtSearchSC.Text);

                if (data != null && data.Rows.Count > 0)
                {
                    dgvSuaChua.DataSource = data;

                    txtMaSC.Text = dgvSuaChua.CurrentRow.Cells[0].Value.ToString();
                    cboMaKH.Text = dgvSuaChua.CurrentRow.Cells[1].Value.ToString();
                    txtTinhTrang.Text = dgvSuaChua.CurrentRow.Cells[2].Value.ToString();
                    dtSuaChua.Text = dgvSuaChua.CurrentRow.Cells[3].Value.ToString();
                    cboMaNV.Text = dgvSuaChua.CurrentRow.Cells[4].Value.ToString();
                    cboTrangThai.Text = dgvSuaChua.CurrentRow.Cells[5].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Thông tin tìm kiếm không tồn tại");
                }
            }

        }

        private void dgvSuaChua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang=e.RowIndex;
            txtMaSC.Text = dgvSuaChua[0, hang].Value.ToString();
            cboMaKH.Text = dgvSuaChua[1, hang].Value.ToString();
            txtTinhTrang.Text = dgvSuaChua[2, hang].Value.ToString();
            dtSuaChua.Text = dgvSuaChua[3, hang].Value.ToString();
            cboMaNV.Text = dgvSuaChua[4, hang].Value.ToString();
            cboTrangThai.Text = dgvSuaChua[5, hang].Value.ToString();
        }

        private void btnExcelSC_Click(object sender, EventArgs e)
        {
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";

            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string filePath = saveFileDialog.FileName;
            //    DataTable dataTable = Datagriview();
            //    //DataTable dataTable = GetDataTableFromDataGridView(dgvNhanVien);
            //    excel.ExportToExcel(dataTable, filePath);
            //    MessageBox.Show("Dữ liệu đã được xuất ra file Excel.");
            //}

            DataTable dataTable = Datagriview();

            string filePath = @"D:\Downloads\Book1.xlsx";
            excel.ExportToExcel(dataTable, filePath);
            MessageBox.Show("Xuất thành công");
        }
    }
}

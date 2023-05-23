using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frm_GiaNuoc : Form
    {
        GIaNuoc_BLL bllgn = new GIaNuoc_BLL();
        GiaNuoc_DTO dtogn = new GiaNuoc_DTO();
        private Excel excel;

        public frm_GiaNuoc()
        {
            InitializeComponent();
            excel = new Excel();
        }

        public DataTable Datagriview()
        {
            return bllgn.Excel(dgvGiaNuoc);
        }
        public void ShowData()
        {
            dgvGiaNuoc.DataSource = bllgn.ShowData();
        }
        public void ShowMaKH()
        {
            DataTable data = bllgn.Select_MaKH();
            cboMaKH.DataSource = data;
            cboMaKH.DisplayMember = "MaKH";
            cboMaKH.ValueMember = "MaKH";
           
        }


        private void frm_GiaNuoc_Load(object sender, EventArgs e)
        {
            ShowMaKH();
            this.ShowData();
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TenKH = cboMaKH.SelectedValue.ToString();
            DataTable data = bllgn.Select_TenKH(TenKH);
            if (data.Rows.Count > 0)
            {
                txtTenKH.Text = data.Rows[0][0].ToString();
            }
            else
            {
                txtTenKH.Text = "";
            }
        }
        public void Reset()
        {
            txtMaDK.Clear();
            txtTenKH.Clear();
            cboMaN.SelectedIndex = -1;
            txtGiaNuoc.Clear();
            txtSearchGN.Clear();
            ShowData();
        }

        private void dgvGiaNuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaDK.Text = dgvGiaNuoc[0, hang].Value.ToString();
            cboMaKH.Text = dgvGiaNuoc[1, hang].Value.ToString();
            cboMaN.Text = dgvGiaNuoc[2, hang].Value.ToString();
            txtGiaNuoc.Text = dgvGiaNuoc[3, hang].Value.ToString();
        }

        private void btnThemGN_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDK.Text == "" || cboMaKH.Text == "" || cboMaN.Text == "" || txtGiaNuoc.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn thêm thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        //dtogn.MaDK1 = txtMaDK.Text;
                        //dtogn.MaKH1 = cboMaKH.Text;
                        //dtogn.MaNuocSD1 = cboMaN.Text;
                        //dtogn.GiaTien1 = txtGiaNuoc.Text;
                        //if (bllgn.MaT(dtogn.MaDK1) == true)
                        //{
                        //    MessageBox.Show("Mã nước đã tồn tại");
                        //}
                        //else
                        //{
                        //    bllgn.Insert(dtogn);
                        //    MessageBox.Show("Thêm thành công");
                        //    Reset();
                        //}

                        int var = bllgn.Insert(new GiaNuoc_DTO(txtMaDK.Text, cboMaKH.Text, cboMaN.Text, txtGiaNuoc.Text));
                        if (var == -1)
                        {
                            MessageBox.Show("Thêm dữ liệu  thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại,  mã  đã tồn tại ,mã không chứa khoảng trắng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        ShowData();
                        Reset();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSuaGN_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMaDK.Text == "" || cboMaKH.Text == "" || cboMaN.Text == "" || txtGiaNuoc.Text == "")
                {
                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        //dtogn.MaDK1 = txtMaDK.Text;
                        //dtogn.MaKH1 = cboMaKH.Text;
                        //dtogn.MaNuocSD1 = cboMaN.Text;
                        //dtogn.GiaTien1 = txtGiaNuoc.Text;
                        //bllgn.Update(dtogn);
                        //MessageBox.Show("Sửa thành công");
                        //Reset();


                        int var = bllgn.Update(new GiaNuoc_DTO(txtMaDK.Text, cboMaKH.Text, cboMaN.Text, txtGiaNuoc.Text));
                        if (var == -1)
                        {
                            MessageBox.Show("Sửa dữ liệu  thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        ShowData();
                        Reset();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Không sửa được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaGN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn Xóa thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //dtogn.MaDK1 = txtMaDK.Text;
                bllgn.Delete(txtMaDK.Text);
                MessageBox.Show("Xóa thành công");
                Reset();
            }

        }

        private void btnResetGN_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ptSearchGN_Click(object sender, EventArgs e)
        {

            dgvGiaNuoc.DataSource = bllgn.Search_Gn(txtSearchGN.Text);



         
            txtMaDK.Text = dgvGiaNuoc.CurrentRow.Cells[0].Value.ToString();
            cboMaKH.Text = dgvGiaNuoc.CurrentRow.Cells[1].Value.ToString();
            cboMaN.Text = dgvGiaNuoc.CurrentRow.Cells[2].Value.ToString();
            txtGiaNuoc.Text = dgvGiaNuoc.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnExcelGN_Click(object sender, EventArgs e)
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

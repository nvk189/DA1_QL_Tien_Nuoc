using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frm_ThanhToan : Form
    {
        ThanhToan_BLL thanhToan_bll = new ThanhToan_BLL();
        public frm_ThanhToan()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dgvThanhToan.DataSource = thanhToan_bll.ShowData();
        }

        //public void capnhat()
        //{
        //    dgvThanhToan.DataSource = thanhToan_bll.capnhat();
        //}

        private void frm_ThanhToan_Load(object sender, EventArgs e)
        {
            LoadData();
            
            ShowMaNV();
            ShowMaKH();
        }
        public void ShowMaKH()
        {
            DataTable data = thanhToan_bll.Select_MaKH();
            cboMaKH.DataSource = data;
            cboMaKH.DisplayMember = "MaKH";
            cboMaKH.ValueMember = "MaKH";

        }
        public void ShowMaNV()
        {
            DataTable data = thanhToan_bll.Select_MaNV();
            cboMaNV.DataSource = data;
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";

        }
        public void Reset()
        {
          
            txtMaHD.Clear();
          
            txtTenKH.Clear();
            txtDiaChi.Clear();
           
            txtSoKhoisdt.Clear();
            txtSoKhoisds.Clear();
            txtGIaTien.Clear();
            txtThue.Clear();
            dtNgayThanhToan.Text = "";
            cboHTThanhToan.SelectedIndex = -1;
            txtTongTien.Clear();
            txtSearchTT.Clear();
            LoadData();
        }
        private void btnThemTT_Click(object sender, EventArgs e)
        {
            float tongTien;
            float.TryParse(txtTongTien.Text, out tongTien);
            float Sokhoisdt;
            float.TryParse(txtSoKhoisdt.Text, out Sokhoisdt);
            float Sokhoisds;
            float.TryParse(txtSoKhoisds.Text, out Sokhoisds);
            float giatien;
            float.TryParse(txtGIaTien.Text, out giatien);
            int thue;
            int.TryParse(txtThue.Text, out thue);
            if(txtTenKH.Text=="" ||txtSoKhoisds.Text=="" || txtThue.Text=="" || cboHTThanhToan.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin.");
            }
            else
            {
                int var = thanhToan_bll.Insert(new ThanhToan_DTO(cboMaKH.Text, cboMaNV.Text, Sokhoisdt, Sokhoisds, giatien, thue, dtNgayThanhToan.Value.Date, cboHTThanhToan.Text, tongTien));
                if (var == -1)
                {
                    MessageBox.Show("thông tin không hợp lệ ,số mới phải lớn hơn số cũ,hãy kiểm tra lại!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Thêm thành công,hãy kiểm tra lại!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            
                LoadData();
            }
          
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TenKH = cboMaKH.SelectedValue.ToString();
            DataTable data = thanhToan_bll.Select_KH(TenKH);
            DataTable data1 = thanhToan_bll.Select_GiaTien(TenKH);
            DataTable data2 = thanhToan_bll.Select_SoCTS(TenKH);
            if (data.Rows.Count > 0)
            {
                txtTenKH.Text = data.Rows[0][0].ToString();
                txtDiaChi.Text = data.Rows[0][1].ToString();
            }
            else
            {
                txtTenKH.Text = "";
            }

            if (data1.Rows.Count > 0)
            {
                txtGIaTien.Text = data1.Rows[0][0].ToString();
                
            }
            else
            {
                txtGIaTien.Text = "";
            }

            if (data2.Rows.Count > 0)
            {
                txtSoKhoisdt.Text = data2.Rows[0][0].ToString();

            }
            else
            {
                txtSoKhoisdt.Text = "";
            }

        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {

            
            int MaHD;
            int.TryParse(txtMaHD.Text, out MaHD);
            float tongTien;
            float.TryParse(txtTongTien.Text, out tongTien);
            float Sokhoisdt;
            float.TryParse(txtSoKhoisdt.Text, out Sokhoisdt);
            float Sokhoisds;
            float.TryParse(txtSoKhoisds.Text, out Sokhoisds);
            float giatien;
            float.TryParse(txtGIaTien.Text, out giatien);
            int thue;
            int.TryParse(txtThue.Text, out thue);

            if (txtTenKH.Text == "" || txtSoKhoisds.Text == "" || txtThue.Text == "" || cboHTThanhToan.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin.");
            }
            else
            {
                int var = thanhToan_bll.Update(new ThanhToan_DTO(MaHD, cboMaKH.Text, cboMaNV.Text, Sokhoisdt, Sokhoisds, giatien, thue, dtNgayThanhToan.Value.Date, cboHTThanhToan.Text, tongTien));
                if (var == 0)
                {
                    MessageBox.Show("thông tin không hợp lệ , số mới lớn hơn số cũ ,hãy kiểm tra lại!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Sửa thành công,hãy kiểm tra lại!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                LoadData();
          

            }

          

          
          
        }

        private void dgvThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            txtMaHD.Text = dgvThanhToan.CurrentRow.Cells[0].Value.ToString();
            cboMaKH.Text = dgvThanhToan.CurrentRow.Cells[1].Value.ToString();
            cboMaNV.Text = dgvThanhToan.CurrentRow.Cells[2].Value.ToString();
            txtSoKhoisdt.Text = dgvThanhToan.CurrentRow.Cells[3].Value.ToString();
            txtSoKhoisds.Text = dgvThanhToan.CurrentRow.Cells[4].Value.ToString();
            txtGIaTien.Text = dgvThanhToan.CurrentRow.Cells[5].Value.ToString();
            txtThue.Text = dgvThanhToan.CurrentRow.Cells[6].Value.ToString();
            dtNgayThanhToan.Text = dgvThanhToan.CurrentRow.Cells[7].Value.ToString();
            cboHTThanhToan.Text = dgvThanhToan.CurrentRow.Cells[8].Value.ToString();
            txtTongTien.Text = dgvThanhToan.CurrentRow.Cells[9].Value.ToString();






        }

        private void ptSearchTT_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(txtSearchTT.Text))
            {
                MessageBox.Show("Nhập thông tin tìm kiếm");
            }
            else
            {
                int MaHD;
                int.TryParse(txtSearchTT.Text, out MaHD);
                DataTable data = thanhToan_bll.Search(MaHD, txtSearchTT.Text);

                if (data != null && data.Rows.Count > 0)
                {
                    dgvThanhToan.DataSource = data;

                    txtMaHD.Text = dgvThanhToan.CurrentRow.Cells[0].Value.ToString();
                    cboMaKH.Text = dgvThanhToan.CurrentRow.Cells[1].Value.ToString();
                    cboMaNV.Text = dgvThanhToan.CurrentRow.Cells[2].Value.ToString();
                    txtSoKhoisdt.Text = dgvThanhToan.CurrentRow.Cells[3].Value.ToString();
                    txtSoKhoisds.Text = dgvThanhToan.CurrentRow.Cells[4].Value.ToString();
                    txtGIaTien.Text = dgvThanhToan.CurrentRow.Cells[5].Value.ToString();
                    txtThue.Text = dgvThanhToan.CurrentRow.Cells[6].Value.ToString();
                    dtNgayThanhToan.Text = dgvThanhToan.CurrentRow.Cells[7].Value.ToString();
                    cboHTThanhToan.Text = dgvThanhToan.CurrentRow.Cells[8].Value.ToString();
                    txtTongTien.Text = dgvThanhToan.CurrentRow.Cells[9].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Thông tin tìm kiếm không tồn tại");
                }
            }



        }

        private void btnResetTT_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtXuatHD_Click(object sender, EventArgs e)
        {
          
            
            int MaHD;
            int.TryParse(txtMaHD.Text, out MaHD);
            float tongTien;
            float.TryParse(txtTongTien.Text, out tongTien);
            float soCTT;
            float.TryParse(txtSoKhoisdt.Text, out soCTT);
            float soCTS;
            float.TryParse(txtSoKhoisds.Text, out soCTS);
            float giaTien;
            float.TryParse(txtGIaTien.Text, out giaTien);
            int thue;
            int.TryParse(txtThue.Text, out thue);


            if (txtTenKH.Text == "" || txtSoKhoisds.Text == "" || txtThue.Text == "" || cboHTThanhToan.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin.");
            }
            else
            {
                float soSD = soCTS - soCTT;

                thanhToan_bll.ExportInvoiceToNotepad(MaHD, cboMaKH.Text, txtTenKH.Text, txtDiaChi.Text, cboMaNV.Text, soCTT, soCTS, soSD, giaTien, thue, dtNgayThanhToan.Value.Date, cboHTThanhToan.Text, tongTien);

            }
           


           




        }

        private void btnXoaTT_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int MaHD;
                int.TryParse(txtMaHD.Text, out MaHD);
                thanhToan_bll.Delete_HD(MaHD);
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại,lỗi hệ thống");
            }
            LoadData();
        }
    }
}

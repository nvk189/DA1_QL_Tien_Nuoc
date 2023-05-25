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
           int var = thanhToan_bll.Insert(new ThanhToan_DTO(cboMaKH.Text, cboMaNV.Text, Sokhoisdt, Sokhoisds, giatien, thue, dtNgayThanhToan.Value.Date, cboHTThanhToan.Text, tongTien));
            if(var == -1)
            {
                MessageBox.Show("thông tin không hợp lệ ,hãy kiểm tra lại!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); 
            }
            else
            {
                MessageBox.Show("Thêm thành công,hãy kiểm tra lại!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            LoadData();
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

            int var = thanhToan_bll.Update(new ThanhToan_DTO(MaHD, cboMaKH.Text, cboMaNV.Text, Sokhoisdt, Sokhoisds, giatien, thue, dtNgayThanhToan.Value.Date, cboHTThanhToan.Text, tongTien));
            if (var == -1)
            {
                MessageBox.Show("thông tin không hợp lệ ,hãy kiểm tra lại!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Sửa thành công,hãy kiểm tra lại!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            LoadData();

          
          
        }

        private void dgvThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaHD.Text = dgvThanhToan[5,hang].Value.ToString();
            cboMaKH.Text = dgvThanhToan[1, hang].Value.ToString();
            cboMaNV.Text = dgvThanhToan[2, hang].Value.ToString();
            txtSoKhoisdt.Text = dgvThanhToan[6, hang].Value.ToString();
            txtSoKhoisds.Text = dgvThanhToan[7, hang].Value.ToString();
            txtGIaTien.Text = dgvThanhToan[8, hang].Value.ToString();
            txtThue.Text = dgvThanhToan[9, hang].Value.ToString();
            //dtNgayThanhToan.Text = dgvThanhToan[3, hang].Value.ToString();
            cboHTThanhToan.Text = dgvThanhToan[4, hang].Value.ToString();
            txtTongTien.Text = dgvThanhToan[10, hang].Value.ToString();




        }

        private void ptSearchTT_Click(object sender, EventArgs e)
        {
            int MaHD;
            int.TryParse(txtSearchTT.Text, out MaHD);
            dgvThanhToan.DataSource = thanhToan_bll.Search(MaHD,txtSearchTT.Text);
        }

        private void btnResetTT_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtXuatHD_Click(object sender, EventArgs e)
        {
            //if(txtTenKH.Text=="" || txtDiaChi.Text=="" || txtGIaTien.Text=="" || txtThue.Text=="" || cboHTThanhToan.Text=="" || txtTongTien.Text == "")
            //{
            //    MessageBox.Show("Chọn thông tin khách hàng cần xuất hóa đơn ");

            //}
            //else
            //{
            //    DataTable dataTable = new DataTable();
            //    dataTable.Rows[0][0] = txtMaHD.Text;
            //    dataTable.Rows[0][1] = cboMaKH.Text;
            //    dataTable.Rows[0][2] = txtTenKH.Text;
            //    dataTable.Rows[0][3] = txtDiaChi.Text;
            //    dataTable.Rows[0][4] = cboMaNV.Text;
            //    dataTable.Rows[0][5] = txtSoKhoisdt.Text;
            //    dataTable.Rows[0][6] = txtSoKhoisds.Text;
            //    dataTable.Rows[0][7] = txtGIaTien.Text;
            //    dataTable.Rows[0][8] = txtThue.Text;
            //    dataTable.Rows[0][9] = dtNgayThanhToan.Value.Date;
            //    dataTable.Rows[0][10] = cboHTThanhToan.Text;
            //    dataTable.Rows[0][11] = txtTongTien.Text;


            //}

           

             
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

            float soSD = soCTS - soCTT;

            thanhToan_bll.ExportInvoiceToNotepad(MaHD,cboMaKH.Text, txtTenKH.Text, txtDiaChi.Text, cboMaNV.Text, soCTT, soCTS, soSD, giaTien, thue, dtNgayThanhToan.Value.Date, cboHTThanhToan.Text, tongTien);
           




        }
    }
}

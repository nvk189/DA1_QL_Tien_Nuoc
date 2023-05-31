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
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class frm_ThongKe : Form
    {
        ThongKe_BLL thongKe_BLL =new ThongKe_BLL();
        private Excel excel;

        public DataTable Datagriview()
        {
            return thongKe_BLL.Excel(dgvThongKe);
        }

        public frm_ThongKe()
        {
            InitializeComponent();
            LoadData();
            LoadNV();
            excel = new Excel();
        }

        public void LoadNV()
        {
            DataTable datatable= thongKe_BLL.ShowNV();
            lblNhanVien.Text = datatable.Rows[0][0].ToString();
        }
        public void LoadData()
        {
            dgvThongKe.DataSource= thongKe_BLL.ShowData();
        }

        private void ptSearchDate_Click(object sender, EventArgs e)
        {
            DateTime dt = dtSearchtime.Value.Date;
            DataTable data = thongKe_BLL.Search(dt);
            if(data.Rows.Count > 0)
            {
                lbKhachHang.Text = data.Rows[0][0].ToString();
                lblNuocSD.Text=data.Rows[0][1].ToString();
                lblTongTien.Text=data.Rows[0][2].ToString();
                //dgvThongKe.DataSource= data;
                ShowDT();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin cần tìm kiếm");
            }
        }
      
        public void ShowDT()
        {
            DateTime da = dtSearchtime.Value.Date;
            dgvThongKe.DataSource = thongKe_BLL.Search1(da);
        }
       
        private void ptSearchTK_Click(object sender, EventArgs e)
        {
            int MaHD;
            int.TryParse(txtSearchTK.Text, out MaHD);
            int t;
            int.TryParse(txtSearchTK.Text, out t);
            

            DataTable data1 = thongKe_BLL.SearchMY(Convert.ToInt32(MaHD));
            if(data1.Rows.Count > 0)
            {
                lbKhachHang.Text = data1.Rows[0][0].ToString();
                lblNuocSD.Text = data1.Rows[0][1].ToString();
                lblTongTien.Text = data1.Rows[0][2].ToString();
                dgvThongKe.DataSource = thongKe_BLL.Search1(t);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin cần tìm kiếm");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtSearchtime.DataBindings.Clear();
            txtSearchTK.Clear();
            lbKhachHang.Text = "0";
            lblNuocSD.Text = "0";
            lblTongTien.Text = "0";
            LoadData();

        }

        private void btnExcelTK_Click(object sender, EventArgs e)
        {
            DataTable dataTable = Datagriview();

            string filePath = @"D:\Downloads\Book1.xlsx";
            excel.ExportToExcel(dataTable, filePath);
            MessageBox.Show("Xuất thành công");
        }
    }
}

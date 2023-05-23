namespace GUI
{
    partial class frm_NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbNhanVien = new System.Windows.Forms.GroupBox();
            this.btnExcelNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnResetNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemNV = new Guna.UI2.WinForms.Guna2Button();
            this.cbGioiTinhNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtSoDTNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChiNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbDSNhanVien = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.txtSearchNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.ptSearchNV = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNhanVien.SuspendLayout();
            this.gbDSNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchNV)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNhanVien
            // 
            this.gbNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNhanVien.Controls.Add(this.btnExcelNV);
            this.gbNhanVien.Controls.Add(this.btnResetNV);
            this.gbNhanVien.Controls.Add(this.btnXoaNV);
            this.gbNhanVien.Controls.Add(this.btnSuaNV);
            this.gbNhanVien.Controls.Add(this.btnThemNV);
            this.gbNhanVien.Controls.Add(this.cbGioiTinhNV);
            this.gbNhanVien.Controls.Add(this.dtNgaySinhNV);
            this.gbNhanVien.Controls.Add(this.lblGioiTinh);
            this.gbNhanVien.Controls.Add(this.lblNgaySinh);
            this.gbNhanVien.Controls.Add(this.lblSoDT);
            this.gbNhanVien.Controls.Add(this.lblDiaChi);
            this.gbNhanVien.Controls.Add(this.lblTenNV);
            this.gbNhanVien.Controls.Add(this.lblMaNV);
            this.gbNhanVien.Controls.Add(this.txtSoDTNV);
            this.gbNhanVien.Controls.Add(this.txtDiaChiNV);
            this.gbNhanVien.Controls.Add(this.txtTenNV);
            this.gbNhanVien.Controls.Add(this.txtMaNV);
            this.gbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNhanVien.Location = new System.Drawing.Point(12, 57);
            this.gbNhanVien.Name = "gbNhanVien";
            this.gbNhanVien.Size = new System.Drawing.Size(1487, 402);
            this.gbNhanVien.TabIndex = 0;
            this.gbNhanVien.TabStop = false;
            this.gbNhanVien.Text = "Thông tin nhân viên";
            // 
            // btnExcelNV
            // 
            this.btnExcelNV.AutoRoundedCorners = true;
            this.btnExcelNV.BorderRadius = 26;
            this.btnExcelNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcelNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcelNV.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelNV.ForeColor = System.Drawing.Color.White;
            this.btnExcelNV.Location = new System.Drawing.Point(1120, 341);
            this.btnExcelNV.Name = "btnExcelNV";
            this.btnExcelNV.Size = new System.Drawing.Size(152, 55);
            this.btnExcelNV.TabIndex = 26;
            this.btnExcelNV.Text = "Excel";
            this.btnExcelNV.Click += new System.EventHandler(this.btnExcelNV_Click);
            // 
            // btnResetNV
            // 
            this.btnResetNV.AutoRoundedCorners = true;
            this.btnResetNV.BorderRadius = 26;
            this.btnResetNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetNV.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetNV.ForeColor = System.Drawing.Color.White;
            this.btnResetNV.Location = new System.Drawing.Point(935, 341);
            this.btnResetNV.Name = "btnResetNV";
            this.btnResetNV.Size = new System.Drawing.Size(152, 55);
            this.btnResetNV.TabIndex = 25;
            this.btnResetNV.Text = "Làm mới";
            this.btnResetNV.Click += new System.EventHandler(this.btnResetNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.AutoRoundedCorners = true;
            this.btnXoaNV.BorderRadius = 26;
            this.btnXoaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaNV.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.ForeColor = System.Drawing.Color.White;
            this.btnXoaNV.Location = new System.Drawing.Point(744, 341);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(152, 55);
            this.btnXoaNV.TabIndex = 24;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.AutoRoundedCorners = true;
            this.btnSuaNV.BorderRadius = 26;
            this.btnSuaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaNV.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.ForeColor = System.Drawing.Color.White;
            this.btnSuaNV.Location = new System.Drawing.Point(542, 341);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(152, 55);
            this.btnSuaNV.TabIndex = 23;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.AutoRoundedCorners = true;
            this.btnThemNV.BorderRadius = 26;
            this.btnThemNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemNV.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.ForeColor = System.Drawing.Color.White;
            this.btnThemNV.Location = new System.Drawing.Point(327, 341);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(152, 55);
            this.btnThemNV.TabIndex = 22;
            this.btnThemNV.Text = "Lưu";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // cbGioiTinhNV
            // 
            this.cbGioiTinhNV.AutoRoundedCorners = true;
            this.cbGioiTinhNV.BackColor = System.Drawing.Color.Transparent;
            this.cbGioiTinhNV.BorderRadius = 17;
            this.cbGioiTinhNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGioiTinhNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinhNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGioiTinhNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGioiTinhNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinhNV.ForeColor = System.Drawing.Color.Black;
            this.cbGioiTinhNV.ItemHeight = 30;
            this.cbGioiTinhNV.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cbGioiTinhNV.Location = new System.Drawing.Point(958, 243);
            this.cbGioiTinhNV.Name = "cbGioiTinhNV";
            this.cbGioiTinhNV.Size = new System.Drawing.Size(193, 36);
            this.cbGioiTinhNV.TabIndex = 9;
            // 
            // dtNgaySinhNV
            // 
            this.dtNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinhNV.Location = new System.Drawing.Point(958, 172);
            this.dtNgaySinhNV.Name = "dtNgaySinhNV";
            this.dtNgaySinhNV.Size = new System.Drawing.Size(301, 34);
            this.dtNgaySinhNV.TabIndex = 8;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(803, 243);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(124, 29);
            this.lblGioiTinh.TabIndex = 21;
            this.lblGioiTinh.Text = "Giới tính :";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(785, 168);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(142, 29);
            this.lblNgaySinh.TabIndex = 20;
            this.lblNgaySinh.Text = "Ngày sinh :";
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(739, 82);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(188, 29);
            this.lblSoDT.TabIndex = 19;
            this.lblSoDT.Text = "Số điện thoại  :";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(251, 243);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(107, 29);
            this.lblDiaChi.TabIndex = 18;
            this.lblDiaChi.Text = "Địa chỉ :";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(222, 168);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(136, 29);
            this.lblTenNV.TabIndex = 17;
            this.lblTenNV.Text = "Họ và tên :";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(171, 82);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(187, 29);
            this.lblMaNV.TabIndex = 16;
            this.lblMaNV.Text = "Mã  nhân viên :";
            // 
            // txtSoDTNV
            // 
            this.txtSoDTNV.AutoRoundedCorners = true;
            this.txtSoDTNV.BorderRadius = 25;
            this.txtSoDTNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDTNV.DefaultText = "";
            this.txtSoDTNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDTNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDTNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDTNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDTNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDTNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDTNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoDTNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDTNV.Location = new System.Drawing.Point(958, 71);
            this.txtSoDTNV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSoDTNV.Name = "txtSoDTNV";
            this.txtSoDTNV.PasswordChar = '\0';
            this.txtSoDTNV.PlaceholderText = "";
            this.txtSoDTNV.SelectedText = "";
            this.txtSoDTNV.Size = new System.Drawing.Size(301, 52);
            this.txtSoDTNV.TabIndex = 5;
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.AutoRoundedCorners = true;
            this.txtDiaChiNV.BorderRadius = 25;
            this.txtDiaChiNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChiNV.DefaultText = "";
            this.txtDiaChiNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChiNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChiNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChiNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChiNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChiNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiaChiNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChiNV.Location = new System.Drawing.Point(382, 227);
            this.txtDiaChiNV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.PasswordChar = '\0';
            this.txtDiaChiNV.PlaceholderText = "";
            this.txtDiaChiNV.SelectedText = "";
            this.txtDiaChiNV.Size = new System.Drawing.Size(301, 52);
            this.txtDiaChiNV.TabIndex = 4;
            // 
            // txtTenNV
            // 
            this.txtTenNV.AutoRoundedCorners = true;
            this.txtTenNV.BorderRadius = 25;
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.DefaultText = "";
            this.txtTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Location = new System.Drawing.Point(382, 154);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.PlaceholderText = "";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.Size = new System.Drawing.Size(301, 52);
            this.txtTenNV.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.AutoRoundedCorners = true;
            this.txtMaNV.BorderRadius = 25;
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.DefaultText = "";
            this.txtMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Location = new System.Drawing.Point(382, 71);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PasswordChar = '\0';
            this.txtMaNV.PlaceholderText = "";
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.Size = new System.Drawing.Size(301, 52);
            this.txtMaNV.TabIndex = 2;
            // 
            // gbDSNhanVien
            // 
            this.gbDSNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDSNhanVien.Controls.Add(this.dgvNhanVien);
            this.gbDSNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDSNhanVien.Location = new System.Drawing.Point(12, 465);
            this.gbDSNhanVien.Name = "gbDSNhanVien";
            this.gbDSNhanVien.Size = new System.Drawing.Size(1487, 439);
            this.gbDSNhanVien.TabIndex = 1;
            this.gbDSNhanVien.TabStop = false;
            this.gbDSNhanVien.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvNhanVien.Location = new System.Drawing.Point(15, 33);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1466, 391);
            this.dgvNhanVien.TabIndex = 25;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // txtSearchNV
            // 
            this.txtSearchNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchNV.AutoRoundedCorners = true;
            this.txtSearchNV.BorderRadius = 25;
            this.txtSearchNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchNV.DefaultText = "";
            this.txtSearchNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchNV.Location = new System.Drawing.Point(1022, 15);
            this.txtSearchNV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearchNV.Name = "txtSearchNV";
            this.txtSearchNV.PasswordChar = '\0';
            this.txtSearchNV.PlaceholderText = "Tìm kiếm mã hoặc số điện thoại";
            this.txtSearchNV.SelectedText = "";
            this.txtSearchNV.Size = new System.Drawing.Size(387, 52);
            this.txtSearchNV.TabIndex = 23;
            this.txtSearchNV.Tag = "";
            // 
            // ptSearchNV
            // 
            this.ptSearchNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptSearchNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptSearchNV.Image = global::GUI.Properties.Resources.search_interface_symbol;
            this.ptSearchNV.Location = new System.Drawing.Point(1416, 26);
            this.ptSearchNV.Name = "ptSearchNV";
            this.ptSearchNV.Size = new System.Drawing.Size(45, 41);
            this.ptSearchNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptSearchNV.TabIndex = 24;
            this.ptSearchNV.TabStop = false;
            this.ptSearchNV.Click += new System.EventHandler(this.ptSearchNV_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 220;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 450;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoDT";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgaySinh";
            this.Column5.HeaderText = "Ngày sinh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GioiTinh";
            this.Column6.HeaderText = "Giới tính";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1511, 948);
            this.Controls.Add(this.ptSearchNV);
            this.Controls.Add(this.txtSearchNV);
            this.Controls.Add(this.gbDSNhanVien);
            this.Controls.Add(this.gbNhanVien);
            this.Name = "frm_NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            this.gbNhanVien.ResumeLayout(false);
            this.gbNhanVien.PerformLayout();
            this.gbDSNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNhanVien;
        private System.Windows.Forms.GroupBox gbDSNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDTNV;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChiNV;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private Guna.UI2.WinForms.Guna2ComboBox cbGioiTinhNV;
        private System.Windows.Forms.DateTimePicker dtNgaySinhNV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchNV;
        private System.Windows.Forms.PictureBox ptSearchNV;
        private Guna.UI2.WinForms.Guna2Button btnThemNV;
        private Guna.UI2.WinForms.Guna2Button btnSuaNV;
        private Guna.UI2.WinForms.Guna2Button btnXoaNV;
        private Guna.UI2.WinForms.Guna2Button btnExcelNV;
        private Guna.UI2.WinForms.Guna2Button btnResetNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
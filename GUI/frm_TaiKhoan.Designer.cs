namespace GUI
{
    partial class frm_TaiKhoan
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
            this.gbTaiKhoan = new System.Windows.Forms.GroupBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.txtTenNVTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnResetTK = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaTK = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaTK = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemTK = new Guna.UI2.WinForms.Guna2Button();
            this.cbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboQuyen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenDN = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.cboMaNVTK = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.gbTaiKhoanDS = new System.Windows.Forms.GroupBox();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.ptSearchTK = new System.Windows.Forms.PictureBox();
            this.gbTaiKhoan.SuspendLayout();
            this.gbTaiKhoanDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchTK)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTaiKhoan
            // 
            this.gbTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTaiKhoan.Controls.Add(this.lblTenNV);
            this.gbTaiKhoan.Controls.Add(this.txtTenNVTK);
            this.gbTaiKhoan.Controls.Add(this.btnResetTK);
            this.gbTaiKhoan.Controls.Add(this.btnXoaTK);
            this.gbTaiKhoan.Controls.Add(this.btnSuaTK);
            this.gbTaiKhoan.Controls.Add(this.btnThemTK);
            this.gbTaiKhoan.Controls.Add(this.cbTrangThai);
            this.gbTaiKhoan.Controls.Add(this.cboQuyen);
            this.gbTaiKhoan.Controls.Add(this.txtMatKhau);
            this.gbTaiKhoan.Controls.Add(this.txtTenDN);
            this.gbTaiKhoan.Controls.Add(this.lblTrangThai);
            this.gbTaiKhoan.Controls.Add(this.lblChucVu);
            this.gbTaiKhoan.Controls.Add(this.lblMatKhau);
            this.gbTaiKhoan.Controls.Add(this.lblTenDN);
            this.gbTaiKhoan.Controls.Add(this.cboMaNVTK);
            this.gbTaiKhoan.Controls.Add(this.lblMaNV);
            this.gbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTaiKhoan.Location = new System.Drawing.Point(0, 64);
            this.gbTaiKhoan.Name = "gbTaiKhoan";
            this.gbTaiKhoan.Size = new System.Drawing.Size(1509, 396);
            this.gbTaiKhoan.TabIndex = 0;
            this.gbTaiKhoan.TabStop = false;
            this.gbTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(750, 67);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(129, 29);
            this.lblTenNV.TabIndex = 35;
            this.lblTenNV.Text = "Họ và tên:";
            // 
            // txtTenNVTK
            // 
            this.txtTenNVTK.AutoRoundedCorners = true;
            this.txtTenNVTK.BorderRadius = 25;
            this.txtTenNVTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNVTK.DefaultText = "";
            this.txtTenNVTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNVTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNVTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNVTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNVTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNVTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNVTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenNVTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNVTK.Location = new System.Drawing.Point(903, 60);
            this.txtTenNVTK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTenNVTK.Name = "txtTenNVTK";
            this.txtTenNVTK.PasswordChar = '\0';
            this.txtTenNVTK.PlaceholderText = "";
            this.txtTenNVTK.SelectedText = "";
            this.txtTenNVTK.Size = new System.Drawing.Size(278, 52);
            this.txtTenNVTK.TabIndex = 34;
            // 
            // btnResetTK
            // 
            this.btnResetTK.AutoRoundedCorners = true;
            this.btnResetTK.BorderRadius = 26;
            this.btnResetTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetTK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetTK.ForeColor = System.Drawing.Color.White;
            this.btnResetTK.Location = new System.Drawing.Point(903, 335);
            this.btnResetTK.Name = "btnResetTK";
            this.btnResetTK.Size = new System.Drawing.Size(152, 55);
            this.btnResetTK.TabIndex = 33;
            this.btnResetTK.Text = "Làm mới";
            this.btnResetTK.Click += new System.EventHandler(this.btnResetTK_Click);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.AutoRoundedCorners = true;
            this.btnXoaTK.BorderRadius = 26;
            this.btnXoaTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaTK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.ForeColor = System.Drawing.Color.White;
            this.btnXoaTK.Location = new System.Drawing.Point(712, 335);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(152, 55);
            this.btnXoaTK.TabIndex = 32;
            this.btnXoaTK.Text = "Xóa";
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // btnSuaTK
            // 
            this.btnSuaTK.AutoRoundedCorners = true;
            this.btnSuaTK.BorderRadius = 26;
            this.btnSuaTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaTK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTK.ForeColor = System.Drawing.Color.White;
            this.btnSuaTK.Location = new System.Drawing.Point(507, 335);
            this.btnSuaTK.Name = "btnSuaTK";
            this.btnSuaTK.Size = new System.Drawing.Size(152, 55);
            this.btnSuaTK.TabIndex = 31;
            this.btnSuaTK.Text = "Sửa";
            this.btnSuaTK.Click += new System.EventHandler(this.btnSuaTK_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.AutoRoundedCorners = true;
            this.btnThemTK.BorderRadius = 26;
            this.btnThemTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemTK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTK.ForeColor = System.Drawing.Color.White;
            this.btnThemTK.Location = new System.Drawing.Point(294, 335);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(152, 55);
            this.btnThemTK.TabIndex = 30;
            this.btnThemTK.Text = "Lưu";
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.AutoRoundedCorners = true;
            this.cbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbTrangThai.BorderRadius = 17;
            this.cbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbTrangThai.ForeColor = System.Drawing.Color.Black;
            this.cbTrangThai.ItemHeight = 30;
            this.cbTrangThai.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbTrangThai.Location = new System.Drawing.Point(903, 218);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(142, 36);
            this.cbTrangThai.TabIndex = 5;
            // 
            // cboQuyen
            // 
            this.cboQuyen.AutoRoundedCorners = true;
            this.cboQuyen.BackColor = System.Drawing.Color.Transparent;
            this.cboQuyen.BorderRadius = 17;
            this.cboQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboQuyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboQuyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cboQuyen.ForeColor = System.Drawing.Color.Black;
            this.cboQuyen.ItemHeight = 30;
            this.cboQuyen.Items.AddRange(new object[] {
            "user",
            "user_1",
            "admin"});
            this.cboQuyen.Location = new System.Drawing.Point(903, 135);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(283, 36);
            this.cboQuyen.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AutoRoundedCorners = true;
            this.txtMatKhau.BorderRadius = 25;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Location = new System.Drawing.Point(294, 220);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(278, 52);
            this.txtMatKhau.TabIndex = 3;
            // 
            // txtTenDN
            // 
            this.txtTenDN.AutoRoundedCorners = true;
            this.txtTenDN.BorderRadius = 25;
            this.txtTenDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDN.DefaultText = "";
            this.txtTenDN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenDN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDN.Location = new System.Drawing.Point(294, 133);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.PasswordChar = '\0';
            this.txtTenDN.PlaceholderText = "";
            this.txtTenDN.SelectedText = "";
            this.txtTenDN.Size = new System.Drawing.Size(278, 52);
            this.txtTenDN.TabIndex = 2;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(758, 220);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(122, 29);
            this.lblTrangThai.TabIndex = 24;
            this.lblTrangThai.Text = "Hiệu lực :";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(778, 135);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(102, 29);
            this.lblChucVu.TabIndex = 21;
            this.lblChucVu.Text = "Quyền :";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(145, 225);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(131, 29);
            this.lblMatKhau.TabIndex = 20;
            this.lblMatKhau.Text = "Mật khẩu :";
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Location = new System.Drawing.Point(74, 142);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(202, 29);
            this.lblTenDN.TabIndex = 19;
            this.lblTenDN.Text = "Tên đăng nhập :";
            // 
            // cboMaNVTK
            // 
            this.cboMaNVTK.AutoRoundedCorners = true;
            this.cboMaNVTK.BackColor = System.Drawing.Color.Transparent;
            this.cboMaNVTK.BorderRadius = 17;
            this.cboMaNVTK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaNVTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNVTK.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaNVTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaNVTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNVTK.ForeColor = System.Drawing.Color.Black;
            this.cboMaNVTK.ItemHeight = 30;
            this.cboMaNVTK.Location = new System.Drawing.Point(294, 60);
            this.cboMaNVTK.Name = "cboMaNVTK";
            this.cboMaNVTK.Size = new System.Drawing.Size(278, 36);
            this.cboMaNVTK.TabIndex = 1;
            this.cboMaNVTK.SelectedIndexChanged += new System.EventHandler(this.cboMaNVTK_SelectedIndexChanged);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(89, 60);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(187, 29);
            this.lblMaNV.TabIndex = 17;
            this.lblMaNV.Text = "Mã  nhân viên :";
            // 
            // gbTaiKhoanDS
            // 
            this.gbTaiKhoanDS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTaiKhoanDS.Controls.Add(this.dgvTaiKhoan);
            this.gbTaiKhoanDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTaiKhoanDS.Location = new System.Drawing.Point(0, 466);
            this.gbTaiKhoanDS.Name = "gbTaiKhoanDS";
            this.gbTaiKhoanDS.Size = new System.Drawing.Size(1509, 346);
            this.gbTaiKhoanDS.TabIndex = 1;
            this.gbTaiKhoanDS.TabStop = false;
            this.gbTaiKhoanDS.Text = "Danh sách tài khoản";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTaiKhoan.Location = new System.Drawing.Point(67, 47);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 24;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(1424, 278);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellContentClick);
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
            this.Column2.DataPropertyName = "TenDN";
            this.Column2.HeaderText = "Tên đăng nhập";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MatKhau";
            this.Column3.HeaderText = "Mật khẩu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ChucVu";
            this.Column4.HeaderText = "Quyền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TrangThai";
            this.Column5.HeaderText = "Hiệu lực";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // txtSearchTK
            // 
            this.txtSearchTK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchTK.AutoRoundedCorners = true;
            this.txtSearchTK.BorderRadius = 25;
            this.txtSearchTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchTK.DefaultText = "";
            this.txtSearchTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchTK.Location = new System.Drawing.Point(1178, 24);
            this.txtSearchTK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearchTK.Name = "txtSearchTK";
            this.txtSearchTK.PasswordChar = '\0';
            this.txtSearchTK.PlaceholderText = "Tìm kiếm theo mã";
            this.txtSearchTK.SelectedText = "";
            this.txtSearchTK.Size = new System.Drawing.Size(273, 52);
            this.txtSearchTK.TabIndex = 24;
            this.txtSearchTK.Tag = "";
            // 
            // ptSearchTK
            // 
            this.ptSearchTK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptSearchTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptSearchTK.Image = global::GUI.Properties.Resources.search_interface_symbol;
            this.ptSearchTK.Location = new System.Drawing.Point(1458, 35);
            this.ptSearchTK.Name = "ptSearchTK";
            this.ptSearchTK.Size = new System.Drawing.Size(45, 41);
            this.ptSearchTK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptSearchTK.TabIndex = 25;
            this.ptSearchTK.TabStop = false;
            this.ptSearchTK.Click += new System.EventHandler(this.ptSearchTK_Click);
            // 
            // frm_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1580, 824);
            this.Controls.Add(this.ptSearchTK);
            this.Controls.Add(this.txtSearchTK);
            this.Controls.Add(this.gbTaiKhoanDS);
            this.Controls.Add(this.gbTaiKhoan);
            this.Name = "frm_TaiKhoan";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.frm_TaiKhoan_Load);
            this.gbTaiKhoan.ResumeLayout(false);
            this.gbTaiKhoan.PerformLayout();
            this.gbTaiKhoanDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTaiKhoan;
        private System.Windows.Forms.GroupBox gbTaiKhoanDS;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchTK;
        private System.Windows.Forms.PictureBox ptSearchTK;
        private System.Windows.Forms.Label lblMaNV;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaNVTK;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTenDN;
        private Guna.UI2.WinForms.Guna2ComboBox cbTrangThai;
        private Guna.UI2.WinForms.Guna2ComboBox cboQuyen;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDN;
        private Guna.UI2.WinForms.Guna2Button btnThemTK;
        private Guna.UI2.WinForms.Guna2Button btnSuaTK;
        private Guna.UI2.WinForms.Guna2Button btnXoaTK;
        private Guna.UI2.WinForms.Guna2Button btnResetTK;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Label lblTenNV;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNVTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
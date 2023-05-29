namespace GUI
{
    partial class frm_SuaChua
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
            this.gbSuaChua = new System.Windows.Forms.GroupBox();
            this.btnExcelSC = new Guna.UI2.WinForms.Guna2Button();
            this.btnResetSC = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaSC = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaSC = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemSC = new Guna.UI2.WinForms.Guna2Button();
            this.cboTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboMaNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtSuaChua = new System.Windows.Forms.DateTimePicker();
            this.txtTinhTrang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboMaKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMaSC = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNgaySC = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblMaSC = new System.Windows.Forms.Label();
            this.gbdsSuaChua = new System.Windows.Forms.GroupBox();
            this.dgvSuaChua = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchSC = new Guna.UI2.WinForms.Guna2TextBox();
            this.ptSearchSC = new System.Windows.Forms.PictureBox();
            this.gbSuaChua.SuspendLayout();
            this.gbdsSuaChua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuaChua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchSC)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSuaChua
            // 
            this.gbSuaChua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSuaChua.Controls.Add(this.btnExcelSC);
            this.gbSuaChua.Controls.Add(this.btnResetSC);
            this.gbSuaChua.Controls.Add(this.btnXoaSC);
            this.gbSuaChua.Controls.Add(this.btnSuaSC);
            this.gbSuaChua.Controls.Add(this.btnThemSC);
            this.gbSuaChua.Controls.Add(this.cboTrangThai);
            this.gbSuaChua.Controls.Add(this.cboMaNV);
            this.gbSuaChua.Controls.Add(this.dtSuaChua);
            this.gbSuaChua.Controls.Add(this.txtTinhTrang);
            this.gbSuaChua.Controls.Add(this.txtDiaChi);
            this.gbSuaChua.Controls.Add(this.txtTenKH);
            this.gbSuaChua.Controls.Add(this.cboMaKH);
            this.gbSuaChua.Controls.Add(this.txtMaSC);
            this.gbSuaChua.Controls.Add(this.lblTrangThai);
            this.gbSuaChua.Controls.Add(this.lblMaNV);
            this.gbSuaChua.Controls.Add(this.lblNgaySC);
            this.gbSuaChua.Controls.Add(this.lblTinhTrang);
            this.gbSuaChua.Controls.Add(this.lblDiaChi);
            this.gbSuaChua.Controls.Add(this.lblTenKH);
            this.gbSuaChua.Controls.Add(this.lblMaKH);
            this.gbSuaChua.Controls.Add(this.lblMaSC);
            this.gbSuaChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSuaChua.Location = new System.Drawing.Point(12, 73);
            this.gbSuaChua.Name = "gbSuaChua";
            this.gbSuaChua.Size = new System.Drawing.Size(1699, 425);
            this.gbSuaChua.TabIndex = 0;
            this.gbSuaChua.TabStop = false;
            this.gbSuaChua.Text = "Thông tin sửa chữa";
            // 
            // btnExcelSC
            // 
            this.btnExcelSC.AutoRoundedCorners = true;
            this.btnExcelSC.BorderRadius = 26;
            this.btnExcelSC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelSC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelSC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelSC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcelSC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcelSC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelSC.ForeColor = System.Drawing.Color.White;
            this.btnExcelSC.Location = new System.Drawing.Point(1045, 364);
            this.btnExcelSC.Name = "btnExcelSC";
            this.btnExcelSC.Size = new System.Drawing.Size(152, 55);
            this.btnExcelSC.TabIndex = 38;
            this.btnExcelSC.Text = "Excel";
            this.btnExcelSC.Click += new System.EventHandler(this.btnExcelSC_Click);
            // 
            // btnResetSC
            // 
            this.btnResetSC.AutoRoundedCorners = true;
            this.btnResetSC.BorderRadius = 26;
            this.btnResetSC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetSC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetSC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetSC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetSC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetSC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSC.ForeColor = System.Drawing.Color.White;
            this.btnResetSC.Location = new System.Drawing.Point(853, 364);
            this.btnResetSC.Name = "btnResetSC";
            this.btnResetSC.Size = new System.Drawing.Size(152, 55);
            this.btnResetSC.TabIndex = 37;
            this.btnResetSC.Text = "Làm mới";
            this.btnResetSC.Click += new System.EventHandler(this.btnResetSC_Click);
            // 
            // btnXoaSC
            // 
            this.btnXoaSC.AutoRoundedCorners = true;
            this.btnXoaSC.BorderRadius = 26;
            this.btnXoaSC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaSC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaSC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaSC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSC.ForeColor = System.Drawing.Color.White;
            this.btnXoaSC.Location = new System.Drawing.Point(659, 364);
            this.btnXoaSC.Name = "btnXoaSC";
            this.btnXoaSC.Size = new System.Drawing.Size(152, 55);
            this.btnXoaSC.TabIndex = 36;
            this.btnXoaSC.Text = "Xóa";
            this.btnXoaSC.Click += new System.EventHandler(this.btnXoaSC_Click);
            // 
            // btnSuaSC
            // 
            this.btnSuaSC.AutoRoundedCorners = true;
            this.btnSuaSC.BorderRadius = 26;
            this.btnSuaSC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaSC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaSC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaSC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaSC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaSC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSC.ForeColor = System.Drawing.Color.White;
            this.btnSuaSC.Location = new System.Drawing.Point(443, 364);
            this.btnSuaSC.Name = "btnSuaSC";
            this.btnSuaSC.Size = new System.Drawing.Size(152, 55);
            this.btnSuaSC.TabIndex = 34;
            this.btnSuaSC.Text = "Sửa";
            this.btnSuaSC.Click += new System.EventHandler(this.btnSuaSC_Click);
            // 
            // btnThemSC
            // 
            this.btnThemSC.AutoRoundedCorners = true;
            this.btnThemSC.BorderRadius = 26;
            this.btnThemSC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemSC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemSC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSC.ForeColor = System.Drawing.Color.White;
            this.btnThemSC.Location = new System.Drawing.Point(231, 364);
            this.btnThemSC.Name = "btnThemSC";
            this.btnThemSC.Size = new System.Drawing.Size(152, 55);
            this.btnThemSC.TabIndex = 33;
            this.btnThemSC.Text = "Lưu";
            this.btnThemSC.Click += new System.EventHandler(this.btnThemSC_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.AutoRoundedCorners = true;
            this.cboTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cboTrangThai.BorderRadius = 17;
            this.cboTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cboTrangThai.ForeColor = System.Drawing.Color.Black;
            this.cboTrangThai.ItemHeight = 30;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Hoàn thành ",
            "Chưa hoàn thành"});
            this.cboTrangThai.Location = new System.Drawing.Point(1447, 189);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(244, 36);
            this.cboTrangThai.TabIndex = 32;
            // 
            // cboMaNV
            // 
            this.cboMaNV.AutoRoundedCorners = true;
            this.cboMaNV.BackColor = System.Drawing.Color.Transparent;
            this.cboMaNV.BorderRadius = 17;
            this.cboMaNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaNV.ForeColor = System.Drawing.Color.Black;
            this.cboMaNV.ItemHeight = 30;
            this.cboMaNV.Location = new System.Drawing.Point(1455, 90);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(227, 36);
            this.cboMaNV.TabIndex = 31;
            // 
            // dtSuaChua
            // 
            this.dtSuaChua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSuaChua.Location = new System.Drawing.Point(853, 271);
            this.dtSuaChua.Name = "dtSuaChua";
            this.dtSuaChua.Size = new System.Drawing.Size(241, 34);
            this.dtSuaChua.TabIndex = 30;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.AutoRoundedCorners = true;
            this.txtTinhTrang.BorderRadius = 25;
            this.txtTinhTrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTinhTrang.DefaultText = "";
            this.txtTinhTrang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTinhTrang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTinhTrang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTinhTrang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTinhTrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinhTrang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTinhTrang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinhTrang.Location = new System.Drawing.Point(796, 182);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.PasswordChar = '\0';
            this.txtTinhTrang.PlaceholderText = "";
            this.txtTinhTrang.SelectedText = "";
            this.txtTinhTrang.Size = new System.Drawing.Size(301, 52);
            this.txtTinhTrang.TabIndex = 29;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoRoundedCorners = true;
            this.txtDiaChi.BorderRadius = 25;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(728, 83);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "Chọn mã khách hàng";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(488, 52);
            this.txtDiaChi.TabIndex = 28;
            // 
            // txtTenKH
            // 
            this.txtTenKH.AutoRoundedCorners = true;
            this.txtTenKH.BorderRadius = 25;
            this.txtTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKH.DefaultText = "";
            this.txtTenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.Location = new System.Drawing.Point(244, 260);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.PlaceholderText = "Chọn mã khách hàng";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.Size = new System.Drawing.Size(301, 52);
            this.txtTenKH.TabIndex = 27;
            // 
            // cboMaKH
            // 
            this.cboMaKH.AutoRoundedCorners = true;
            this.cboMaKH.BackColor = System.Drawing.Color.Transparent;
            this.cboMaKH.BorderRadius = 17;
            this.cboMaKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaKH.ForeColor = System.Drawing.Color.Black;
            this.cboMaKH.ItemHeight = 30;
            this.cboMaKH.Location = new System.Drawing.Point(244, 182);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(297, 36);
            this.cboMaKH.TabIndex = 26;
            this.cboMaKH.SelectedIndexChanged += new System.EventHandler(this.cboMaKH_SelectedIndexChanged);
            // 
            // txtMaSC
            // 
            this.txtMaSC.AutoRoundedCorners = true;
            this.txtMaSC.BorderRadius = 25;
            this.txtMaSC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSC.DefaultText = "";
            this.txtMaSC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaSC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaSC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaSC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSC.Location = new System.Drawing.Point(244, 83);
            this.txtMaSC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMaSC.Name = "txtMaSC";
            this.txtMaSC.PasswordChar = '\0';
            this.txtMaSC.PlaceholderText = "";
            this.txtMaSC.SelectedText = "";
            this.txtMaSC.Size = new System.Drawing.Size(301, 52);
            this.txtMaSC.TabIndex = 25;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(1273, 189);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(152, 29);
            this.lblTrangThai.TabIndex = 24;
            this.lblTrangThai.Text = "Trạng thái  :";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(1251, 97);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(187, 29);
            this.lblMaNV.TabIndex = 23;
            this.lblMaNV.Text = "Mã  nhân viên :";
            // 
            // lblNgaySC
            // 
            this.lblNgaySC.AutoSize = true;
            this.lblNgaySC.Location = new System.Drawing.Point(614, 271);
            this.lblNgaySC.Name = "lblNgaySC";
            this.lblNgaySC.Size = new System.Drawing.Size(197, 29);
            this.lblNgaySC.TabIndex = 22;
            this.lblNgaySC.Text = "Ngày sửa chữa :";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(637, 189);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(138, 29);
            this.lblTinhTrang.TabIndex = 21;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(614, 97);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(107, 29);
            this.lblDiaChi.TabIndex = 20;
            this.lblDiaChi.Text = "Địa chỉ :";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(77, 271);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(136, 29);
            this.lblTenKH.TabIndex = 19;
            this.lblTenKH.Text = "Họ và tên :";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(6, 189);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(208, 29);
            this.lblMaKH.TabIndex = 18;
            this.lblMaKH.Text = "Mã  khách hàng :";
            // 
            // lblMaSC
            // 
            this.lblMaSC.AutoSize = true;
            this.lblMaSC.Location = new System.Drawing.Point(34, 97);
            this.lblMaSC.Name = "lblMaSC";
            this.lblMaSC.Size = new System.Drawing.Size(179, 29);
            this.lblMaSC.TabIndex = 17;
            this.lblMaSC.Text = "Mã  sửa chữa :";
            // 
            // gbdsSuaChua
            // 
            this.gbdsSuaChua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbdsSuaChua.Controls.Add(this.dgvSuaChua);
            this.gbdsSuaChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdsSuaChua.Location = new System.Drawing.Point(12, 504);
            this.gbdsSuaChua.Name = "gbdsSuaChua";
            this.gbdsSuaChua.Size = new System.Drawing.Size(1682, 407);
            this.gbdsSuaChua.TabIndex = 1;
            this.gbdsSuaChua.TabStop = false;
            this.gbdsSuaChua.Text = "Danh sách sửa chữa";
            // 
            // dgvSuaChua
            // 
            this.dgvSuaChua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuaChua.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuaChua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvSuaChua.Location = new System.Drawing.Point(19, 44);
            this.dgvSuaChua.Name = "dgvSuaChua";
            this.dgvSuaChua.RowHeadersWidth = 51;
            this.dgvSuaChua.RowTemplate.Height = 24;
            this.dgvSuaChua.Size = new System.Drawing.Size(1631, 342);
            this.dgvSuaChua.TabIndex = 1;
            this.dgvSuaChua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuaChua_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSC";
            this.Column1.HeaderText = "Mã sửa chữa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaKH";
            this.Column2.HeaderText = "Mã khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TinhTrang";
            this.Column3.HeaderText = "Tình trạng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 330;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgaySC";
            this.Column4.HeaderText = "Ngày sửa chữa";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaNV";
            this.Column5.HeaderText = "Mã nhân viên";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "TrangThai";
            this.Column6.HeaderText = "Trạng thái";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // txtSearchSC
            // 
            this.txtSearchSC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchSC.AutoRoundedCorners = true;
            this.txtSearchSC.BorderRadius = 25;
            this.txtSearchSC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchSC.DefaultText = "";
            this.txtSearchSC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchSC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchSC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchSC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchSC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchSC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchSC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchSC.Location = new System.Drawing.Point(1253, 23);
            this.txtSearchSC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearchSC.Name = "txtSearchSC";
            this.txtSearchSC.PasswordChar = '\0';
            this.txtSearchSC.PlaceholderText = "Tìm kiếm ";
            this.txtSearchSC.SelectedText = "";
            this.txtSearchSC.Size = new System.Drawing.Size(302, 52);
            this.txtSearchSC.TabIndex = 33;
            this.txtSearchSC.Tag = "";
            // 
            // ptSearchSC
            // 
            this.ptSearchSC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptSearchSC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptSearchSC.Image = global::GUI.Properties.Resources.search_interface_symbol;
            this.ptSearchSC.Location = new System.Drawing.Point(1577, 34);
            this.ptSearchSC.Name = "ptSearchSC";
            this.ptSearchSC.Size = new System.Drawing.Size(45, 41);
            this.ptSearchSC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptSearchSC.TabIndex = 34;
            this.ptSearchSC.TabStop = false;
            this.ptSearchSC.Click += new System.EventHandler(this.ptSearchSC_Click);
            // 
            // frm_SuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1715, 923);
            this.Controls.Add(this.ptSearchSC);
            this.Controls.Add(this.txtSearchSC);
            this.Controls.Add(this.gbdsSuaChua);
            this.Controls.Add(this.gbSuaChua);
            this.Name = "frm_SuaChua";
            this.Text = "Sửa chữa";
            this.Load += new System.EventHandler(this.frm_SuaChua_Load);
            this.gbSuaChua.ResumeLayout(false);
            this.gbSuaChua.PerformLayout();
            this.gbdsSuaChua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuaChua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchSC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSuaChua;
        private System.Windows.Forms.GroupBox gbdsSuaChua;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblNgaySC;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblMaSC;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSC;
        private Guna.UI2.WinForms.Guna2TextBox txtTinhTrang;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaKH;
        private Guna.UI2.WinForms.Guna2ComboBox cboTrangThai;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaNV;
        private System.Windows.Forms.DateTimePicker dtSuaChua;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchSC;
        private System.Windows.Forms.PictureBox ptSearchSC;
        private Guna.UI2.WinForms.Guna2Button btnExcelSC;
        private Guna.UI2.WinForms.Guna2Button btnResetSC;
        private Guna.UI2.WinForms.Guna2Button btnXoaSC;
        private Guna.UI2.WinForms.Guna2Button btnSuaSC;
        private Guna.UI2.WinForms.Guna2Button btnThemSC;
        private System.Windows.Forms.DataGridView dgvSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
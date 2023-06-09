﻿namespace GUI
{
    partial class frm_KhachHang
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
            this.gbDsKhachHang = new System.Windows.Forms.GroupBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbKhachHang = new System.Windows.Forms.GroupBox();
            this.lblTrangThaiKH = new System.Windows.Forms.Label();
            this.cbonTrangThaiKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnExcelKKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnResetKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemKH = new Guna.UI2.WinForms.Guna2Button();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtSoDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSearchKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ptSearchKH = new System.Windows.Forms.PictureBox();
            this.gbDsKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.gbKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchKH)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDsKhachHang
            // 
            this.gbDsKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDsKhachHang.Controls.Add(this.dgvKhachHang);
            this.gbDsKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDsKhachHang.Location = new System.Drawing.Point(12, 530);
            this.gbDsKhachHang.Name = "gbDsKhachHang";
            this.gbDsKhachHang.Size = new System.Drawing.Size(1534, 367);
            this.gbDsKhachHang.TabIndex = 1;
            this.gbDsKhachHang.TabStop = false;
            this.gbDsKhachHang.Text = "Danh sách khách hàng";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvKhachHang.Location = new System.Drawing.Point(30, 33);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(1498, 308);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 220;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa chỉ ";
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
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TrangThai";
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // txtMaKH
            // 
            this.txtMaKH.AutoRoundedCorners = true;
            this.txtMaKH.BorderRadius = 25;
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.DefaultText = "";
            this.txtMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Location = new System.Drawing.Point(251, 77);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PasswordChar = '\0';
            this.txtMaKH.PlaceholderText = "";
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.Size = new System.Drawing.Size(301, 52);
            this.txtMaKH.TabIndex = 1;
            // 
            // gbKhachHang
            // 
            this.gbKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbKhachHang.Controls.Add(this.lblTrangThaiKH);
            this.gbKhachHang.Controls.Add(this.cbonTrangThaiKH);
            this.gbKhachHang.Controls.Add(this.btnExcelKKH);
            this.gbKhachHang.Controls.Add(this.btnResetKH);
            this.gbKhachHang.Controls.Add(this.btnXoaKH);
            this.gbKhachHang.Controls.Add(this.btnSuaKH);
            this.gbKhachHang.Controls.Add(this.btnThemKH);
            this.gbKhachHang.Controls.Add(this.lblSoDT);
            this.gbKhachHang.Controls.Add(this.lblDiaChi);
            this.gbKhachHang.Controls.Add(this.lblTenKH);
            this.gbKhachHang.Controls.Add(this.lblMaKH);
            this.gbKhachHang.Controls.Add(this.txtSoDT);
            this.gbKhachHang.Controls.Add(this.txtDiaChi);
            this.gbKhachHang.Controls.Add(this.txtTenKH);
            this.gbKhachHang.Controls.Add(this.txtMaKH);
            this.gbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKhachHang.Location = new System.Drawing.Point(12, 83);
            this.gbKhachHang.Name = "gbKhachHang";
            this.gbKhachHang.Size = new System.Drawing.Size(1534, 429);
            this.gbKhachHang.TabIndex = 0;
            this.gbKhachHang.TabStop = false;
            this.gbKhachHang.Text = "Thông tin khách hàng";
            // 
            // lblTrangThaiKH
            // 
            this.lblTrangThaiKH.AutoSize = true;
            this.lblTrangThaiKH.Location = new System.Drawing.Point(751, 160);
            this.lblTrangThaiKH.Name = "lblTrangThaiKH";
            this.lblTrangThaiKH.Size = new System.Drawing.Size(145, 29);
            this.lblTrangThaiKH.TabIndex = 29;
            this.lblTrangThaiKH.Text = "Trạng thái :";
            // 
            // cbonTrangThaiKH
            // 
            this.cbonTrangThaiKH.AutoRoundedCorners = true;
            this.cbonTrangThaiKH.BackColor = System.Drawing.Color.Transparent;
            this.cbonTrangThaiKH.BorderRadius = 17;
            this.cbonTrangThaiKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbonTrangThaiKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonTrangThaiKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbonTrangThaiKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbonTrangThaiKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbonTrangThaiKH.ForeColor = System.Drawing.Color.Black;
            this.cbonTrangThaiKH.ItemHeight = 30;
            this.cbonTrangThaiKH.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbonTrangThaiKH.Location = new System.Drawing.Point(911, 160);
            this.cbonTrangThaiKH.Name = "cbonTrangThaiKH";
            this.cbonTrangThaiKH.Size = new System.Drawing.Size(181, 36);
            this.cbonTrangThaiKH.TabIndex = 28;
            // 
            // btnExcelKKH
            // 
            this.btnExcelKKH.AutoRoundedCorners = true;
            this.btnExcelKKH.BorderRadius = 26;
            this.btnExcelKKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelKKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelKKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelKKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcelKKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcelKKH.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelKKH.ForeColor = System.Drawing.Color.White;
            this.btnExcelKKH.Location = new System.Drawing.Point(1060, 354);
            this.btnExcelKKH.Name = "btnExcelKKH";
            this.btnExcelKKH.Size = new System.Drawing.Size(152, 55);
            this.btnExcelKKH.TabIndex = 27;
            this.btnExcelKKH.Text = "Excel";
            this.btnExcelKKH.Click += new System.EventHandler(this.btnExcelKKH_Click);
            // 
            // btnResetKH
            // 
            this.btnResetKH.AutoRoundedCorners = true;
            this.btnResetKH.BorderRadius = 26;
            this.btnResetKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetKH.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetKH.ForeColor = System.Drawing.Color.White;
            this.btnResetKH.Location = new System.Drawing.Point(870, 354);
            this.btnResetKH.Name = "btnResetKH";
            this.btnResetKH.Size = new System.Drawing.Size(152, 55);
            this.btnResetKH.TabIndex = 21;
            this.btnResetKH.Text = "Làm mới";
            this.btnResetKH.Click += new System.EventHandler(this.btnResetKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.AutoRoundedCorners = true;
            this.btnXoaKH.BorderRadius = 26;
            this.btnXoaKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaKH.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKH.ForeColor = System.Drawing.Color.White;
            this.btnXoaKH.Location = new System.Drawing.Point(684, 354);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(152, 55);
            this.btnXoaKH.TabIndex = 20;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.AutoRoundedCorners = true;
            this.btnSuaKH.BorderRadius = 26;
            this.btnSuaKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaKH.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKH.ForeColor = System.Drawing.Color.White;
            this.btnSuaKH.Location = new System.Drawing.Point(500, 354);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(152, 55);
            this.btnSuaKH.TabIndex = 19;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.AutoRoundedCorners = true;
            this.btnThemKH.BorderRadius = 26;
            this.btnThemKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemKH.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.ForeColor = System.Drawing.Color.White;
            this.btnThemKH.Location = new System.Drawing.Point(307, 354);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(152, 55);
            this.btnThemKH.TabIndex = 18;
            this.btnThemKH.Text = "Lưu";
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(715, 86);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(181, 29);
            this.lblSoDT.TabIndex = 15;
            this.lblSoDT.Text = "Số điện thoại :";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(124, 238);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(107, 29);
            this.lblDiaChi.TabIndex = 14;
            this.lblDiaChi.Text = "Địa chỉ :";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(95, 160);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(136, 29);
            this.lblTenKH.TabIndex = 13;
            this.lblTenKH.Text = "Họ và tên :";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(37, 86);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(194, 29);
            this.lblMaKH.TabIndex = 12;
            this.lblMaKH.Text = "Mã khách hàng:";
            // 
            // txtSoDT
            // 
            this.txtSoDT.AutoRoundedCorners = true;
            this.txtSoDT.BorderRadius = 25;
            this.txtSoDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDT.DefaultText = "";
            this.txtSoDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDT.Location = new System.Drawing.Point(911, 77);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.PasswordChar = '\0';
            this.txtSoDT.PlaceholderText = "";
            this.txtSoDT.SelectedText = "";
            this.txtSoDT.Size = new System.Drawing.Size(301, 52);
            this.txtSoDT.TabIndex = 4;
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
            this.txtDiaChi.Location = new System.Drawing.Point(251, 224);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(547, 52);
            this.txtDiaChi.TabIndex = 3;
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
            this.txtTenKH.Location = new System.Drawing.Point(251, 160);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.PlaceholderText = "";
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.Size = new System.Drawing.Size(301, 52);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtSearchKH
            // 
            this.txtSearchKH.AutoRoundedCorners = true;
            this.txtSearchKH.BorderRadius = 25;
            this.txtSearchKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchKH.DefaultText = "";
            this.txtSearchKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchKH.Location = new System.Drawing.Point(1163, 38);
            this.txtSearchKH.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearchKH.Name = "txtSearchKH";
            this.txtSearchKH.PasswordChar = '\0';
            this.txtSearchKH.PlaceholderText = "Tìm kiếm mã hoặc số điện thoại";
            this.txtSearchKH.SelectedText = "";
            this.txtSearchKH.Size = new System.Drawing.Size(336, 52);
            this.txtSearchKH.TabIndex = 22;
            this.txtSearchKH.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(933, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 22;
            // 
            // ptSearchKH
            // 
            this.ptSearchKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptSearchKH.Image = global::GUI.Properties.Resources.search_interface_symbol;
            this.ptSearchKH.Location = new System.Drawing.Point(1506, 49);
            this.ptSearchKH.Name = "ptSearchKH";
            this.ptSearchKH.Size = new System.Drawing.Size(45, 41);
            this.ptSearchKH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptSearchKH.TabIndex = 23;
            this.ptSearchKH.TabStop = false;
            this.ptSearchKH.Click += new System.EventHandler(this.ptSearchKH_Click);
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1583, 909);
            this.Controls.Add(this.ptSearchKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearchKH);
            this.Controls.Add(this.gbDsKhachHang);
            this.Controls.Add(this.gbKhachHang);
            this.Name = "frm_KhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.frm_KhachHang_Load);
            this.gbDsKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.gbKhachHang.ResumeLayout(false);
            this.gbKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDsKhachHang;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        private System.Windows.Forms.GroupBox gbKhachHang;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDT;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaKH;
        private Guna.UI2.WinForms.Guna2Button btnResetKH;
        private Guna.UI2.WinForms.Guna2Button btnXoaKH;
        private Guna.UI2.WinForms.Guna2Button btnSuaKH;
        private Guna.UI2.WinForms.Guna2Button btnThemKH;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.PictureBox ptSearchKH;
        private Guna.UI2.WinForms.Guna2Button btnExcelKKH;
        private System.Windows.Forms.Label lblTrangThaiKH;
        private Guna.UI2.WinForms.Guna2ComboBox cbonTrangThaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
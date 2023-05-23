namespace GUI
{
    partial class frm_GiaNuoc
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
            this.gbGiaNuoc = new System.Windows.Forms.GroupBox();
            this.txtGiaNuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaDK = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcelGN = new Guna.UI2.WinForms.Guna2Button();
            this.cboMaN = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnResetGN = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaGN = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaGN = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemGN = new Guna.UI2.WinForms.Guna2Button();
            this.cboMaKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaN = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.gbDSGiaNuoc = new System.Windows.Forms.GroupBox();
            this.dgvGiaNuoc = new System.Windows.Forms.DataGridView();
            this.txtSearchGN = new Guna.UI2.WinForms.Guna2TextBox();
            this.ptSearchGN = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbGiaNuoc.SuspendLayout();
            this.gbDSGiaNuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchGN)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGiaNuoc
            // 
            this.gbGiaNuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGiaNuoc.Controls.Add(this.txtGiaNuoc);
            this.gbGiaNuoc.Controls.Add(this.txtMaDK);
            this.gbGiaNuoc.Controls.Add(this.label1);
            this.gbGiaNuoc.Controls.Add(this.btnExcelGN);
            this.gbGiaNuoc.Controls.Add(this.cboMaN);
            this.gbGiaNuoc.Controls.Add(this.btnResetGN);
            this.gbGiaNuoc.Controls.Add(this.btnXoaGN);
            this.gbGiaNuoc.Controls.Add(this.btnSuaGN);
            this.gbGiaNuoc.Controls.Add(this.btnThemGN);
            this.gbGiaNuoc.Controls.Add(this.cboMaKH);
            this.gbGiaNuoc.Controls.Add(this.txtTenKH);
            this.gbGiaNuoc.Controls.Add(this.lblGiaTien);
            this.gbGiaNuoc.Controls.Add(this.lblTenKH);
            this.gbGiaNuoc.Controls.Add(this.lblMaN);
            this.gbGiaNuoc.Controls.Add(this.lblMaKH);
            this.gbGiaNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGiaNuoc.Location = new System.Drawing.Point(12, 84);
            this.gbGiaNuoc.Name = "gbGiaNuoc";
            this.gbGiaNuoc.Size = new System.Drawing.Size(1649, 388);
            this.gbGiaNuoc.TabIndex = 0;
            this.gbGiaNuoc.TabStop = false;
            this.gbGiaNuoc.Text = "Thông tin giá nước";
            // 
            // txtGiaNuoc
            // 
            this.txtGiaNuoc.AutoRoundedCorners = true;
            this.txtGiaNuoc.BorderRadius = 25;
            this.txtGiaNuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaNuoc.DefaultText = "";
            this.txtGiaNuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaNuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaNuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaNuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGiaNuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaNuoc.Location = new System.Drawing.Point(871, 182);
            this.txtGiaNuoc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtGiaNuoc.Name = "txtGiaNuoc";
            this.txtGiaNuoc.PasswordChar = '\0';
            this.txtGiaNuoc.PlaceholderText = "";
            this.txtGiaNuoc.SelectedText = "";
            this.txtGiaNuoc.Size = new System.Drawing.Size(301, 52);
            this.txtGiaNuoc.TabIndex = 33;
            // 
            // txtMaDK
            // 
            this.txtMaDK.AutoRoundedCorners = true;
            this.txtMaDK.BorderRadius = 25;
            this.txtMaDK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDK.DefaultText = "";
            this.txtMaDK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaDK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDK.Location = new System.Drawing.Point(286, 87);
            this.txtMaDK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMaDK.Name = "txtMaDK";
            this.txtMaDK.PasswordChar = '\0';
            this.txtMaDK.PlaceholderText = "";
            this.txtMaDK.SelectedText = "";
            this.txtMaDK.Size = new System.Drawing.Size(301, 52);
            this.txtMaDK.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã đăng ký :";
            // 
            // btnExcelGN
            // 
            this.btnExcelGN.AutoRoundedCorners = true;
            this.btnExcelGN.BorderRadius = 26;
            this.btnExcelGN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelGN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelGN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelGN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcelGN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcelGN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelGN.ForeColor = System.Drawing.Color.White;
            this.btnExcelGN.Location = new System.Drawing.Point(1016, 308);
            this.btnExcelGN.Name = "btnExcelGN";
            this.btnExcelGN.Size = new System.Drawing.Size(152, 55);
            this.btnExcelGN.TabIndex = 30;
            this.btnExcelGN.Text = "Excel";
            this.btnExcelGN.Click += new System.EventHandler(this.btnExcelGN_Click);
            // 
            // cboMaN
            // 
            this.cboMaN.AutoRoundedCorners = true;
            this.cboMaN.BackColor = System.Drawing.Color.Transparent;
            this.cboMaN.BorderRadius = 17;
            this.cboMaN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaN.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cboMaN.ForeColor = System.Drawing.Color.Black;
            this.cboMaN.ItemHeight = 30;
            this.cboMaN.Items.AddRange(new object[] {
            "nds01",
            "nds02",
            "nds03"});
            this.cboMaN.Location = new System.Drawing.Point(871, 126);
            this.cboMaN.Name = "cboMaN";
            this.cboMaN.Size = new System.Drawing.Size(297, 36);
            this.cboMaN.TabIndex = 18;
            // 
            // btnResetGN
            // 
            this.btnResetGN.AutoRoundedCorners = true;
            this.btnResetGN.BorderRadius = 26;
            this.btnResetGN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetGN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetGN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetGN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetGN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetGN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGN.ForeColor = System.Drawing.Color.White;
            this.btnResetGN.Location = new System.Drawing.Point(818, 308);
            this.btnResetGN.Name = "btnResetGN";
            this.btnResetGN.Size = new System.Drawing.Size(152, 55);
            this.btnResetGN.TabIndex = 28;
            this.btnResetGN.Text = "Làm mới";
            this.btnResetGN.Click += new System.EventHandler(this.btnResetGN_Click);
            // 
            // btnXoaGN
            // 
            this.btnXoaGN.AutoRoundedCorners = true;
            this.btnXoaGN.BorderRadius = 26;
            this.btnXoaGN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaGN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaGN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaGN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaGN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaGN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaGN.ForeColor = System.Drawing.Color.White;
            this.btnXoaGN.Location = new System.Drawing.Point(620, 308);
            this.btnXoaGN.Name = "btnXoaGN";
            this.btnXoaGN.Size = new System.Drawing.Size(152, 55);
            this.btnXoaGN.TabIndex = 27;
            this.btnXoaGN.Text = "Xóa";
            this.btnXoaGN.Click += new System.EventHandler(this.btnXoaGN_Click);
            // 
            // btnSuaGN
            // 
            this.btnSuaGN.AutoRoundedCorners = true;
            this.btnSuaGN.BorderRadius = 26;
            this.btnSuaGN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaGN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaGN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaGN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaGN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaGN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaGN.ForeColor = System.Drawing.Color.White;
            this.btnSuaGN.Location = new System.Drawing.Point(419, 308);
            this.btnSuaGN.Name = "btnSuaGN";
            this.btnSuaGN.Size = new System.Drawing.Size(152, 55);
            this.btnSuaGN.TabIndex = 26;
            this.btnSuaGN.Text = "Sửa";
            this.btnSuaGN.Click += new System.EventHandler(this.btnSuaGN_Click);
            // 
            // btnThemGN
            // 
            this.btnThemGN.AutoRoundedCorners = true;
            this.btnThemGN.BorderRadius = 26;
            this.btnThemGN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemGN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemGN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemGN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemGN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemGN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGN.ForeColor = System.Drawing.Color.White;
            this.btnThemGN.Location = new System.Drawing.Point(219, 308);
            this.btnThemGN.Name = "btnThemGN";
            this.btnThemGN.Size = new System.Drawing.Size(152, 55);
            this.btnThemGN.TabIndex = 25;
            this.btnThemGN.Text = "Lưu";
            this.btnThemGN.Click += new System.EventHandler(this.btnThemGN_Click);
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
            this.cboMaKH.Location = new System.Drawing.Point(286, 198);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(297, 36);
            this.cboMaKH.TabIndex = 19;
            this.cboMaKH.SelectedIndexChanged += new System.EventHandler(this.cboMaKH_SelectedIndexChanged);
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
            this.txtTenKH.Location = new System.Drawing.Point(871, 46);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.PlaceholderText = "Chọn mã khách hàng ";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.Size = new System.Drawing.Size(301, 52);
            this.txtTenKH.TabIndex = 20;
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Location = new System.Drawing.Point(747, 198);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(117, 29);
            this.lblGiaTien.TabIndex = 16;
            this.lblGiaTien.Text = "Giá tiền :";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(652, 58);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(212, 29);
            this.lblTenKH.TabIndex = 15;
            this.lblTenKH.Text = "Tên khách hàng :";
            // 
            // lblMaN
            // 
            this.lblMaN.AutoSize = true;
            this.lblMaN.Location = new System.Drawing.Point(730, 133);
            this.lblMaN.Name = "lblMaN";
            this.lblMaN.Size = new System.Drawing.Size(125, 29);
            this.lblMaN.TabIndex = 14;
            this.lblMaN.Text = "Mã nước :";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(69, 198);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(201, 29);
            this.lblMaKH.TabIndex = 13;
            this.lblMaKH.Text = "Mã khách hàng :";
            // 
            // gbDSGiaNuoc
            // 
            this.gbDSGiaNuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDSGiaNuoc.Controls.Add(this.dgvGiaNuoc);
            this.gbDSGiaNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDSGiaNuoc.Location = new System.Drawing.Point(12, 501);
            this.gbDSGiaNuoc.Name = "gbDSGiaNuoc";
            this.gbDSGiaNuoc.Size = new System.Drawing.Size(1649, 212);
            this.gbDSGiaNuoc.TabIndex = 1;
            this.gbDSGiaNuoc.TabStop = false;
            this.gbDSGiaNuoc.Text = "Danh sách giá nước";
            // 
            // dgvGiaNuoc
            // 
            this.dgvGiaNuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGiaNuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvGiaNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvGiaNuoc.Location = new System.Drawing.Point(103, 33);
            this.dgvGiaNuoc.Name = "dgvGiaNuoc";
            this.dgvGiaNuoc.RowHeadersWidth = 51;
            this.dgvGiaNuoc.RowTemplate.Height = 24;
            this.dgvGiaNuoc.Size = new System.Drawing.Size(1167, 160);
            this.dgvGiaNuoc.TabIndex = 31;
            this.dgvGiaNuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaNuoc_CellContentClick);
            // 
            // txtSearchGN
            // 
            this.txtSearchGN.AutoRoundedCorners = true;
            this.txtSearchGN.BorderRadius = 25;
            this.txtSearchGN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchGN.DefaultText = "";
            this.txtSearchGN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchGN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchGN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchGN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchGN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchGN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchGN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchGN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchGN.Location = new System.Drawing.Point(1230, 37);
            this.txtSearchGN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearchGN.Name = "txtSearchGN";
            this.txtSearchGN.PasswordChar = '\0';
            this.txtSearchGN.PlaceholderText = "Mã đăng ký hoặc mã khách hàng";
            this.txtSearchGN.SelectedText = "";
            this.txtSearchGN.Size = new System.Drawing.Size(345, 52);
            this.txtSearchGN.TabIndex = 23;
            this.txtSearchGN.Tag = "";
            // 
            // ptSearchGN
            // 
            this.ptSearchGN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptSearchGN.Image = global::GUI.Properties.Resources.search_interface_symbol;
            this.ptSearchGN.Location = new System.Drawing.Point(1582, 48);
            this.ptSearchGN.Name = "ptSearchGN";
            this.ptSearchGN.Size = new System.Drawing.Size(45, 41);
            this.ptSearchGN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptSearchGN.TabIndex = 24;
            this.ptSearchGN.TabStop = false;
            this.ptSearchGN.Click += new System.EventHandler(this.ptSearchGN_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDK";
            this.Column1.HeaderText = "Mã đăng ký";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaKH";
            this.Column2.HeaderText = "Mã khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaNuocSD";
            this.Column3.HeaderText = "Mã nước";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GiaTien";
            this.Column4.HeaderText = "Giá tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // frm_GiaNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1673, 721);
            this.Controls.Add(this.ptSearchGN);
            this.Controls.Add(this.txtSearchGN);
            this.Controls.Add(this.gbDSGiaNuoc);
            this.Controls.Add(this.gbGiaNuoc);
            this.Name = "frm_GiaNuoc";
            this.Text = "frm_GiaNuoc";
            this.Load += new System.EventHandler(this.frm_GiaNuoc_Load);
            this.gbGiaNuoc.ResumeLayout(false);
            this.gbGiaNuoc.PerformLayout();
            this.gbDSGiaNuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchGN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGiaNuoc;
        private System.Windows.Forms.GroupBox gbDSGiaNuoc;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaN;
        private System.Windows.Forms.Label lblMaKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaKH;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchGN;
        private System.Windows.Forms.PictureBox ptSearchGN;
        private Guna.UI2.WinForms.Guna2Button btnThemGN;
        private Guna.UI2.WinForms.Guna2Button btnSuaGN;
        private Guna.UI2.WinForms.Guna2Button btnXoaGN;
        private Guna.UI2.WinForms.Guna2Button btnResetGN;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaN;
        private Guna.UI2.WinForms.Guna2Button btnExcelGN;
        private System.Windows.Forms.DataGridView dgvGiaNuoc;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDK;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
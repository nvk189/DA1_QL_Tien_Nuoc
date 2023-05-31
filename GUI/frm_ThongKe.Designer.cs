namespace GUI
{
    partial class frm_ThongKe
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
            this.pnKhachHang = new System.Windows.Forms.Panel();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnNhanVien = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.pnSoKhoiNuoc = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNuocSD = new System.Windows.Forms.Label();
            this.pnTongTien = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.gbHoaDon = new System.Windows.Forms.GroupBox();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.dtSearchtime = new System.Windows.Forms.DateTimePicker();
            this.ptSearchDate = new System.Windows.Forms.PictureBox();
            this.ptSearchTK = new System.Windows.Forms.PictureBox();
            this.txtSearchTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExcelTK = new Guna.UI2.WinForms.Guna2Button();
            this.pnKhachHang.SuspendLayout();
            this.pnNhanVien.SuspendLayout();
            this.pnSoKhoiNuoc.SuspendLayout();
            this.pnTongTien.SuspendLayout();
            this.gbHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchTK)).BeginInit();
            this.SuspendLayout();
            // 
            // pnKhachHang
            // 
            this.pnKhachHang.BackColor = System.Drawing.Color.SkyBlue;
            this.pnKhachHang.Controls.Add(this.lblNhanVien);
            this.pnKhachHang.Controls.Add(this.label1);
            this.pnKhachHang.Location = new System.Drawing.Point(91, 73);
            this.pnKhachHang.Name = "pnKhachHang";
            this.pnKhachHang.Size = new System.Drawing.Size(274, 151);
            this.pnKhachHang.TabIndex = 0;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.ForeColor = System.Drawing.Color.White;
            this.lblNhanVien.Location = new System.Drawing.Point(120, 63);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(27, 29);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhân viên";
            // 
            // pnNhanVien
            // 
            this.pnNhanVien.BackColor = System.Drawing.Color.DarkViolet;
            this.pnNhanVien.Controls.Add(this.label2);
            this.pnNhanVien.Controls.Add(this.lbKhachHang);
            this.pnNhanVien.Location = new System.Drawing.Point(475, 73);
            this.pnNhanVien.Name = "pnNhanVien";
            this.pnNhanVien.Size = new System.Drawing.Size(282, 151);
            this.pnNhanVien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khách hàng";
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachHang.ForeColor = System.Drawing.Color.White;
            this.lbKhachHang.Location = new System.Drawing.Point(100, 65);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(27, 29);
            this.lbKhachHang.TabIndex = 1;
            this.lbKhachHang.Text = "0";
            // 
            // pnSoKhoiNuoc
            // 
            this.pnSoKhoiNuoc.BackColor = System.Drawing.Color.SkyBlue;
            this.pnSoKhoiNuoc.Controls.Add(this.label3);
            this.pnSoKhoiNuoc.Controls.Add(this.lblNuocSD);
            this.pnSoKhoiNuoc.Location = new System.Drawing.Point(860, 73);
            this.pnSoKhoiNuoc.Name = "pnSoKhoiNuoc";
            this.pnSoKhoiNuoc.Size = new System.Drawing.Size(287, 151);
            this.pnSoKhoiNuoc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nước sử dụng";
            // 
            // lblNuocSD
            // 
            this.lblNuocSD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNuocSD.AutoSize = true;
            this.lblNuocSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuocSD.ForeColor = System.Drawing.Color.White;
            this.lblNuocSD.Location = new System.Drawing.Point(113, 65);
            this.lblNuocSD.Name = "lblNuocSD";
            this.lblNuocSD.Size = new System.Drawing.Size(27, 29);
            this.lblNuocSD.TabIndex = 2;
            this.lblNuocSD.Text = "0";
            // 
            // pnTongTien
            // 
            this.pnTongTien.BackColor = System.Drawing.Color.MediumVioletRed;
            this.pnTongTien.Controls.Add(this.label4);
            this.pnTongTien.Controls.Add(this.lblTongTien);
            this.pnTongTien.Location = new System.Drawing.Point(1240, 73);
            this.pnTongTien.Name = "pnTongTien";
            this.pnTongTien.Size = new System.Drawing.Size(306, 151);
            this.pnTongTien.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tổng tiền";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.White;
            this.lblTongTien.Location = new System.Drawing.Point(132, 65);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(27, 29);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "0";
            // 
            // gbHoaDon
            // 
            this.gbHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHoaDon.Controls.Add(this.dgvThongKe);
            this.gbHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHoaDon.Location = new System.Drawing.Point(21, 413);
            this.gbHoaDon.Name = "gbHoaDon";
            this.gbHoaDon.Size = new System.Drawing.Size(1828, 546);
            this.gbHoaDon.TabIndex = 2;
            this.gbHoaDon.TabStop = false;
            this.gbHoaDon.Text = "Danh sách hóa đơn";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvThongKe.Location = new System.Drawing.Point(12, 33);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(1810, 418);
            this.dgvThongKe.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã HD";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaKH";
            this.Column2.HeaderText = "Mã KH";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaNV";
            this.Column3.HeaderText = "Mã NV";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoCTT";
            this.Column4.HeaderText = "Số cũ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoCTS";
            this.Column5.HeaderText = "Số mới";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GiaTien";
            this.Column6.HeaderText = "giá tiền";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Thue";
            this.Column7.HeaderText = "Thuế";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NgayThanhToan";
            this.Column8.HeaderText = "Ngày Thanh toán";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 180;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "HinhThucTT";
            this.Column9.HeaderText = "Hình thức thanh toán";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 180;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "TongTien";
            this.Column10.HeaderText = "Tổng tiền";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // btnReset
            // 
            this.btnReset.AutoRoundedCorners = true;
            this.btnReset.BorderRadius = 26;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1406, 338);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 55);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "Làm mới";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtSearchtime
            // 
            this.dtSearchtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSearchtime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSearchtime.Location = new System.Drawing.Point(402, 341);
            this.dtSearchtime.Name = "dtSearchtime";
            this.dtSearchtime.Size = new System.Drawing.Size(283, 38);
            this.dtSearchtime.TabIndex = 36;
            // 
            // ptSearchDate
            // 
            this.ptSearchDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptSearchDate.Image = global::GUI.Properties.Resources.search_interface_symbol;
            this.ptSearchDate.Location = new System.Drawing.Point(691, 341);
            this.ptSearchDate.Name = "ptSearchDate";
            this.ptSearchDate.Size = new System.Drawing.Size(45, 41);
            this.ptSearchDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptSearchDate.TabIndex = 35;
            this.ptSearchDate.TabStop = false;
            this.ptSearchDate.Click += new System.EventHandler(this.ptSearchDate_Click);
            // 
            // ptSearchTK
            // 
            this.ptSearchTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptSearchTK.Image = global::GUI.Properties.Resources.search_interface_symbol;
            this.ptSearchTK.Location = new System.Drawing.Point(1118, 349);
            this.ptSearchTK.Name = "ptSearchTK";
            this.ptSearchTK.Size = new System.Drawing.Size(45, 41);
            this.ptSearchTK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptSearchTK.TabIndex = 33;
            this.ptSearchTK.TabStop = false;
            this.ptSearchTK.Click += new System.EventHandler(this.ptSearchTK_Click);
            // 
            // txtSearchTK
            // 
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
            this.txtSearchTK.Location = new System.Drawing.Point(797, 338);
            this.txtSearchTK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearchTK.Name = "txtSearchTK";
            this.txtSearchTK.PasswordChar = '\0';
            this.txtSearchTK.PlaceholderText = "Tháng hoặc Năm";
            this.txtSearchTK.SelectedText = "";
            this.txtSearchTK.Size = new System.Drawing.Size(314, 52);
            this.txtSearchTK.TabIndex = 32;
            this.txtSearchTK.Tag = "";
            // 
            // btnExcelTK
            // 
            this.btnExcelTK.AutoRoundedCorners = true;
            this.btnExcelTK.BorderRadius = 26;
            this.btnExcelTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcelTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcelTK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelTK.ForeColor = System.Drawing.Color.White;
            this.btnExcelTK.Location = new System.Drawing.Point(1212, 338);
            this.btnExcelTK.Name = "btnExcelTK";
            this.btnExcelTK.Size = new System.Drawing.Size(152, 55);
            this.btnExcelTK.TabIndex = 31;
            this.btnExcelTK.Text = "Excel";
            this.btnExcelTK.Click += new System.EventHandler(this.btnExcelTK_Click);
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1852, 980);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtSearchTK);
            this.Controls.Add(this.ptSearchTK);
            this.Controls.Add(this.dtSearchtime);
            this.Controls.Add(this.btnExcelTK);
            this.Controls.Add(this.gbHoaDon);
            this.Controls.Add(this.ptSearchDate);
            this.Controls.Add(this.pnKhachHang);
            this.Controls.Add(this.pnNhanVien);
            this.Controls.Add(this.pnSoKhoiNuoc);
            this.Controls.Add(this.pnTongTien);
            this.Name = "frm_ThongKe";
            this.Text = "Thống kê";
            this.pnKhachHang.ResumeLayout(false);
            this.pnKhachHang.PerformLayout();
            this.pnNhanVien.ResumeLayout(false);
            this.pnNhanVien.PerformLayout();
            this.pnSoKhoiNuoc.ResumeLayout(false);
            this.pnSoKhoiNuoc.PerformLayout();
            this.pnTongTien.ResumeLayout(false);
            this.pnTongTien.PerformLayout();
            this.gbHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnKhachHang;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Panel pnNhanVien;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Panel pnSoKhoiNuoc;
        private System.Windows.Forms.Label lblNuocSD;
        private System.Windows.Forms.Panel pnTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.GroupBox gbHoaDon;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private Guna.UI2.WinForms.Guna2Button btnExcelTK;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchTK;
        private System.Windows.Forms.PictureBox ptSearchTK;
        private System.Windows.Forms.PictureBox ptSearchDate;
        private System.Windows.Forms.DateTimePicker dtSearchtime;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}
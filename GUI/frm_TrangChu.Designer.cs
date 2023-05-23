namespace GUI
{
    partial class frm_TrangChu
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
            this.panel_Left = new System.Windows.Forms.Panel();
            this.ptHome = new System.Windows.Forms.PictureBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnGiaNuoc = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnQLSuaChua = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.lblTrangChu = new System.Windows.Forms.Label();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.ptSologan = new System.Windows.Forms.PictureBox();
            this.panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptHome)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptSologan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.Teal;
            this.panel_Left.Controls.Add(this.ptHome);
            this.panel_Left.Controls.Add(this.btnThongKe);
            this.panel_Left.Controls.Add(this.btnGiaNuoc);
            this.panel_Left.Controls.Add(this.btnThanhToan);
            this.panel_Left.Controls.Add(this.btnQLSuaChua);
            this.panel_Left.Controls.Add(this.btnTaiKhoan);
            this.panel_Left.Controls.Add(this.btnNhanVien);
            this.panel_Left.Controls.Add(this.btnKhachhang);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(229, 1055);
            this.panel_Left.TabIndex = 0;
            // 
            // ptHome
            // 
            this.ptHome.Image = global::GUI.Properties.Resources.banner_wed_2;
            this.ptHome.Location = new System.Drawing.Point(0, 0);
            this.ptHome.Name = "ptHome";
            this.ptHome.Size = new System.Drawing.Size(229, 181);
            this.ptHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptHome.TabIndex = 1;
            this.ptHome.TabStop = false;
            this.ptHome.Click += new System.EventHandler(this.ptHome_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Teal;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(-9, 537);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(247, 51);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnGiaNuoc
            // 
            this.btnGiaNuoc.BackColor = System.Drawing.Color.Teal;
            this.btnGiaNuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiaNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaNuoc.ForeColor = System.Drawing.Color.White;
            this.btnGiaNuoc.Location = new System.Drawing.Point(-9, 466);
            this.btnGiaNuoc.Name = "btnGiaNuoc";
            this.btnGiaNuoc.Size = new System.Drawing.Size(247, 51);
            this.btnGiaNuoc.TabIndex = 6;
            this.btnGiaNuoc.Text = "Giá nước";
            this.btnGiaNuoc.UseVisualStyleBackColor = false;
            this.btnGiaNuoc.Click += new System.EventHandler(this.btnGiaNuoc_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Teal;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(-9, 313);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(247, 51);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnQLSuaChua
            // 
            this.btnQLSuaChua.BackColor = System.Drawing.Color.Teal;
            this.btnQLSuaChua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLSuaChua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSuaChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSuaChua.ForeColor = System.Drawing.Color.White;
            this.btnQLSuaChua.Location = new System.Drawing.Point(-9, 389);
            this.btnQLSuaChua.Name = "btnQLSuaChua";
            this.btnQLSuaChua.Size = new System.Drawing.Size(247, 51);
            this.btnQLSuaChua.TabIndex = 4;
            this.btnQLSuaChua.Text = "Sửa chữa";
            this.btnQLSuaChua.UseVisualStyleBackColor = false;
            this.btnQLSuaChua.Click += new System.EventHandler(this.btnQLSuaChua_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.Teal;
            this.btnTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 685);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(247, 51);
            this.btnTaiKhoan.TabIndex = 3;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Teal;
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Location = new System.Drawing.Point(-9, 611);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(247, 51);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.BackColor = System.Drawing.Color.Teal;
            this.btnKhachhang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachhang.ForeColor = System.Drawing.Color.White;
            this.btnKhachhang.Location = new System.Drawing.Point(-9, 241);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(247, 51);
            this.btnKhachhang.TabIndex = 1;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.UseVisualStyleBackColor = false;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.Teal;
            this.panel_Top.Controls.Add(this.lblTrangChu);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(229, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1089, 118);
            this.panel_Top.TabIndex = 1;
            // 
            // lblTrangChu
            // 
            this.lblTrangChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrangChu.AutoSize = true;
            this.lblTrangChu.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangChu.ForeColor = System.Drawing.Color.White;
            this.lblTrangChu.Location = new System.Drawing.Point(428, 46);
            this.lblTrangChu.Name = "lblTrangChu";
            this.lblTrangChu.Size = new System.Drawing.Size(254, 49);
            this.lblTrangChu.TabIndex = 0;
            this.lblTrangChu.Text = "TRANG CHỦ";
            // 
            // panel_Body
            // 
            this.panel_Body.Controls.Add(this.ptSologan);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(229, 118);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1089, 937);
            this.panel_Body.TabIndex = 2;
            // 
            // ptSologan
            // 
            this.ptSologan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptSologan.Image = global::GUI.Properties.Resources.logo_Nuoc;
            this.ptSologan.Location = new System.Drawing.Point(0, 0);
            this.ptSologan.Name = "ptSologan";
            this.ptSologan.Size = new System.Drawing.Size(1089, 937);
            this.ptSologan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptSologan.TabIndex = 0;
            this.ptSologan.TabStop = false;
            // 
            // frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1318, 1055);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Left);
            this.Name = "frm_TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptHome)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptSologan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Button btnQLSuaChua;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnGiaNuoc;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Label lblTrangChu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.PictureBox ptSologan;
        private System.Windows.Forms.PictureBox ptHome;
    }
}


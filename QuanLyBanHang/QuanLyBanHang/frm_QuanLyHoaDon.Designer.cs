namespace QuanLyBanHang
{
    partial class frm_QuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyHoaDon));
            this.label8 = new System.Windows.Forms.Label();
            this.cb_KhachHang = new System.Windows.Forms.ComboBox();
            this.cb_NhanVien = new System.Windows.Forms.ComboBox();
            this.dtp_NgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_MaKhachHang = new System.Windows.Forms.Label();
            this.lbl_MaNhanVien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_DanhSachHD = new System.Windows.Forms.DataGridView();
            this.btn_HienThiTatCa = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lbl_HoaDonHienTai = new System.Windows.Forms.Label();
            this.btn_ChiTietHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(418, 45);
            this.label8.TabIndex = 21;
            this.label8.Text = "QUẢN LÝ HOÁ ĐƠN";
            // 
            // cb_KhachHang
            // 
            this.cb_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_KhachHang.FormattingEnabled = true;
            this.cb_KhachHang.Location = new System.Drawing.Point(256, 86);
            this.cb_KhachHang.Name = "cb_KhachHang";
            this.cb_KhachHang.Size = new System.Drawing.Size(255, 33);
            this.cb_KhachHang.TabIndex = 22;
            this.cb_KhachHang.SelectedIndexChanged += new System.EventHandler(this.cb_KhachHang_SelectedIndexChanged);
            // 
            // cb_NhanVien
            // 
            this.cb_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_NhanVien.FormattingEnabled = true;
            this.cb_NhanVien.Location = new System.Drawing.Point(256, 148);
            this.cb_NhanVien.Name = "cb_NhanVien";
            this.cb_NhanVien.Size = new System.Drawing.Size(255, 33);
            this.cb_NhanVien.TabIndex = 23;
            this.cb_NhanVien.SelectedIndexChanged += new System.EventHandler(this.cb_NhanVien_SelectedIndexChanged);
            // 
            // dtp_NgayLapHD
            // 
            this.dtp_NgayLapHD.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayLapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayLapHD.Location = new System.Drawing.Point(703, 220);
            this.dtp_NgayLapHD.Name = "dtp_NgayLapHD";
            this.dtp_NgayLapHD.Size = new System.Drawing.Size(168, 30);
            this.dtp_NgayLapHD.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 57);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nhân viên lập hoá hơn";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(547, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mã khách hàng";
            // 
            // lbl_MaKhachHang
            // 
            this.lbl_MaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaKhachHang.Location = new System.Drawing.Point(728, 88);
            this.lbl_MaKhachHang.Name = "lbl_MaKhachHang";
            this.lbl_MaKhachHang.Size = new System.Drawing.Size(151, 30);
            this.lbl_MaKhachHang.TabIndex = 29;
            this.lbl_MaKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_MaNhanVien
            // 
            this.lbl_MaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNhanVien.Location = new System.Drawing.Point(728, 150);
            this.lbl_MaNhanVien.Name = "lbl_MaNhanVien";
            this.lbl_MaNhanVien.Size = new System.Drawing.Size(151, 30);
            this.lbl_MaNhanVien.TabIndex = 30;
            this.lbl_MaNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(508, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 30);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ngày lập hoá đơn";
            // 
            // dgv_DanhSachHD
            // 
            this.dgv_DanhSachHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachHD.Location = new System.Drawing.Point(203, 276);
            this.dgv_DanhSachHD.Name = "dgv_DanhSachHD";
            this.dgv_DanhSachHD.RowHeadersWidth = 51;
            this.dgv_DanhSachHD.RowTemplate.Height = 24;
            this.dgv_DanhSachHD.Size = new System.Drawing.Size(604, 312);
            this.dgv_DanhSachHD.TabIndex = 32;
            this.dgv_DanhSachHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachHD_CellClick);
            // 
            // btn_HienThiTatCa
            // 
            this.btn_HienThiTatCa.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_HienThiTatCa.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienThiTatCa.Location = new System.Drawing.Point(51, 276);
            this.btn_HienThiTatCa.Name = "btn_HienThiTatCa";
            this.btn_HienThiTatCa.Size = new System.Drawing.Size(90, 60);
            this.btn_HienThiTatCa.TabIndex = 37;
            this.btn_HienThiTatCa.Text = "HIỂN THỊ TẤT CẢ";
            this.btn_HienThiTatCa.UseVisualStyleBackColor = false;
            this.btn_HienThiTatCa.Click += new System.EventHandler(this.btn_HienThiTatCa_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Menu.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.Location = new System.Drawing.Point(850, 540);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(90, 47);
            this.btn_Menu.TabIndex = 36;
            this.btn_Menu.Text = "MENU";
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Xoa.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Location = new System.Drawing.Point(850, 400);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(90, 47);
            this.btn_Xoa.TabIndex = 35;
            this.btn_Xoa.Text = "XOÁ";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Them.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Green;
            this.btn_Them.Location = new System.Drawing.Point(850, 275);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(90, 47);
            this.btn_Them.TabIndex = 33;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lbl_HoaDonHienTai
            // 
            this.lbl_HoaDonHienTai.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HoaDonHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoaDonHienTai.Location = new System.Drawing.Point(6, 368);
            this.lbl_HoaDonHienTai.Name = "lbl_HoaDonHienTai";
            this.lbl_HoaDonHienTai.Size = new System.Drawing.Size(185, 79);
            this.lbl_HoaDonHienTai.TabIndex = 38;
            this.lbl_HoaDonHienTai.Text = "HOÁ ĐƠN ĐANG CHỌN: CHƯA CHỌN";
            this.lbl_HoaDonHienTai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ChiTietHoaDon
            // 
            this.btn_ChiTietHoaDon.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ChiTietHoaDon.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChiTietHoaDon.Location = new System.Drawing.Point(44, 478);
            this.btn_ChiTietHoaDon.Name = "btn_ChiTietHoaDon";
            this.btn_ChiTietHoaDon.Size = new System.Drawing.Size(112, 97);
            this.btn_ChiTietHoaDon.TabIndex = 39;
            this.btn_ChiTietHoaDon.Text = "CHI TIẾT HOÁ ĐƠN";
            this.btn_ChiTietHoaDon.UseVisualStyleBackColor = false;
            this.btn_ChiTietHoaDon.Click += new System.EventHandler(this.btn_ChiTietHoaDon_Click);
            // 
            // frm_QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 600);
            this.Controls.Add(this.btn_ChiTietHoaDon);
            this.Controls.Add(this.lbl_HoaDonHienTai);
            this.Controls.Add(this.btn_HienThiTatCa);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_DanhSachHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_MaNhanVien);
            this.Controls.Add(this.lbl_MaKhachHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_NgayLapHD);
            this.Controls.Add(this.cb_NhanVien);
            this.Controls.Add(this.cb_KhachHang);
            this.Controls.Add(this.label8);
            this.Name = "frm_QuanLyHoaDon";
            this.Text = "QUẢN LÝ HOÁ ĐƠN";
            this.Load += new System.EventHandler(this.frm_QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_KhachHang;
        private System.Windows.Forms.ComboBox cb_NhanVien;
        private System.Windows.Forms.DateTimePicker dtp_NgayLapHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_MaKhachHang;
        private System.Windows.Forms.Label lbl_MaNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_DanhSachHD;
        private System.Windows.Forms.Button btn_HienThiTatCa;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lbl_HoaDonHienTai;
        private System.Windows.Forms.Button btn_ChiTietHoaDon;
    }
}
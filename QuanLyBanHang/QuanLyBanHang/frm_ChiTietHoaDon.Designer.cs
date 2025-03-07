namespace QuanLyBanHang
{
    partial class frm_ChiTietHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChiTietHoaDon));
            this.dgv_ChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.cb_SanPham = new System.Windows.Forms.ComboBox();
            this.lbl_SanPham = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_TongHoaDon = new System.Windows.Forms.Label();
            this.lbl_GiaTien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            this.lbl_TenKhachHang = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_TenNhanVien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ChiTietHoaDon
            // 
            this.dgv_ChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietHoaDon.Location = new System.Drawing.Point(201, 296);
            this.dgv_ChiTietHoaDon.Name = "dgv_ChiTietHoaDon";
            this.dgv_ChiTietHoaDon.RowHeadersWidth = 51;
            this.dgv_ChiTietHoaDon.RowTemplate.Height = 24;
            this.dgv_ChiTietHoaDon.Size = new System.Drawing.Size(606, 217);
            this.dgv_ChiTietHoaDon.TabIndex = 0;
            this.dgv_ChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietHoaDon_CellClick);
            // 
            // cb_SanPham
            // 
            this.cb_SanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SanPham.FormattingEnabled = true;
            this.cb_SanPham.Location = new System.Drawing.Point(306, 199);
            this.cb_SanPham.Name = "cb_SanPham";
            this.cb_SanPham.Size = new System.Drawing.Size(194, 33);
            this.cb_SanPham.TabIndex = 24;
            this.cb_SanPham.SelectedIndexChanged += new System.EventHandler(this.cb_SanPham_SelectedIndexChanged);
            // 
            // lbl_SanPham
            // 
            this.lbl_SanPham.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SanPham.Location = new System.Drawing.Point(168, 198);
            this.lbl_SanPham.Name = "lbl_SanPham";
            this.lbl_SanPham.Size = new System.Drawing.Size(112, 33);
            this.lbl_SanPham.TabIndex = 26;
            this.lbl_SanPham.Text = "Sản phẩm";
            this.lbl_SanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "Số lượng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(707, 200);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(100, 32);
            this.txt_SoLuong.TabIndex = 28;
            this.txt_SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 33);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tổng tiền";
            // 
            // lbl_TongHoaDon
            // 
            this.lbl_TongHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TongHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongHoaDon.Location = new System.Drawing.Point(575, 535);
            this.lbl_TongHoaDon.Name = "lbl_TongHoaDon";
            this.lbl_TongHoaDon.Size = new System.Drawing.Size(232, 33);
            this.lbl_TongHoaDon.TabIndex = 30;
            // 
            // lbl_GiaTien
            // 
            this.lbl_GiaTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_GiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaTien.Location = new System.Drawing.Point(306, 246);
            this.lbl_GiaTien.Name = "lbl_GiaTien";
            this.lbl_GiaTien.Size = new System.Drawing.Size(260, 33);
            this.lbl_GiaTien.TabIndex = 32;
            this.lbl_GiaTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 33);
            this.label5.TabIndex = 31;
            this.label5.Text = "Giá tiền";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Xoa.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Location = new System.Drawing.Point(823, 431);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(73, 82);
            this.btn_Xoa.TabIndex = 39;
            this.btn_Xoa.Text = "XOÁ";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Them.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Green;
            this.btn_Them.Location = new System.Drawing.Point(823, 296);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(73, 82);
            this.btn_Them.TabIndex = 37;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TieuDe.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.Location = new System.Drawing.Point(-9, 5);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(1065, 83);
            this.lbl_TieuDe.TabIndex = 41;
            this.lbl_TieuDe.Text = "CHI TIẾT HOÁ ĐƠN SỐ X";
            this.lbl_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TenKhachHang
            // 
            this.lbl_TenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenKhachHang.Location = new System.Drawing.Point(308, 99);
            this.lbl_TenKhachHang.Name = "lbl_TenKhachHang";
            this.lbl_TenKhachHang.Size = new System.Drawing.Size(194, 33);
            this.lbl_TenKhachHang.TabIndex = 43;
            this.lbl_TenKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 33);
            this.label7.TabIndex = 42;
            this.label7.Text = "Tên khách hàng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TenNhanVien
            // 
            this.lbl_TenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNhanVien.Location = new System.Drawing.Point(775, 98);
            this.lbl_TenNhanVien.Name = "lbl_TenNhanVien";
            this.lbl_TenNhanVien.Size = new System.Drawing.Size(194, 33);
            this.lbl_TenNhanVien.TabIndex = 45;
            this.lbl_TenNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(589, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 33);
            this.label9.TabIndex = 44;
            this.label9.Text = "Tên nhân viên";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(-8, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1064, 3);
            this.label6.TabIndex = 46;
            // 
            // frm_ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 604);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_TenNhanVien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_TenKhachHang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_TieuDe);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lbl_GiaTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_TongHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_SanPham);
            this.Controls.Add(this.cb_SanPham);
            this.Controls.Add(this.dgv_ChiTietHoaDon);
            this.Name = "frm_ChiTietHoaDon";
            this.Text = "CHI TIẾT HOÁ ĐƠN";
            this.Load += new System.EventHandler(this.frm_ChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ChiTietHoaDon;
        private System.Windows.Forms.ComboBox cb_SanPham;
        private System.Windows.Forms.Label lbl_SanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_TongHoaDon;
        private System.Windows.Forms.Label lbl_GiaTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lbl_TieuDe;
        private System.Windows.Forms.Label lbl_TenKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_TenNhanVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}
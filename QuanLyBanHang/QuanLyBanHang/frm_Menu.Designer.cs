namespace QuanLyBanHang
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_QuanLyKhachHang = new System.Windows.Forms.Button();
            this.btn_QuanLyNhanVien = new System.Windows.Forms.Button();
            this.btn_QuanLySanPham = new System.Windows.Forms.Button();
            this.btn_QuanLyHoaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(-7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(844, 172);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ BÁN HÀNG CÔNG TY ABC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_QuanLyKhachHang
            // 
            this.btn_QuanLyKhachHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_QuanLyKhachHang.BackgroundImage")));
            this.btn_QuanLyKhachHang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyKhachHang.Location = new System.Drawing.Point(101, 225);
            this.btn_QuanLyKhachHang.Name = "btn_QuanLyKhachHang";
            this.btn_QuanLyKhachHang.Size = new System.Drawing.Size(274, 56);
            this.btn_QuanLyKhachHang.TabIndex = 2;
            this.btn_QuanLyKhachHang.Text = "Quản Lý Khách Hàng";
            this.btn_QuanLyKhachHang.UseVisualStyleBackColor = true;
            this.btn_QuanLyKhachHang.Click += new System.EventHandler(this.btn_QuanLyKhachHang_Click);
            // 
            // btn_QuanLyNhanVien
            // 
            this.btn_QuanLyNhanVien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_QuanLyNhanVien.BackgroundImage")));
            this.btn_QuanLyNhanVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyNhanVien.Location = new System.Drawing.Point(458, 225);
            this.btn_QuanLyNhanVien.Name = "btn_QuanLyNhanVien";
            this.btn_QuanLyNhanVien.Size = new System.Drawing.Size(274, 56);
            this.btn_QuanLyNhanVien.TabIndex = 3;
            this.btn_QuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.btn_QuanLyNhanVien.UseVisualStyleBackColor = true;
            this.btn_QuanLyNhanVien.Click += new System.EventHandler(this.btn_QuanLyNhanVien_Click);
            // 
            // btn_QuanLySanPham
            // 
            this.btn_QuanLySanPham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_QuanLySanPham.BackgroundImage")));
            this.btn_QuanLySanPham.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLySanPham.Location = new System.Drawing.Point(101, 351);
            this.btn_QuanLySanPham.Name = "btn_QuanLySanPham";
            this.btn_QuanLySanPham.Size = new System.Drawing.Size(274, 56);
            this.btn_QuanLySanPham.TabIndex = 4;
            this.btn_QuanLySanPham.Text = "Quản Lý Sản Phẩm";
            this.btn_QuanLySanPham.UseVisualStyleBackColor = true;
            this.btn_QuanLySanPham.Click += new System.EventHandler(this.btn_QuanLySanPham_Click);
            // 
            // btn_QuanLyHoaDon
            // 
            this.btn_QuanLyHoaDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_QuanLyHoaDon.BackgroundImage")));
            this.btn_QuanLyHoaDon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyHoaDon.Location = new System.Drawing.Point(458, 351);
            this.btn_QuanLyHoaDon.Name = "btn_QuanLyHoaDon";
            this.btn_QuanLyHoaDon.Size = new System.Drawing.Size(274, 56);
            this.btn_QuanLyHoaDon.TabIndex = 5;
            this.btn_QuanLyHoaDon.Text = "Quản Lý Hóa Đơn";
            this.btn_QuanLyHoaDon.UseVisualStyleBackColor = true;
            this.btn_QuanLyHoaDon.Click += new System.EventHandler(this.btn_QuanLyHoaDon_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(833, 457);
            this.Controls.Add(this.btn_QuanLyHoaDon);
            this.Controls.Add(this.btn_QuanLySanPham);
            this.Controls.Add(this.btn_QuanLyNhanVien);
            this.Controls.Add(this.btn_QuanLyKhachHang);
            this.Controls.Add(this.label1);
            this.Name = "frm_Menu";
            this.Text = "MENU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Menu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_QuanLyKhachHang;
        private System.Windows.Forms.Button btn_QuanLyNhanVien;
        private System.Windows.Forms.Button btn_QuanLySanPham;
        private System.Windows.Forms.Button btn_QuanLyHoaDon;
    }
}
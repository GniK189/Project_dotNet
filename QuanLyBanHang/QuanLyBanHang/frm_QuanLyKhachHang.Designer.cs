namespace QuanLyBanHang
{
    partial class frm_QuanLyKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyKhachHang));
            this.dgv_DanhSachKH = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaKhachHang = new System.Windows.Forms.TextBox();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_DiaChi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Dem = new System.Windows.Forms.Button();
            this.lbl_Dem = new System.Windows.Forms.Label();
            this.rdo_Tang = new System.Windows.Forms.RadioButton();
            this.rdo_Giam = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_HienThiTatCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DanhSachKH
            // 
            this.dgv_DanhSachKH.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DanhSachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachKH.Location = new System.Drawing.Point(157, 361);
            this.dgv_DanhSachKH.Name = "dgv_DanhSachKH";
            this.dgv_DanhSachKH.RowHeadersWidth = 51;
            this.dgv_DanhSachKH.RowTemplate.Height = 24;
            this.dgv_DanhSachKH.Size = new System.Drawing.Size(739, 237);
            this.dgv_DanhSachKH.TabIndex = 0;
            this.dgv_DanhSachKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachKH_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Them.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Green;
            this.btn_Them.Location = new System.Drawing.Point(919, 361);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(90, 30);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Sua.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Navy;
            this.btn_Sua.Location = new System.Drawing.Point(919, 428);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(90, 30);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "SỬA";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Tim.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(918, 238);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(90, 30);
            this.btn_Tim.TabIndex = 3;
            this.btn_Tim.Text = "TÌM";
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã khách hàng: ";
            // 
            // txt_MaKhachHang
            // 
            this.txt_MaKhachHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_MaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKhachHang.Location = new System.Drawing.Point(288, 96);
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.Size = new System.Drawing.Size(191, 30);
            this.txt_MaKhachHang.TabIndex = 6;
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_TenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKhachHang.Location = new System.Drawing.Point(288, 150);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Size = new System.Drawing.Size(191, 30);
            this.txt_TenKhachHang.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên khách hàng: ";
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_SoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(703, 150);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(217, 30);
            this.txt_SoDienThoai.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số điện thoại: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa chỉ: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Giới tính: ";
            // 
            // cb_GioiTinh
            // 
            this.cb_GioiTinh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_GioiTinh.FormattingEnabled = true;
            this.cb_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_GioiTinh.Location = new System.Drawing.Point(288, 201);
            this.cb_GioiTinh.Name = "cb_GioiTinh";
            this.cb_GioiTinh.Size = new System.Drawing.Size(145, 33);
            this.cb_GioiTinh.TabIndex = 15;
            // 
            // txt_Tim
            // 
            this.txt_Tim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tim.Location = new System.Drawing.Point(708, 237);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(187, 30);
            this.txt_Tim.TabIndex = 16;
            this.txt_Tim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Menu.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.Location = new System.Drawing.Point(918, 498);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(90, 30);
            this.btn_Menu.TabIndex = 17;
            this.btn_Menu.Text = "MENU";
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(644, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nhập tên hoặc mã khách hàng";
            // 
            // cb_DiaChi
            // 
            this.cb_DiaChi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_DiaChi.DropDownHeight = 200;
            this.cb_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DiaChi.FormattingEnabled = true;
            this.cb_DiaChi.IntegralHeight = false;
            this.cb_DiaChi.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cần Thơ",
            "Cao Bằng",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "TP. Hồ Chí Minh",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.cb_DiaChi.Location = new System.Drawing.Point(703, 95);
            this.cb_DiaChi.Name = "cb_DiaChi";
            this.cb_DiaChi.Size = new System.Drawing.Size(260, 33);
            this.cb_DiaChi.TabIndex = 19;
            this.cb_DiaChi.SelectedIndexChanged += new System.EventHandler(this.cb_DiaChi_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(280, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(499, 45);
            this.label8.TabIndex = 20;
            this.label8.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // btn_Dem
            // 
            this.btn_Dem.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Dem.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dem.Location = new System.Drawing.Point(29, 360);
            this.btn_Dem.Name = "btn_Dem";
            this.btn_Dem.Size = new System.Drawing.Size(90, 30);
            this.btn_Dem.TabIndex = 21;
            this.btn_Dem.Text = "ĐẾM";
            this.btn_Dem.UseVisualStyleBackColor = false;
            this.btn_Dem.Click += new System.EventHandler(this.btn_Dem_Click);
            // 
            // lbl_Dem
            // 
            this.lbl_Dem.AutoSize = true;
            this.lbl_Dem.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Dem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dem.Location = new System.Drawing.Point(9, 392);
            this.lbl_Dem.Name = "lbl_Dem";
            this.lbl_Dem.Size = new System.Drawing.Size(0, 20);
            this.lbl_Dem.TabIndex = 22;
            this.lbl_Dem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdo_Tang
            // 
            this.rdo_Tang.AutoSize = true;
            this.rdo_Tang.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Tang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Tang.Location = new System.Drawing.Point(384, 335);
            this.rdo_Tang.Name = "rdo_Tang";
            this.rdo_Tang.Size = new System.Drawing.Size(64, 20);
            this.rdo_Tang.TabIndex = 23;
            this.rdo_Tang.TabStop = true;
            this.rdo_Tang.Text = "Tăng";
            this.rdo_Tang.UseVisualStyleBackColor = false;
            this.rdo_Tang.CheckedChanged += new System.EventHandler(this.rdo_Tang_CheckedChanged);
            // 
            // rdo_Giam
            // 
            this.rdo_Giam.AutoSize = true;
            this.rdo_Giam.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Giam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Giam.Location = new System.Drawing.Point(474, 335);
            this.rdo_Giam.Name = "rdo_Giam";
            this.rdo_Giam.Size = new System.Drawing.Size(64, 20);
            this.rdo_Giam.TabIndex = 24;
            this.rdo_Giam.TabStop = true;
            this.rdo_Giam.Text = "Giảm";
            this.rdo_Giam.UseVisualStyleBackColor = false;
            this.rdo_Giam.CheckedChanged += new System.EventHandler(this.rdo_Giam_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(154, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Sắp xếp theo mã KH: ";
            // 
            // btn_HienThiTatCa
            // 
            this.btn_HienThiTatCa.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_HienThiTatCa.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienThiTatCa.Location = new System.Drawing.Point(806, 294);
            this.btn_HienThiTatCa.Name = "btn_HienThiTatCa";
            this.btn_HienThiTatCa.Size = new System.Drawing.Size(90, 60);
            this.btn_HienThiTatCa.TabIndex = 26;
            this.btn_HienThiTatCa.Text = "HIỂN THỊ TẤT CẢ";
            this.btn_HienThiTatCa.UseVisualStyleBackColor = false;
            this.btn_HienThiTatCa.Click += new System.EventHandler(this.btn_HienThiTatCa_Click);
            // 
            // frm_QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 619);
            this.Controls.Add(this.btn_HienThiTatCa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rdo_Giam);
            this.Controls.Add(this.rdo_Tang);
            this.Controls.Add(this.lbl_Dem);
            this.Controls.Add(this.btn_Dem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_DiaChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.cb_GioiTinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_SoDienThoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_TenKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_DanhSachKH);
            this.Name = "frm_QuanLyKhachHang";
            this.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frm_QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DanhSachKH;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaKhachHang;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_GioiTinh;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_DiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Dem;
        private System.Windows.Forms.Label lbl_Dem;
        private System.Windows.Forms.RadioButton rdo_Tang;
        private System.Windows.Forms.RadioButton rdo_Giam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_HienThiTatCa;
    }
}
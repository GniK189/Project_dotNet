namespace QuanLyBanHang
{
    partial class frm_QuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyNhanVien));
            this.label8 = new System.Windows.Forms.Label();
            this.cb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_DiaChi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_VaiTro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdo_Giam = new System.Windows.Forms.RadioButton();
            this.rdo_Tang = new System.Windows.Forms.RadioButton();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgv_DanhSachNV = new System.Windows.Forms.DataGridView();
            this.btn_HienThiTatCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(-6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1303, 45);
            this.label8.TabIndex = 21;
            this.label8.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_GioiTinh
            // 
            this.cb_GioiTinh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_GioiTinh.FormattingEnabled = true;
            this.cb_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_GioiTinh.Location = new System.Drawing.Point(387, 192);
            this.cb_GioiTinh.Name = "cb_GioiTinh";
            this.cb_GioiTinh.Size = new System.Drawing.Size(145, 33);
            this.cb_GioiTinh.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Giới tính: ";
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_TenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNhanVien.Location = new System.Drawing.Point(387, 141);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Size = new System.Drawing.Size(242, 30);
            this.txt_TenNhanVien.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên nhân viên: ";
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_MaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNhanVien.Location = new System.Drawing.Point(387, 87);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(242, 30);
            this.txt_MaNhanVien.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã nhân viên: ";
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
            this.cb_DiaChi.Location = new System.Drawing.Point(836, 87);
            this.cb_DiaChi.Name = "cb_DiaChi";
            this.cb_DiaChi.Size = new System.Drawing.Size(217, 33);
            this.cb_DiaChi.TabIndex = 29;
            this.cb_DiaChi.SelectedIndexChanged += new System.EventHandler(this.cb_DiaChi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(720, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Địa chỉ: ";
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_SoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(836, 142);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(217, 30);
            this.txt_SoDienThoai.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Số điện thoại: ";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(836, 192);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(200, 30);
            this.dtp_NgaySinh.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(689, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ngày sinh: ";
            // 
            // cb_VaiTro
            // 
            this.cb_VaiTro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_VaiTro.DropDownHeight = 200;
            this.cb_VaiTro.DropDownWidth = 170;
            this.cb_VaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_VaiTro.FormattingEnabled = true;
            this.cb_VaiTro.IntegralHeight = false;
            this.cb_VaiTro.Items.AddRange(new object[] {
            "Nhân viên bán hàng",
            "Nhân viên kho",
            "Nhân viên kế toán"});
            this.cb_VaiTro.Location = new System.Drawing.Point(387, 244);
            this.cb_VaiTro.Name = "cb_VaiTro";
            this.cb_VaiTro.Size = new System.Drawing.Size(242, 33);
            this.cb_VaiTro.TabIndex = 35;
            this.cb_VaiTro.SelectedIndexChanged += new System.EventHandler(this.cb_VaiTro_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(183, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Vai trò: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(113, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Sắp xếp theo mã NV: ";
            // 
            // rdo_Giam
            // 
            this.rdo_Giam.AutoSize = true;
            this.rdo_Giam.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Giam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Giam.Location = new System.Drawing.Point(433, 318);
            this.rdo_Giam.Name = "rdo_Giam";
            this.rdo_Giam.Size = new System.Drawing.Size(64, 20);
            this.rdo_Giam.TabIndex = 43;
            this.rdo_Giam.TabStop = true;
            this.rdo_Giam.Text = "Giảm";
            this.rdo_Giam.UseVisualStyleBackColor = false;
            this.rdo_Giam.CheckedChanged += new System.EventHandler(this.rdo_Giam_CheckedChanged);
            // 
            // rdo_Tang
            // 
            this.rdo_Tang.AutoSize = true;
            this.rdo_Tang.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Tang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Tang.Location = new System.Drawing.Point(343, 318);
            this.rdo_Tang.Name = "rdo_Tang";
            this.rdo_Tang.Size = new System.Drawing.Size(64, 20);
            this.rdo_Tang.TabIndex = 42;
            this.rdo_Tang.TabStop = true;
            this.rdo_Tang.Text = "Tăng";
            this.rdo_Tang.UseVisualStyleBackColor = false;
            this.rdo_Tang.CheckedChanged += new System.EventHandler(this.rdo_Tang_CheckedChanged);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Menu.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.Location = new System.Drawing.Point(1153, 551);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(87, 30);
            this.btn_Menu.TabIndex = 40;
            this.btn_Menu.Text = "MENU";
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Xoa.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Location = new System.Drawing.Point(1153, 484);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(87, 30);
            this.btn_Xoa.TabIndex = 39;
            this.btn_Xoa.Text = "XOÁ";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Sua.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Navy;
            this.btn_Sua.Location = new System.Drawing.Point(1153, 411);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(87, 30);
            this.btn_Sua.TabIndex = 38;
            this.btn_Sua.Text = "SỬA";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Them.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Green;
            this.btn_Them.Location = new System.Drawing.Point(1153, 344);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(87, 30);
            this.btn_Them.TabIndex = 37;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_DanhSachNV
            // 
            this.dgv_DanhSachNV.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachNV.Location = new System.Drawing.Point(116, 344);
            this.dgv_DanhSachNV.Name = "dgv_DanhSachNV";
            this.dgv_DanhSachNV.RowHeadersWidth = 51;
            this.dgv_DanhSachNV.RowTemplate.Height = 24;
            this.dgv_DanhSachNV.Size = new System.Drawing.Size(1005, 237);
            this.dgv_DanhSachNV.TabIndex = 36;
            this.dgv_DanhSachNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachNV_CellClick);
            // 
            // btn_HienThiTatCa
            // 
            this.btn_HienThiTatCa.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_HienThiTatCa.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienThiTatCa.Location = new System.Drawing.Point(881, 311);
            this.btn_HienThiTatCa.Name = "btn_HienThiTatCa";
            this.btn_HienThiTatCa.Size = new System.Drawing.Size(240, 33);
            this.btn_HienThiTatCa.TabIndex = 45;
            this.btn_HienThiTatCa.Text = "HIỂN THỊ TẤT CẢ";
            this.btn_HienThiTatCa.UseVisualStyleBackColor = false;
            this.btn_HienThiTatCa.Click += new System.EventHandler(this.btn_HienThiTatCa_Click);
            // 
            // frm_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1298, 602);
            this.Controls.Add(this.btn_HienThiTatCa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rdo_Giam);
            this.Controls.Add(this.rdo_Tang);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_DanhSachNV);
            this.Controls.Add(this.cb_VaiTro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.txt_SoDienThoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_DiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_GioiTinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TenNhanVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "frm_QuanLyNhanVien";
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            this.Load += new System.EventHandler(this.frm_QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_GioiTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TenNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_DiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_VaiTro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdo_Giam;
        private System.Windows.Forms.RadioButton rdo_Tang;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_DanhSachNV;
        private System.Windows.Forms.Button btn_HienThiTatCa;
    }
}
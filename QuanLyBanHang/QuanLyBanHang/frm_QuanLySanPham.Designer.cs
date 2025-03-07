namespace QuanLyBanHang
{
    partial class frm_QuanLySanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLySanPham));
            this.dgv_SanPham = new System.Windows.Forms.DataGridView();
            this.cb_DonViTinh = new System.Windows.Forms.ComboBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaSanPham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.MENU = new System.Windows.Forms.Button();
            this.btn_HienToanBo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ptb_SanPham = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanPham.Location = new System.Drawing.Point(226, 379);
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.RowHeadersWidth = 51;
            this.dgv_SanPham.RowTemplate.Height = 24;
            this.dgv_SanPham.Size = new System.Drawing.Size(605, 240);
            this.dgv_SanPham.TabIndex = 0;
            this.dgv_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPham_CellClick);
            // 
            // cb_DonViTinh
            // 
            this.cb_DonViTinh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_DonViTinh.DropDownHeight = 200;
            this.cb_DonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DonViTinh.FormattingEnabled = true;
            this.cb_DonViTinh.IntegralHeight = false;
            this.cb_DonViTinh.Items.AddRange(new object[] {
            "Viên",
            "Cái",
            "Tấm",
            "Cuộn",
            "Ống",
            "Kilogram (kg)",
            "Tấn (t)",
            "Lít (L)",
            "Mét khối (m³)",
            "Mét (m)",
            "Centimet (cm)",
            "Mét vuông (m²)"});
            this.cb_DonViTinh.Location = new System.Drawing.Point(367, 236);
            this.cb_DonViTinh.Name = "cb_DonViTinh";
            this.cb_DonViTinh.Size = new System.Drawing.Size(260, 33);
            this.cb_DonViTinh.TabIndex = 27;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_DonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Location = new System.Drawing.Point(367, 291);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(217, 30);
            this.txt_DonGia.TabIndex = 26;
            this.txt_DonGia.TextChanged += new System.EventHandler(this.txt_DonGia_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Đơn vị tính: ";
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_TenSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSanPham.Location = new System.Drawing.Point(367, 175);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(191, 30);
            this.txt_TenSanPham.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên sản phẩm: ";
            // 
            // txt_MaSanPham
            // 
            this.txt_MaSanPham.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_MaSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSanPham.Location = new System.Drawing.Point(367, 121);
            this.txt_MaSanPham.Name = "txt_MaSanPham";
            this.txt_MaSanPham.Size = new System.Drawing.Size(191, 30);
            this.txt_MaSanPham.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã sản phẩm: ";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Them.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Them.Location = new System.Drawing.Point(856, 379);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(91, 43);
            this.btn_Them.TabIndex = 28;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Sua.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Sua.Location = new System.Drawing.Point(856, 442);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(91, 43);
            this.btn_Sua.TabIndex = 29;
            this.btn_Sua.Text = "SỬA";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Brown;
            this.btn_Xoa.Location = new System.Drawing.Point(856, 510);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(91, 43);
            this.btn_Xoa.TabIndex = 30;
            this.btn_Xoa.Text = "XOÁ";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // MENU
            // 
            this.MENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MENU.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENU.ForeColor = System.Drawing.Color.Olive;
            this.MENU.Location = new System.Drawing.Point(856, 576);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(91, 43);
            this.MENU.TabIndex = 31;
            this.MENU.Text = "MENU";
            this.MENU.UseVisualStyleBackColor = false;
            this.MENU.Click += new System.EventHandler(this.MENU_Click);
            // 
            // btn_HienToanBo
            // 
            this.btn_HienToanBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_HienToanBo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienToanBo.Location = new System.Drawing.Point(594, 344);
            this.btn_HienToanBo.Name = "btn_HienToanBo";
            this.btn_HienToanBo.Size = new System.Drawing.Size(237, 29);
            this.btn_HienToanBo.TabIndex = 32;
            this.btn_HienToanBo.Text = "HIỆN TOÀN BỘ";
            this.btn_HienToanBo.UseVisualStyleBackColor = false;
            this.btn_HienToanBo.Click += new System.EventHandler(this.btn_HienToanBo_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-9, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1123, 45);
            this.label8.TabIndex = 33;
            this.label8.Text = "QUẢN LÝ SẢN PHẨM";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptb_SanPham
            // 
            this.ptb_SanPham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_SanPham.BackgroundImage")));
            this.ptb_SanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_SanPham.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptb_SanPham.ErrorImage")));
            this.ptb_SanPham.Location = new System.Drawing.Point(678, 121);
            this.ptb_SanPham.Name = "ptb_SanPham";
            this.ptb_SanPham.Size = new System.Drawing.Size(191, 200);
            this.ptb_SanPham.TabIndex = 34;
            this.ptb_SanPham.TabStop = false;
            this.ptb_SanPham.Click += new System.EventHandler(this.ptb_SanPham_Click);
            // 
            // frm_QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 631);
            this.Controls.Add(this.ptb_SanPham);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_HienToanBo);
            this.Controls.Add(this.MENU);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cb_DonViTinh);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_TenSanPham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaSanPham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_SanPham);
            this.Name = "frm_QuanLySanPham";
            this.Text = "QUẢN LÝ SẢN PHẨM";
            this.Load += new System.EventHandler(this.frm_QuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SanPham;
        private System.Windows.Forms.ComboBox cb_DonViTinh;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button MENU;
        private System.Windows.Forms.Button btn_HienToanBo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox ptb_SanPham;
    }
}
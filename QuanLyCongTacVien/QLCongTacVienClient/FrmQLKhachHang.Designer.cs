namespace QLCongTacVienClient
{
    partial class FrmQLKhachHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGiaiTri = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGhiChu4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGhiChu2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhiChu1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cbTrangThai1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTrangThai2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTrangThai3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTrangThai4 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnDongKhachHang = new System.Windows.Forms.Button();
            this.btnLuuKhachHang = new System.Windows.Forms.Button();
            this.btnXoaKhachHang = new System.Windows.Forms.Button();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKhachHang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Khách Hàng";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(3, 16);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(836, 154);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGhiChu3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtGiaiTri);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtGhiChu4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtGhiChu2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtGhiChu1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSoDT);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTenKhachHang);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.cbTrangThai1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbTrangThai2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbTrangThai3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbTrangThai4);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.btnDongKhachHang);
            this.groupBox2.Controls.Add(this.btnLuuKhachHang);
            this.groupBox2.Controls.Add(this.btnXoaKhachHang);
            this.groupBox2.Controls.Add(this.btnThemKhachHang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // txtGhiChu3
            // 
            this.txtGhiChu3.Enabled = false;
            this.txtGhiChu3.Location = new System.Drawing.Point(162, 243);
            this.txtGhiChu3.Name = "txtGhiChu3";
            this.txtGhiChu3.Size = new System.Drawing.Size(184, 20);
            this.txtGhiChu3.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Ghi Chú 3:";
            // 
            // txtGiaiTri
            // 
            this.txtGiaiTri.Enabled = false;
            this.txtGiaiTri.Location = new System.Drawing.Point(606, 78);
            this.txtGiaiTri.Name = "txtGiaiTri";
            this.txtGiaiTri.Size = new System.Drawing.Size(184, 20);
            this.txtGiaiTri.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(501, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Giá Trị:";
            // 
            // txtGhiChu4
            // 
            this.txtGhiChu4.Enabled = false;
            this.txtGhiChu4.Location = new System.Drawing.Point(606, 40);
            this.txtGhiChu4.Name = "txtGhiChu4";
            this.txtGhiChu4.Size = new System.Drawing.Size(184, 20);
            this.txtGhiChu4.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Ghi Chú 4:";
            // 
            // txtGhiChu2
            // 
            this.txtGhiChu2.Enabled = false;
            this.txtGhiChu2.Location = new System.Drawing.Point(162, 206);
            this.txtGhiChu2.Name = "txtGhiChu2";
            this.txtGhiChu2.Size = new System.Drawing.Size(184, 20);
            this.txtGhiChu2.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Ghi Chú 2:";
            // 
            // txtGhiChu1
            // 
            this.txtGhiChu1.Enabled = false;
            this.txtGhiChu1.Location = new System.Drawing.Point(162, 163);
            this.txtGhiChu1.Name = "txtGhiChu1";
            this.txtGhiChu1.Size = new System.Drawing.Size(184, 20);
            this.txtGhiChu1.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Ghi Chú 1:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(162, 121);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(184, 20);
            this.txtDiaChi.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Địa Chỉ:";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Enabled = false;
            this.txtSoDT.Location = new System.Drawing.Point(162, 82);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(184, 20);
            this.txtSoDT.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Số Điện Thoại:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Enabled = false;
            this.txtTenKhachHang.Location = new System.Drawing.Point(162, 40);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(184, 20);
            this.txtTenKhachHang.TabIndex = 47;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(57, 43);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 13);
            this.label28.TabIndex = 48;
            this.label28.Text = "Tên Khách Hàng:";
            // 
            // cbTrangThai1
            // 
            this.cbTrangThai1.Enabled = false;
            this.cbTrangThai1.FormattingEnabled = true;
            this.cbTrangThai1.Location = new System.Drawing.Point(606, 116);
            this.cbTrangThai1.Name = "cbTrangThai1";
            this.cbTrangThai1.Size = new System.Drawing.Size(184, 21);
            this.cbTrangThai1.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Trạng Thái 1:";
            // 
            // cbTrangThai2
            // 
            this.cbTrangThai2.Enabled = false;
            this.cbTrangThai2.FormattingEnabled = true;
            this.cbTrangThai2.Location = new System.Drawing.Point(606, 155);
            this.cbTrangThai2.Name = "cbTrangThai2";
            this.cbTrangThai2.Size = new System.Drawing.Size(184, 21);
            this.cbTrangThai2.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Trạng Thái 2:";
            // 
            // cbTrangThai3
            // 
            this.cbTrangThai3.Enabled = false;
            this.cbTrangThai3.FormattingEnabled = true;
            this.cbTrangThai3.Location = new System.Drawing.Point(606, 196);
            this.cbTrangThai3.Name = "cbTrangThai3";
            this.cbTrangThai3.Size = new System.Drawing.Size(184, 21);
            this.cbTrangThai3.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Trạng Thái 3:";
            // 
            // cbTrangThai4
            // 
            this.cbTrangThai4.Enabled = false;
            this.cbTrangThai4.FormattingEnabled = true;
            this.cbTrangThai4.Location = new System.Drawing.Point(606, 243);
            this.cbTrangThai4.Name = "cbTrangThai4";
            this.cbTrangThai4.Size = new System.Drawing.Size(184, 21);
            this.cbTrangThai4.TabIndex = 40;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(501, 246);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 13);
            this.label27.TabIndex = 39;
            this.label27.Text = "Trạng Thái 4:";
            // 
            // btnDongKhachHang
            // 
            this.btnDongKhachHang.Location = new System.Drawing.Point(643, 280);
            this.btnDongKhachHang.Name = "btnDongKhachHang";
            this.btnDongKhachHang.Size = new System.Drawing.Size(75, 36);
            this.btnDongKhachHang.TabIndex = 38;
            this.btnDongKhachHang.Text = "Đóng";
            this.btnDongKhachHang.UseVisualStyleBackColor = true;
            this.btnDongKhachHang.Click += new System.EventHandler(this.btnDongKhachHang_Click);
            // 
            // btnLuuKhachHang
            // 
            this.btnLuuKhachHang.Enabled = false;
            this.btnLuuKhachHang.Location = new System.Drawing.Point(304, 280);
            this.btnLuuKhachHang.Name = "btnLuuKhachHang";
            this.btnLuuKhachHang.Size = new System.Drawing.Size(75, 36);
            this.btnLuuKhachHang.TabIndex = 36;
            this.btnLuuKhachHang.Text = "Lưu";
            this.btnLuuKhachHang.UseVisualStyleBackColor = true;
            this.btnLuuKhachHang.Click += new System.EventHandler(this.btnLuuKhachHang_Click);
            // 
            // btnXoaKhachHang
            // 
            this.btnXoaKhachHang.Enabled = false;
            this.btnXoaKhachHang.Location = new System.Drawing.Point(492, 280);
            this.btnXoaKhachHang.Name = "btnXoaKhachHang";
            this.btnXoaKhachHang.Size = new System.Drawing.Size(75, 36);
            this.btnXoaKhachHang.TabIndex = 37;
            this.btnXoaKhachHang.Text = "Xóa";
            this.btnXoaKhachHang.UseVisualStyleBackColor = true;
            this.btnXoaKhachHang.Click += new System.EventHandler(this.btnXoaKhachHang_Click);
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.Location = new System.Drawing.Point(113, 280);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(75, 36);
            this.btnThemKhachHang.TabIndex = 35;
            this.btnThemKhachHang.Text = "Thêm";
            this.btnThemKhachHang.UseVisualStyleBackColor = true;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // FrmQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQLKhachHang";
            this.Text = "FrmQLKhachHang";
            this.Load += new System.EventHandler(this.FrmQLKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDongKhachHang;
        private System.Windows.Forms.Button btnLuuKhachHang;
        private System.Windows.Forms.Button btnXoaKhachHang;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.ComboBox cbTrangThai1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTrangThai2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTrangThai3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTrangThai4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtGhiChu3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGiaiTri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGhiChu4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGhiChu2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGhiChu1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label28;
    }
}
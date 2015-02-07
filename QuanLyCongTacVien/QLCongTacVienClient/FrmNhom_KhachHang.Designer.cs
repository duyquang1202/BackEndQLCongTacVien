namespace QLCongTacVienClient
{
    partial class FrmNhom_KhachHang
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
            this.dgvNhom_KH = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTrangthaiNhom_KH = new System.Windows.Forms.ComboBox();
            this.cbTenKH_ = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemNhom_KH = new System.Windows.Forms.Button();
            this.btnDongNhom_KH = new System.Windows.Forms.Button();
            this.btnLuuNhom_KH = new System.Windows.Forms.Button();
            this.btnXoaNhom_KH = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhom_KH)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNhom_KH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Khách Hàng";
            // 
            // dgvNhom_KH
            // 
            this.dgvNhom_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhom_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhom_KH.Location = new System.Drawing.Point(3, 16);
            this.dgvNhom_KH.Name = "dgvNhom_KH";
            this.dgvNhom_KH.Size = new System.Drawing.Size(755, 178);
            this.dgvNhom_KH.TabIndex = 0;
            this.dgvNhom_KH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhom_KH_CellDoubleClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(204, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Tên Khách Hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Trạng Thái:";
            // 
            // cbTrangthaiNhom_KH
            // 
            this.cbTrangthaiNhom_KH.FormattingEnabled = true;
            this.cbTrangthaiNhom_KH.Location = new System.Drawing.Point(291, 112);
            this.cbTrangthaiNhom_KH.Name = "cbTrangthaiNhom_KH";
            this.cbTrangthaiNhom_KH.Size = new System.Drawing.Size(186, 21);
            this.cbTrangthaiNhom_KH.TabIndex = 33;
            // 
            // cbTenKH_
            // 
            this.cbTenKH_.FormattingEnabled = true;
            this.cbTenKH_.Location = new System.Drawing.Point(291, 69);
            this.cbTenKH_.Name = "cbTenKH_";
            this.cbTenKH_.Size = new System.Drawing.Size(186, 21);
            this.cbTenKH_.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemNhom_KH);
            this.groupBox2.Controls.Add(this.btnDongNhom_KH);
            this.groupBox2.Controls.Add(this.btnLuuNhom_KH);
            this.groupBox2.Controls.Add(this.btnXoaNhom_KH);
            this.groupBox2.Controls.Add(this.cbTenKH_);
            this.groupBox2.Controls.Add(this.cbTrangthaiNhom_KH);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // btnThemNhom_KH
            // 
            this.btnThemNhom_KH.Location = new System.Drawing.Point(99, 203);
            this.btnThemNhom_KH.Name = "btnThemNhom_KH";
            this.btnThemNhom_KH.Size = new System.Drawing.Size(75, 36);
            this.btnThemNhom_KH.TabIndex = 38;
            this.btnThemNhom_KH.Text = "Thêm";
            this.btnThemNhom_KH.UseVisualStyleBackColor = true;
            this.btnThemNhom_KH.Click += new System.EventHandler(this.btnThemNhom_KH_Click);
            // 
            // btnDongNhom_KH
            // 
            this.btnDongNhom_KH.Location = new System.Drawing.Point(608, 203);
            this.btnDongNhom_KH.Name = "btnDongNhom_KH";
            this.btnDongNhom_KH.Size = new System.Drawing.Size(75, 36);
            this.btnDongNhom_KH.TabIndex = 37;
            this.btnDongNhom_KH.Text = "Đóng";
            this.btnDongNhom_KH.UseVisualStyleBackColor = true;
            this.btnDongNhom_KH.Click += new System.EventHandler(this.btnDongNhom_KH_Click);
            // 
            // btnLuuNhom_KH
            // 
            this.btnLuuNhom_KH.Enabled = false;
            this.btnLuuNhom_KH.Location = new System.Drawing.Point(270, 203);
            this.btnLuuNhom_KH.Name = "btnLuuNhom_KH";
            this.btnLuuNhom_KH.Size = new System.Drawing.Size(75, 36);
            this.btnLuuNhom_KH.TabIndex = 35;
            this.btnLuuNhom_KH.Text = "Lưu";
            this.btnLuuNhom_KH.UseVisualStyleBackColor = true;
            this.btnLuuNhom_KH.Click += new System.EventHandler(this.btnLuuNhom_KH_Click);
            // 
            // btnXoaNhom_KH
            // 
            this.btnXoaNhom_KH.Enabled = false;
            this.btnXoaNhom_KH.Location = new System.Drawing.Point(458, 203);
            this.btnXoaNhom_KH.Name = "btnXoaNhom_KH";
            this.btnXoaNhom_KH.Size = new System.Drawing.Size(75, 36);
            this.btnXoaNhom_KH.TabIndex = 36;
            this.btnXoaNhom_KH.Text = "Xóa";
            this.btnXoaNhom_KH.UseVisualStyleBackColor = true;
            this.btnXoaNhom_KH.Click += new System.EventHandler(this.btnXoaNhom_KH_Click);
            // 
            // FrmNhom_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNhom_KhachHang";
            this.Text = "FrmNhom_KhachHang";
            this.Load += new System.EventHandler(this.FrmNhom_KhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhom_KH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNhom_KH;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTrangthaiNhom_KH;
        private System.Windows.Forms.ComboBox cbTenKH_;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemNhom_KH;
        private System.Windows.Forms.Button btnDongNhom_KH;
        private System.Windows.Forms.Button btnLuuNhom_KH;
        private System.Windows.Forms.Button btnXoaNhom_KH;
    }
}
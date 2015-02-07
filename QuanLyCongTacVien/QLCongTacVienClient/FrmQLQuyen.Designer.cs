namespace QLCongTacVienClient
{
    partial class FrmQLQuyen
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSQuyen = new System.Windows.Forms.DataGridView();
            this.cbTrangThaiPermission = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtNamePermission = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnDongPermission = new System.Windows.Forms.Button();
            this.btnLuuPermission = new System.Windows.Forms.Button();
            this.btnXoaPermission = new System.Windows.Forms.Button();
            this.btnThemPermission = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSQuyen);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Quyền";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDongPermission);
            this.groupBox2.Controls.Add(this.btnLuuPermission);
            this.groupBox2.Controls.Add(this.btnXoaPermission);
            this.groupBox2.Controls.Add(this.btnThemPermission);
            this.groupBox2.Controls.Add(this.cbTrangThaiPermission);
            this.groupBox2.Controls.Add(this.txtNamePermission);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // dgvDSQuyen
            // 
            this.dgvDSQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSQuyen.Location = new System.Drawing.Point(3, 16);
            this.dgvDSQuyen.Name = "dgvDSQuyen";
            this.dgvDSQuyen.Size = new System.Drawing.Size(664, 185);
            this.dgvDSQuyen.TabIndex = 0;
            this.dgvDSQuyen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSQuyen_CellDoubleClick);
            // 
            // cbTrangThaiPermission
            // 
            this.cbTrangThaiPermission.FormattingEnabled = true;
            this.cbTrangThaiPermission.Location = new System.Drawing.Point(252, 91);
            this.cbTrangThaiPermission.Name = "cbTrangThaiPermission";
            this.cbTrangThaiPermission.Size = new System.Drawing.Size(223, 21);
            this.cbTrangThaiPermission.TabIndex = 22;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(147, 91);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 13);
            this.label26.TabIndex = 21;
            this.label26.Text = "Trạng Thái:";
            // 
            // txtNamePermission
            // 
            this.txtNamePermission.Enabled = false;
            this.txtNamePermission.Location = new System.Drawing.Point(252, 42);
            this.txtNamePermission.Name = "txtNamePermission";
            this.txtNamePermission.Size = new System.Drawing.Size(223, 20);
            this.txtNamePermission.TabIndex = 19;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(147, 45);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 13);
            this.label25.TabIndex = 20;
            this.label25.Text = "Name:";
            // 
            // btnDongPermission
            // 
            this.btnDongPermission.Location = new System.Drawing.Point(570, 149);
            this.btnDongPermission.Name = "btnDongPermission";
            this.btnDongPermission.Size = new System.Drawing.Size(75, 36);
            this.btnDongPermission.TabIndex = 34;
            this.btnDongPermission.Text = "Đóng";
            this.btnDongPermission.UseVisualStyleBackColor = true;
            this.btnDongPermission.Click += new System.EventHandler(this.btnDongPermission_Click);
            // 
            // btnLuuPermission
            // 
            this.btnLuuPermission.Enabled = false;
            this.btnLuuPermission.Location = new System.Drawing.Point(231, 149);
            this.btnLuuPermission.Name = "btnLuuPermission";
            this.btnLuuPermission.Size = new System.Drawing.Size(75, 36);
            this.btnLuuPermission.TabIndex = 32;
            this.btnLuuPermission.Text = "Lưu";
            this.btnLuuPermission.UseVisualStyleBackColor = true;
            this.btnLuuPermission.Click += new System.EventHandler(this.btnLuuPermission_Click);
            // 
            // btnXoaPermission
            // 
            this.btnXoaPermission.Enabled = false;
            this.btnXoaPermission.Location = new System.Drawing.Point(419, 149);
            this.btnXoaPermission.Name = "btnXoaPermission";
            this.btnXoaPermission.Size = new System.Drawing.Size(75, 36);
            this.btnXoaPermission.TabIndex = 33;
            this.btnXoaPermission.Text = "Xóa";
            this.btnXoaPermission.UseVisualStyleBackColor = true;
            this.btnXoaPermission.Click += new System.EventHandler(this.btnXoaPermission_Click);
            // 
            // btnThemPermission
            // 
            this.btnThemPermission.Location = new System.Drawing.Point(40, 149);
            this.btnThemPermission.Name = "btnThemPermission";
            this.btnThemPermission.Size = new System.Drawing.Size(75, 36);
            this.btnThemPermission.TabIndex = 31;
            this.btnThemPermission.Text = "Thêm";
            this.btnThemPermission.UseVisualStyleBackColor = true;
            this.btnThemPermission.Click += new System.EventHandler(this.btnThemPermission_Click);
            // 
            // FrmQLQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQLQuyen";
            this.Text = "FrmQLQuyen";
            this.Load += new System.EventHandler(this.FrmQLQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSQuyen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTrangThaiPermission;
        private System.Windows.Forms.TextBox txtNamePermission;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnDongPermission;
        private System.Windows.Forms.Button btnLuuPermission;
        private System.Windows.Forms.Button btnXoaPermission;
        private System.Windows.Forms.Button btnThemPermission;
    }
}
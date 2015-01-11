namespace QLCongTacVienClient
{
    partial class FormMain
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
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDongPhongBan = new System.Windows.Forms.Button();
            this.btnLuuPhongBan = new System.Windows.Forms.Button();
            this.btnXoaPhongBan = new System.Windows.Forms.Button();
            this.txtphongban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemPhongBan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLuuYPhongBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTrangThaiPhongBan = new System.Windows.Forms.ComboBox();
            this.txtMoTaPhongBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabMainControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tabPage1);
            this.tabMainControl.Controls.Add(this.tabPage2);
            this.tabMainControl.Controls.Add(this.tabPage3);
            this.tabMainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainControl.Location = new System.Drawing.Point(0, 0);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(803, 622);
            this.tabMainControl.TabIndex = 0;
            this.tabMainControl.SelectedIndexChanged += new System.EventHandler(this.tabMainControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý Đơn Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 596);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý Phòng Ban";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMoTaPhongBan);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbTrangThaiPhongBan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtLuuYPhongBan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDongPhongBan);
            this.groupBox2.Controls.Add(this.btnLuuPhongBan);
            this.groupBox2.Controls.Add(this.btnXoaPhongBan);
            this.groupBox2.Controls.Add(this.txtphongban);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnThemPhongBan);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 324);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // btnDongPhongBan
            // 
            this.btnDongPhongBan.Location = new System.Drawing.Point(547, 241);
            this.btnDongPhongBan.Name = "btnDongPhongBan";
            this.btnDongPhongBan.Size = new System.Drawing.Size(75, 36);
            this.btnDongPhongBan.TabIndex = 6;
            this.btnDongPhongBan.Text = "Đóng";
            this.btnDongPhongBan.UseVisualStyleBackColor = true;
            this.btnDongPhongBan.Click += new System.EventHandler(this.btnDongPhongBan_Click);
            // 
            // btnLuuPhongBan
            // 
            this.btnLuuPhongBan.Enabled = false;
            this.btnLuuPhongBan.Location = new System.Drawing.Point(208, 241);
            this.btnLuuPhongBan.Name = "btnLuuPhongBan";
            this.btnLuuPhongBan.Size = new System.Drawing.Size(75, 36);
            this.btnLuuPhongBan.TabIndex = 4;
            this.btnLuuPhongBan.Text = "Lưu";
            this.btnLuuPhongBan.UseVisualStyleBackColor = true;
            this.btnLuuPhongBan.Click += new System.EventHandler(this.btnLuuPhongBan_Click);
            // 
            // btnXoaPhongBan
            // 
            this.btnXoaPhongBan.Enabled = false;
            this.btnXoaPhongBan.Location = new System.Drawing.Point(396, 241);
            this.btnXoaPhongBan.Name = "btnXoaPhongBan";
            this.btnXoaPhongBan.Size = new System.Drawing.Size(75, 36);
            this.btnXoaPhongBan.TabIndex = 5;
            this.btnXoaPhongBan.Text = "Xóa";
            this.btnXoaPhongBan.UseVisualStyleBackColor = true;
            this.btnXoaPhongBan.Click += new System.EventHandler(this.btnXoaPhongBan_Click);
            // 
            // txtphongban
            // 
            this.txtphongban.Enabled = false;
            this.txtphongban.Location = new System.Drawing.Point(114, 20);
            this.txtphongban.Name = "txtphongban";
            this.txtphongban.Size = new System.Drawing.Size(427, 20);
            this.txtphongban.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Phòng Ban:";
            // 
            // btnThemPhongBan
            // 
            this.btnThemPhongBan.Location = new System.Drawing.Point(17, 241);
            this.btnThemPhongBan.Name = "btnThemPhongBan";
            this.btnThemPhongBan.Size = new System.Drawing.Size(75, 36);
            this.btnThemPhongBan.TabIndex = 3;
            this.btnThemPhongBan.Text = "Thêm";
            this.btnThemPhongBan.UseVisualStyleBackColor = true;
            this.btnThemPhongBan.Click += new System.EventHandler(this.btnThemPhongBan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPhongBan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phòng Ban";
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongBan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPhongBan.Location = new System.Drawing.Point(3, 16);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.Size = new System.Drawing.Size(783, 247);
            this.dgvPhongBan.TabIndex = 0;
            this.dgvPhongBan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản Lý Account";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lưu ý:";
            // 
            // txtLuuYPhongBan
            // 
            this.txtLuuYPhongBan.Enabled = false;
            this.txtLuuYPhongBan.Location = new System.Drawing.Point(469, 109);
            this.txtLuuYPhongBan.Multiline = true;
            this.txtLuuYPhongBan.Name = "txtLuuYPhongBan";
            this.txtLuuYPhongBan.Size = new System.Drawing.Size(281, 88);
            this.txtLuuYPhongBan.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Trạng Thái:";
            // 
            // cbTrangThaiPhongBan
            // 
            this.cbTrangThaiPhongBan.FormattingEnabled = true;
            this.cbTrangThaiPhongBan.Location = new System.Drawing.Point(114, 58);
            this.cbTrangThaiPhongBan.Name = "cbTrangThaiPhongBan";
            this.cbTrangThaiPhongBan.Size = new System.Drawing.Size(121, 21);
            this.cbTrangThaiPhongBan.TabIndex = 10;
            // 
            // txtMoTaPhongBan
            // 
            this.txtMoTaPhongBan.Enabled = false;
            this.txtMoTaPhongBan.Location = new System.Drawing.Point(114, 109);
            this.txtMoTaPhongBan.Multiline = true;
            this.txtMoTaPhongBan.Name = "txtMoTaPhongBan";
            this.txtMoTaPhongBan.Size = new System.Drawing.Size(223, 88);
            this.txtMoTaPhongBan.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mô Tả:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 622);
            this.Controls.Add(this.tabMainControl);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabMainControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDongPhongBan;
        private System.Windows.Forms.Button btnLuuPhongBan;
        private System.Windows.Forms.Button btnXoaPhongBan;
        private System.Windows.Forms.TextBox txtphongban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemPhongBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.ComboBox cbTrangThaiPhongBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLuuYPhongBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoTaPhongBan;
        private System.Windows.Forms.Label label4;
    }
}
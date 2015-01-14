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
            this.txtMoTaPhongBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTrangThaiPhongBan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLuuYPhongBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDongPhongBan = new System.Windows.Forms.Button();
            this.btnLuuPhongBan = new System.Windows.Forms.Button();
            this.btnXoaPhongBan = new System.Windows.Forms.Button();
            this.txtphongban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemPhongBan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDongAcount = new System.Windows.Forms.Button();
            this.btnLuuAcount = new System.Windows.Forms.Button();
            this.btnXoaAcount = new System.Windows.Forms.Button();
            this.btnThemAcount = new System.Windows.Forms.Button();
            this.txtLoaiAcount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboTrangthaiAcount = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLuuyAcount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenAcount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.txtAccountManager = new System.Windows.Forms.TextBox();
            this.tabMainControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
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
            this.tabPage1.Size = new System.Drawing.Size(795, 596);
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
            // cbTrangThaiPhongBan
            // 
            this.cbTrangThaiPhongBan.FormattingEnabled = true;
            this.cbTrangThaiPhongBan.Location = new System.Drawing.Point(114, 58);
            this.cbTrangThaiPhongBan.Name = "cbTrangThaiPhongBan";
            this.cbTrangThaiPhongBan.Size = new System.Drawing.Size(121, 21);
            this.cbTrangThaiPhongBan.TabIndex = 10;
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
            // txtLuuYPhongBan
            // 
            this.txtLuuYPhongBan.Enabled = false;
            this.txtLuuYPhongBan.Location = new System.Drawing.Point(469, 109);
            this.txtLuuYPhongBan.Multiline = true;
            this.txtLuuYPhongBan.Name = "txtLuuYPhongBan";
            this.txtLuuYPhongBan.Size = new System.Drawing.Size(281, 88);
            this.txtLuuYPhongBan.TabIndex = 8;
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
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 596);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản Lý Account";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAccountManager);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnDongAcount);
            this.groupBox4.Controls.Add(this.btnLuuAcount);
            this.groupBox4.Controls.Add(this.btnXoaAcount);
            this.groupBox4.Controls.Add(this.btnThemAcount);
            this.groupBox4.Controls.Add(this.txtLoaiAcount);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cboTrangthaiAcount);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtLuuyAcount);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtTenAcount);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(789, 377);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Acount Mannager";
            // 
            // btnDongAcount
            // 
            this.btnDongAcount.Location = new System.Drawing.Point(609, 289);
            this.btnDongAcount.Name = "btnDongAcount";
            this.btnDongAcount.Size = new System.Drawing.Size(75, 36);
            this.btnDongAcount.TabIndex = 26;
            this.btnDongAcount.Text = "Đóng";
            this.btnDongAcount.UseVisualStyleBackColor = true;
            this.btnDongAcount.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLuuAcount
            // 
            this.btnLuuAcount.Enabled = false;
            this.btnLuuAcount.Location = new System.Drawing.Point(270, 289);
            this.btnLuuAcount.Name = "btnLuuAcount";
            this.btnLuuAcount.Size = new System.Drawing.Size(75, 36);
            this.btnLuuAcount.TabIndex = 24;
            this.btnLuuAcount.Text = "Lưu";
            this.btnLuuAcount.UseVisualStyleBackColor = true;
            this.btnLuuAcount.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnXoaAcount
            // 
            this.btnXoaAcount.Enabled = false;
            this.btnXoaAcount.Location = new System.Drawing.Point(458, 289);
            this.btnXoaAcount.Name = "btnXoaAcount";
            this.btnXoaAcount.Size = new System.Drawing.Size(75, 36);
            this.btnXoaAcount.TabIndex = 25;
            this.btnXoaAcount.Text = "Xóa";
            this.btnXoaAcount.UseVisualStyleBackColor = true;
            this.btnXoaAcount.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnThemAcount
            // 
            this.btnThemAcount.Location = new System.Drawing.Point(79, 289);
            this.btnThemAcount.Name = "btnThemAcount";
            this.btnThemAcount.Size = new System.Drawing.Size(75, 36);
            this.btnThemAcount.TabIndex = 23;
            this.btnThemAcount.Text = "Thêm";
            this.btnThemAcount.UseVisualStyleBackColor = true;
            this.btnThemAcount.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtLoaiAcount
            // 
            this.txtLoaiAcount.Enabled = false;
            this.txtLoaiAcount.Location = new System.Drawing.Point(115, 61);
            this.txtLoaiAcount.Name = "txtLoaiAcount";
            this.txtLoaiAcount.Size = new System.Drawing.Size(223, 20);
            this.txtLoaiAcount.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Loại Acount";
            // 
            // cboTrangthaiAcount
            // 
            this.cboTrangthaiAcount.FormattingEnabled = true;
            this.cboTrangthaiAcount.Location = new System.Drawing.Point(122, 115);
            this.cboTrangthaiAcount.Name = "cboTrangthaiAcount";
            this.cboTrangthaiAcount.Size = new System.Drawing.Size(121, 21);
            this.cboTrangthaiAcount.TabIndex = 18;
            this.cboTrangthaiAcount.SelectedIndexChanged += new System.EventHandler(this.cboTrangthaiAcount_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Trạng Thái:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtLuuyAcount
            // 
            this.txtLuuyAcount.Enabled = false;
            this.txtLuuyAcount.Location = new System.Drawing.Point(477, 166);
            this.txtLuuyAcount.Multiline = true;
            this.txtLuuyAcount.Name = "txtLuuyAcount";
            this.txtLuuyAcount.Size = new System.Drawing.Size(281, 88);
            this.txtLuuyAcount.TabIndex = 16;
            this.txtLuuyAcount.TextChanged += new System.EventHandler(this.txtLuuyAcount_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lưu ý:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtTenAcount
            // 
            this.txtTenAcount.Enabled = false;
            this.txtTenAcount.Location = new System.Drawing.Point(115, 20);
            this.txtTenAcount.Name = "txtTenAcount";
            this.txtTenAcount.Size = new System.Drawing.Size(223, 20);
            this.txtTenAcount.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tên Account";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAccount);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(789, 213);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Account";
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(3, 16);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(783, 194);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellDoubleClick);
            // 
            // txtAccountManager
            // 
            this.txtAccountManager.Enabled = false;
            this.txtAccountManager.Location = new System.Drawing.Point(115, 162);
            this.txtAccountManager.Name = "txtAccountManager";
            this.txtAccountManager.Size = new System.Drawing.Size(223, 20);
            this.txtAccountManager.TabIndex = 28;
            this.txtAccountManager.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboTrangthaiAcount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLuuyAcount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenAcount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoaiAcount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDongAcount;
        private System.Windows.Forms.Button btnLuuAcount;
        private System.Windows.Forms.Button btnXoaAcount;
        private System.Windows.Forms.Button btnThemAcount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountManager;
    }
}
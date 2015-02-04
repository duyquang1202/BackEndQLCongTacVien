namespace QLCongTacVienClient
{
    partial class frmQLUser
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
            this.dgvDSUser = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbGroupPerrmsion = new System.Windows.Forms.ListBox();
            this.cbTrangthaiUser = new System.Windows.Forms.ComboBox();
            this.btnDongUser = new System.Windows.Forms.Button();
            this.btnLuuUser = new System.Windows.Forms.Button();
            this.btnXoaUser = new System.Windows.Forms.Button();
            this.btnThemUser = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSUser)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSUser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách User";
            // 
            // dgvDSUser
            // 
            this.dgvDSUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSUser.Location = new System.Drawing.Point(3, 16);
            this.dgvDSUser.Name = "dgvDSUser";
            this.dgvDSUser.Size = new System.Drawing.Size(761, 168);
            this.dgvDSUser.TabIndex = 0;
            this.dgvDSUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSUser_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbGroupPerrmsion);
            this.groupBox2.Controls.Add(this.cbTrangthaiUser);
            this.groupBox2.Controls.Add(this.btnDongUser);
            this.groupBox2.Controls.Add(this.btnLuuUser);
            this.groupBox2.Controls.Add(this.btnXoaUser);
            this.groupBox2.Controls.Add(this.btnThemUser);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDienthoai);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDiachi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtFullName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 377);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // lbGroupPerrmsion
            // 
            this.lbGroupPerrmsion.FormattingEnabled = true;
            this.lbGroupPerrmsion.Location = new System.Drawing.Point(96, 180);
            this.lbGroupPerrmsion.Name = "lbGroupPerrmsion";
            this.lbGroupPerrmsion.Size = new System.Drawing.Size(161, 108);
            this.lbGroupPerrmsion.TabIndex = 21;
            this.lbGroupPerrmsion.SelectedIndexChanged += new System.EventHandler(this.lbGroupPerrmsion_SelectedIndexChanged);
            // 
            // cbTrangthaiUser
            // 
            this.cbTrangthaiUser.FormattingEnabled = true;
            this.cbTrangthaiUser.Location = new System.Drawing.Point(408, 97);
            this.cbTrangthaiUser.Name = "cbTrangthaiUser";
            this.cbTrangthaiUser.Size = new System.Drawing.Size(161, 21);
            this.cbTrangthaiUser.TabIndex = 20;
            // 
            // btnDongUser
            // 
            this.btnDongUser.Location = new System.Drawing.Point(558, 316);
            this.btnDongUser.Name = "btnDongUser";
            this.btnDongUser.Size = new System.Drawing.Size(75, 36);
            this.btnDongUser.TabIndex = 19;
            this.btnDongUser.Text = "Đóng";
            this.btnDongUser.UseVisualStyleBackColor = true;
            this.btnDongUser.Click += new System.EventHandler(this.btnDongUser_Click);
            // 
            // btnLuuUser
            // 
            this.btnLuuUser.Enabled = false;
            this.btnLuuUser.Location = new System.Drawing.Point(219, 316);
            this.btnLuuUser.Name = "btnLuuUser";
            this.btnLuuUser.Size = new System.Drawing.Size(75, 36);
            this.btnLuuUser.TabIndex = 17;
            this.btnLuuUser.Text = "Lưu";
            this.btnLuuUser.UseVisualStyleBackColor = true;
            this.btnLuuUser.Click += new System.EventHandler(this.btnLuuUser_Click);
            // 
            // btnXoaUser
            // 
            this.btnXoaUser.Enabled = false;
            this.btnXoaUser.Location = new System.Drawing.Point(407, 316);
            this.btnXoaUser.Name = "btnXoaUser";
            this.btnXoaUser.Size = new System.Drawing.Size(75, 36);
            this.btnXoaUser.TabIndex = 18;
            this.btnXoaUser.Text = "Xóa";
            this.btnXoaUser.UseVisualStyleBackColor = true;
            this.btnXoaUser.Click += new System.EventHandler(this.btnXoaUser_Click);
            // 
            // btnThemUser
            // 
            this.btnThemUser.Location = new System.Drawing.Point(28, 316);
            this.btnThemUser.Name = "btnThemUser";
            this.btnThemUser.Size = new System.Drawing.Size(75, 36);
            this.btnThemUser.TabIndex = 16;
            this.btnThemUser.Text = "Thêm";
            this.btnThemUser.UseVisualStyleBackColor = true;
            this.btnThemUser.Click += new System.EventHandler(this.btnThemUser_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(408, 139);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(223, 71);
            this.txtGhiChu.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ghi Chú";
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(96, 139);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(161, 20);
            this.txtDienthoai.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Trạng Thái";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(408, 20);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(161, 20);
            this.txtDiachi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa Chỉ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(408, 56);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ẻmail";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(96, 97);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(161, 20);
            this.txtFullName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "FullName";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 56);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(161, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(96, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(161, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:";
            // 
            // frmQLUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 564);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLUser";
            this.Text = "QLUser";
            this.Load += new System.EventHandler(this.frmQLUser_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSUser)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDongUser;
        private System.Windows.Forms.Button btnLuuUser;
        private System.Windows.Forms.Button btnXoaUser;
        private System.Windows.Forms.Button btnThemUser;
        private System.Windows.Forms.ComboBox cbTrangthaiUser;
        private System.Windows.Forms.ListBox lbGroupPerrmsion;

    }
}
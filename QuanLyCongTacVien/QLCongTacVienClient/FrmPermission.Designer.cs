namespace QLCongTacVienClient
{
    partial class FrmGroup_Permission
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
            this.dgvGroup_Per = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDongGroupPer_ = new System.Windows.Forms.Button();
            this.btnLuuGroupPer_ = new System.Windows.Forms.Button();
            this.btnXoaGroupPer_ = new System.Windows.Forms.Button();
            this.btnThemGroupPer_ = new System.Windows.Forms.Button();
            this.cbNameGroup_per = new System.Windows.Forms.ComboBox();
            this.cbTrangthaiGroup_Per = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup_Per)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGroup_Per);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Quyền";
            // 
            // dgvGroup_Per
            // 
            this.dgvGroup_Per.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup_Per.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroup_Per.Location = new System.Drawing.Point(3, 16);
            this.dgvGroup_Per.Name = "dgvGroup_Per";
            this.dgvGroup_Per.Size = new System.Drawing.Size(676, 165);
            this.dgvGroup_Per.TabIndex = 0;
            this.dgvGroup_Per.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroup_Per_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDongGroupPer_);
            this.groupBox2.Controls.Add(this.btnLuuGroupPer_);
            this.groupBox2.Controls.Add(this.btnXoaGroupPer_);
            this.groupBox2.Controls.Add(this.btnThemGroupPer_);
            this.groupBox2.Controls.Add(this.cbNameGroup_per);
            this.groupBox2.Controls.Add(this.cbTrangthaiGroup_Per);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 244);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // btnDongGroupPer_
            // 
            this.btnDongGroupPer_.Location = new System.Drawing.Point(575, 178);
            this.btnDongGroupPer_.Name = "btnDongGroupPer_";
            this.btnDongGroupPer_.Size = new System.Drawing.Size(75, 36);
            this.btnDongGroupPer_.TabIndex = 29;
            this.btnDongGroupPer_.Text = "Đóng";
            this.btnDongGroupPer_.UseVisualStyleBackColor = true;
            // 
            // btnLuuGroupPer_
            // 
            this.btnLuuGroupPer_.Enabled = false;
            this.btnLuuGroupPer_.Location = new System.Drawing.Point(237, 178);
            this.btnLuuGroupPer_.Name = "btnLuuGroupPer_";
            this.btnLuuGroupPer_.Size = new System.Drawing.Size(75, 36);
            this.btnLuuGroupPer_.TabIndex = 27;
            this.btnLuuGroupPer_.Text = "Lưu";
            this.btnLuuGroupPer_.UseVisualStyleBackColor = true;
            this.btnLuuGroupPer_.Click += new System.EventHandler(this.btnLuuGroupPer__Click);
            // 
            // btnXoaGroupPer_
            // 
            this.btnXoaGroupPer_.Enabled = false;
            this.btnXoaGroupPer_.Location = new System.Drawing.Point(425, 178);
            this.btnXoaGroupPer_.Name = "btnXoaGroupPer_";
            this.btnXoaGroupPer_.Size = new System.Drawing.Size(75, 36);
            this.btnXoaGroupPer_.TabIndex = 28;
            this.btnXoaGroupPer_.Text = "Xóa";
            this.btnXoaGroupPer_.UseVisualStyleBackColor = true;
            // 
            // btnThemGroupPer_
            // 
            this.btnThemGroupPer_.Location = new System.Drawing.Point(46, 178);
            this.btnThemGroupPer_.Name = "btnThemGroupPer_";
            this.btnThemGroupPer_.Size = new System.Drawing.Size(75, 36);
            this.btnThemGroupPer_.TabIndex = 26;
            this.btnThemGroupPer_.Text = "Thêm";
            this.btnThemGroupPer_.UseVisualStyleBackColor = true;
            this.btnThemGroupPer_.Click += new System.EventHandler(this.btnThemGroupPer__Click);
            // 
            // cbNameGroup_per
            // 
            this.cbNameGroup_per.FormattingEnabled = true;
            this.cbNameGroup_per.Location = new System.Drawing.Point(241, 58);
            this.cbNameGroup_per.Name = "cbNameGroup_per";
            this.cbNameGroup_per.Size = new System.Drawing.Size(186, 21);
            this.cbNameGroup_per.TabIndex = 25;
            // 
            // cbTrangthaiGroup_Per
            // 
            this.cbTrangthaiGroup_Per.FormattingEnabled = true;
            this.cbTrangthaiGroup_Per.Location = new System.Drawing.Point(239, 102);
            this.cbTrangthaiGroup_Per.Name = "cbTrangthaiGroup_Per";
            this.cbTrangthaiGroup_Per.Size = new System.Drawing.Size(186, 21);
            this.cbTrangthaiGroup_Per.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Trạng Thái:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(150, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Name:";
            // 
            // FrmGroup_Permission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGroup_Permission";
            this.Text = "FrmGroup_Permission";
            this.Load += new System.EventHandler(this.FrmGroup_Permission_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup_Per)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGroup_Per;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbTrangthaiGroup_Per;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbNameGroup_per;
        private System.Windows.Forms.Button btnDongGroupPer_;
        private System.Windows.Forms.Button btnLuuGroupPer_;
        private System.Windows.Forms.Button btnXoaGroupPer_;
        private System.Windows.Forms.Button btnThemGroupPer_;
    }
}
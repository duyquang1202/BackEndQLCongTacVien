namespace QLCongTacVienClient
{
    partial class FrmHoaHong
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
            this.btnDongHoaHong = new System.Windows.Forms.Button();
            this.btnLuuHoaHong = new System.Windows.Forms.Button();
            this.cbTrangThaiHoaHong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoaHong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHoaHong = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaHong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDongHoaHong);
            this.groupBox1.Controls.Add(this.btnLuuHoaHong);
            this.groupBox1.Controls.Add(this.cbTrangThaiHoaHong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoaHong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDongHoaHong
            // 
            this.btnDongHoaHong.Location = new System.Drawing.Point(474, 162);
            this.btnDongHoaHong.Name = "btnDongHoaHong";
            this.btnDongHoaHong.Size = new System.Drawing.Size(75, 36);
            this.btnDongHoaHong.TabIndex = 30;
            this.btnDongHoaHong.Text = "Đóng";
            this.btnDongHoaHong.UseVisualStyleBackColor = true;
            this.btnDongHoaHong.Click += new System.EventHandler(this.btnDongHoaHong_Click);
            // 
            // btnLuuHoaHong
            // 
            this.btnLuuHoaHong.Enabled = false;
            this.btnLuuHoaHong.Location = new System.Drawing.Point(182, 162);
            this.btnLuuHoaHong.Name = "btnLuuHoaHong";
            this.btnLuuHoaHong.Size = new System.Drawing.Size(75, 36);
            this.btnLuuHoaHong.TabIndex = 28;
            this.btnLuuHoaHong.Text = "Lưu";
            this.btnLuuHoaHong.UseVisualStyleBackColor = true;
            this.btnLuuHoaHong.Click += new System.EventHandler(this.btnLuuHoaHong_Click);
            // 
            // cbTrangThaiHoaHong
            // 
            this.cbTrangThaiHoaHong.FormattingEnabled = true;
            this.cbTrangThaiHoaHong.Location = new System.Drawing.Point(430, 57);
            this.cbTrangThaiHoaHong.Name = "cbTrangThaiHoaHong";
            this.cbTrangThaiHoaHong.Size = new System.Drawing.Size(161, 21);
            this.cbTrangThaiHoaHong.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Trạng Thái:";
            // 
            // txtHoaHong
            // 
            this.txtHoaHong.Location = new System.Drawing.Point(124, 57);
            this.txtHoaHong.Name = "txtHoaHong";
            this.txtHoaHong.Size = new System.Drawing.Size(161, 20);
            this.txtHoaHong.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Hoa Hồng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHoaHong);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hoa Hồng";
            // 
            // dgvHoaHong
            // 
            this.dgvHoaHong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaHong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaHong.Location = new System.Drawing.Point(3, 16);
            this.dgvHoaHong.Name = "dgvHoaHong";
            this.dgvHoaHong.Size = new System.Drawing.Size(744, 186);
            this.dgvHoaHong.TabIndex = 0;
            this.dgvHoaHong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaHong_CellDoubleClick);
            // 
            // FrmHoaHong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmHoaHong";
            this.Text = "FrmHoaHong";
            this.Load += new System.EventHandler(this.FrmHoaHong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaHong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHoaHong;
        private System.Windows.Forms.TextBox txtHoaHong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTrangThaiHoaHong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDongHoaHong;
        private System.Windows.Forms.Button btnLuuHoaHong;
    }
}
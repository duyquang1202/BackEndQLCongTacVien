namespace QLCongTacVienClient
{
    partial class FrmAboutSite
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
            this.btnDongAboutSite = new System.Windows.Forms.Button();
            this.btnLuuAboutSite = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNoteAboutSite = new System.Windows.Forms.TextBox();
            this.dgvAboutSite = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAboutSite)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAboutSite);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách AboutSite:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDongAboutSite);
            this.groupBox2.Controls.Add(this.btnLuuAboutSite);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtNoteAboutSite);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin:";
            // 
            // btnDongAboutSite
            // 
            this.btnDongAboutSite.Location = new System.Drawing.Point(410, 165);
            this.btnDongAboutSite.Name = "btnDongAboutSite";
            this.btnDongAboutSite.Size = new System.Drawing.Size(75, 36);
            this.btnDongAboutSite.TabIndex = 25;
            this.btnDongAboutSite.Text = "Đóng";
            this.btnDongAboutSite.UseVisualStyleBackColor = true;
            this.btnDongAboutSite.Click += new System.EventHandler(this.btnDongAboutSite_Click);
            // 
            // btnLuuAboutSite
            // 
            this.btnLuuAboutSite.Enabled = false;
            this.btnLuuAboutSite.Location = new System.Drawing.Point(220, 165);
            this.btnLuuAboutSite.Name = "btnLuuAboutSite";
            this.btnLuuAboutSite.Size = new System.Drawing.Size(75, 36);
            this.btnLuuAboutSite.TabIndex = 24;
            this.btnLuuAboutSite.Text = "Lưu";
            this.btnLuuAboutSite.UseVisualStyleBackColor = true;
            this.btnLuuAboutSite.Click += new System.EventHandler(this.btnLuuAboutSite_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(217, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 24);
            this.label15.TabIndex = 22;
            this.label15.Text = "Note:";
            // 
            // txtNoteAboutSite
            // 
            this.txtNoteAboutSite.Location = new System.Drawing.Point(220, 49);
            this.txtNoteAboutSite.Multiline = true;
            this.txtNoteAboutSite.Name = "txtNoteAboutSite";
            this.txtNoteAboutSite.Size = new System.Drawing.Size(265, 75);
            this.txtNoteAboutSite.TabIndex = 23;
            // 
            // dgvAboutSite
            // 
            this.dgvAboutSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAboutSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAboutSite.Location = new System.Drawing.Point(3, 16);
            this.dgvAboutSite.Name = "dgvAboutSite";
            this.dgvAboutSite.Size = new System.Drawing.Size(697, 166);
            this.dgvAboutSite.TabIndex = 0;
            this.dgvAboutSite.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAboutSite_CellDoubleClick);
            // 
            // FrmAboutSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAboutSite";
            this.Text = "FrmAboutSite";
            this.Load += new System.EventHandler(this.FrmAboutSite_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAboutSite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDongAboutSite;
        private System.Windows.Forms.Button btnLuuAboutSite;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNoteAboutSite;
        private System.Windows.Forms.DataGridView dgvAboutSite;
    }
}
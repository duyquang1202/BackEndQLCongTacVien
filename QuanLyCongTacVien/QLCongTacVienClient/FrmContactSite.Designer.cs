namespace QLCongTacVienClient
{
    partial class FrmContactSite
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
            this.dgvContactSite = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNoteContactSite = new System.Windows.Forms.TextBox();
            this.btnDongContactSite = new System.Windows.Forms.Button();
            this.btnLuuContactSite = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactSite)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvContactSite);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách ContactSite";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDongContactSite);
            this.groupBox2.Controls.Add(this.btnLuuContactSite);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtNoteContactSite);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvContactSite
            // 
            this.dgvContactSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContactSite.Location = new System.Drawing.Point(3, 16);
            this.dgvContactSite.Name = "dgvContactSite";
            this.dgvContactSite.Size = new System.Drawing.Size(711, 181);
            this.dgvContactSite.TabIndex = 0;
            this.dgvContactSite.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactSite_CellDoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(204, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 24);
            this.label15.TabIndex = 9;
            this.label15.Text = "Note:";
            // 
            // txtNoteContactSite
            // 
            this.txtNoteContactSite.Location = new System.Drawing.Point(207, 78);
            this.txtNoteContactSite.Multiline = true;
            this.txtNoteContactSite.Name = "txtNoteContactSite";
            this.txtNoteContactSite.Size = new System.Drawing.Size(265, 75);
            this.txtNoteContactSite.TabIndex = 10;
            // 
            // btnDongContactSite
            // 
            this.btnDongContactSite.Location = new System.Drawing.Point(397, 194);
            this.btnDongContactSite.Name = "btnDongContactSite";
            this.btnDongContactSite.Size = new System.Drawing.Size(75, 36);
            this.btnDongContactSite.TabIndex = 21;
            this.btnDongContactSite.Text = "Đóng";
            this.btnDongContactSite.UseVisualStyleBackColor = true;
            this.btnDongContactSite.Click += new System.EventHandler(this.btnDongContactSite_Click);
            // 
            // btnLuuContactSite
            // 
            this.btnLuuContactSite.Enabled = false;
            this.btnLuuContactSite.Location = new System.Drawing.Point(207, 194);
            this.btnLuuContactSite.Name = "btnLuuContactSite";
            this.btnLuuContactSite.Size = new System.Drawing.Size(75, 36);
            this.btnLuuContactSite.TabIndex = 19;
            this.btnLuuContactSite.Text = "Lưu";
            this.btnLuuContactSite.UseVisualStyleBackColor = true;
            this.btnLuuContactSite.Click += new System.EventHandler(this.btnLuuContactSite_Click);
            // 
            // FrmContactSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 476);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmContactSite";
            this.Text = "FrmContactSite";
            this.Load += new System.EventHandler(this.FrmContactSite_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactSite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvContactSite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNoteContactSite;
        private System.Windows.Forms.Button btnDongContactSite;
        private System.Windows.Forms.Button btnLuuContactSite;
    }
}
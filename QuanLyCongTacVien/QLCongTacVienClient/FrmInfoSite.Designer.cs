namespace QLCongTacVienClient
{
    partial class FrmInfoSite
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
            this.dgvInfoSite = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDongInfoSite = new System.Windows.Forms.Button();
            this.btnLuuÌnoSite = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNoteInfoSite = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoSite)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvInfoSite);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách ÌnoSite:";
            // 
            // dgvInfoSite
            // 
            this.dgvInfoSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfoSite.Location = new System.Drawing.Point(3, 16);
            this.dgvInfoSite.Name = "dgvInfoSite";
            this.dgvInfoSite.Size = new System.Drawing.Size(723, 138);
            this.dgvInfoSite.TabIndex = 0;
            this.dgvInfoSite.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoSite_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDongInfoSite);
            this.groupBox2.Controls.Add(this.btnLuuÌnoSite);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtNoteInfoSite);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin:";
            // 
            // btnDongInfoSite
            // 
            this.btnDongInfoSite.Location = new System.Drawing.Point(423, 165);
            this.btnDongInfoSite.Name = "btnDongInfoSite";
            this.btnDongInfoSite.Size = new System.Drawing.Size(75, 36);
            this.btnDongInfoSite.TabIndex = 25;
            this.btnDongInfoSite.Text = "Đóng";
            this.btnDongInfoSite.UseVisualStyleBackColor = true;
            this.btnDongInfoSite.Click += new System.EventHandler(this.btnDongInfoSite_Click);
            // 
            // btnLuuÌnoSite
            // 
            this.btnLuuÌnoSite.Enabled = false;
            this.btnLuuÌnoSite.Location = new System.Drawing.Point(233, 165);
            this.btnLuuÌnoSite.Name = "btnLuuÌnoSite";
            this.btnLuuÌnoSite.Size = new System.Drawing.Size(75, 36);
            this.btnLuuÌnoSite.TabIndex = 24;
            this.btnLuuÌnoSite.Text = "Lưu";
            this.btnLuuÌnoSite.UseVisualStyleBackColor = true;
            this.btnLuuÌnoSite.Click += new System.EventHandler(this.btnLuuÌnoSite_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(230, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 24);
            this.label15.TabIndex = 22;
            this.label15.Text = "Note:";
            // 
            // txtNoteInfoSite
            // 
            this.txtNoteInfoSite.Location = new System.Drawing.Point(233, 49);
            this.txtNoteInfoSite.Multiline = true;
            this.txtNoteInfoSite.Name = "txtNoteInfoSite";
            this.txtNoteInfoSite.Size = new System.Drawing.Size(265, 75);
            this.txtNoteInfoSite.TabIndex = 23;
            // 
            // FrmInfoSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmInfoSite";
            this.Text = "FrmInfoSite";
            this.Load += new System.EventHandler(this.FrmInfoSite_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoSite)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDongInfoSite;
        private System.Windows.Forms.Button btnLuuÌnoSite;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNoteInfoSite;
        private System.Windows.Forms.DataGridView dgvInfoSite;
    }
}
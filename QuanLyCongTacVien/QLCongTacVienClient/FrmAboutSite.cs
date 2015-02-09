using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLCongTacVienClient
{
    public partial class FrmAboutSite : Form
    {
        AboutSite about;
        public int SiteID;
        public FrmAboutSite(int SiteID)
        {
            InitializeComponent();
            about = new AboutSite();
            this.SiteID = SiteID;

        }
        public void LoadDSAboutSite()
        {
            var list =about.LoadDSAbout(this.SiteID);
            DataTable dt = new DataTable();
            dt.Columns.Add("AboutID");
            dt.Columns.Add("Note");
            dt.Columns.Add("SiteID");

            foreach (var item in list)
            {
                dt.Rows.Add(item.AboutID,
                    item.Note,
                    item.SiteID);
            }
            dgvAboutSite.DataSource = dt;

        }

        private void FrmAboutSite_Load(object sender, EventArgs e)
        {
            LoadDSAboutSite();
        }

        private void dgvAboutSite_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLuuAboutSite.Enabled = true;
            btnDongAboutSite.Enabled = true;
            
            

            txtNoteAboutSite.Enabled = true;

            txtNoteAboutSite.Text =dgvAboutSite.CurrentRow.Cells[1].Value.ToString();
        }
        public void CapNhapContactSite()
        {
            var result =about.CapNhapAbout(new tblAboutSite()
            {
                AboutID = int.Parse(dgvAboutSite.CurrentRow.Cells[0].Value.ToString()),
                Note = Regex.Replace(txtNoteAboutSite.Text, @"([\r\n]\s*)+", "<br>"),

            });
            if (result == false)
            {
                MessageBox.Show("Cập nhập AboutSite không thành công");
            }
            else
            {
                MessageBox.Show("Bạn đã Cập Nhập AboutSite thành công");
            }
            LoadDSAboutSite();
        }

        private void btnLuuAboutSite_Click(object sender, EventArgs e)
        {
            CapNhapContactSite();
        }

        private void btnDongAboutSite_Click(object sender, EventArgs e)
        {
            btnLuuAboutSite.Enabled = false;
            txtNoteAboutSite.Enabled = false;
            txtNoteAboutSite.Text = string.Empty;
        }
    }
}

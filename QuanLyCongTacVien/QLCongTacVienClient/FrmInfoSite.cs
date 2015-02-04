using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCongTacVienClient
{
    public partial class FrmInfoSite : Form
    {
        InfoSite info;
        public int SiteID;
        public FrmInfoSite(int SiteID)
        {
            InitializeComponent();
            info = new InfoSite();
            this.SiteID = SiteID;
        }

        public void LoadDSInfoSite()
        {
            var list =info.LoadDSInfo(this.SiteID);
            DataTable dt = new DataTable();
            dt.Columns.Add("InfoID");
            dt.Columns.Add("Note");
            dt.Columns.Add("SiteID");

            foreach (var item in list)
            {
                dt.Rows.Add(item.InfoID,
                    item.Note,
                    item.SiteID);
            }
            dgvInfoSite.DataSource = dt;

        }
        private void FrmInfoSite_Load(object sender, EventArgs e)
        {
            LoadDSInfoSite();
        }

        private void dgvInfoSite_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLuuÌnoSite.Enabled = true;
            btnDongInfoSite.Enabled = true;

            txtNoteInfoSite.Enabled = true;
            txtNoteInfoSite.Text = dgvInfoSite.CurrentRow.Cells[1].Value.ToString();

        }
        public void CapNhapInfoSite()
        {
            var result =info.CapNhapInfo(new tblInfoSite()
            {
                InfoID = int.Parse(dgvInfoSite.CurrentRow.Cells[0].Value.ToString()),
                Note =txtNoteInfoSite.Text,

            });
            if (result == false)
            {
                MessageBox.Show("Cập nhập InfoSite không thành công");
            }
            else
            {
                MessageBox.Show("Bạn đã Cập Nhập InfoSite thành công");
            }
            LoadDSInfoSite();
        }

        private void btnLuuÌnoSite_Click(object sender, EventArgs e)
        {
            CapNhapInfoSite();
        }

        private void btnDongInfoSite_Click(object sender, EventArgs e)
        {
            btnLuuÌnoSite.Enabled = false;

            txtNoteInfoSite.Enabled = false;
            txtNoteInfoSite.Text = string.Empty;
        }
    }
}

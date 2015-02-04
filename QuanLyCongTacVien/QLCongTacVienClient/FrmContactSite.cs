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
    public partial class FrmContactSite : Form
    {
        ConttactSite cont;
        public int SiteID;
        public FrmContactSite(int SiteID)
        {
            InitializeComponent();
            cont = new ConttactSite();
            this.SiteID = SiteID;
        }
        public void LoadDSContactSite()
        {
            var list = cont.LoadDSContact(this.SiteID);
            DataTable dt = new DataTable();
            dt.Columns.Add("ContactID");
            dt.Columns.Add("Note");
            dt.Columns.Add("SiteID");

            foreach (var item in list)
            {
                dt.Rows.Add(item.ContacID,
                    item.Note,
                    item.SiteID);
            }
            dgvContactSite.DataSource = dt;
            
        }
            

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmContactSite_Load(object sender, EventArgs e)
        {
            LoadDSContactSite();
        }

        private void dgvContactSite_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLuuContactSite.Enabled = true;
            btnDongContactSite.Enabled = true;

            txtNoteContactSite.Enabled = true;

            txtNoteContactSite.Text = dgvContactSite.CurrentRow.Cells[1].Value.ToString();
        }
        public void CapNhapContactSite()
        {
            var result = cont.CapNhapContact(new tblContactSite()
            {
                ContacID = int.Parse(dgvContactSite.CurrentRow.Cells[0].Value.ToString()),
                Note = txtNoteContactSite.Text,
 
            });
            if (result == false)
            {
                MessageBox.Show("Cập nhập ContactSite không thành công");
            }
            else
            {
                MessageBox.Show("Bạn đã Cập Nhập ContactSite thành công");
            }
            LoadDSContactSite();
        }

        private void btnLuuContactSite_Click(object sender, EventArgs e)
        {
            CapNhapContactSite();
        }

        private void btnDongContactSite_Click(object sender, EventArgs e)
        {
            btnLuuContactSite.Enabled = false;
            txtNoteContactSite.Enabled = false;
            txtNoteContactSite.Text = string.Empty;
        }
       
    }
}

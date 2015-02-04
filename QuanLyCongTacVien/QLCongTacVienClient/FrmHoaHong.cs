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
    public partial class FrmHoaHong : Form
    {
        HoaHong hh;
        public long OrderID;
        public FrmHoaHong()
        {
            InitializeComponent();
            
        }

        public FrmHoaHong(long OrderID)
        {
             
            InitializeComponent();
            hh = new HoaHong();
            this.OrderID=OrderID;
        }

        public void LoadDSHoaHong()
        {
            var list = hh.LoadDSHoaHong(this.OrderID);
            DataTable dt = new DataTable();
            dt.Columns.Add("AccountID");
            dt.Columns.Add("TenAccount");
            dt.Columns.Add("OrderID");          
            dt.Columns.Add("Hoa Hồng");
            dt.Columns.Add("Trạng Thái");
            dt.Columns.Add("TrangThai");

            foreach (var item in list)
            {
                dt.Rows.Add(item.AccountID,
                    item.tblAccount.TenAccount,
                    item.OrderID,
                    item.HueHong,
                    (item.TrangThai == 1 ? "Hoạt Động" : "Dừng Hoạt Động"), 
                    item.TrangThai);
            }
            dgvHoaHong.DataSource = dt;
            
        }
        public void LoadTrangThaiHoaHong()
        {
             DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động", 1);
            cbTrangThaiHoaHong.DataSource = dt;
            cbTrangThaiHoaHong.DisplayMember = "TenTrangThai";
            cbTrangThaiHoaHong.ValueMember = "MaTrangThai";     
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmHoaHong_Load(object sender, EventArgs e)
        {
            LoadDSHoaHong();
            LoadTrangThaiHoaHong();
        }

        private void dgvHoaHong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLuuHoaHong.Enabled = true;
            btnDongHoaHong.Enabled = true;

            cbTrangThaiHoaHong.Enabled = true;
            txtHoaHong.Enabled = true;

            txtHoaHong.Text = dgvHoaHong.CurrentRow.Cells[3].Value.ToString();
            cbTrangThaiHoaHong.SelectedIndex = int.Parse(dgvHoaHong.CurrentRow.Cells[5].Value.ToString());
        }

        public void CapNhapHoaHong()
        {
            var result = hh.CapNhapHoaHong(new tblOrder_Account() 
            {
                AccountID=int.Parse(dgvHoaHong.CurrentRow.Cells[0].Value.ToString()),
                HueHong=int.Parse(txtHoaHong.Text),
                TrangThai=int.Parse(cbTrangThaiHoaHong.SelectedValue.ToString()),
            });
            if (result == false)
            {
                MessageBox.Show("Cập nhập Hoa Hồng không thành công");
            }
            else
            {
                MessageBox.Show("Bạn đã Cập Nhập Hoa Hồng thành công");
            }
            LoadDSHoaHong();
        }
        private void btnLuuHoaHong_Click(object sender, EventArgs e)
        {
            CapNhapHoaHong();
        }

        private void btnDongHoaHong_Click(object sender, EventArgs e)
        {
            btnLuuHoaHong.Enabled = false;
            cbTrangThaiHoaHong.Enabled = false;
            txtHoaHong.Enabled = false;

            cbTrangThaiHoaHong.SelectedIndex = 0;
            txtHoaHong.Text = string.Empty;
        }
    }
}

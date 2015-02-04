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
    public partial class FrmGroup_Permission : Form
    {
        Group_Permission Gp_;
        public int GroupID;
        public bool Them;
        public FrmGroup_Permission(int GroupID)
        {
            InitializeComponent();
            Gp_ = new Group_Permission();
            this.GroupID = GroupID;
        }
        public void LoadDSGroup_Per()
        {
            var list = Gp_.LoadDSGroup_per(this.GroupID);
            DataTable dt = new DataTable();
            dt.Columns.Add("PermissionID");
            dt.Columns.Add("Name");
            dt.Columns.Add("TrangThai");
            dt.Columns.Add("Trạng Thái");
            dt.Columns.Add("Ngày Tạo");
            dt.Columns.Add("Ngày Update");
            foreach (var item in list)
            {
                dt.Rows.Add(item.PermisionID,
                    item.Name,
                    item.Status,
                    (item.Status == 1 ? "Hoạt Động" : "Không Hoạt Động"),
                    item.NgayTao.ToString(),
                    item.NgayUpdate.ToString());
            }
            dgvGroup_Per.DataSource = dt;
        }
        public void loadTrangthaiGroup_Per()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động", 1);
            cbTrangthaiGroup_Per.DataSource = dt;
            cbTrangthaiGroup_Per.DisplayMember = "TenTrangThai";
            cbTrangthaiGroup_Per.ValueMember = "MaTrangThai";
        }  
        private void FrmGroup_Permission_Load(object sender, EventArgs e)
        {
            LoadDSGroup_Per();
            loadTrangthaiGroup_Per();
            LoadcbNameGroup_per();
        }
        public void LoadcbNameGroup_per()
        {
            var list =Gp_.LoadDSGroup_per();
            DataTable dt = new DataTable();
            dt.Columns.Add("PermissionID");
            dt.Columns.Add("Name");
            foreach (var item in list)
            {
                dt.Rows.Add(item.PermisionID, item.Name);
            }
            cbNameGroup_per.DataSource = dt;
            cbNameGroup_per.DisplayMember = "Name";
            cbNameGroup_per.ValueMember = "PermissionID";
        }
        private void dgvGroup_Per_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLuuGroupPer_.Enabled = true;
            btnDongGroupPer_.Enabled = true;

           
            cbTrangthaiGroup_Per.Enabled = true;
            cbNameGroup_per.Enabled = true;

            cbNameGroup_per.SelectedValue =int.Parse (dgvGroup_Per.CurrentRow.Cells[0].Value.ToString());
            cbTrangthaiGroup_Per.SelectedIndex = int.Parse(dgvGroup_Per.CurrentRow.Cells[2].Value.ToString());
        }

        public void CapNhapGroupPer_()
        {
            var result =Gp_.CapNhapGroupPer_(new tblPermission()
            {
                PermisionID = int.Parse(dgvGroup_Per.CurrentRow.Cells[0].Value.ToString()),
                Name = cbNameGroup_per.SelectedValue.ToString(),
                Status = int.Parse(cbTrangthaiGroup_Per.SelectedValue.ToString()),
            });
            if (result == false)
            {
                MessageBox.Show("Cập nhập GroupPermission không thành công");
            }
            else
            {
                MessageBox.Show("Bạn đã Cập Nhập GroupPermission thành công");
            }
            LoadDSGroup_Per();
        }
        public int ThemGroupPer_()
        {
            int result =Gp_.ThemGroupPer_(new tblPermission()
            {
                Name=cbNameGroup_per.SelectedValue.ToString(),
                Status=int.Parse(cbTrangthaiGroup_Per.SelectedIndex.ToString()),
                NgayTao = DateTime.Now,
                NgayUpdate = DateTime.Now

            });

            if (result == 0)
            {
                MessageBox.Show("Thêm Permission Không Thành Công", "Warning!");
                return 0;
            }

            MessageBox.Show("Bạn Đã Thêm Permission Thành Công!");
            // LoadDSDonHang();
            return result;
        }
        public void ThemGroup_Permission(int orderID)
        {
            /*var result = dh.ThemOrderAccount(new tblOrder_Account()
            {
                AccountID = int.Parse(cbTenAccountDH.SelectedValue.ToString()),
                OrderID = orderID

            });*/
        }
        public void CapNhapGroup_Permission()
        {
            /* var result = dh.ThemOrderAccount(new tblOrder_Account()
             {
                 AccountID = int.Parse(cbTenAccountDH.SelectedValue.ToString()),
                 OrderID = int.Parse(dtgvDonHang.CurrentRow.Cells["OrderID"].Value.ToString()) //////////////////////////////////ko doi-----------
             });*/
        }

        private void btnLuuGroupPer__Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                ThemGroupPer_();
            }
            else
            {
                CapNhapGroupPer_();
            }
        }

        private void btnThemGroupPer__Click(object sender, EventArgs e)
        {
            cbNameGroup_per.Enabled = true;
            cbTrangthaiGroup_Per.Enabled = true;
            btnLuuGroupPer_.Enabled = true;

            Them = true;
        }
    }
}

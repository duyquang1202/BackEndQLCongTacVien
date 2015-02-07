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
        public void LoadDSGroup_Permission()
        {
            var list = Gp_.LoadDSGroup_Permission(this.GroupID);
            DataTable dt = new DataTable();
            dt.Columns.Add("GroupID");
            dt.Columns.Add("Tên Group");
            dt.Columns.Add("PermissionID");
            dt.Columns.Add("Tên Permission");
            dt.Columns.Add("TrangThai");
            dt.Columns.Add("Trạng Thái");         
            dt.Columns.Add("Ngày Tạo");
            dt.Columns.Add("Ngày Update");
            foreach (var item in list)
            {
                dt.Rows.Add(item.GroupID,
                    item.tblGroupPermission.Name,
                    item.PermissionID,
                    item.tblPermission.Name,
                    item.TrangThai,
                    (item.TrangThai == 1 ? "Hoạt Động" : "Không Hoạt Động"),
                    item.tblPermission.NgayTao.ToString(),
                    item.tblPermission.NgayUpdate.ToString()
                    );
            }
            dgvGroup_Per.DataSource = dt;
        }
        public void loadTrangthaiGroup_Permission()
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
        public void LoadcbNameGroup_Permission()
        {
            var list = Gp_.LoadDSPermission();
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
        private void FrmGroup_Permission_Load(object sender, EventArgs e)
        {
            LoadDSGroup_Permission();
            loadTrangthaiGroup_Permission();
            LoadcbNameGroup_Permission();
        }
      
        private void dgvGroup_Per_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnThemGroupPer_.Enabled = true;
            btnDongGroupPer_.Enabled = true;
            btnXoaGroupPer_.Enabled = true;
          
            cbTrangthaiGroup_Per.Enabled = true;
            cbNameGroup_per.Enabled = true;


            cbNameGroup_per.SelectedValue = int.Parse(dgvGroup_Per.CurrentRow.Cells[2].Value.ToString());
            cbTrangthaiGroup_Per.SelectedIndex = int.Parse(dgvGroup_Per.CurrentRow.Cells[4].Value.ToString());
        }
         public void ThemGroup_Permission()
        {
            var result =Gp_.ThemGroup_Permission(new tblGroup_Perrmision()
            {
                //GroupID= int.Parse(dgvGroup_Per.CurrentRow.Cells[0].Value.ToString()),
                GroupID=this.GroupID,
                PermissionID=int.Parse(cbNameGroup_per.SelectedValue.ToString()),
                TrangThai=int.Parse(cbTrangthaiGroup_Per.SelectedIndex.ToString())
                

            });

            if (result == false)
            {
                MessageBox.Show("Thêm Permission Không Thành Công", "Warning!");
                return ;
            }

            MessageBox.Show("Bạn Đã Thêm Permission Thành Công!");
            LoadDSGroup_Permission();
          
        }

       
       
       
        private void btnLuuGroupPer__Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                ThemGroup_Permission();
            }
            btnLuuGroupPer_.Enabled = false;
            btnXoaGroupPer_.Enabled = false;
           
          
        }

        private void btnThemGroupPer__Click(object sender, EventArgs e)
        {
            cbTrangthaiGroup_Per.Enabled = true;
            btnLuuGroupPer_.Enabled = true;
            cbNameGroup_per.Enabled = true;

            Them = true;
        }

        private void btnDongGroupPer__Click(object sender, EventArgs e)
        {
            cbNameGroup_per.Enabled = false;
            cbTrangthaiGroup_Per.Enabled = false;

            btnLuuGroupPer_.Enabled = false;
            btnXoaGroupPer_.Enabled = false;

            cbNameGroup_per.SelectedIndex = 0;
            cbTrangthaiGroup_Per.SelectedIndex = 0;
        }

        private void btnXoaGroupPer__Click(object sender, EventArgs e)
        {
            var result =Gp_.XoaGroup_Permission (new tblGroup_Perrmision()
            {
                PermissionID = Convert.ToInt16(dgvGroup_Per.CurrentRow.Cells[2].Value.ToString()),
            });
            if (result == false)
            {
                MessageBox.Show("Xóa Đơn Hàng Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Xóa Đơn Hàng Thành Công!");
            LoadDSGroup_Permission();
        }

        private void btnThemGroupPer__Click_1(object sender, EventArgs e)
        {
            cbTrangthaiGroup_Per.Enabled = true;
            btnLuuGroupPer_.Enabled = true;
            cbNameGroup_per.Enabled = true;

            Them = true;
        }
    }
}

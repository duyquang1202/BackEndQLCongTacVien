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
    public partial class frmQLUser : Form
    {
        USer us;
        public bool them;
        public long MaAccount;
        public frmQLUser()
        {
            InitializeComponent();
          
        }

        public frmQLUser(long MaAccount)
        {
            InitializeComponent();
            us = new USer();
            this.MaAccount=MaAccount;
        }

        public void loadDSUser()
        {
            var list = us.LoadDSUser(this.MaAccount);
            DataTable dt = new DataTable();
            dt.Columns.Add("MaUser");
            dt.Columns.Add("UserName");
            dt.Columns.Add("Password");
            dt.Columns.Add("Fullname");
            dt.Columns.Add("Điện Thoại");
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Email");
            dt.Columns.Add("Ghi Chú");
            dt.Columns.Add("Ngày Tạo");
            dt.Columns.Add("Ngày Cập Nhật");
            dt.Columns.Add("User Tạo");
            dt.Columns.Add("User Cập Nhật");
            dt.Columns.Add("TrangThai");
            dt.Columns.Add("Trạng Thái");
            dt.Columns.Add("GroupID");
          
            foreach (var item in list)
            {
                dt.Rows.Add(item.MaUser,
                    item.UserName,
                    item.Password,
                    item.FullName,
                    item.DienThoai,
                    item.DiaChi,
                    item.Email,
                    item.GhiChu,
                    item.NgayTao.ToString(), 
                    item.NgayUpdate.ToString(),
                    item.UserTao,
                    item.UserUpdate,
                    item.TrangThai,
                    (item.TrangThai == 1 ? "Hoạt Động" : "Dừng Hoạt Động"),
                    item.GroupID);
                    
                    

            }

            dgvDSUser.DataSource = dt;
        }
        public void loadTrangthaiUser()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động", 1);
            cbTrangthaiUser.DataSource = dt;
            cbTrangthaiUser.DisplayMember = "TenTrangThai";
            cbTrangthaiUser.ValueMember = "MaTrangThai";
        }  
        private void frmQLUser_Load(object sender, EventArgs e)
        {
            loadDSUser();
            loadTrangthaiUser();
            LoadGroupPerrmision();
        }

        public void LoadGroupPerrmision()
        {
            var result = us.getGroupPermission();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("GroupID");
            dt.Rows.Add("None Select", 0);
            foreach (var item in result)
            {
                dt.Rows.Add(item.Name,item.GroupID);
               
            }
           
            lbGroupPerrmsion.DataSource = dt;
            lbGroupPerrmsion.DisplayMember = "Name";
            lbGroupPerrmsion.ValueMember = "GroupID";
          
            
        }

        private void btnThemUser_Click(object sender, EventArgs e)
        {
            them = true;
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            txtGhiChu.Enabled = true;
            txtFullName.Enabled = true;
            txtEmail.Enabled = true;
            txtDienthoai.Enabled = true;
            txtDiachi.Enabled = true;
            cbTrangthaiUser.Enabled = true;
            lbGroupPerrmsion.Enabled = true;

            btnLuuUser.Enabled = true;
        }
        public void ThemUser()
        {
            var result = us.ThemUser(new tblUser()
            {
                UserName=txtUserName.Text,
                Password=txtPassword.Text,
                FullName=txtFullName.Text,
                DienThoai=txtDienthoai.Text,
                DiaChi=txtDiachi.Text,
                Email=txtEmail.Text,
                GhiChu=txtGhiChu.Text,
                NgayTao = DateTime.Now,
                NgayUpdate = DateTime.Now,
                UserTao = FormDangNhap.objUser.UserName,
                UserUpdate = FormDangNhap.objUser.UserName,
                TrangThai=int.Parse(cbTrangthaiUser.SelectedValue.ToString()),
                GroupID=int.Parse(lbGroupPerrmsion.SelectedValue.ToString())
                
                

            });
            if (result == false )
            {
                MessageBox.Show("Thêm User Không Thành Công", "Warning!");
                return;
            }
            
            MessageBox.Show("Bạn đã thêm User Thành Công");
            loadDSUser();
        }
        public void CapNhapUser()
        {
            var result = us.CapNhapUser(new tblUser()
            {
                MaUser=int.Parse(dgvDSUser.CurrentRow.Cells[0].Value.ToString()),
                UserName=txtUserName.Text,
                FullName=txtFullName.Text,
                DiaChi=txtDiachi.Text,
                DienThoai=txtDienthoai.Text,
                Email=txtEmail.Text,
                GhiChu=txtGhiChu.Text,
                TrangThai=int.Parse(cbTrangthaiUser.SelectedValue.ToString()),
                Password=txtPassword.Text,
                GroupID=int.Parse(lbGroupPerrmsion.SelectedValue.ToString())
            });
            if (result == false)
            {
                MessageBox.Show("Cập nhập User không thành công");
            }
            else
            {
                MessageBox.Show("Bạn đã Cập Nhập User thành công");
            }
            loadDSUser();
        }

        private void btnLuuUser_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                ThemUser();
            }
            else
            {
                CapNhapUser();
            }
        }

        private void btnXoaUser_Click(object sender, EventArgs e)
        {
            var result = us.XoaUser(new tblUser() 
            {
                MaUser=int.Parse(dgvDSUser.CurrentRow.Cells[0].Value.ToString())
            });
            if (result == false)
            {
                MessageBox.Show("Xóa Không thành công");
            }
            else
            {
                MessageBox.Show("Bạn Đã Xóa thanh công");
            }
            loadDSUser();
        }

        private void dgvDSUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            them = false;
            btnLuuUser.Enabled = true;
            btnXoaUser.Enabled = true;
            btnThemUser.Enabled = false;

            txtDiachi.Enabled = true;
            txtDienthoai.Enabled = true;
            txtEmail.Enabled = true;
            txtFullName.Enabled = true;
            txtGhiChu.Enabled = true;
            txtPassword.Enabled = true;
            txtUserName.Enabled = true;
            cbTrangthaiUser.Enabled = true;
            lbGroupPerrmsion.Enabled = true;

            txtUserName.Text = dgvDSUser.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dgvDSUser.CurrentRow.Cells[2].Value.ToString();
            txtFullName.Text = dgvDSUser.CurrentRow.Cells[3].Value.ToString();
            txtDienthoai.Text = dgvDSUser.CurrentRow.Cells[4].Value.ToString();
            txtDiachi.Text = dgvDSUser.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dgvDSUser.CurrentRow.Cells[6].Value.ToString();
            txtGhiChu.Text = dgvDSUser.CurrentRow.Cells[7].Value.ToString();
            cbTrangthaiUser.SelectedIndex = int.Parse(dgvDSUser.CurrentRow.Cells[12].Value.ToString());
            lbGroupPerrmsion.SelectedIndex = int.Parse(dgvDSUser.CurrentRow.Cells[14].Value.ToString());
        }

        private void btnDongUser_Click(object sender, EventArgs e)
        {
            btnLuuUser.Enabled = false;
            btnXoaUser.Enabled = false;
            btnThemUser.Enabled = true;

            txtDiachi.Enabled = false;
            txtDienthoai.Enabled = false;
            txtEmail.Enabled = false;
            txtFullName.Enabled = false;
            txtGhiChu.Enabled = false;
            txtPassword.Enabled = false;
            txtUserName.Enabled = false;
            cbTrangthaiUser.Enabled = false;

            txtUserName.Text ="";
            txtPassword.Text = "";
            txtFullName.Text = "";
            txtDienthoai.Text = "";
            txtDiachi.Text = "";
            txtEmail.Text = "";
            txtGhiChu.Text = "";
            cbTrangthaiUser.SelectedIndex = 0;
        }

        /*private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        */
      /*  public void LoadPermission(int GroupID)
        {
            var listResult = new List<tblPermission>();
            lbPermission.ResetText();
            listResult = us.getPermissionFromGroupPermission(GroupID);
            
                lbPermission.DataSource = listResult;
                lbPermission.DisplayMember = "Name";
                lbPermission.ValueMember = "PermissionID";
            
        }*/
        private void lbGroupPerrmsion_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* int GroupID = int.Parse(lbGroupPerrmsion.SelectedValue.ToString());

            LoadPermission(GroupID);*/
        }
    }
}


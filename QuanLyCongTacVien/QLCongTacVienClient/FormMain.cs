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
    public partial class FormMain : Form
    {
        Account ac;
        PhongBan objPro;
        public bool Them;
        
        public FormMain()
        {
            InitializeComponent();
            objPro = new PhongBan();
            ac = new Account();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }

        public void LoadTrangThai()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động",1);           
            cbTrangThaiPhongBan.DataSource = dt;
            cbTrangThaiPhongBan.DisplayMember = "TenTrangThai";
            cbTrangThaiPhongBan.ValueMember = "MaTrangThai";
        }
        public void LoadTrangThaiAcount()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động", 1);
            cboTrangthaiAcount.DataSource = dt;
            cboTrangthaiAcount.DisplayMember = "TenTrangThai";
            cboTrangthaiAcount.ValueMember = "MaTrangThai";

        }
       

        public void LoadDSPhongBan()
        {
            var list = objPro.LoadDSPhongBan();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Tên Phòng Ban");
            dt.Columns.Add("Mô Tả");
            dt.Columns.Add("Ghi Chú");
            dt.Columns.Add("Trạng Thái");
            dt.Columns.Add("Ngày Tạo");
            dt.Columns.Add("Ngày Cập Nhật");
            dt.Columns.Add("User Tạo");
            dt.Columns.Add("User Cập Nhật");
            dt.Columns.Add("TrangThai");
            foreach (var item in list)
            {
                dt.Rows.Add(item.MaPhongBan, item.TenPhongBan,item.MoTaPhongBan,item.GhiChuPhongBan,(item.TrangThai==1?"Hoạt Động":"Dừng Hoạt Động"),item.NgayTao.ToString(),item.NgayUpdate.ToString(),item.UserTao,item.UserUpdate,item.TrangThai);

            }

            dgvPhongBan.DataSource = dt;
            dgvPhongBan.Columns[8].Visible = false;
        }

        public void loadDSAcount()
        {
            var list = ac.loadDSAccount();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaACount");
            dt.Columns.Add("Tên Account");
            dt.Columns.Add("Loại Acount");
            dt.Columns.Add("Ghi Chú");
            dt.Columns.Add("Acount Manager");
            dt.Columns.Add("Ngày tạo");
            dt.Columns.Add("Ngày Cập Nhật");
            dt.Columns.Add("User Tạo");
            dt.Columns.Add("User Cập Nhật");
            dt.Columns.Add("Trạng Thái");
            dt.Columns.Add("TrangThai");
            foreach (var item in list)
            {
                dt.Rows.Add(item.MaAccount, item.TenAccount, item.LoaiAccount, item.GhiChu, item.AccountManager, item.NgayTao.ToString(), item.NgayUpdate.ToString(), item.UserTao, item.UserUpdate,(item.TrangThai==1?"Hoạt động":"Không hoạt động"),item.TrangThai);
   
            }
            dgvAccount.DataSource = dt;
        }
       
        private void tabMainControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMainControl.SelectedIndex)
            {
                case 1: // quan ly phong ban
                    LoadTrangThai();
                    LoadDSPhongBan();
                    break;
                case 2: //quan ly account
                    loadDSAcount();
                    LoadTrangThaiAcount();
                    
                    break;
                default:
                    break;
            }
        }

        private void btnThemPhongBan_Click(object sender, EventArgs e)
        {
            txtphongban.Enabled = true;
            cbTrangThaiPhongBan.Enabled = true;
            txtLuuYPhongBan.Enabled = true;
            txtMoTaPhongBan.Enabled = true;
            btnLuuPhongBan.Enabled = true;
            Them = true;
         
        }

        public void ThemPhongBan()
        {
            var result = objPro.ThemPhongBan(new tblPhongBan()
            {
                TenPhongBan = txtphongban.Text,
                GhiChuPhongBan = txtLuuYPhongBan.Text,
                TrangThai = int.Parse(cbTrangThaiPhongBan.SelectedValue.ToString()),
                NgayTao = DateTime.Now,
                NgayUpdate = DateTime.Now,
                UserTao = FormDangNhap.objUser.UserName,
                UserUpdate = FormDangNhap.objUser.UserName,
                MoTaPhongBan = txtMoTaPhongBan.Text

            });

            if (result == false)
            {
                MessageBox.Show("Thêm Phòng Ban Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Thêm Phòng Ban Thành Công!");
            LoadDSPhongBan();
        }

        public void CapNhatPhongBan()
        {
            var result = objPro.CapNhatPhongBan(new tblPhongBan()
            {
                MaPhongBan = Convert.ToInt32(dgvPhongBan.CurrentRow.Cells[0].Value.ToString()),
                TenPhongBan = txtphongban.Text,
                GhiChuPhongBan = txtLuuYPhongBan.Text,
                TrangThai = int.Parse(cbTrangThaiPhongBan.SelectedValue.ToString()),
                NgayUpdate = DateTime.Now,
                UserUpdate = FormDangNhap.objUser.UserName,
                MoTaPhongBan = txtMoTaPhongBan.Text
            });

            if (result == false)
            {
                MessageBox.Show("Sửa Phòng Ban Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Sửa Phòng Ban Thành Công!");
            LoadDSPhongBan();
        }

        private void btnLuuPhongBan_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                ThemPhongBan();
            }
            else
            {
                CapNhatPhongBan();
            }
        }

        private void dgvPhongBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Them = false;
             btnXoaPhongBan.Enabled = true;
            btnLuuPhongBan.Enabled = true;
            btnThemPhongBan.Enabled = false;

            txtphongban.Enabled = true;
            txtLuuYPhongBan.Enabled = true;
            txtMoTaPhongBan.Enabled = true;
            cbTrangThaiPhongBan.Enabled = true;

            txtphongban.Text = dgvPhongBan.CurrentRow.Cells[1].Value.ToString();
            txtLuuYPhongBan.Text = dgvPhongBan.CurrentRow.Cells[3].Value.ToString();
            txtMoTaPhongBan.Text = dgvPhongBan.CurrentRow.Cells[2].Value.ToString();
           
            cbTrangThaiPhongBan.SelectedIndex = int.Parse(dgvPhongBan.CurrentRow.Cells[9].Value.ToString());

        }

        private void btnDongPhongBan_Click(object sender, EventArgs e)
        {
            btnXoaPhongBan.Enabled = false;
            btnLuuPhongBan.Enabled = false;
            btnThemPhongBan.Enabled = true;

            txtphongban.Enabled = false;
            txtLuuYPhongBan.Enabled = false;
            txtMoTaPhongBan.Enabled = false;
            cbTrangThaiPhongBan.Enabled = false;

            txtphongban.Text = String.Empty;
            txtLuuYPhongBan.Text = String.Empty;
            txtMoTaPhongBan.Text = String.Empty;
            cbTrangThaiPhongBan.SelectedIndex = 0;
        }

        private void btnXoaPhongBan_Click(object sender, EventArgs e)
        {
              var result = objPro.XoaPhongBan(new tblPhongBan()
                {
                    MaPhongBan = Convert.ToInt32(dgvPhongBan.CurrentRow.Cells[0].Value.ToString()),
                   
                });

            if (result == false)
            {
                MessageBox.Show("Xóa Phòng Ban Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Xóa Phòng Ban Thành Công!");
            LoadDSPhongBan();
  
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cboTrangthaiAcount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtMotaAcount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtLuuyAcount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //btnthem Account
        private void button4_Click(object sender, EventArgs e) //btnthemAccount
        {
            txtTenAcount.Enabled = true;
            txtLoaiAcount.Enabled = true;
            cboTrangthaiAcount.Enabled = true;
            txtLuuyAcount.Enabled = true;
            txtAccountManager.Enabled = true;
            btnLuuAcount.Enabled = true;
            Them = true;
        }
        public void ThemAccount()
        {
            var result = ac.ThemAccount(new tblAccount()
            {
                TenAccount=txtTenAcount.Text,
                LoaiAccount=txtLoaiAcount.Text,
                GhiChu=txtLuuyAcount.Text,
                AccountManager=Convert.ToInt64(txtAccountManager.Text),
                TrangThai=Convert.ToInt16(cboTrangthaiAcount.SelectedValue.ToString()),
                NgayTao= DateTime.Now,
                NgayUpdate = DateTime.Now,
                UserTao = FormDangNhap.objUser.UserName,
                UserUpdate = FormDangNhap.objUser.UserName
                
            });
            if (result == false)
            {
                MessageBox.Show("Thêm Account Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Thêm Account Thành Công!");
            loadDSAcount();

        }

        public void CapNhatAccount()
        {
            var result = ac.CapNhatAccount(new tblAccount()
            {
                MaAccount=Convert.ToInt64(dgvAccount.CurrentRow.Cells[0].Value.ToString()),
                TenAccount=txtTenAcount.Text,
                LoaiAccount=txtLoaiAcount.Text,
                TrangThai=Convert.ToInt16(cboTrangthaiAcount.SelectedValue.ToString()),
                AccountManager=Convert.ToInt64(txtAccountManager.Text),
                GhiChu= txtLuuyAcount.Text,
                NgayUpdate=DateTime.Now,
                UserUpdate=FormDangNhap.objUser.UserName    
            });
            if (result == false)
            {
                MessageBox.Show("Sửa Account Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Sửa Account Thành Công!");
            loadDSAcount();
        }
        //btnluuAccount
        private void button2_Click(object sender, EventArgs e) //btnluuAccount
        {
            if (Them == true)
            {
                ThemAccount();
            }
            else
            {
                CapNhatAccount();
            }

        }
        //btnXoaAccount
        private void button3_Click(object sender, EventArgs e) //btnXoaAccount
        {
            var result = ac.XoaAccount(new tblAccount()
                {
                    MaAccount=Convert.ToInt64(dgvAccount.CurrentRow.Cells[0].Value.ToString()),
                });
            if (result == false)
            {
                MessageBox.Show("Xóa Account Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Xóa Account Thành Công!");
            loadDSAcount();
        }
         
        //btnDongAccount
        private void button1_Click(object sender, EventArgs e)    //btnDongAccount
        {
            btnXoaAcount.Enabled = false;
            btnLuuAcount.Enabled = false;
            btnThemAcount.Enabled = true;

            txtTenAcount.Enabled = false;
            txtLoaiAcount.Enabled = false;
            cboTrangthaiAcount.Enabled = false;
            txtLuuyAcount.Enabled = false;
            txtAccountManager.Enabled = false;

            txtTenAcount.Text = string.Empty;
            txtLoaiAcount.Text = string.Empty;
            txtLuuyAcount.Text = string.Empty;
            cboTrangthaiAcount.SelectedIndex = 0;
            txtAccountManager.Text = string.Empty;

        }

        private void dgvAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaAcount.Enabled = true;
            btnThemAcount.Enabled = false;
            btnLuuAcount.Enabled = true;

            txtTenAcount.Enabled = true;
            txtLoaiAcount.Enabled = true;
            txtAccountManager.Enabled = true;
            txtLuuyAcount.Enabled = true;
            cboTrangthaiAcount.Enabled = true;

            txtTenAcount.Text =dgvAccount.CurrentRow.Cells[1].Value.ToString();
            txtLoaiAcount.Text = dgvAccount.CurrentRow.Cells[2].Value.ToString();
            txtLuuyAcount.Text = dgvAccount.CurrentRow.Cells[3].Value.ToString();
            txtAccountManager.Text = dgvAccount.CurrentRow.Cells[4].Value.ToString();
           
            cboTrangthaiAcount.SelectedIndex = int.Parse(dgvAccount.CurrentRow.Cells[10].Value.ToString());
            //lam load account manager;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

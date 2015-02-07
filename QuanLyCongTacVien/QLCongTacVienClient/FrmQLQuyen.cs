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
    public partial class FrmQLQuyen : Form
    {
        QLQuyen quyen;
        public bool Them;
        public FrmQLQuyen()
        {
            InitializeComponent();
            quyen = new QLQuyen();
        }
        public void LoadDSPermission()
        {
            var list = quyen.LoadDSPermission();
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
                    item.NgayUpdate.ToString()
                    );
            }
            dgvDSQuyen.DataSource = dt;
        }
        public void loadTrangthaiPermission()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động", 1);
           
            cbTrangThaiPermission.DataSource = dt;
            cbTrangThaiPermission.DisplayMember = "TenTrangThai";
            cbTrangThaiPermission.ValueMember = "MaTrangThai";
        }  
        private void FrmQLQuyen_Load(object sender, EventArgs e)
        {
            LoadDSPermission();
            loadTrangthaiPermission();
        }

        private void btnThemPermission_Click(object sender, EventArgs e)
        {
            btnLuuPermission.Enabled = true;

            txtNamePermission.Enabled = true;
            cbTrangThaiPermission.Enabled = true;

            Them = true;
        }
        public void ThemPermission()
        {
            var result =quyen.ThemPermission(new tblPermission()
            {
                Name=txtNamePermission.Text,
                Status=int.Parse(cbTrangThaiPermission.SelectedValue.ToString()),
                NgayTao = DateTime.Now,
                NgayUpdate = DateTime.Now,
            });

            if (result == false)
            {
                MessageBox.Show("Thêm Permission Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Thêm Permission Thành Công!");
            LoadDSPermission();
        }
        public void CapNhapPermission()
        {
            var result = quyen.CapNhatPermission(new tblPermission() 
            {
                PermisionID=int.Parse(dgvDSQuyen.CurrentRow.Cells[0].Value.ToString()),
                Name=txtNamePermission.Text,
                Status = int.Parse(cbTrangThaiPermission.SelectedValue.ToString())
            });
             if (result == false)
            {
                MessageBox.Show("Sửa Permission Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Sửa Permission Thành Công!");
            LoadDSPermission();
        
        }

        private void btnLuuPermission_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                ThemPermission();
            }
            else
            {
                CapNhapPermission();
            }
        }

        private void dgvDSQuyen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLuuPermission.Enabled = true;
            btnXoaPermission.Enabled = true;
            btnThemPermission.Enabled = false;
            btnDongPermission.Enabled = true;

            txtNamePermission.Enabled = true;
            cbTrangThaiPermission.Enabled = true;

            txtNamePermission.Text = dgvDSQuyen.CurrentRow.Cells[1].Value.ToString();
            cbTrangThaiPermission.SelectedIndex = int.Parse(dgvDSQuyen.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnXoaPermission_Click(object sender, EventArgs e)
        {
            var result =quyen.XoaPermission(new tblPermission()
            {
                PermisionID = int.Parse(dgvDSQuyen.CurrentRow.Cells[0].Value.ToString()),

            });

            if (result == false)
            {
                MessageBox.Show("Xóa Permission Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Xóa Permission Thành Công!");
            LoadDSPermission();
        }

        private void btnDongPermission_Click(object sender, EventArgs e)
        {
            btnThemPermission.Enabled = true;
            btnLuuPermission.Enabled = false;
            btnXoaPermission.Enabled = false;

            txtNamePermission.Enabled = false;
            cbTrangThaiPermission.Enabled = false;

            txtNamePermission.Text = "";
            cbTrangThaiPermission.SelectedIndex = 0;
        }


    }
}

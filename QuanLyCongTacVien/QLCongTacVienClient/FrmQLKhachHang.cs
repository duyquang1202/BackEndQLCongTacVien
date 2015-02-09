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
    public partial class FrmQLKhachHang : Form
    {
        public tblUser objUser;
        QLKhachHang kh;
        public bool Them;
        public FrmQLKhachHang(tblUser objUser)
        {
            InitializeComponent();
            kh = new QLKhachHang();
            this.objUser = objUser;
        }
        public void LoadDSKhachHang()
        {
            var list = kh.LoadDSKhachHang();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaKhachHang");
            dt.Columns.Add("Tên Khách Hàng");
            dt.Columns.Add("Số Điện Thoại");
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Ghi Chú 1");
            dt.Columns.Add("Ghi Chú 2");
            dt.Columns.Add("Ghi Chú 3");
            dt.Columns.Add("Ghi Chú 4");
            dt.Columns.Add("Giá Trị");
            dt.Columns.Add("TrangThai1");
            dt.Columns.Add("TrangThai2");
            dt.Columns.Add("TrangThai3");
            dt.Columns.Add("TrangThai4");
            dt.Columns.Add("Trạng Thái 1");
            dt.Columns.Add("Trạng Thái 2");
            dt.Columns.Add("Trạng Thái 3");
            dt.Columns.Add("Trạng Thái 4");
            dt.Columns.Add("Ngày Tạo");
            dt.Columns.Add("Ngày Update");
            dt.Columns.Add("User Tạo");
            dt.Columns.Add("User Update");

            foreach (var item in list)
            {
                dt.Rows.Add(item.MaKhachHang,
                    item.TenKhachHang,
                    item.SoDT,
                    item.DiaChi,
                    item.GhiChu1,item.GhiChu2,item.GhiChu3,item.GhiChu4,
                    item.GiaTri,
                    item.TrangThai1,item.TrangThai2,item.TrangThai3,item.TrangThai4,
                    (item.TrangThai1 == 1 ? "Hoạt Động" : "Không Hoạt Động"), (item.TrangThai2 == 1 ? "Hoạt Động" : "Không Hoạt Động"), (item.TrangThai3 == 1 ? "Hoạt Động" : "Không Hoạt Động"), (item.TrangThai4 == 1 ? "Hoạt Động" : "Không Hoạt Động"),
                    item.NgayTao.ToString(),
                    item.NgayUpdate.ToString(),
                    item.UserTao,
                    item.UserUpdate
                    );
            }
            dgvKhachHang.DataSource = dt;
        }
        public void loadTrangthai1KhachHang()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động", 1);
          
            cbTrangThai1.DataSource = dt;
            cbTrangThai1.DisplayMember = "TenTrangThai";
            cbTrangThai1.ValueMember = "MaTrangThai";
        }
        public void loadTrangthai2KhachHang()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động", 1);

            cbTrangThai2.DataSource = dt;
            cbTrangThai2.DisplayMember = "TenTrangThai";
            cbTrangThai2.ValueMember = "MaTrangThai";
        }
        public void loadTrangthai3KhachHang()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động", 1);

            cbTrangThai3.DataSource = dt;
            cbTrangThai3.DisplayMember = "TenTrangThai";
            cbTrangThai3.ValueMember = "MaTrangThai";
        }
        public void loadTrangthai4KhachHang()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động", 1);

            cbTrangThai4.DataSource = dt;
            cbTrangThai4.DisplayMember = "TenTrangThai";
            cbTrangThai4.ValueMember = "MaTrangThai";
        }  
        private void FrmQLKhachHang_Load(object sender, EventArgs e)
        {
            LoadDSKhachHang();
            loadTrangthai1KhachHang();
            loadTrangthai2KhachHang();
            loadTrangthai3KhachHang();
            loadTrangthai4KhachHang();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "ThemKhachHang") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            btnLuuKhachHang.Enabled = true;

            txtTenKhachHang.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDT.Enabled = true;
            txtGhiChu1.Enabled = true; txtGhiChu2.Enabled = true; txtGhiChu3.Enabled = true; txtGhiChu4.Enabled = true;
            txtGiaiTri.Enabled = true;
            cbTrangThai1.Enabled = true; cbTrangThai2.Enabled = true; cbTrangThai3.Enabled = true; cbTrangThai4.Enabled = true;
            Them = true;
        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLuuKhachHang.Enabled = true;
            btnThemKhachHang.Enabled = false;
            btnXoaKhachHang.Enabled = true;

            txtTenKhachHang.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDT.Enabled = true;
            txtGhiChu1.Enabled = true; txtGhiChu2.Enabled = true; txtGhiChu3.Enabled = true; txtGhiChu4.Enabled = true;
            txtGiaiTri.Enabled = true;
            cbTrangThai1.Enabled = true; cbTrangThai2.Enabled = true; cbTrangThai3.Enabled = true; cbTrangThai4.Enabled = true;

            txtTenKhachHang.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtSoDT.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            txtGhiChu1.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
            txtGhiChu2.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString();
            txtGhiChu3.Text = dgvKhachHang.CurrentRow.Cells[6].Value.ToString();
            txtGhiChu4.Text = dgvKhachHang.CurrentRow.Cells[7].Value.ToString();
            txtGiaiTri.Text = dgvKhachHang.CurrentRow.Cells[8].Value.ToString();
            cbTrangThai1.SelectedIndex = int.Parse(dgvKhachHang.CurrentRow.Cells[9].Value.ToString());
            cbTrangThai2.SelectedIndex = int.Parse(dgvKhachHang.CurrentRow.Cells[10].Value.ToString());
            cbTrangThai3.SelectedIndex = int.Parse(dgvKhachHang.CurrentRow.Cells[11].Value.ToString());
            cbTrangThai4.SelectedIndex = int.Parse(dgvKhachHang.CurrentRow.Cells[12].Value.ToString());

        }
        public void ThemKhachHang()
        {
            
            var result =kh.ThemKhachHang(new tblKhachHang()
            {
                TenKhachHang =txtTenKhachHang.Text,
                SoDT=txtSoDT.Text,
                DiaChi=txtDiaChi.Text,
                GiaTri=float.Parse(txtGiaiTri.Text),
                GhiChu1=txtGhiChu1.Text,
                GhiChu2 = txtGhiChu2.Text,
                GhiChu3 = txtGhiChu3.Text,
                GhiChu4 = txtGhiChu4.Text,
                TrangThai1 = int.Parse(cbTrangThai1.SelectedValue.ToString()),
                TrangThai2 = int.Parse(cbTrangThai2.SelectedValue.ToString()),
                TrangThai3 = int.Parse(cbTrangThai3.SelectedValue.ToString()),
                TrangThai4 = int.Parse(cbTrangThai4.SelectedValue.ToString()),
                NgayTao = DateTime.Now,
                NgayUpdate = DateTime.Now,
                UserTao = FormDangNhap.objUser.UserName,
                UserUpdate = FormDangNhap.objUser.UserName,
            });

            if (result == false)
            {
                MessageBox.Show("Thêm Khach Hang Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Thêm Khach Hang Thành Công!");
            LoadDSKhachHang();
        }
        public void CapNhapKhachHang()
        {
            var result =kh.CapNhatKhachHang (new tblKhachHang()
            {
                MaKhachHang=int.Parse(dgvKhachHang.CurrentRow.Cells[0].Value.ToString()),
                TenKhachHang = txtTenKhachHang.Text,
                SoDT = txtSoDT.Text,
                DiaChi = txtDiaChi.Text,
                GiaTri = float.Parse(txtGiaiTri.Text),
                GhiChu1 = txtGhiChu1.Text,
                GhiChu2 = txtGhiChu2.Text,
                GhiChu3 = txtGhiChu3.Text,
                GhiChu4 = txtGhiChu4.Text,
                TrangThai1 = int.Parse(cbTrangThai1.SelectedValue.ToString()),
                TrangThai2 = int.Parse(cbTrangThai2.SelectedValue.ToString()),
                TrangThai3 = int.Parse(cbTrangThai3.SelectedValue.ToString()),
                TrangThai4 = int.Parse(cbTrangThai4.SelectedValue.ToString()),
                NgayUpdate = DateTime.Now,
                UserUpdate = FormDangNhap.objUser.UserName,
            });
            if (result == false)
            {
                MessageBox.Show("Sửa Khach Hang Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Sửa Khach Hang Thành Công!");
            LoadDSKhachHang();

        }

        private void btnLuuKhachHang_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                ThemKhachHang();

            }
            else
            {
                if (Process.getInstance().CheckPermission(this.objUser.MaUser, "CapNhatKhachHang") == false)
                {
                    MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                    return;
                } 
                CapNhapKhachHang();
            }
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "XoaKhachHang") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            var result =kh.XoaKhachHang (new tblKhachHang()
            {
                MaKhachHang = int.Parse(dgvKhachHang.CurrentRow.Cells[0].Value.ToString()),

            });

            if (result == false)
            {
                MessageBox.Show("Xóa Khach Hang Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Xóa Khach Hang Thành Công!");
            LoadDSKhachHang();
        }

        private void btnDongKhachHang_Click(object sender, EventArgs e)
        {
            btnThemKhachHang.Enabled = true;
            btnLuuKhachHang.Enabled = false;
            btnXoaKhachHang.Enabled = false;

            txtTenKhachHang.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoDT.Enabled = false;
            txtGhiChu1.Enabled = false; txtGhiChu2.Enabled = false; txtGhiChu3.Enabled = false; txtGhiChu4.Enabled = false;
            txtGiaiTri.Enabled = false;
            cbTrangThai1.Enabled = false; cbTrangThai2.Enabled = false; cbTrangThai3.Enabled = false; cbTrangThai4.Enabled = false;

            txtTenKhachHang.Text = "";
            txtDiaChi.Text = ""; txtSoDT.Text = ""; txtGiaiTri.Text = "";
            txtGhiChu1.Text = ""; txtGhiChu2.Text = ""; txtGhiChu3.Text = ""; txtGhiChu4.Text = "";
            cbTrangThai1.SelectedIndex = 0; cbTrangThai2.SelectedIndex = 0; cbTrangThai3.SelectedIndex = 0; cbTrangThai4.SelectedIndex = 0;
        }
    }
}

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
    public partial class FrmNhom_KhachHang : Form
    {
        Nhom_KH nh;
        public int MaNhom;
        public bool Them;
        public FrmNhom_KhachHang(int MaNhom)
        {
            InitializeComponent();
            nh = new Nhom_KH();
            this.MaNhom = MaNhom;
        }
        public void LoadDSNhom_KH()
        {
            var list =nh.LoadDSNhom_KH (this.MaNhom);
            DataTable dt = new DataTable();
            dt.Columns.Add("MaNhom");
            dt.Columns.Add("Tên Nhóm");
            dt.Columns.Add("MaKhachHang");
            dt.Columns.Add("Tên Khách Hàng");
            dt.Columns.Add("Số Điện Thoại");
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("TrangThai");
            dt.Columns.Add("Trạng Thái");
            dt.Columns.Add("Ngày Tạo");
            dt.Columns.Add("Ngày Update");
            foreach (var item in list)
            {
                dt.Rows.Add(item.MaNhom,
                    item.tblNhom.TenNhom,
                    item.MaKhachHang,
                    item.tblKhachHang.TenKhachHang,
                    item.tblKhachHang.SoDT,
                    item.tblKhachHang.DiaChi,
                    item.TrangThai,
                    (item.TrangThai == 1 ? "Hoạt Động" : "Không Hoạt Động"),
                    item.tblKhachHang.NgayTao.ToString(),
                    item.tblKhachHang.NgayUpdate.ToString()
                    );
            }
            dgvNhom_KH.DataSource = dt;
           
        }
        public void loadTrangthaiNhom_KH()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động", 1);
         
            cbTrangthaiNhom_KH.DataSource = dt;
            cbTrangthaiNhom_KH.DisplayMember = "TenTrangThai";
            cbTrangthaiNhom_KH.ValueMember = "MaTrangThai";
        }
        public void LoadcbTenNhomKH()
        {
            var list = nh.LoadDSKhachHang();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaKhachHang");
            dt.Columns.Add("TenKhachHang");
            foreach (var item in list)
            {
                dt.Rows.Add(item.MaKhachHang, item.TenKhachHang);
            }
            
            cbTenKH_.DataSource = dt;
            cbTenKH_.DisplayMember = "TenKhachHang";
            cbTenKH_.ValueMember = "MaKhachHang";
        }
        private void FrmNhom_KhachHang_Load(object sender, EventArgs e)
        {
            LoadDSNhom_KH();
            loadTrangthaiNhom_KH();
            LoadcbTenNhomKH();
        }

        private void dgvNhom_KH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThemNhom_KH.Enabled = true;
            btnDongNhom_KH.Enabled = true;
            btnXoaNhom_KH.Enabled = true;

            cbTrangthaiNhom_KH.Enabled = true;
            cbTenKH_.Enabled = true;



            cbTenKH_.SelectedValue = int.Parse(dgvNhom_KH.CurrentRow.Cells[2].Value.ToString());
            cbTrangthaiNhom_KH.SelectedIndex = int.Parse(dgvNhom_KH.CurrentRow.Cells[6].Value.ToString());
        }
        public void ThemNhom_KH()
        {
            var result = nh.ThemNhom_KH(new tblNhom_KhachHang()
            {
                MaNhom = this.MaNhom,
                MaKhachHang = int.Parse(cbTenKH_.SelectedValue.ToString()),
                TrangThai = int.Parse(cbTrangthaiNhom_KH.SelectedIndex.ToString())


            });

            if (result == false)
            {
                MessageBox.Show("Thêm Nhóm KH Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Thêm Nhóm KH Thành Công!");
            LoadDSNhom_KH();
        }

        private void btnLuuNhom_KH_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                ThemNhom_KH();
            }
           // btnLuuNhom_KH.Enabled = false;
           // btnXoaNhom_KH.Enabled = false;
           
        }

        private void btnThemNhom_KH_Click(object sender, EventArgs e)
        {
            cbTrangthaiNhom_KH.Enabled = true;
            cbTenKH_.Enabled = true;
            btnLuuNhom_KH.Enabled = true;         

            Them = true;
        }

        private void btnDongNhom_KH_Click(object sender, EventArgs e)
        {
            btnLuuNhom_KH.Enabled = false;
            btnXoaNhom_KH.Enabled = false;

            cbTenKH_.Enabled = false;
            cbTrangthaiNhom_KH.Enabled = false;

            cbTrangthaiNhom_KH.SelectedIndex = 0;
            cbTenKH_.SelectedIndex = 0;
        }

        private void btnXoaNhom_KH_Click(object sender, EventArgs e)
        {
            var result =nh.XoaNhom_KH(new tblNhom_KhachHang()
            {
                MaKhachHang = Convert.ToInt16(dgvNhom_KH.CurrentRow.Cells[2].Value.ToString()),
            });
            if (result == false)
            {
                MessageBox.Show("Xóa Nhóm KH Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Xóa Nhóm KH Thành Công!");
            LoadDSNhom_KH();
        }
    }
}

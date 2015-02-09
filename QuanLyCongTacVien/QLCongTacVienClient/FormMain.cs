using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCongTacVienClient
{
    public partial class FormMain : Form
    {
        LoaiSanPham lsp;
        NhomKhachHang nhomKH;
        GroupPermission gp;
        Account ac;
        PhongBan objPro;
        DonHang dh;
        Site si;
        SanPham sp;
        public bool Them;
        public tblUser objUser;
        
        public FormMain()
        {
            InitializeComponent();
            
        }

        public FormMain(tblUser objUser)
        {
            InitializeComponent();
            objPro = new PhongBan();
            ac = new Account();
            dh = new DonHang();
            si = new Site();
            gp = new GroupPermission();
            nhomKH = new NhomKhachHang();
            sp = new SanPham();
            lsp = new LoaiSanPham();
            this.objUser = objUser;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void DisplayTabControl()
        {
            //            // Hide the tab page
            //tabControl.TabPages.Remove(tabPage1);
            //// Show the tab page (insert it to the correct position)
            //tabControl.TabPages.Insert(0, tabPage1);
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "HienThiQLDH") == false)
            {
                tabMainControl.TabPages.Remove(tabPage1);
            }
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "HienThiQLPB") == false)
            {
                tabMainControl.TabPages.Remove(tabPage2);
            }
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "HienThiQLAccount") == false)
            {
                tabMainControl.TabPages.Remove(tabPage3);
            }
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "HienThiQLSite") == false)
            {
                tabMainControl.TabPages.Remove(tabPage4);
            }
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "HienThiQLPhanQuyen") == false)
            {
                tabMainControl.TabPages.Remove(tabPage5);
            }
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "HienThiQLNhomKH") == false)
            {
                tabMainControl.TabPages.Remove(tabPage6);
            }
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "HienThiQLSanPham") == false)
            {
                tabMainControl.TabPages.Remove(tabPage7);
            }
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "HienThiQLLoaiSanPham") == false)
            {
                tabMainControl.TabPages.Remove(tabPage8);
            }


        }

        public void loadform()
        {

            LoadTrangThai();
            LoadDSPhongBan();

            loadDSAcount();
            LoadTrangThaiAcount();
            // loadAccountManager();
            loadcboChonPhongBan();
            loadLoaiAccount();
            LoadDSDonHang();
            LoadTrangThaiDonHang();
            LoadCbTenAccount();
            LoadNhanVienGiaoDich();
            LoadCbTenKhachHang();
            loadProduct();

            LoadDSSite();
            LoadTrangThaiSite();
            LoadCbTenAccountSite();

            LoadDSGroupPermission();
            LoadTrangThaiPhanQuyen();

            LoadDSNhomKH();
            LoadTrangThaiNhomKH();

            LoadDSSanPham();
            LoadTrangThaiSanPham();
            LoadCbCategoryName();

            LoadDSLoaiSanPham();
            LoadCbAccountNamecategory();
            DisplayTabControl();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadform();
        }
        public void LoadDSLoaiSanPham()
        {
            var list = lsp.LoadDSLoaiSanPham();
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryID");
            dt.Columns.Add("CategoryName");
            dt.Columns.Add("AccountID");
            dt.Columns.Add("AccountName");
            dt.Columns.Add("Ngày Tạo");
            dt.Columns.Add("Ngày Update");

            foreach (var item in list)
            {
                dt.Rows.Add(item.CategoryID,
                    item.CategoryName,
                    item.AccountID,
                    item.tblAccount.TenAccount,
                    item.NgayTao.ToString(),
                    item.NgayUpdate.ToString());
            }
            
            dgvLoaiSanPham.DataSource = dt;
        }
        public void LoadCbAccountNamecategory()
        {
            var list =lsp.loadAccount();
            DataTable dt = new DataTable();
            dt.Columns.Add("AccountID");
            dt.Columns.Add("AccountName");
            foreach (var item in list)
            {
                dt.Rows.Add(item.MaAccount, item.TenAccount);
            }
            
            cbTenAccountLSP.DataSource = dt;
            cbTenAccountLSP.DisplayMember = "AccountName";
            cbTenAccountLSP.ValueMember = "AccountID";
        }
       
       
        public void LoadDSSanPham()
        {
            var list =sp.LoadDSProduct();
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductID");
            dt.Columns.Add("Product Name");
            dt.Columns.Add("CategoryID");
            dt.Columns.Add("Category Name");
            dt.Columns.Add("Giá Bán");
            dt.Columns.Add("TrangThai");
            dt.Columns.Add("Trạng Thái");
            dt.Columns.Add("Ngày Tạo");
            dt.Columns.Add("Ngày Update");
            dt.Columns.Add("Nội Dung");
            dt.Columns.Add("Hình Ảnh");
            
            foreach (var item in list)
            {
                dt.Rows.Add(item.ProductID,
                    item.ProductName,
                    item.CategoryID,
                    item.Category.CategoryName,
                    item.GiaBan,
                    item.TrangThai,
                    (item.TrangThai == 1 ? "Hoạt Động" : "Dừng Hoạt động"),
                    item.NgayTao.ToString(),
                    item.NgayUpdate.ToString(),
                    item.NoiDung,
                    item.HinhAnh);
            }
           
            dgvSanPham.DataSource = dt;
        }
        public void LoadTrangThaiSanPham()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động", 1);
           
            cbTrangThaiSanPham.DataSource = dt;
            cbTrangThaiSanPham.DisplayMember = "TenTrangThai";
            cbTrangThaiSanPham.ValueMember = "MaTrangThai";
        }
        public void LoadCbCategoryName()
        {
            var list =sp.loadCategory();
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryID");
            dt.Columns.Add("CategoryName");
            foreach (var item in list)
            {
                dt.Rows.Add(item.CategoryID, item.CategoryName);
            }
            
            cbCategoryName.DataSource = dt;
            cbCategoryName.DisplayMember = "CategoryName";
            cbCategoryName.ValueMember = "CategoryID";
        }
        public void LoadDSNhomKH()
        {
            var list = nhomKH.LoadDSNhomKH();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaNhom");
            dt.Columns.Add("Tên Nhóm");
            dt.Columns.Add("Mô Tả Nhóm");
            dt.Columns.Add("Ghi Chú");
            dt.Columns.Add("TrangThai");
            dt.Columns.Add("Trạng Thái");
            dt.Columns.Add("Ngày Tạo");
            dt.Columns.Add("Ngày Update");
            dt.Columns.Add("User Tạo");
            dt.Columns.Add("User Update");
            foreach (var item in list)
            {
                dt.Rows.Add(item.MaNhom,
                    item.TenNhom,
                    item.MoTaoNhom,
                    item.GhiChu,
                    item.TrangThai,
                    (item.TrangThai == 1 ? "Hoạt Động" : "Dừng Hoạt động"),
                    item.NgayTao.ToString(),
                    item.NgayUpdate.ToString(),
                    item.UserTao,
                    item.UserUpdate);
            }
            DataGridViewButtonColumn btnKhachHang = new DataGridViewButtonColumn();
            btnKhachHang.HeaderText = "Button KhachHang";
            btnKhachHang.Text = "Button KhachHang";
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.UseColumnTextForButtonValue = true;
            if (dgvNhomKH.Columns["btnKhachHang"] == null)
            {
                dgvNhomKH.Columns.Add(btnKhachHang);
            }
            dgvNhomKH.DataSource = dt;
            dgvNhomKH.Columns["btnKhachHang"].DisplayIndex = dgvNhomKH.Columns.Count - 1;
        }
        public void LoadTrangThaiNhomKH()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động", 1);

            cbTrangThaiNhomKH.DataSource = dt;
            cbTrangThaiNhomKH.DisplayMember = "TenTrangThai";
            cbTrangThaiNhomKH.ValueMember = "MaTrangThai";
        }
       
        public void LoadDSGroupPermission()
        {
            var list = gp.LoadDSGroupPermission();
            DataTable dt = new DataTable();
            dt.Columns.Add("GroupID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Status");
            dt.Columns.Add("Trạng Thái");
            dt.Columns.Add("Ngày Tạo");
            dt.Columns.Add("Ngày Update");
            foreach (var item in list)
            {
                dt.Rows.Add(item.GroupID,
                    item.Name,
                    item.Status,
                    (item.Status == 1 ? "Hoạt Động" : "Dừng Hoạt động"),
                    item.NgayTao.ToString(),
                    item.NgayTao.ToString());
            }
            DataGridViewButtonColumn btnPermission = new DataGridViewButtonColumn();
            btnPermission.HeaderText = "Button Permission";
            btnPermission.Text = "Button Permission";
            btnPermission.Name = "btnPermission";
            btnPermission.UseColumnTextForButtonValue = true;
            if (dgvPhanQuyen.Columns["btnPermission"] == null)
            {
                dgvPhanQuyen.Columns.Add(btnPermission);
            }
            dgvPhanQuyen.DataSource = dt;
            dgvPhanQuyen.Columns["btnPermission"].DisplayIndex = dgvPhanQuyen.Columns.Count - 1;
        }
        public void LoadTrangThaiPhanQuyen()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động", 1);

            cbTrangThaiGroupPer.DataSource = dt;
            cbTrangThaiGroupPer.DisplayMember = "TenTrangThai";
            cbTrangThaiGroupPer.ValueMember = "MaTrangThai";
        }
        public void LoadDSSite()
        {
            var list = si.loadDSSite();
            DataTable dt = new DataTable();
            dt.Columns.Add("SiteID");
            dt.Columns.Add("SiteName");
            dt.Columns.Add("Title");
            dt.Columns.Add("TrangThai");
            dt.Columns.Add("Trạng Thái");
            dt.Columns.Add("Ngày Tạo");
            dt.Columns.Add("Ngày Update");
            dt.Columns.Add("AccountID");
            dt.Columns.Add("TenAccount");
            dt.Columns.Add("Domain");
            foreach (var item in list)
            {
                dt.Rows.Add(item.SiteID,
                    item.SiteName,
                    item.Title,
                    item.TrangThai,
                    (item.TrangThai==1?"Hoạt Động":"Dừng Hoạt Động"),
                    item.NgayTao.ToString(),
                    item.NgayUpdate.ToString(),
                    item.AccountID,
                    item.tblAccount.TenAccount,
                    item.Domain);
            }
            DataGridViewButtonColumn btnAboutSite = new DataGridViewButtonColumn();
            btnAboutSite.HeaderText = "Button AboutSite";
            btnAboutSite.Text = "Button AboutSite";
            btnAboutSite.Name = "btnAboutSite";
            btnAboutSite.UseColumnTextForButtonValue = true;
            if (dgvSite.Columns["btnAboutSite"] == null)
            {
                dgvSite.Columns.Add(btnAboutSite);
            }

            DataGridViewButtonColumn btnContactSite = new DataGridViewButtonColumn();
            btnContactSite.HeaderText = "Button ContactSite";
            btnContactSite.Text = "Button ContactSite";
            btnContactSite.Name = "btnContactSite";
            btnContactSite.UseColumnTextForButtonValue = true;
            if (dgvSite.Columns["btnContactSite"] == null)
            {
                dgvSite.Columns.Add(btnContactSite);
            }

            DataGridViewButtonColumn btnInfoSite = new DataGridViewButtonColumn();
            btnInfoSite.HeaderText = "Button InfoSite";
            btnInfoSite.Text = "Button InfoSite";
            btnInfoSite.Name = "btnInfoSite";
            btnInfoSite.UseColumnTextForButtonValue = true;
            if (dgvSite.Columns["btnInfoSite"] == null)
            {
                dgvSite.Columns.Add(btnInfoSite);
            }
            
            dgvSite.DataSource = dt;
            dgvSite.Columns["btnAboutSite"].DisplayIndex = dgvSite.Columns.Count - 1;
            dgvSite.Columns["btnContactSite"].DisplayIndex = dgvSite.Columns.Count - 2;
            dgvSite.Columns["btnInfoSite"].DisplayIndex = dgvSite.Columns.Count - 3;
        }
        public void LoadTrangThaiSite()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động", 1);
            
            cbTrangThaiSite.DataSource = dt;
            cbTrangThaiSite.DisplayMember = "TenTrangThai";
            cbTrangThaiSite.ValueMember = "MaTrangThai";

        }
        public void LoadCbTenAccountSite()
        {
            var list =si.loadAccount();
            DataTable dt = new DataTable();
            dt.Columns.Add("AccountID");
            dt.Columns.Add("TenAccount");
            foreach (var item in list)
            {
                dt.Rows.Add(item.MaAccount, item.TenAccount);
            }
            
            cbTenAccountSite.DataSource = dt;
            cbTenAccountSite.DisplayMember = "TenAccount";
            cbTenAccountSite.ValueMember = "AccountID";
        }
        public void LoadDSDonHang()
        {
            long MaAccount = objUser.tblAccounts.FirstOrDefault().MaAccount;
            var result = dh.getDSDonHang(MaAccount);
            DataTable dt = new DataTable();
            dt.Columns.Add("OrderID");
            dt.Columns.Add("ProductID");
            dt.Columns.Add("ProductName");
            dt.Columns.Add("Số Lượng");
            dt.Columns.Add("MaKhachHang");
            dt.Columns.Add("Tên Khách Hàng");
            dt.Columns.Add("Tổng Tiền");
            dt.Columns.Add("AccountID");
            dt.Columns.Add("TenAccount");
            dt.Columns.Add("Ngày hẹn");
            dt.Columns.Add("Ngày Tạo");
            dt.Columns.Add("Ngày Update");
            dt.Columns.Add("TrangThai");
            dt.Columns.Add("Trạng Thái");
            
            foreach (var item in result)
            {
                dt.Rows.Add(item.OrderID,
                    item.ProductID,
                    item.tblProduct.ProductName,
                    item.SoLuong,
                    item.MaKhachHang,
                    item.tblKhachHang.TenKhachHang,
                    item.TongTien,
                    item.AccountID,
                    item.tblAccount.TenAccount,
                    item.NgayHen.ToString(),
                    item.NgayTao.ToString(),
                    item.NgayUpdate.ToString(),
                    item.TrangThai,
                    (item.TrangThai==1?"Hoạt Động":"Dừng Hoạt Động"));
            }
            DataGridViewButtonColumn btnHoaHong = new DataGridViewButtonColumn();
            btnHoaHong.HeaderText = "Button Hoa Hong";
            btnHoaHong.Text = "Button Hoa Hong";
            btnHoaHong.Name = "btnHoaHong";
            btnHoaHong.UseColumnTextForButtonValue = true;
            if (dtgvDonHang.Columns["btnHoaHong"] == null)
            {
                dtgvDonHang.Columns.Add(btnHoaHong);
            }
            
            dtgvDonHang.DataSource = dt ;
            dtgvDonHang.Columns["btnHoaHong"].DisplayIndex = dtgvDonHang.Columns.Count - 1;
           
        }
        public void LoadCbTenAccount()
        {
            
            var list = dh.loadAccount();
            DataTable dt = new DataTable();
            dt.Columns.Add("AccountID");
            dt.Columns.Add("TenAccount");
            foreach (var item in list)
            {
                dt.Rows.Add(item.MaAccount, item.TenAccount);
            }
            cbTenAccountDH.DataSource = dt;
            cbTenAccountDH.DisplayMember = "TenAccount";
            cbTenAccountDH.ValueMember = "AccountID";
        }
        public void LoadNhanVienGiaoDich()
        {
            var list = dh.loadAccount();
            DataTable dt = new DataTable();
            dt.Columns.Add("AccountID");
            dt.Columns.Add("TenAccount");
            foreach (var item in list)
            {
                dt.Rows.Add(item.MaAccount, item.TenAccount);
            }
            cbNhanVienGiaoDich.DataSource = dt;
            cbNhanVienGiaoDich.DisplayMember = "TenAccount";
            cbNhanVienGiaoDich.ValueMember = "AccountID";
        }
        public void LoadCbTenKhachHang()
        {
            var list = dh.loadKhachHang();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaKhachHang");
            dt.Columns.Add("TenKhachHang");
            foreach (var item in list)
            {
                dt.Rows.Add(item.MaKhachHang, item.TenKhachHang);
            }
            cbTenKhachHang.DataSource = dt;
            cbTenKhachHang.DisplayMember = "TenKhachHang";
            cbTenKhachHang.ValueMember = "MaKHachHang";
        }
            
        public void LoadTrangThaiDonHang()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTrangThai");
            dt.Columns.Add("MaTrangThai");
            dt.Rows.Add("Dừng Hoạt Động", 0);
            dt.Rows.Add("Hoạt Động", 1);
            cbTrangThaiDHang.DataSource = dt;
            cbTrangThaiDHang.DisplayMember = "TenTrangThai";
            cbTrangThaiDHang.ValueMember = "MaTrangThai";

        }
        public void loadProduct()
        {
            var list = dh.loadProduct();
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductID");
            dt.Columns.Add("ProductName");
            foreach (var item in list)
            {
                dt.Rows.Add(item.ProductID, item.ProductName);
            }
            cbProduct.DataSource = dt;
            cbProduct.DisplayMember = "ProductName";
            cbProduct.ValueMember = "ProductID";

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

        public void loadLoaiAccount()
        {
            var list = ac.getLoaiAccount();
          
            cbLoaiAccount.DataSource = list;
            cbLoaiAccount.DisplayMember = "Name";
            cbLoaiAccount.ValueMember = "Value";
            cbLoaiAccount.SelectedIndex = 0;
        }

        /*public void loadAccountManager()
        {
            var list = ac.loadDSAccount();
            DataTable dt = new DataTable();
            dt.Columns.Add("AccountManager");
            dt.Columns.Add("LoaiAccount");
            foreach (var item in list)
            {
                dt.Rows.Add(item.tblAccount2.AccountManager,item.tblAccount2.LoaiAccount);
            }
            cboAccountManager.DataSource = dt;
            cboAccountManager.DisplayMember = "LoaiAccount";
            cboAccountManager.ValueMember = "AccountManager";
        }*/
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
            try
            {
                var list = ac.loadDSAccount();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaAccount");
                dt.Columns.Add("Tên Account");
                dt.Columns.Add("LoaiAccount");
                dt.Columns.Add("Loại Acount");
                dt.Columns.Add("Phòng Ban");
                dt.Columns.Add("Ghi Chú");
                dt.Columns.Add("Acount Manager");
                dt.Columns.Add("Account Manager");
                dt.Columns.Add("Ngày tạo");
                dt.Columns.Add("Ngày Cập Nhật");
                dt.Columns.Add("User Tạo");
                dt.Columns.Add("User Cập Nhật");
                dt.Columns.Add("Trạng Thái");

                dt.Columns.Add("TrangThai");
                dt.Columns.Add("PhongBan");

              

                foreach (var item in list)
                {
                    string strLoaiAccount = ac.getLoaiAccount().Find(x => x.Value == item.LoaiAccount).Name;
                    dt.Rows.Add(item.MaAccount,
                        item.TenAccount,
                        item.LoaiAccount,
                        strLoaiAccount,
                        ((item.tblPhongBans.FirstOrDefault() != null) ? item.tblPhongBans.FirstOrDefault().TenPhongBan : String.Empty),
                        item.GhiChu,
                        item.AccountManager,
                        item.tblAccount2.TenAccount,
                        item.NgayTao.ToString(),
                        item.NgayUpdate.ToString(),
                        item.UserTao,
                        item.UserUpdate,
                        (item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động"),
                        item.TrangThai,
                         ((item.tblPhongBans.FirstOrDefault() != null) ? item.tblPhongBans.FirstOrDefault().MaPhongBan.ToString() : String.Empty));

                }
               
                dgvAccount.DataSource = dt;

                DataGridViewButtonColumn btnUser = new DataGridViewButtonColumn();
                btnUser.HeaderText = "Button User";
                btnUser.Text = "Button User";
                btnUser.Name = "btnUser";
                btnUser.UseColumnTextForButtonValue = true;
                if (dgvAccount.Columns["btnUser"] == null)
                {
                    dgvAccount.Columns.Add(btnUser);
                }
             
              
            }
            catch (Exception obj)
            {

                MessageBox.Show(obj.Message);
            }
           
            
        }

        public void loadcboChonPhongBan()
        {
            var list = objPro.LoadDSPhongBan();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaPhongBan");
            dt.Columns.Add("TenPhongBan");
            foreach (var item in list)
            {
                dt.Rows.Add(item.MaPhongBan, item.TenPhongBan);
            }
            cboChonPhongBan.DataSource = dt;
            cboChonPhongBan.DisplayMember = "TenPhongBan";
            cboChonPhongBan.ValueMember = "MaPhongBan";
        }
       
     

        private void btnThemPhongBan_Click(object sender, EventArgs e)
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "ThemPhongBan") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
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
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "CapNhatPhongBan") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            var result = objPro.CapNhatPhongBan(new tblPhongBan()
            {
                MaPhongBan = Convert.ToInt32(dgvPhongBan.CurrentRow.Cells[0].Value.ToString()),
                TenPhongBan = txtphongban.Text,
                GhiChuPhongBan = txtLuuYPhongBan.Text,
                TrangThai = int.Parse(cbTrangThaiPhongBan.SelectedValue.ToString()),
                //NgayUpdate = DateTime.Now,
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
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "XoaPhongBan") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
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

       
        public void ThemAccount()
        {
            var objAccount = new tblAccount()
            {
                TenAccount = txtTenAcount.Text,
                LoaiAccount=cbLoaiAccount.SelectedValue.ToString(),

                GhiChu = txtLuuyAcount.Text,
                AccountManager = Convert.ToInt16(cboAccountManager.SelectedValue.ToString()),

                TrangThai = Convert.ToInt16(cboTrangthaiAcount.SelectedValue.ToString()),
                NgayTao = DateTime.Now,
                NgayUpdate = DateTime.Now,
                UserTao = FormDangNhap.objUser.UserName,
                UserUpdate = FormDangNhap.objUser.UserName,


            };
           
          
            var result = ac.ThemAccount(objAccount,int.Parse(cboChonPhongBan.SelectedValue.ToString()));
            if (result == false)
            {
                MessageBox.Show("Thêm Account Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Thêm Account Thành Công!");
            loadDSAcount();
            //this.dgvAccount.Columns[16].Visible = false;
        }

        public void CapNhatAccount()
        {
            var result = ac.CapNhatAccount(new tblAccount()
            {
                MaAccount=Convert.ToInt16(dgvAccount.CurrentRow.Cells[1].Value.ToString()),
                TenAccount=txtTenAcount.Text,
                
                TrangThai=Convert.ToInt16(cboTrangthaiAcount.SelectedValue.ToString()),
                LoaiAccount=cbLoaiAccount.SelectedValue.ToString(),
                AccountManager=Convert.ToInt16(cboAccountManager.SelectedValue.ToString()),
                GhiChu= txtLuuyAcount.Text,
               // NgayUpdate=DateTime.Now,
                UserUpdate=FormDangNhap.objUser.UserName    
            });
            if (result == false)
            {
                MessageBox.Show("Sửa Account Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Sửa Account Thành Công!");
            loadDSAcount();
           // this.dgvAccount.Columns[16].Visible = false;

            
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
                if (Process.getInstance().CheckPermission(this.objUser.MaUser, "CapNhatAccount") == false)
                {
                    MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                    return;
                }
                CapNhatAccount();
            }

        }
        //btnXoaAccount
        private void button3_Click(object sender, EventArgs e) //btnXoaAccount
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "XoaAccount") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            var result = ac.XoaAccount(new tblAccount()
                {
                    MaAccount=Convert.ToInt16(dgvAccount.CurrentRow.Cells[1].Value.ToString()),
                });
            if (result == false)
            {
                MessageBox.Show("Xóa Account Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Xóa Account Thành Công!");
            loadDSAcount();
           // this.dgvAccount.Columns[16].Visible = false;
        }
         
        //btnDongAccount
        private void button1_Click(object sender, EventArgs e)    //btnDongAccount
        {
            btnXoaAcount.Enabled = false;
            btnLuuAcount.Enabled = false;
            btnThemAcount.Enabled = true;

            txtTenAcount.Enabled = false;
           
            cboTrangthaiAcount.Enabled = false;
            txtLuuyAcount.Enabled = false;
            cboAccountManager.Enabled = false;

            txtTenAcount.Text = string.Empty;
           
            txtLuuyAcount.Text = string.Empty;
            cboTrangthaiAcount.SelectedIndex = 0;
            cboAccountManager.SelectedIndex = 0;

        }

        private void dgvAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Them = false;
            btnXoaAcount.Enabled = true;
            btnThemAcount.Enabled = false;
            btnLuuAcount.Enabled = true;

            txtTenAcount.Enabled = true;
            cboChonPhongBan.Enabled = true;
            cbLoaiAccount.Enabled = true;
            cboAccountManager.Enabled = true;
            txtLuuyAcount.Enabled = true;
            cboTrangthaiAcount.Enabled = true;

            txtTenAcount.Text =dgvAccount.CurrentRow.Cells[2].Value.ToString();
            cboChonPhongBan.SelectedValue = dgvAccount.CurrentRow.Cells[15].Value.ToString();
           // var LoaiAcc = new LoaiAccount() { Value = dgvAccount.CurrentRow.Cells[3].Value.ToString(), Name = dgvAccount.CurrentRow.Cells[4].Value.ToString() };
           // cbLoaiAccount.SelectedItem = LoaiAcc; 
            cbLoaiAccount.SelectedValue = dgvAccount.CurrentRow.Cells[3].Value.ToString();
            txtLuuyAcount.Text = dgvAccount.CurrentRow.Cells[6].Value.ToString();
            //cboChonPhongBan.SelectedItem= new KeyValuePair<string, int>(dgvAccount.CurrentRow.Cells[5].Value.ToString(), int.Parse(dgvAccount.CurrentRow.Cells[15].Value.ToString()));
            
            //LoadAccountManager(LoaiAcc.Value, int.Parse(dgvAccount.CurrentRow.Cells[14].Value.ToString()));
            //LoadAccountManager(int.Parse(dgvAccount.CurrentRow.Cells[14].Value.ToString()),LoaiAcc.Value);
            //cboAccountManager.SelectedItem = new KeyValuePair<string, string>(dgvAccount.CurrentRow.Cells[7].Value.ToString(), dgvAccount.CurrentRow.Cells[8].Value.ToString());
            cboAccountManager.SelectedItem = dgvAccount.CurrentRow.Cells[7].Value.ToString();
            cboTrangthaiAcount.SelectedIndex =int.Parse(dgvAccount.CurrentRow.Cells[14].Value.ToString());

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) //btnOKChonPhongban
        {
            

        }

        public void LoadAccountManager(int MaPhongBan,string strLoaiAccount)
        {
            var listResult = new List<tblAccount>();
            cboAccountManager.ResetText();
            if (strLoaiAccount == "KD" || strLoaiAccount == "CTV")
            {
                //to do something
                listResult = ac.getAccountFromLoaiAccount(MaPhongBan, "QL");

                cboAccountManager.DataSource = listResult;
                cboAccountManager.DisplayMember = "TenAccount";
                cboAccountManager.ValueMember = "MaAccount";

                return;
            }

            listResult = ac.getAccountFromLoaiAccount(MaPhongBan, "AD");
            cboAccountManager.DataSource = listResult;
            cboAccountManager.DisplayMember = "TenAccount";
            cboAccountManager.ValueMember = "MaAccount";
        }

        private void cbLoaiAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string LoaiAccount = cbLoaiAccount.SelectedValue.ToString();
            int MaPhongBan = int.Parse(cboChonPhongBan.SelectedValue.ToString());
            LoadAccountManager( MaPhongBan,LoaiAccount);

        }

        private void btnThemAcount_Click(object sender, EventArgs e)
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "ThemAccount") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            txtTenAcount.Enabled = true;

            cboTrangthaiAcount.Enabled = true;
            txtLuuyAcount.Enabled = true;
            cboAccountManager.Enabled = true;
            btnLuuAcount.Enabled = true;
            Them = true;
        }

       

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && 
                e.RowIndex >= 0)
            {
                

             
                long MaAccount = long.Parse(dgvAccount.Rows[e.RowIndex].Cells[dgvAccount.Columns["MaAccount"].Index].Value.ToString());
                frmQLUser myform = new frmQLUser(MaAccount);
                myform.Show();
                
            }

        }

       
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemDH_Click(object sender, EventArgs e)
        {

            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "ThemDH") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            cbProduct.Enabled = true;
            txtSoluong.Enabled= true;
            txtTongTien.Enabled = true;
            cbTenAccountDH.Enabled= true;
            cbTenKhachHang.Enabled = true;
            txtNgayHen.Enabled = true;
            cbTrangThaiDHang.Enabled = true;

            btnLuuDH.Enabled = true;
            Them = true;
        }
        public int ThemDonHang()
        {
            int result =dh.ThemDonHang(new tblOrder()
            {
                ProductID= int.Parse(cbProduct.SelectedValue.ToString()),
                SoLuong = int.Parse(txtSoluong.Text),
                TongTien=int.Parse(txtTongTien.Text),
                MaKhachHang=int.Parse(cbTenKhachHang.SelectedValue.ToString()),
                AccountID=int.Parse(cbTenAccountDH.SelectedValue.ToString()),
                NgayHen=DateTime.Parse(txtNgayHen.Text),
                TrangThai=int.Parse(cbTrangThaiDHang.SelectedValue.ToString()),
                NgayTao = DateTime.Now,
                NgayUpdate = DateTime.Now

            });

            if (result == 0)
            {
                MessageBox.Show("Thêm Đơn Hàng Không Thành Công", "Warning!");
                return 0;
            }

            MessageBox.Show("Bạn Đã Thêm Đơn Hàng Thành Công!");
           // LoadDSDonHang();
            return result;
        }
        public void CapNhapDonHang()
        {
            
             var result =dh.CapNhatDonHang(new tblOrder()
            {
                OrderID = int.Parse(dtgvDonHang.CurrentRow.Cells[1].Value.ToString()),///////// ko doi------------
                ProductID=int.Parse(cbProduct.SelectedValue.ToString()),
                SoLuong = int.Parse(txtSoluong.Text),
                MaKhachHang = int.Parse(cbTenKhachHang.SelectedValue.ToString()),
                TongTien = int.Parse(txtTongTien.Text),
                AccountID = int.Parse(cbTenAccountDH.SelectedValue.ToString()),
                NgayHen=DateTime.Parse(txtNgayHen.Text),
                TrangThai = int.Parse(cbTrangThaiDHang.SelectedValue.ToString()),
                //NgayUpdate = DateTime.Now
                
            });

            if (result == false)
            {
                MessageBox.Show("Sửa Đơn Hàng Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Sửa Đơn Hàng Thành Công!");
           

        }
        public void ThemOrderAccount(int orderID)
        {
            var result = dh.ThemOrderAccount(new tblOrder_Account()
            {
                AccountID = int.Parse(cbTenAccountDH.SelectedValue.ToString()),
                OrderID = orderID
                
            });
        }
        public void ThemNhanVienGiaoDich()//////////// ko doi--------------
        {
            var result = dh.ThemOrderAccountNhanVienGiaoDich(new tblOrder_Account() 
            {
                AccountID = int.Parse(cbNhanVienGiaoDich.SelectedValue.ToString()),
                OrderID=int.Parse(dtgvDonHang.CurrentRow.Cells["OrderID"].Value.ToString())////////////////////////////////////
            });
        }
        public void CapNhapOrderAccount()
        {
            var result = dh.ThemOrderAccount(new tblOrder_Account()
            {
                AccountID = int.Parse(cbTenAccountDH.SelectedValue.ToString()),
                OrderID = int.Parse(dtgvDonHang.CurrentRow.Cells["OrderID"].Value.ToString()) //////////////////////////////////ko doi-----------
            });
          
        }
        
        private void btnLuuDH_Click(object sender, EventArgs e)
        {
            
            if (Them == true)
            {
                int orderID = ThemDonHang();
                ThemOrderAccount(orderID);
                LoadDSDonHang();
              
            }
            else
            {
                if (Process.getInstance().CheckPermission(this.objUser.MaUser, "CapNhapDH") == false)
                {
                    MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                    return;
                }
                CapNhapOrderAccount();
                CapNhapDonHang();
                
                ThemNhanVienGiaoDich();
                LoadDSDonHang();
            }
        }

        private void dtgvDonHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)////////////////////ko doi-----------
        {
            Them = false;
            btnThemDH.Enabled = false;
            btnLuuDH.Enabled = true;
            btnDongDH.Enabled = true;
            btnXoaDH.Enabled = true;

            cbProduct.Enabled = true;
            txtSoluong.Enabled = true;
            txtTongTien.Enabled = true;
            cbTenAccountDH.Enabled = true;
            cbTenKhachHang.Enabled = true;
            txtNgayHen.Enabled = true;
            cbTrangThaiDHang.Enabled = true;
          
            cbProduct.SelectedValue =int.Parse(dtgvDonHang.Rows[e.RowIndex].Cells[2].Value.ToString());/////////////////////
            txtSoluong.Text = dtgvDonHang.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTongTien.Text = dtgvDonHang.Rows[e.RowIndex].Cells[7].Value.ToString();
            cbTenAccountDH.SelectedValue = int.Parse(dtgvDonHang.Rows[e.RowIndex].Cells[8].Value.ToString());//////////////////
            cbTenKhachHang.SelectedValue = int.Parse(dtgvDonHang.Rows[e.RowIndex].Cells[5].Value.ToString());
            txtNgayHen.Text = dtgvDonHang.Rows[e.RowIndex].Cells[10].Value.ToString();
            cbTrangThaiDHang.SelectedIndex = int.Parse(dtgvDonHang.Rows[e.RowIndex].Cells[13].Value.ToString());/////////////////////
            cbNhanVienGiaoDich.SelectedValue = int.Parse(dtgvDonHang.Rows[e.RowIndex].Cells[8].Value.ToString());
        }

        private void btnDongDH_Click(object sender, EventArgs e)
        {
            btnThemDH.Enabled = true;
            btnLuuDH.Enabled = false;
            
            btnXoaDH.Enabled = false;

            cbProduct.Enabled = false;
            txtSoluong.Enabled = false;
            txtTongTien.Enabled = false;
            cbTenAccountDH.Enabled = false;
            cbTenKhachHang.Enabled = false;
            txtNgayHen.Enabled = false;
            cbTrangThaiDHang.Enabled = false;
            cbProduct.SelectedIndex = 0;
            txtSoluong.Text = string.Empty;
            txtTongTien.Text = string.Empty;
            cbTenAccountDH.SelectedIndex = 0;
            cbTenKhachHang.SelectedIndex = 0;
            txtNgayHen.Text = string.Empty;
            cbTrangThaiDHang.SelectedIndex = 0;

            
        }
        public void XoaOrderAccount()//////////////////////////////////ko doi------------
        {
            var result = dh.XoaOrderAccount(new tblOrder_Account()
            {
                AccountID=int.Parse(dtgvDonHang.CurrentRow.Cells[8].Value.ToString()),//////////////////////////---------
            });
        }
        private void btnXoaDH_Click(object sender, EventArgs e)
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "XoaDH") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            var result =dh.XoaDonHang(new tblOrder()
            {
                OrderID = Convert.ToInt16(dtgvDonHang.CurrentRow.Cells[1].Value.ToString()),///////////////////////////ko doi----------
            });
            if (result == false)
            {
                MessageBox.Show("Xóa Đơn Hàng Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Xóa Đơn Hàng Thành Công!");
            LoadDSDonHang();
            XoaOrderAccount();
        }

        private void dtgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                long OrderID = long.Parse(dtgvDonHang.Rows[e.RowIndex].Cells[dtgvDonHang.Columns["OrderID"].Index].Value.ToString());
                FrmHoaHong myform = new FrmHoaHong(OrderID);
                myform.Show();

            }
        }

        private void btnThemSite_Click(object sender, EventArgs e)
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "ThemSite") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            btnLuuSite.Enabled = true;

            txtSiteName.Enabled = true;
            txtTitle.Enabled = true;
            cbTenAccountSite.Enabled = true;
            cbTrangThaiSite.Enabled = true;
            txtDomain.Enabled = true;
            Them = true;
        }
        public void ThemSite()
        {
            var result = si.ThemSite(new tblSite() 
            {
                SiteName=txtSiteName.Text,
                Title=txtTitle.Text,
                TrangThai = int.Parse(cbTrangThaiSite.SelectedValue.ToString()),
                NgayTao = DateTime.Now,
                NgayUpdate = DateTime.Now,
                AccountID=int.Parse(cbTenAccountSite.SelectedValue.ToString()),
                Domain=txtDomain.Text

            });

            if (result == false)
            {
                MessageBox.Show("Thêm Site Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Thêm Site Thành Công!");
            LoadDSSite();
        }
        public void CapNhapSite()
        {
            var result = si.CapNhatSite(new tblSite()
            {
                SiteID = Convert.ToInt32(dgvSite.CurrentRow.Cells[3].Value.ToString()),
                SiteName =txtSiteName.Text,
                Title =txtTitle.Text,
                TrangThai = int.Parse(cbTrangThaiPhongBan.SelectedValue.ToString()),
                //NgayUpdate = DateTime.Now,
                AccountID= int.Parse(cbTenAccountSite.SelectedValue.ToString()),
                Domain=txtDomain.Text,
            });

            if (result == false)
            {
                MessageBox.Show("Sửa Site Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Sửa Site Thành Công!");
            LoadDSSite();
        }
        private void btnLuuSite_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                ThemSite();
            }
            else
            {
                if (Process.getInstance().CheckPermission(this.objUser.MaUser, "CapNhatSite") == false)
                {
                    MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                    return;
                }
                CapNhapSite();
            }
        }

        private void dgvSite_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLuuSite.Enabled = true;
            btnXoaSite.Enabled = true;
            btnDongSite.Enabled = true;

            txtSiteName.Enabled = true;
            txtTitle.Enabled = true;
            txtDomain.Enabled = true;
            cbTenAccountSite.Enabled = true;
            cbTrangThaiSite.Enabled = true;

            txtSiteName.Text = dgvSite.CurrentRow.Cells[4].Value.ToString();
            txtTitle.Text = dgvSite.CurrentRow.Cells[5].Value.ToString();
            cbTrangThaiSite.SelectedIndex = int.Parse(dgvSite.CurrentRow.Cells[6].Value.ToString());
            cbTenAccountSite.SelectedValue = int.Parse(dgvSite.CurrentRow.Cells[10].Value.ToString());
            txtDomain.Text = dgvSite.CurrentRow.Cells[12].Value.ToString();
        }

        private void btnDongSite_Click(object sender, EventArgs e)
        {
            btnLuuSite.Enabled = false;
            btnXoaSite.Enabled = false;
            btnThemSite.Enabled = true;

            txtSiteName.Enabled = false;
            txtTitle.Enabled = false;
            txtDomain.Enabled = false;
            cbTenAccountSite.Enabled = false;
            cbTrangThaiSite.Enabled = false;

            txtSiteName.Text=string.Empty;
            txtTitle.Text=string.Empty;
            txtDomain.Text=string.Empty;
            cbTenAccountSite.SelectedIndex=0;
            cbTrangThaiSite.SelectedIndex=0;
            
        }

        private void btnXoaSite_Click(object sender, EventArgs e)
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "XoaSite") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            var result =si.XoaSite(new tblSite()
            {
                SiteID = Convert.ToInt16(dgvSite.CurrentRow.Cells[3].Value.ToString()),

            });

            if (result == false)
            {
                MessageBox.Show("Xóa Site Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Xóa Site Thành Công!");
            LoadDSSite();
  
        }

        private void dgvSite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             var senderGrid = (DataGridView)sender;

             if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                 senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Button AboutSite" &&
                 e.RowIndex >= 0)
             {
                 

                     int SiteID = int.Parse(dgvSite.Rows[e.RowIndex].Cells[dgvSite.Columns["SiteID"].Index].Value.ToString());
                     FrmAboutSite myform = new FrmAboutSite(SiteID);
                     myform.Show();
             } 
             if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                 senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Button ContactSite" &&
                 e.RowIndex >= 0)
             {
             
                     int SiteID = int.Parse(dgvSite.Rows[e.RowIndex].Cells[dgvSite.Columns["SiteID"].Index].Value.ToString());
                     FrmContactSite myform = new FrmContactSite(SiteID);
                     myform.Show();
             }
             
             if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                 senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Button InfoSite" &&
                 e.RowIndex >= 0)
             {
                     int SiteID = int.Parse(dgvSite.Rows[e.RowIndex].Cells[dgvSite.Columns["SiteID"].Index].Value.ToString());
                     FrmInfoSite myform = new FrmInfoSite(SiteID);
                     myform.Show();
             }
 
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void dgvPhanQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)///////////////////////////////
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {



                int GroupID = int.Parse(dgvPhanQuyen.Rows[e.RowIndex].Cells[dgvPhanQuyen.Columns["GroupID"].Index].Value.ToString());
                FrmGroup_Permission myform = new FrmGroup_Permission(GroupID);////////////////(GroupID)
                myform.Show();

            }
        }

        private void btnThemGroupPer_Click(object sender, EventArgs e)
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "ThemGroupPermission") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            txtNameGroupPer.Enabled = true;
            cbTrangThaiGroupPer.Enabled = true;

            btnLuuGroupPer.Enabled = true;
            Them = true;
        }
        public void ThemGroupPer()
        {
            var result = gp.ThemGroupPermission(new tblGroupPermission() 
            {
                Name=txtNameGroupPer.Text,
                Status=int.Parse(cbTrangThaiGroupPer.SelectedValue.ToString()),
                NgayTao=DateTime.Now,
                NgayUpdate = DateTime.Now
            });
            if (result == false)
            {
                MessageBox.Show("Thêm GroupPermission Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Thêm GroupPermission Thành Công!");
            LoadDSGroupPermission();
        }
        public void CapNhapGroupPer()
        {
            var result =gp.CapNhatGroupPermission(new tblGroupPermission()
            {
                GroupID = int.Parse(dgvPhanQuyen.CurrentRow.Cells[1].Value.ToString()),
                Name = txtNameGroupPer.Text,
                Status=int.Parse(cbTrangThaiGroupPer.SelectedValue.ToString()),
                //NgayUpdate = DateTime.Now
                

            });

            if (result == false)
            {
                MessageBox.Show("Sửa GroupPermission Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Sửa GroupPermission Thành Công!");
            LoadDSGroupPermission();
        }

        private void btnLuuGroupPer_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                ThemGroupPer();
            }
            else
            {
                if (Process.getInstance().CheckPermission(this.objUser.MaUser, "CapNhatGroupPermission") == false)
                {
                    MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                    return;
                }
                CapNhapGroupPer();
            }
        }

        private void dgvPhanQuyen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThemGroupPer.Enabled = false;
            btnLuuGroupPer.Enabled = true;
            btnXoaGroupPer.Enabled = true;
            btnDongGroupPer.Enabled = true;

            txtNameGroupPer.Enabled = true;
            cbTrangThaiGroupPer.Enabled = true;

            txtNameGroupPer.Text = dgvPhanQuyen.CurrentRow.Cells[2].Value.ToString();
            cbTrangThaiGroupPer.SelectedIndex = int.Parse(dgvPhanQuyen.CurrentRow.Cells[3].Value.ToString());
        }

        private void btnXoaGroupPer_Click(object sender, EventArgs e)
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "XoaGroupPermission") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            var result = gp.XoaGroupPermission(new tblGroupPermission() 
            {
                GroupID=int.Parse(dgvPhanQuyen.CurrentRow.Cells[1].Value.ToString())
            });
            if (result == false)
            {
                MessageBox.Show("Xóa GroupPermission Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Xóa GroupPermission Thành Công!");
            LoadDSGroupPermission();
        }

        private void btnDongGroupPer_Click(object sender, EventArgs e)
        {
            btnLuuGroupPer.Enabled = false;
            btnXoaGroupPer.Enabled = false;
            btnThemGroupPer.Enabled = true;

            txtNameGroupPer.Text = string.Empty;
            cbTrangThaiGroupPer.SelectedIndex = 0;

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FrmQLQuyen frm = new FrmQLQuyen();
            frm.Show();
        }

        private void btnThemNhomKH_Click(object sender, EventArgs e)
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "ThemNhomKhachHang") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            btnLuuNhomKH.Enabled = true;
            txtTenNhomKH.Enabled = true;
            txtMotaNhomKH.Enabled = true;
            txtGhiChuNhomKH.Enabled = true;
            cbTrangThaiNhomKH.Enabled = true;

            Them = true;
        }
        public void ThemNhomKH()
        {
            var result = nhomKH.ThemNhomKH(new tblNhom()
            {
                TenNhom =txtTenNhomKH.Text,
                MoTaoNhom =txtMotaNhomKH.Text,
                GhiChu=txtGhiChuNhomKH.Text,
                TrangThai = int.Parse(cbTrangThaiNhomKH.SelectedValue.ToString()),
                NgayTao = DateTime.Now,
                NgayUpdate = DateTime.Now,
                UserTao = FormDangNhap.objUser.UserName,
                UserUpdate = FormDangNhap.objUser.UserName,

            });

            if (result == false)
            {
                MessageBox.Show("Thêm Nhóm KH Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Thêm Nhóm KH Thành Công!");
            LoadDSNhomKH();
        }
        public void CapNhapNhomKH()
        {
            var result =nhomKH.CapNhatNhomKH(new tblNhom()
            {
                MaNhom = int.Parse(dgvNhomKH.CurrentRow.Cells[1].Value.ToString()),
                TenNhom =txtTenNhomKH.Text,
                MoTaoNhom =txtMotaNhomKH.Text,
                GhiChu=txtGhiChuNhomKH.Text,
                TrangThai = int.Parse(cbTrangThaiNhomKH.SelectedValue.ToString()),
               // NgayUpdate = DateTime.Now,
                UserUpdate = FormDangNhap.objUser.UserName,
          
            });

            if (result == false)
            {
                MessageBox.Show("Sửa Nhóm KH Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Sửa Nhóm KH Thành Công!");
            LoadDSNhomKH();
        }

        private void btnLuuNhomKH_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                ThemNhomKH();
            }
            else
            {
                if (Process.getInstance().CheckPermission(this.objUser.MaUser, "CapNhatNhomKhachHang") == false)
                {
                    MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                    return;
                }
                CapNhapNhomKH();
            }
        }

        private void dgvNhomKH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Them = false;
            btnLuuNhomKH.Enabled = true;
            btnXoaNhomKH.Enabled = true;
            btnThemNhomKH.Enabled = false;

            txtTenNhomKH.Enabled = true;
            txtMotaNhomKH.Enabled = true;
            txtGhiChuNhomKH.Enabled = true;
            cbTrangThaiNhomKH.Enabled = true;

            txtTenNhomKH.Text = dgvNhomKH.CurrentRow.Cells[2].Value.ToString();
            txtGhiChuNhomKH.Text = dgvNhomKH.CurrentRow.Cells[4].Value.ToString();
            txtMotaNhomKH.Text = dgvNhomKH.CurrentRow.Cells[3].Value.ToString();
            cbTrangThaiNhomKH.SelectedIndex = int.Parse(dgvNhomKH.CurrentRow.Cells[5].Value.ToString());
        }

        private void btnXoaNhomKH_Click(object sender, EventArgs e)
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "XoaNhomKhachHang") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            var result =nhomKH.XoaNhomKH (new tblNhom()
            {
                MaNhom = int.Parse(dgvNhomKH.CurrentRow.Cells[1].Value.ToString()),

            });

            if (result == false)
            {
                MessageBox.Show("Xóa Nhóm KH Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Xóa Nhóm KH Thành Công!");
            LoadDSNhomKH();
  
        }

        private void btnDongNhomKH_Click(object sender, EventArgs e)
        {
            btnLuuNhomKH.Enabled = false;
            btnXoaNhomKH.Enabled = false;
            btnThemNhomKH.Enabled = true;

            txtTenNhomKH.Enabled = false;
            txtGhiChuNhomKH.Enabled = false;
            txtMotaNhomKH.Enabled = false;
            cbTrangThaiNhomKH.Enabled = false;

            txtTenNhomKH.Text = "";
            txtGhiChuNhomKH.Text = "";
            txtMotaNhomKH.Text = "";
            cbTrangThaiNhomKH.SelectedIndex = 0;
        }

        private void dgvNhomKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {



                int MaNhom = int.Parse(dgvNhomKH.Rows[e.RowIndex].Cells[dgvNhomKH.Columns["MaNhom"].Index].Value.ToString());
                FrmNhom_KhachHang myform = new FrmNhom_KhachHang(MaNhom);////////////////(GroupID)
                myform.Show();

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmQLKhachHang frm = new FrmQLKhachHang(objUser);
            frm.Show();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "ThemSanPham") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            btnLuuSanPham.Enabled = true;
            txtGiaBan.Enabled = true;
            txtTenSanPham.Enabled = true;
            txtNoiDung.Enabled = true;
            
            cbTrangThaiSanPham.Enabled = true;
            cbCategoryName.Enabled = true;
            Them = true;
        }

        public void ThemSanPham()
        {
            //copy
            string filename = getImageName(txtPath.Text);
            string timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff",
                                  CultureInfo.InvariantCulture);
            string DesPath = ConfigurationManager.AppSettings["UploadPath"];
            string strPath = ConfigurationManager.AppSettings["Path"]; 
            string picture = SaveImageToDrive(txtPath.Text, DesPath, filename, timestamp + filename);
            string path = strPath + timestamp + filename;
            var result =sp.ThemProduct(new tblProduct()
            {
                ProductName=txtTenSanPham.Text,
                CategoryID=int.Parse(cbCategoryName.SelectedValue.ToString()),
                GiaBan =float.Parse(txtGiaBan.Text),
                TrangThai = int.Parse(cbTrangThaiSanPham.SelectedValue.ToString()),
                NoiDung=txtNoiDung.Text,
                HinhAnh=path,
                NgayTao = DateTime.Now,
                NgayUpdate = DateTime.Now,               
            });

            if (result == false)
            {
                MessageBox.Show("Thêm Sản Phẩm Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Thêm Sản Phẩm Thành Công!");
            LoadDSSanPham();
        }
        public void CapNhapSanPham()
        {
            //hinhah database
            if (txtPath.Text != dgvSanPham.CurrentRow.Cells[10].Value.ToString())
            {
                string filename = getImageName(txtPath.Text);
                string timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff",
                                      CultureInfo.InvariantCulture);
                string DesPath = ConfigurationManager.AppSettings["UploadPath"];
                string strPath = ConfigurationManager.AppSettings["Path"]; 
                string picture = SaveImageToDrive(txtPath.Text, DesPath, filename, timestamp + filename);
                string path = strPath + timestamp + filename;
                var result = sp.CapNhatProduct(new tblProduct()
                {
                    ProductID = int.Parse(dgvSanPham.CurrentRow.Cells[0].Value.ToString()),
                    ProductName = txtTenSanPham.Text,
                    CategoryID = int.Parse(cbCategoryName.SelectedValue.ToString()),
                    GiaBan = float.Parse(txtGiaBan.Text),
                    TrangThai = int.Parse(cbTrangThaiSanPham.SelectedValue.ToString()),
                   // NgayUpdate = DateTime.Now,
                    NoiDung=txtNoiDung.Text,
                    HinhAnh=path,
                    //HinhAnh
                });
                if (result == false)
                {
                    MessageBox.Show("Sửa Sản Phẩm Không Thành Công", "Warning!");
                    return;
                }

                MessageBox.Show("Bạn Đã Sửa Sản Phẩm Thành Công!");
                LoadDSSanPham();

            }
            else
            {
                var result = sp.CapNhatProduct(new tblProduct()
                {
                    ProductID = int.Parse(dgvSanPham.CurrentRow.Cells[0].Value.ToString()),
                    ProductName = txtTenSanPham.Text,
                    CategoryID = int.Parse(cbCategoryName.SelectedValue.ToString()),
                    GiaBan = float.Parse(txtGiaBan.Text),
                    TrangThai = int.Parse(cbTrangThaiSanPham.SelectedValue.ToString()),
                    //NgayUpdate = DateTime.Now,
                    NoiDung=txtNoiDung.Text,
                    HinhAnh=dgvSanPham.CurrentRow.Cells[10].Value.ToString(),
                    //HinhAnh
                });
                if (result == false)
                {
                    MessageBox.Show("Sửa Sản Phẩm Không Thành Công", "Warning!");
                    return;
                }

                MessageBox.Show("Bạn Đã Sửa Sản Phẩm Thành Công!");
                LoadDSSanPham();
            }
          
            /*if (result == false)
            {
                MessageBox.Show("Sửa Sản Phẩm Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Sửa Sản Phẩm Thành Công!");
            LoadDSSanPham();*/
        }

        private void btnLuuSanPham_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                ThemSanPham();
            }
            else 
            {
                if (Process.getInstance().CheckPermission(this.objUser.MaUser, "CapNhatSanPham") == false)
                {
                    MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                    return;
                }
                CapNhapSanPham();
            }
        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Them = false;
            btnLuuSanPham.Enabled = true;
            btnXoaSanPham.Enabled = true;
            btnThemSanPham.Enabled = false;
            

            txtTenSanPham.Enabled = true;
            txtGiaBan.Enabled = true;
            cbTrangThaiSanPham.Enabled = true;
            cbCategoryName.Enabled = true;
            txtNoiDung.Enabled = true;

            txtTenSanPham.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            cbCategoryName.SelectedValue = int.Parse(dgvSanPham.CurrentRow.Cells[2].Value.ToString());
            txtGiaBan.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
            cbTrangThaiSanPham.SelectedIndex = int.Parse(dgvSanPham.CurrentRow.Cells[5].Value.ToString());
            txtNoiDung.Text = dgvSanPham.CurrentRow.Cells[9].Value.ToString();
            txtPath.Text = dgvSanPham.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "XoaSanPham") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            var result =sp.XoaProduct(new tblProduct()
            {
                ProductID = int.Parse(dgvSanPham.CurrentRow.Cells[0].Value.ToString()),

            });

            if (result == false)
            {
                MessageBox.Show("Xóa Sản Phẩm Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Xóa Sản Phẩm Thành Công!");
            LoadDSSanPham();
        }

        private void btnDongSanPham_Click(object sender, EventArgs e)
        {
            btnLuuSanPham.Enabled =false;
            btnXoaSanPham.Enabled = false;
            btnThemSanPham.Enabled = true;

            txtTenSanPham.Enabled = false;
            txtGiaBan.Enabled = false;
            cbTrangThaiSanPham.Enabled = false;
            cbCategoryName.Enabled = false;
            txtNoiDung.Enabled = false;
            txtTenSanPham.Text = "";
            txtGiaBan.Text = "";
            cbCategoryName.SelectedIndex = 0;
            cbTrangThaiSanPham.SelectedIndex = 0;
            txtNoiDung.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)//btnThemloaisanpham
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "ThemLoaiSanPham") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            btnLuuLoaiSP.Enabled = true;
            txtcategoryname.Enabled = true;
            cbTenAccountLSP.Enabled = true;

            

            Them = true;
        }

        private void dgvLoaiSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Them = false;
            btnLuuLoaiSP.Enabled = true;
            btnXoaLoaiSP.Enabled = true;
            btnThemLoaiSanPham.Enabled = false;
            txtcategoryname.Enabled = true;
            cbTenAccountLSP.Enabled = true;

            txtcategoryname.Text = dgvLoaiSanPham.CurrentRow.Cells[1].Value.ToString();
            cbTenAccountLSP.SelectedValue = int.Parse(dgvLoaiSanPham.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnDongLoaiSP_Click(object sender, EventArgs e)
        {
            btnLuuLoaiSP.Enabled = false;
            btnXoaLoaiSP.Enabled = false; btnThemLoaiSanPham.Enabled = true;

            txtcategoryname.Enabled = false;
            cbTenAccountLSP.Enabled = false;
          

            txtcategoryname.Text = "";
            cbTenAccountLSP.SelectedIndex = 0;
           
        }

        public void ThemLoaiSanPham()
        {
            var result =lsp.ThemLoaiSanPham(new Category()
            {
                CategoryName=txtcategoryname.Text,
                AccountID=int.Parse(cbTenAccountLSP.SelectedValue.ToString()),             
                NgayTao = DateTime.Now,
                NgayUpdate = DateTime.Now,
            });

            if (result == false)
            {
                MessageBox.Show("Thêm Loại Sản Phẩm Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Thêm Loại Sản Phẩm Thành Công!");
            LoadDSLoaiSanPham();
        }
        public void CapNhapLoaiSanPham()
        {
            var result =lsp.CapNhatLoaiSanPham (new Category()
            {
                CategoryID=int.Parse(dgvLoaiSanPham.CurrentRow.Cells[0].Value.ToString()),
                CategoryName = txtcategoryname.Text,
                AccountID = int.Parse(cbTenAccountLSP.SelectedValue.ToString()),              
                //NgayUpdate = DateTime.Now,


            });

            if (result == false)
            {
                MessageBox.Show("Sửa Loại Sản Phẩm Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Sửa Loại Sản Phẩm Thành Công!");
            LoadDSLoaiSanPham();
        }

        private void btnLuuLoaiSP_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                ThemLoaiSanPham();
            }
            else
            {
                if (Process.getInstance().CheckPermission(this.objUser.MaUser, "CapNhatLoaiSanPham") == false)
                {
                    MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                    return;
                }
                CapNhapLoaiSanPham();
            }
        }

        private void btnXoaLoaiSP_Click(object sender, EventArgs e)
        {
            if (Process.getInstance().CheckPermission(this.objUser.MaUser, "XoaLoaiSanPham") == false)
            {
                MessageBox.Show("Ban khong co quyen su dung chuc nang  nay");
                return;
            }
            var result =lsp.XoaLoaiSanPham(new Category()
            {
                 CategoryID=int.Parse(dgvLoaiSanPham.CurrentRow.Cells[0].Value.ToString()),

            });

            if (result == false)
            {
                MessageBox.Show("Xóa Loại Sản Phẩm Không Thành Công", "Warning!");
                return;
            }

            MessageBox.Show("Bạn Đã Xóa Loại Sản Phẩm Thành Công!");
            LoadDSLoaiSanPham();
        }

        public  string SaveImageToDrive(string src, string desc, string filename, string fileNew)
        {
            //const string localFilename = @"c:\file.jpg";
         
            string localFileNew = @desc + "\\" + fileNew;
            System.IO.File.Copy(@src, @localFileNew);
            return fileNew;
        }
        public  string getImageName(string values)
        {
            string[] rs = values.Split('\\');
            return rs[rs.Length - 1];
        }
        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            //Create a new instance of openFileDialog
            OpenFileDialog res = new OpenFileDialog();

            //Filter
            res.Filter = "Image Files|*.jpg;*.jpeg;*.png;";

            //When the user select the file
            if (res.ShowDialog() == DialogResult.OK)
            {
               //Get the file's path
               var filePath = res.FileName;
               txtPath.Text = filePath;
            
              
            }
        }

        private void dĐaăngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            FormDangNhap dangnhap = new FormDangNhap();
            dangnhap.Show();
            this.Hide();
            
            
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            loadform();
        }

    }
}

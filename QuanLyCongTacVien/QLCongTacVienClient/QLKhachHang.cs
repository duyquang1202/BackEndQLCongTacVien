using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class QLKhachHang:Process
    {
        public List<tblKhachHang> LoadDSKhachHang()
        {
            try
            {
                return context.tblKhachHangs.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblKhachHang>();
            }
        }

        public bool ThemKhachHang(tblKhachHang obj)
        {
            try
            {
                context.tblKhachHangs.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool CapNhatKhachHang(tblKhachHang obj)
        {
            try
            {
                var result = context.tblKhachHangs.Where(x => x.MaKhachHang.Equals(obj.MaKhachHang)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }
                result.TenKhachHang = obj.TenKhachHang;
                result.SoDT = obj.SoDT;
                result.DiaChi = obj.DiaChi;
                result.GhiChu1 = obj.GhiChu1;
                result.GhiChu2 = obj.GhiChu2;
                result.GhiChu3 = obj.GhiChu3;
                result.GhiChu4 = obj.GhiChu4;
                result.TrangThai1 = obj.TrangThai1;
                result.TrangThai2 = obj.TrangThai2;
                result.TrangThai3 = obj.TrangThai3;
                result.TrangThai4 = obj.TrangThai4;
                result.GiaTri = obj.GiaTri;
                result.NgayUpdate = obj.NgayUpdate;
                result.UserUpdate = obj.UserUpdate;

                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool XoaKhachHang(tblKhachHang obj)
        {
            try
            {
                var result = context.tblKhachHangs.Where(x => x.MaKhachHang.Equals(obj.MaKhachHang)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }

                context.tblKhachHangs.Remove(result);

                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }
    }
}

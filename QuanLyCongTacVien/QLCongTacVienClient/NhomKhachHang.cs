using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class NhomKhachHang:Process
    {
        public List<tblNhom> LoadDSNhomKH()
        {
            try
            {
                context = new QLCongTacVienEntities();
                return context.tblNhoms.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblNhom>();
            }
        }

        public bool ThemNhomKH(tblNhom obj)
        {
            try
            {
                context.tblNhoms.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool CapNhatNhomKH(tblNhom obj)
        {
            try
            {
                var result = context.tblNhoms.Where(x => x.MaNhom.Equals(obj.MaNhom)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }

                result.TenNhom = obj.TenNhom;
                result.MoTaoNhom = obj.MoTaoNhom;
                result.GhiChu = obj.GhiChu;
                result.NgayUpdate = obj.NgayUpdate;
                result.UserUpdate = obj.UserUpdate;
                result.TrangThai = obj.TrangThai;
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool XoaNhomKH(tblNhom obj)
        {
            try
            {
                var result = context.tblNhoms.Where(x => x.MaNhom.Equals(obj.MaNhom)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }

                context.tblNhoms.Remove(result);

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

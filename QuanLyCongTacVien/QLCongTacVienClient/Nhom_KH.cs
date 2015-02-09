using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class Nhom_KH:Process
    {
        public List<tblNhom_KhachHang> LoadDSNhom_KH(int MaNhom)
        {
            try
            {
                context = new QLCongTacVienEntities();
                var objNhom = context.tblNhoms.Find(MaNhom);
                if (objNhom == null)
                {
                    return new List<tblNhom_KhachHang>();
                }
                return objNhom.tblNhom_KhachHang.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblNhom_KhachHang>();
            }
        }
        public List<tblKhachHang> LoadDSKhachHang()
        {
            try
            {
                context = new QLCongTacVienEntities();
                return context.tblKhachHangs.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblKhachHang>();
            }
        }
        public bool ThemNhom_KH(tblNhom_KhachHang obj)
        {
            try
            {
                context.tblNhom_KhachHang.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }



        public bool XoaNhom_KH(tblNhom_KhachHang obj)
        {
            try
            {
                var result = context.tblNhom_KhachHang.Where(x => x.MaKhachHang.Equals(obj.MaKhachHang)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }

                context.tblNhom_KhachHang.Remove(result);

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

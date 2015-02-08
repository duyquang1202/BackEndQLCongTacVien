using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class LoaiSanPham:Process
    {
         public List<Category> LoadDSLoaiSanPham()
        {
            try
            {
                return context.Categories.ToList();
            }
            catch (Exception objEX)
            {
                return new List<Category>();
            }
        }
         

        public bool ThemLoaiSanPham(Category obj)
        {
            try
            {
                context.Categories.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool CapNhatLoaiSanPham(Category obj)
        {
            try
            {
                var result = context.Categories.Where(x => x.CategoryID.Equals(obj.CategoryID)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }
              
                result.CategoryName = obj.CategoryName;
                result.AccountID=obj.AccountID;
                result.NgayUpdate=obj.NgayUpdate;
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool XoaLoaiSanPham(Category obj)
        {
            try
            {
                var result = context.Categories.Where(x => x.CategoryID.Equals(obj.CategoryID)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }

                context.Categories.Remove(result);

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

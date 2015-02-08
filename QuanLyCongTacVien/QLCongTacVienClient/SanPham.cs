using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class SanPham:Process
    {
         public List<tblProduct> LoadDSProduct()
        {
            try
            {
                return context.tblProducts.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblProduct>();
            }
        }

        public bool ThemProduct(tblProduct obj)
        {
            try
            {
                context.tblProducts.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool CapNhatProduct(tblProduct obj)
        {
            try
            {
                var result = context.tblProducts.Where(x => x.ProductID.Equals(obj.ProductID)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }
              
                result.ProductName = obj.ProductName;
                result.CategoryID=obj.CategoryID;
                result.GiaBan=obj.GiaBan;
                result.TrangThai = obj.TrangThai;
                result.NgayUpdate = obj.NgayUpdate;
                result.NoiDung = obj.NoiDung;
                result.HinhAnh = obj.HinhAnh;
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool XoaProduct(tblProduct obj)
        {
            try
            {
                var result = context.tblProducts.Where(x => x.ProductID.Equals(obj.ProductID)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }

                context.tblProducts.Remove(result);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    public class DonHang : Process
    {
        public List<tblOrder> getDSDonHang(long MaAccount)
        {
            List<tblAccount> lsAccount = new List<tblAccount>();
            var result = context.tblAccounts.Where(x => x.MaAccount == MaAccount).ToList();
            foreach (var item in result)
            {
                lsAccount.Add(item);
                var result1 = context.tblAccounts.Where(x => x.AccountManager == item.MaAccount && x.MaAccount!=x.AccountManager);
                foreach (var item1 in result1)
                {
                    lsAccount.Add(item1);
                }
            }
            
            List<tblOrder> lsOrder = new List<tblOrder>();
            foreach (var item in lsAccount)
            {
                var orders = item.tblOrder_Account.Where(x => x.AccountID == item.MaAccount).GroupBy(y => y.OrderID).ToList();
                
                foreach (var item1 in orders)
                {
                    var order = context.tblOrders.Find(item1.FirstOrDefault().OrderID);
                    lsOrder.Add(order);
                }
               
            }

            return lsOrder;
        }

        public int ThemDonHang(tblOrder obj)
        {
            try
            {
                context.tblOrders.Add(obj);
                context.SaveChanges();
                return obj.OrderID;
            }
            catch (Exception objEX)
            {
                return 0;
            }
        }
        public bool CapNhatDonHang(tblOrder obj)
        {
            try
            {
                var result = context.tblOrders.Where(x => x.OrderID.Equals(obj.OrderID)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }

                result.ProductID = obj.ProductID;
                result.SoLuong = obj.SoLuong;
                result.TrangThai = obj.TrangThai;
                result.TongTien = obj.TongTien;
                result.AccountID = obj.AccountID;
                result.MaKhachHang = obj.MaKhachHang;
                result.NgayHen = obj.NgayHen;

                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }
        public bool XoaDonHang(tblOrder obj)
        {
            try
            {
                var result = context.tblOrders.Where(x => x.OrderID.Equals(obj.OrderID)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }
                context.tblOrders.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
       
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class HoaHong: Process
    {
        public List<tblOrder_Account> LoadDSHoaHong(long OrderID)
        {
            try
            {
                var objHoahong = context.tblOrders.Find(OrderID);
                if (objHoahong == null)
                {
                    return new List<tblOrder_Account>();
                }
                return objHoahong.tblOrder_Account.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblOrder_Account>();
            }
        }
        

        public bool CapNhapHoaHong(tblOrder_Account obj)
        {
            try
            {
                var result = context.tblOrder_Account.Where(x => x.AccountID == obj.AccountID).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }
                result.HueHong = obj.HueHong;
                result.TrangThai = obj.TrangThai;
                
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class Account: Process
    {
        public List<tblAccount> loadDSAccount()
        {
            try
            {
                return context.tblAccounts.ToList();
                
            }
            catch(Exception ex)
            {
                return new List<tblAccount>();
            }
        }
        public bool ThemAccount(tblAccount obj)
        {
            try
            {
                context.tblAccounts.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool CapNhatAccount(tblAccount obj)
        {
            try
            {
                var result = context.tblAccounts.Where(x => x.MaAccount.Equals(obj.MaAccount)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }

                result.TenAccount = obj.TenAccount;
                result.LoaiAccount = obj.LoaiAccount;
                result.TrangThai = obj.TrangThai;
                result.AccountManager = obj.AccountManager;
                result.GhiChu = obj.GhiChu;
                result.UserUpdate = obj.UserUpdate;
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool XoaAccount(tblAccount obj)
        {
            try
            {
                var result = context.tblAccounts.Where(x => x.MaAccount.Equals(obj.MaAccount)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }
                context.tblAccounts.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }


    }
}

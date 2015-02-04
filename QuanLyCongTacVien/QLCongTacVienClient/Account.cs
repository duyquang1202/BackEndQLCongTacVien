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
        public bool ThemAccount(tblAccount obj,int MaPhongBan)
        {
            try
            {
                var phongban = context.tblPhongBans.Where(x => x.MaPhongBan == MaPhongBan).FirstOrDefault();
                obj.tblPhongBans.Add(phongban);
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

        public List<tblAccount> getAccountFromLoaiAccount(int MaPhongBan, string LoaiAccount)
        {
            try
            {
                var result = context.tblAccounts.Where(x => x.tblPhongBans.Where(m => m.MaPhongBan == MaPhongBan).Count() > 0 && x.LoaiAccount==LoaiAccount).ToList();
                return result;
            }
            catch (Exception)
            {
                return new List<tblAccount>();
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class USer : Process
    {

        public List<tblUser> LoadDSUser(long MaAccount)
        {
            try
            {
                var objAccount = context.tblAccounts.Find(MaAccount);
                if(objAccount==null)
                {
                    return new List<tblUser>();
                }
                return objAccount.tblUsers.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblUser>();
            }
        }
        public bool ThemUser(tblUser obj)
        {
            try
            {
                context.tblUsers.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CapNhapUser(tblUser obj)
        {
            try
            {
                var result = context.tblUsers.Where(x => x.MaUser == obj.MaUser).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }
                result.UserName = obj.UserName;
                result.FullName = obj.FullName;
                result.DienThoai = obj.DienThoai;
                result.DiaChi = obj.DiaChi;
                result.Email = obj.Email;
                result.GhiChu = obj.GhiChu;
                result.TrangThai = obj.TrangThai;
                result.Password = obj.Password;
                result.GroupID = obj.GroupID;
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool XoaUser(tblUser obj)
        {
            try
            {
                var result = context.tblUsers.Where(x => x.MaUser == obj.MaUser).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }
                context.tblUsers.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<tblPermission> getPermissionFromGroupPermission(int GroupID)
        {
            try
            {
                var result = context.tblPermissions.Where(x =>x.tblGroupPermissions.Where(m=>m.GroupID==GroupID).Count()>0).ToList();
                return result;
            }
            catch (Exception)
            {
                return new List<tblPermission>();
            }
        }

    } 
}

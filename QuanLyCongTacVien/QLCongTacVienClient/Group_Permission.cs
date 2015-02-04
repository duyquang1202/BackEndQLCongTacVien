using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class Group_Permission:Process
    {
        public List<tblPermission> LoadDSGroup_per(int GroupID)
        {
            try
            {
                var objPermission = context.tblGroupPermissions.Find(GroupID);
                if (objPermission == null)
                {
                    return new List<tblPermission>();
                }
                return objPermission.tblPermissions.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblPermission>();
            }
        }
        public List<tblPermission> LoadDSGroup_per()
        
        {
            try
            {
                return context.tblPermissions.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblPermission>();
            }
        }

        
        public bool CapNhapGroupPer_(tblPermission obj)
        {
            try
            {
                var result = context.tblPermissions.Where(x => x.PermisionID == obj.PermisionID).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }
                result.Name = obj.Name;
                result.Status = obj.Status;
                result.NgayUpdate = obj.NgayUpdate;
                
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int ThemGroupPer_(tblPermission obj)
        {
            try
            {
                context.tblPermissions.Add(obj);
                context.SaveChanges();
                return obj.PermisionID;
            }
            catch (Exception objEX)
            {
                return 0;
            }
        }
        public bool XoaGroupPer_(tblPermission obj)
        {
            try
            {
                var result = context.tblPermissions.Where(x => x.PermisionID.Equals(obj.PermisionID)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }
                context.tblPermissions.Remove(result);
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

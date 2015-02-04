using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    public class GroupPermission : Process
    {
        public List<tblGroupPermission> LoadDSGroupPermission()
        {
            try
            {
                return context.tblGroupPermissions.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblGroupPermission>();
            }
        }

        public bool ThemGroupPermission(tblGroupPermission obj)
        {
            try
            {
                context.tblGroupPermissions.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool CapNhatGroupPermission(tblGroupPermission obj)
        {
            try
            {
                var result = context.tblGroupPermissions.Where(x => x.GroupID.Equals(obj.GroupID)).FirstOrDefault();
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
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool XoaGroupPermission(tblGroupPermission obj)
        {
            try
            {
                var result = context.tblGroupPermissions.Where(x => x.GroupID.Equals(obj.GroupID)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }

                context.tblGroupPermissions.Remove(result);

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

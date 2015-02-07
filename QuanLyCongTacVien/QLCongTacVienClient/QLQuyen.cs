using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class QLQuyen:Process
    {
         public List<tblPermission> LoadDSPermission()
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

        public bool ThemPermission(tblPermission obj)
        {
            try
            {
                context.tblPermissions.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool CapNhatPermission(tblPermission obj)
        {
            try
            {
                var result = context.tblPermissions.Where(x => x.PermisionID.Equals(obj.PermisionID)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }
                result.Name=obj.Name;
                result.Status = obj.Status;

                
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool XoaPermission(tblPermission obj)
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
            catch (Exception objEX)
            {
                return false;
            }
        }
    }
}

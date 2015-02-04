using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class Site:Process
    {
        public List<tblSite> loadDSSite()
        {
            try
            {
                return context.tblSites.ToList();

            }
            catch (Exception ex)
            {
                return new List<tblSite>();
            }
        }

        public bool ThemSite(tblSite obj)
        {
            try
            {
                context.tblSites.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool CapNhatSite(tblSite obj)
        {
            try
            {
                var result = context.tblSites.Where(x => x.SiteID.Equals(obj.SiteID)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }

                result.SiteName = obj.SiteName;
                result.Title = obj.Title;
                result.TrangThai = obj.TrangThai;
                result.AccountID = obj.AccountID;// con domain
                result.Domain = obj.Domain;
                context.SaveChanges();
                return true;
            }
            catch (Exception objEX)
            {
                return false;
            }
        }

        public bool XoaSite(tblSite obj)
        {
            try
            {
                var result = context.tblSites.Where(x => x.SiteID.Equals(obj.SiteID)).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }

                context.tblSites.Remove(result);

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

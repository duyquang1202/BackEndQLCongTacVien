using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class AboutSite:Process
    {
        public List<tblAboutSite> LoadDSAbout(int SiteID)
        {
            try
            {
                var objAbout = context.tblSites.Find(SiteID);
                if (objAbout == null)
                {
                    return new List<tblAboutSite>();
                }
                return objAbout.tblAboutSites.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblAboutSite>();
            }
        }
        public bool CapNhapAbout(tblAboutSite obj)
        {
            try
            {
                var result = context.tblAboutSites.Where(x => x.AboutID == obj.AboutID).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }
                result.Note = obj.Note;

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

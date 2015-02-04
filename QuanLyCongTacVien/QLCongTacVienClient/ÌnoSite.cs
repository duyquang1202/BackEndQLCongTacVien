using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class InfoSite:Process
    {
        public List<tblInfoSite> LoadDSInfo(int SiteID)
        {
            try
            {
                var objInfo = context.tblSites.Find(SiteID);
                if (objInfo == null)
                {
                    return new List<tblInfoSite>();
                }
                return objInfo.tblInfoSites.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblInfoSite>();
            }
        }
        public bool CapNhapInfo(tblInfoSite obj)
        {
            try
            {
                var result = context.tblInfoSites.Where(x => x.InfoID == obj.InfoID).FirstOrDefault();
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

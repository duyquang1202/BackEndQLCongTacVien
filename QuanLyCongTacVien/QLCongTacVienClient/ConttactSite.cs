using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLCongTacVienClient
{
    class ConttactSite: Process
    {
        public List<tblContactSite> LoadDSContact(int SiteID)
        {
            try
            {
                var objContact = context.tblSites.Find(SiteID);
                if (objContact == null)
                {
                    return new List<tblContactSite>();
                }
                return objContact.tblContactSites.ToList();
            }
            catch (Exception objEX)
            {
                return new List<tblContactSite>();
            }
        }
        public bool CapNhapContact(tblContactSite obj)
        {
            try
            {
                var result = context.tblContactSites.Where(x => x.ContacID == obj.ContacID).FirstOrDefault();
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

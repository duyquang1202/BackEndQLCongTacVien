//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCongTacVienClient
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAboutSite
    {
        public int AboutID { get; set; }
        public string Note { get; set; }
        public Nullable<int> SiteID { get; set; }
    
        public virtual tblSite tblSite { get; set; }
    }
}

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
    
    public partial class Category
    {
        public Category()
        {
            this.tblProducts = new HashSet<tblProduct>();
        }
    
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public Nullable<int> AccountID { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<System.DateTime> NgayUpdate { get; set; }
    
        public virtual ICollection<tblProduct> tblProducts { get; set; }
    }
}

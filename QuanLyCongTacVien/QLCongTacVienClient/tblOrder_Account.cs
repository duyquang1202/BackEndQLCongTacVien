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
    
    public partial class tblOrder_Account
    {
        public long AccountID { get; set; }
        public int OrderID { get; set; }
        public Nullable<double> HueHong { get; set; }
        public Nullable<int> TrangThai { get; set; }
    
        public virtual tblAccount tblAccount { get; set; }
        public virtual tblOrder tblOrder { get; set; }
    }
}

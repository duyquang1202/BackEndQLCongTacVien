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
    
    public partial class tblOrder
    {
        public tblOrder()
        {
            this.tblOrder_Account = new HashSet<tblOrder_Account>();
        }
    
        public int OrderID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<long> MaKhachHang { get; set; }
        public Nullable<double> TongTien { get; set; }
        public Nullable<long> AccountID { get; set; }
        public Nullable<System.DateTime> NgayHen { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<System.DateTime> NgayUpdate { get; set; }
        public Nullable<int> TrangThai { get; set; }
    
        public virtual tblAccount tblAccount { get; set; }
        public virtual tblKhachHang tblKhachHang { get; set; }
        public virtual ICollection<tblOrder_Account> tblOrder_Account { get; set; }
        public virtual tblProduct tblProduct { get; set; }
    }
}

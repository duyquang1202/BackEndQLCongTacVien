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
    
    public partial class tblNhom_KhachHang
    {
        public long MaNhom { get; set; }
        public long MaKhachHang { get; set; }
        public Nullable<int> TrangThai { get; set; }
    
        public virtual tblKhachHang tblKhachHang { get; set; }
        public virtual tblNhom tblNhom { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLycyphergame.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDon
    {
        public string ID_HoaDon { get; set; }
        public string ID_TTDV { get; set; }
        public string ID_May { get; set; }
        public Nullable<System.DateTime> ThoiGianMo { get; set; }
        public Nullable<System.DateTime> ThoiGianTat { get; set; }
        public Nullable<decimal> TongTien { get; set; }
        public string TinhTrangHD { get; set; }
        public string ID_KhachHang { get; set; }
    
        public virtual TaiKhoan TaiKhoan { get; set; }
        public virtual May May { get; set; }
        public virtual ThanhToanDV ThanhToanDV { get; set; }
    }
}

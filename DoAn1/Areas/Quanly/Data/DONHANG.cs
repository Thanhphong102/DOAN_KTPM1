//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn1.Areas.Quanly.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DONHANG
    {
        public string MaDH { get; set; }
        public string MaKH { get; set; }
        public string MaHTTT { get; set; }
        public Nullable<int> TongluongSP { get; set; }
        public Nullable<System.DateTime> TGDathang { get; set; }
        public Nullable<System.DateTime> NgaytaoHD { get; set; }
        public Nullable<int> Tongthanhtoan { get; set; }
        public string Trangthai { get; set; }
    
        public virtual CHITIETHOADON CHITIETHOADON { get; set; }
        public virtual HINHTHUCTHANHTOAN HINHTHUCTHANHTOAN { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}

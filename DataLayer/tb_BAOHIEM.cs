//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_BAOHIEM
    {
        public string SOQUYETDINH { get; set; }
        public Nullable<System.DateTime> NGAYCAP { get; set; }
        public string NOICAP { get; set; }
        public string NOIKHAMBENH { get; set; }
        public Nullable<int> MANV { get; set; }
        public Nullable<int> LOAI { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
    
        public virtual tb_NHANVIEN tb_NHANVIEN { get; set; }
    }
}

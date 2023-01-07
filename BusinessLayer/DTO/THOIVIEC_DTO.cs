using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class THOIVIEC_DTO
    {
        public string SOQD { get; set; }
        public Nullable<int> MANV { get; set; }
        public string HOTEN { get; set; }
        public string NGAYNOPDON { get; set; }
        public string NGAYNGHI { get; set; }
        public string LYDO { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
    }
}

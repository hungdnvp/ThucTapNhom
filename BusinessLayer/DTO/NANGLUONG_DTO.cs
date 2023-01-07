using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class NANGLUONG_DTO
    {
        public string SOQD { get; set; }
        public string SOHD { get; set; }
        public Nullable<int> MANV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<double> HESOLUONGHIENTAI { get; set; }
        public Nullable<double> HESOLUONGMOI { get; set; }
        public string NGAYLENLUONG { get; set; }
        public string NGAYKY { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class DIEUCHUYEN_DTO
    {
        public string SOQD { get; set; }
        public string NGAY { get; set; }
        public Nullable<int> MANV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<int> MAPB { get; set; }
        public string TENPB { get; set; }
        public Nullable<int> MAPB2 { get; set; }
        public string TENPB2 { get; set; }
        public string LYDO { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
    }
}

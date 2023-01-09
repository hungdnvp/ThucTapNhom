using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHANSU
{
    public class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;
        public static DanhSachTaiKhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachTaiKhoan();
                return instance;
            } 
            set => instance = value;
        }

        List<TaiKhoan> listTaiKhoan;
        public List<TaiKhoan> ListTaiKhoan
        {
            get => listTaiKhoan;
            set => listTaiKhoan = value;
        }
        
        DanhSachTaiKhoan()
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("ThaoNgan", "123", TaiKhoan.LoaiTK.quantri));
            listTaiKhoan.Add(new TaiKhoan("David Jones", "david", TaiKhoan.LoaiTK.ketoan));
            listTaiKhoan.Add(new TaiKhoan("Patrick Klose", "patrick", TaiKhoan.LoaiTK.nhansu));
        }
    }
}

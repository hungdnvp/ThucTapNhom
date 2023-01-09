using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHANSU
{
    
    public class TaiKhoan
    {
        private string tenTaiKhoan;
        public string TenTaiKhoan
        {
            get => tenTaiKhoan;
            set => tenTaiKhoan = value;
        }
        private string matKhau;
        public string MatKhau
        {
            get => matKhau;
            set => matKhau = value;
        }

        public enum LoaiTK
        {
            quantri,
            ketoan,
            nhansu
        }
        private LoaiTK loaiTaiKhoan;

        public LoaiTK LoaiTaiKhoan 
        {
            get { return loaiTaiKhoan; } 
            set => loaiTaiKhoan = value; 
        }
        
        private string tenHienThi;

        public string TenHienThi 
        {
            get 
            {
                switch (LoaiTaiKhoan)
                {
                    case LoaiTK.quantri:
                        TenHienThi = "Quản Trị Viên";
                        break;
                    case LoaiTK.ketoan:
                        TenHienThi = "Kế Toán";
                        break;
                    default:
                        TenHienThi = "Nhân Sự";
                        break;
                }
                
                return tenHienThi; 
            } 
            set => tenHienThi = value;
        }
        
        
        public TaiKhoan(string tentaikhoan,string matkhau, LoaiTK loaitaikhoan)
        {
            this.TenTaiKhoan = tentaikhoan;
            this.MatKhau = matkhau;
            this.LoaiTaiKhoan = loaitaikhoan;
        }
    }
}

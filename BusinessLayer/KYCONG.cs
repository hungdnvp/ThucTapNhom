using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KYCONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_KYCONG getItem(int makycong)
        {
            return db.tb_KYCONG.FirstOrDefault(x => x.MAKYCONG == makycong);
        }
        public List<tb_KYCONG> getList()
        {
            return db.tb_KYCONG.ToList();
        }
        public tb_KYCONG Add(tb_KYCONG kc)
        {
            try
            {
                db.tb_KYCONG.Add(kc);
                db.SaveChanges();
                return kc;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_KYCONG Update(tb_KYCONG kc)
        {
            try
            {
                var _kc = db.tb_KYCONG.FirstOrDefault(x => x.MAKYCONG == kc.MAKYCONG);
                _kc.NAM= kc.NAM;
                _kc.THANG = kc.THANG;
                _kc.KHOA = kc.KHOA;
                _kc.NGAYCONGTRONGTHANG = kc.NGAYCONGTRONGTHANG;
                _kc.NGAYTINHCONG = kc.NGAYTINHCONG;
                _kc.TRANGTHAI = kc.TRANGTHAI;
                _kc.UPDATED_BY = 1;
                _kc.UPDATED_DATE = DateTime.Now;
                db.SaveChanges();
                return kc;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int makycong)
        {
            try
            {
                var _kc = db.tb_KYCONG.FirstOrDefault(x => x.MAKYCONG == makycong);
                db.tb_KYCONG.Remove(_kc);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public bool KiemTraPhatSinh(int makycong)
        {
            var kc = db.tb_KYCONG.FirstOrDefault(x => x.MAKYCONG == makycong);
            if (kc == null)
            {
                return false;
            }
            else
            {
                if (kc.TRANGTHAI == true)
                    return true;
                else
                    return false;
            }
        }
    }
}

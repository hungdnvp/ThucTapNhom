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
       
    }
}

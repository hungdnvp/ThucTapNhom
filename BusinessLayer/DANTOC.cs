using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class DANTOC
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_DANTOC getItem(int id)
        {
            return db.tb_DANTOC.FirstOrDefault(x => x.ID == id);
        }
        public List<tb_DANTOC> getList()
        {
            return db.tb_DANTOC.ToList();
        }
        public tb_DANTOC Add(tb_DANTOC dt)
        {
            try
            {
                db.tb_DANTOC.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_DANTOC Update(tb_DANTOC dt)
        {
            try
            {
                var _dt = db.tb_DANTOC.FirstOrDefault(x => x.ID == dt.ID);
                _dt.TENDT = dt.TENDT;
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var _dt = db.tb_DANTOC.FirstOrDefault(x => x.ID == id);
                db.tb_DANTOC.Remove(_dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

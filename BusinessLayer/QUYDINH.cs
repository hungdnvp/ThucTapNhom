using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class QUYDINH
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_CONFIG getItem(int id)
        {
            return db.tb_CONFIG.FirstOrDefault(x => x.ID == id);
        }
        public List<tb_CONFIG> getList()
        {
            return db.tb_CONFIG.ToList();
        }
        public tb_CONFIG Add(tb_CONFIG cf)
        {
            try
            {
                db.tb_CONFIG.Add(cf);
                db.SaveChanges();
                return cf;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_CONFIG Update(tb_CONFIG cf)
        {
            try
            {
                var _cf = db.tb_CONFIG.FirstOrDefault(x => x.ID == cf.ID);
                _cf.NAME = cf.NAME;
                _cf.VALUE = cf.VALUE;
                db.SaveChanges();
                return cf;
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
                var _cf = db.tb_CONFIG.FirstOrDefault(x => x.ID == id);
                db.tb_CONFIG.Remove(_cf);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

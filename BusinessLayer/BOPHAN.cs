using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BOPHAN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_BOPHAN getItem(int id)
        {
            return db.tb_BOPHAN.FirstOrDefault(x => x.IDBP == id);
        }
        public List<tb_BOPHAN> getList()
        {
            return db.tb_BOPHAN.ToList();
        }
        
        public tb_BOPHAN Add(tb_BOPHAN bp)
        {
            try
            {
                db.tb_BOPHAN.Add(bp);
                db.SaveChanges();
                return bp;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_BOPHAN Update(tb_BOPHAN bp)
        {
            try
            {
                var _bp = db.tb_BOPHAN.FirstOrDefault(x => x.IDBP == bp.IDBP);
                _bp.TENBP = bp.TENBP;
                db.SaveChanges();
                return bp;
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
                var _bp = db.tb_BOPHAN.FirstOrDefault(x => x.IDBP == id);
                db.tb_BOPHAN.Remove(_bp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

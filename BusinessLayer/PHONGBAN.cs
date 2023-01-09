using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PHONGBAN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_PHONGBAN getItem(int id)
        {
            return db.tb_PHONGBAN.FirstOrDefault(x => x.IDPB == id);
        }
        public List<tb_PHONGBAN> getList()
        {
            return db.tb_PHONGBAN.ToList();
        }
        public tb_PHONGBAN Add(tb_PHONGBAN pb)
        {
            try
            {
                db.tb_PHONGBAN.Add(pb);
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_PHONGBAN Update(tb_PHONGBAN pb)
        {
            try
            {
                var _pb = db.tb_PHONGBAN.FirstOrDefault(x => x.IDPB == pb.IDPB);
                _pb.TENPB = pb.TENPB;
                db.SaveChanges();
                return pb;
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
                var _pb = db.tb_PHONGBAN.FirstOrDefault(x => x.IDPB == id);
                db.tb_PHONGBAN.Remove(_pb);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BAOHIEM
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_BAOHIEM getItem(string soQD)
        {
            return db.tb_BAOHIEM.FirstOrDefault(x => x.SOQUYETDINH == soQD);
        }
        public List<BAOHIEM_DTO> getListFull(int loai)
        {
            List<tb_BAOHIEM> lstBH = db.tb_BAOHIEM.Where(x => x.LOAI == loai).ToList();
            List<BAOHIEM_DTO> lstDTO = new List<BAOHIEM_DTO>();
            BAOHIEM_DTO bh;
            foreach (var item in lstBH)
            {
                bh = new BAOHIEM_DTO();
                bh.SOQUYETDINH = item.SOQUYETDINH;
                bh.NOIKHAMBENH = item.NOIKHAMBENH;
                bh.NGAYCAP = item.NGAYCAP;
                bh.NOICAP = item.NOICAP;
                bh.LOAI = item.LOAI;
                bh.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                bh.HOTEN = nv.HOTEN;
                bh.UPDATED_BY = item.UPDATED_BY;
                bh.UPDATED_DATE = item.UPDATED_DATE;
                bh.CREATED_BY = item.CREATED_BY;
                bh.CREATED_DATE = item.CREATED_DATE;
                lstDTO.Add(bh);
            }
            return lstDTO;
        }

        public List<tb_BAOHIEM> getList(int loai)
        {
            return db.tb_BAOHIEM.Where(x => x.LOAI == loai).ToList();
        }
        public tb_BAOHIEM Add(tb_BAOHIEM bh)
        {
            try
            {
                db.tb_BAOHIEM.Add(bh);
                db.SaveChanges();
                return bh;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_BAOHIEM Update(tb_BAOHIEM bh)
        {
            try
            {
                tb_BAOHIEM _bh = db.tb_BAOHIEM.FirstOrDefault(x => x.SOQUYETDINH == bh.SOQUYETDINH);
                _bh.NGAYCAP = bh.NGAYCAP;
                _bh.NOICAP = bh.NOICAP;
                _bh.NOIKHAMBENH = bh.NOIKHAMBENH;
                _bh.LOAI = bh.LOAI;
                _bh.MANV = bh.MANV;
                _bh.UPDATED_BY = bh.UPDATED_BY;
                _bh.UPDATED_DATE = bh.UPDATED_DATE;
                db.SaveChanges();
                return bh;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(string soQD)
        {
            try
            {
                var _bh = db.tb_BAOHIEM.FirstOrDefault(x => x.SOQUYETDINH == soQD);
                db.tb_BAOHIEM.Remove(_bh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh(int loai)
        {
            var _bh = db.tb_BAOHIEM.Where(x => x.LOAI == loai).OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_bh != null)
            {
                return _bh.SOQUYETDINH;
            }
            else
                return "00000";
        }
    }
}

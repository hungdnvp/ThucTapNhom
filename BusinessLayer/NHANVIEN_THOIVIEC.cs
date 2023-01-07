using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NHANVIEN_THOIVIEC
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_NHANVIEN_THOIVIEC getItem(string soQD)
        {
            return db.tb_NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == soQD);
        }
        public List<tb_NHANVIEN_THOIVIEC> getList()
        {
            return db.tb_NHANVIEN_THOIVIEC.ToList();
        }
        public List<THOIVIEC_DTO> getListFull()
        {
            var lstTV = db.tb_NHANVIEN_THOIVIEC.ToList();
            List<THOIVIEC_DTO> lstDTO = new List<THOIVIEC_DTO>();
            THOIVIEC_DTO nvDTO;
            foreach (var item in lstTV)
            {
                nvDTO = new THOIVIEC_DTO();
                nvDTO.SOQD = item.SOQD;
                nvDTO.NGAYNOPDON = item.NGAYNOPDON.Value.ToString("dd/MM/yyyy");
                nvDTO.NGAYNGHI = item.NGAYNGHI.Value.ToString("dd/MM/yyyy");

                nvDTO.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                nvDTO.HOTEN = nv.HOTEN;

                nvDTO.LYDO = item.LYDO;
                nvDTO.GHICHU = item.GHICHU;
                nvDTO.UPDATED_BY = item.UPDATED_BY;
                nvDTO.UPDATED_DATE = item.UPDATED_DATE;
                nvDTO.CREATED_BY = item.CREATED_BY;
                nvDTO.CREATED_DATE = item.CREATED_DATE;
                lstDTO.Add(nvDTO);
            }
            return lstDTO;
        }
        public tb_NHANVIEN_THOIVIEC Add(tb_NHANVIEN_THOIVIEC tv)
        {
            try
            {
                db.tb_NHANVIEN_THOIVIEC.Add(tv);
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_NHANVIEN_THOIVIEC Update(tb_NHANVIEN_THOIVIEC tv)
        {
            try
            {
                var _tv = db.tb_NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == tv.SOQD);
                _tv.NGAYNOPDON = tv.NGAYNOPDON;
                _tv.NGAYNGHI = tv.NGAYNGHI;
                _tv.MANV = tv.MANV;
                _tv.LYDO = tv.LYDO;
                _tv.GHICHU = tv.GHICHU;
                _tv.UPDATED_BY = tv.UPDATED_BY;
                _tv.UPDATED_DATE = tv.UPDATED_DATE;
                db.SaveChanges();
                return tv;
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
                var _tv = db.tb_NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == soQD);
                db.tb_NHANVIEN_THOIVIEC.Remove(_tv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh()
        {
            var _nvtv = db.tb_NHANVIEN_THOIVIEC.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_nvtv != null)
            {
                return _nvtv.SOQD;
            }
            else
                return "00000";
        }
    }
}

using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NHANVIEN_NANGLUONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_NHANVIEN_NANGLUONG getItem(string soQD)
        {
            return db.tb_NHANVIEN_NANGLUONG.FirstOrDefault(x => x.SOQD == soQD);
        }
        public List<tb_NHANVIEN_NANGLUONG> getList()
        {
            return db.tb_NHANVIEN_NANGLUONG.ToList();
        }
        public List<NANGLUONG_DTO> getListFull()
        {
            var lstNL = db.tb_NHANVIEN_NANGLUONG.ToList();
            List<NANGLUONG_DTO> lstDTO = new List<NANGLUONG_DTO>();
            NANGLUONG_DTO nlDTO;
            foreach (var item in lstNL)
            {
                nlDTO = new NANGLUONG_DTO();
                nlDTO.SOQD = item.SOQD;
                nlDTO.SOHD = item.SOHD;
                nlDTO.NGAYLENLUONG = item.NGAYLENLUONG.Value.ToString("dd/MM/yyyy");
                nlDTO.NGAYKY = item.NGAYKY.Value.ToString("dd/MM/yyyy");

                nlDTO.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                nlDTO.HOTEN = nv.HOTEN;

                nlDTO.HESOLUONGHIENTAI = item.HESOLUONGHIENTAI;
                nlDTO.HESOLUONGMOI = item.HESOLUONGMOI;
                nlDTO.GHICHU = item.GHICHU;
                nlDTO.UPDATED_BY = item.UPDATED_BY;
                nlDTO.UPDATED_DATE = item.UPDATED_DATE;
                nlDTO.CREATED_BY = item.CREATED_BY;
                nlDTO.CREATED_DATE = item.CREATED_DATE;
                nlDTO.DELETED_BY = item.DELETED_BY;
                nlDTO.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(nlDTO);
            }
            return lstDTO;
        }
        public tb_NHANVIEN_NANGLUONG Add(tb_NHANVIEN_NANGLUONG nl)
        {
            try
            {
                db.tb_NHANVIEN_NANGLUONG.Add(nl);
                db.SaveChanges();
                return nl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_NHANVIEN_NANGLUONG Update(tb_NHANVIEN_NANGLUONG nl)
        {
            try
            {
                var _nl = db.tb_NHANVIEN_NANGLUONG.FirstOrDefault(x => x.SOQD == nl.SOQD);
                _nl.SOHD = nl.SOHD;
                _nl.HESOLUONGHIENTAI = nl.HESOLUONGHIENTAI;
                _nl.HESOLUONGMOI = nl.HESOLUONGMOI;
                _nl.NGAYKY = nl.NGAYKY;
                _nl.NGAYLENLUONG= nl.NGAYLENLUONG;
                _nl.MANV = nl.MANV;
                _nl.GHICHU = nl.GHICHU;
                _nl.UPDATED_BY = nl.UPDATED_BY;
                _nl.UPDATED_DATE = nl.UPDATED_DATE;
                _nl.DELETED_BY = nl.DELETED_BY;
                _nl.DELETED_DATE = nl.DELETED_DATE;
                db.SaveChanges();
                return nl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(string soQD, int manv)
        {
            try
            {
                var _nl = db.tb_NHANVIEN_NANGLUONG.FirstOrDefault(x => x.SOQD == soQD);
                _nl.DELETED_BY = manv;
                _nl.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh()
        {
            var _nvnl = db.tb_NHANVIEN_NANGLUONG.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_nvnl != null)
            {
                return _nvnl.SOQD;
            }
            else
                return "00000";
        }
    }
}

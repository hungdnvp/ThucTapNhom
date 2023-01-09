using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KHENTHUONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_KHENTHUONG getItem(string soQD)
        {
            return db.tb_KHENTHUONG.FirstOrDefault(x => x.SOQUYETDINH == soQD);
        }
        public List<KHENTHUONG_DTO> getItemFull(string soQD)
        {
            List<tb_KHENTHUONG> lstKT = db.tb_KHENTHUONG.Where(x => x.SOQUYETDINH == soQD).ToList();
            List<KHENTHUONG_DTO> lstDTO = new List<KHENTHUONG_DTO>();
            KHENTHUONG_DTO kt;
            foreach (var item in lstKT)
            {
                kt = new KHENTHUONG_DTO();
                kt.SOQUYETDINH = item.SOQUYETDINH;
                kt.NOIDUNG = item.NOIDUNG;
                kt.NGAY = item.NGAY.Value.ToString("dd/MM/yyyy");
                kt.LYDO = item.LYDO;
                kt.LOAI = item.LOAI;
                kt.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                kt.HOTEN = nv.HOTEN;
                kt.UPDATED_BY = item.UPDATED_BY;
                kt.UPDATED_DATE = item.UPDATED_DATE;
                kt.CREATED_BY = item.CREATED_BY;
                kt.CREATED_DATE = item.CREATED_DATE;
                lstDTO.Add(kt);
            }
            return lstDTO;
        }
        public List<KHENTHUONG_DTO> getListFull(int loai)
        {
            List<tb_KHENTHUONG> lstKT = db.tb_KHENTHUONG.Where(x=>x.LOAI==loai).ToList();
            List<KHENTHUONG_DTO> lstDTO = new List<KHENTHUONG_DTO>();
            KHENTHUONG_DTO kt;
            foreach (var item in lstKT)
            {
                kt = new KHENTHUONG_DTO();
                kt.SOQUYETDINH = item.SOQUYETDINH;
                kt.NOIDUNG = item.NOIDUNG;
                kt.NGAY = item.NGAY.Value.ToString("dd/MM/yyyy");
                kt.LYDO = item.LYDO;
                kt.LOAI = item.LOAI;
                kt.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                kt.HOTEN = nv.HOTEN;
                kt.UPDATED_BY = item.UPDATED_BY;
                kt.UPDATED_DATE = item.UPDATED_DATE;
                kt.CREATED_BY = item.CREATED_BY;
                kt.CREATED_DATE = item.CREATED_DATE;
                lstDTO.Add(kt);
            }
            return lstDTO;
        }
        public List<tb_KHENTHUONG> getList(int loai)
        {
            return db.tb_KHENTHUONG.Where(x => x.LOAI == loai).ToList();
        }
        public tb_KHENTHUONG Add(tb_KHENTHUONG kt)
        {
            try
            {
                db.tb_KHENTHUONG.Add(kt);
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_KHENTHUONG Update(tb_KHENTHUONG kt)
        {
            try
            {
                tb_KHENTHUONG _kt = db.tb_KHENTHUONG.FirstOrDefault(x=>x.SOQUYETDINH==kt.SOQUYETDINH);
                _kt.NGAY = kt.NGAY;
                _kt.LYDO = kt.LYDO;
                _kt.NOIDUNG = kt.NOIDUNG;
                _kt.LOAI = kt.LOAI;
                _kt.MANV = kt.MANV;
                _kt.UPDATED_BY = kt.UPDATED_BY;
                _kt.UPDATED_DATE = kt.UPDATED_DATE;
                db.SaveChanges();
                return kt;
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
                var _kt = db.tb_KHENTHUONG.FirstOrDefault(x => x.SOQUYETDINH == soQD);
                db.tb_KHENTHUONG.Remove(_kt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh(int loai)
        {
            var _kt = db.tb_KHENTHUONG.Where(x=>x.LOAI == loai).OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_kt != null)
            {
                return _kt.SOQUYETDINH;
            }
            else
                return "00000";
        }
    }
}

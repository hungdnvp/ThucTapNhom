using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KYLUAT
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_KYLUAT getItem(string soQD)
        {
            return db.tb_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == soQD);
        }
        public List<KYLUAT_DTO> getItemFull(string soQD)
        {
            List<tb_KYLUAT> lstKL = db.tb_KYLUAT.Where(x => x.SOQUYETDINH == soQD).ToList();
            List<KYLUAT_DTO> lstDTO = new List<KYLUAT_DTO>();
            KYLUAT_DTO kl;
            foreach (var item in lstKL)
            {
                kl = new KYLUAT_DTO();
                kl.SOQUYETDINH = item.SOQUYETDINH;
                kl.NOIDUNG = item.NOIDUNG;
                kl.LYDO = item.LYDO;
                kl.LOAI = item.LOAI;
                kl.MANV = item.MANV;
                kl.TUNGAY = item.TUNGAY.Value.ToString("dd/MM/yyyy");
                kl.DENNGAY = item.DENNGAY.Value.ToString("dd/MM/yyyy");
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                kl.HOTEN = nv.HOTEN;
                kl.UPDATED_BY = item.UPDATED_BY;
                kl.UPDATED_DATE = item.UPDATED_DATE;
                kl.CREATED_BY = item.CREATED_BY;
                kl.CREATED_DATE = item.CREATED_DATE;
                lstDTO.Add(kl);
            }
            return lstDTO;
        }
        public List<KYLUAT_DTO> getListFull(int loai)
        {
            List<tb_KYLUAT> lstKL = db.tb_KYLUAT.Where(x => x.LOAI == loai).ToList();
            List<KYLUAT_DTO> lstDTO = new List<KYLUAT_DTO>();
            KYLUAT_DTO kl;
            foreach (var item in lstKL)
            {
                kl = new KYLUAT_DTO();
                kl.SOQUYETDINH = item.SOQUYETDINH;
                kl.NOIDUNG = item.NOIDUNG;
                kl.LYDO = item.LYDO;
                kl.LOAI = item.LOAI;
                kl.MANV = item.MANV;
                kl.TUNGAY = item.TUNGAY.Value.ToString("dd/MM/yyyy");
                kl.DENNGAY = item.DENNGAY.Value.ToString("dd/MM/yyyy");
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                kl.HOTEN = nv.HOTEN;
                kl.UPDATED_BY = item.UPDATED_BY;
                kl.UPDATED_DATE = item.UPDATED_DATE;
                kl.CREATED_BY = item.CREATED_BY;
                kl.CREATED_DATE = item.CREATED_DATE;
                lstDTO.Add(kl);
            }
            return lstDTO;
        }
        public List<tb_KYLUAT> getList(int loai)
        {
            return db.tb_KYLUAT.Where(x => x.LOAI == loai).ToList();
        }
        public tb_KYLUAT Add(tb_KYLUAT kl)
        {
            try
            {
                db.tb_KYLUAT.Add(kl);
                db.SaveChanges();
                return kl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_KYLUAT Update(tb_KYLUAT kl)
        {
            try
            {
                tb_KYLUAT _kl = db.tb_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == kl.SOQUYETDINH);
                _kl.LYDO = kl.LYDO;
                _kl.TUNGAY = kl.TUNGAY;
                _kl.DENNGAY = kl.DENNGAY;
                _kl.NOIDUNG = kl.NOIDUNG;
                _kl.LOAI = kl.LOAI;
                _kl.MANV = kl.MANV;
                _kl.UPDATED_BY = kl.UPDATED_BY;
                _kl.UPDATED_DATE = kl.UPDATED_DATE;
                db.SaveChanges();
                return kl;
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
                var _kl = db.tb_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == soQD);
                db.tb_KYLUAT.Remove(_kl);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh(int loai)
        {
            var _kl = db.tb_KYLUAT.Where(x => x.LOAI == loai).OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_kl != null)
            {
                return _kl.SOQUYETDINH;
            }
            else
                return "00000";
        }
    }
}


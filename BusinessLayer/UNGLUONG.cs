using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UNGLUONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_UNGLUONG getItem(int id)
        {
            return db.tb_UNGLUONG.FirstOrDefault(x => x.ID == id);
        }
        public List<tb_UNGLUONG> getList()
        {
            return db.tb_UNGLUONG.ToList();
        }
        public List<UNGLUONG_DTO> getListFull()
        {
            var lstUL = db.tb_UNGLUONG.ToList();
            List<UNGLUONG_DTO> lstDTO = new List<UNGLUONG_DTO>();
            UNGLUONG_DTO dto;
            foreach (var item in lstUL)
            {
                dto = new UNGLUONG_DTO();
                dto.ID = item.ID;
                dto.NAM = item.NAM;
                dto.THANG = item.THANG;
                dto.NGAY = item.NGAY;
                dto.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                dto.HOTEN = nv.HOTEN;
                dto.SOTIEN = item.SOTIEN;
                dto.GHICHU = item.GHICHU;
                dto.CREATED_BY = item.CREATED_BY;
                dto.CREATED_DATE = item.CREATED_DATE;
                dto.UPDATED_BY = item.UPDATED_BY;
                dto.UPDATED_DATE = item.UPDATED_DATE;
                lstDTO.Add(dto);
            }
            return lstDTO;
        }
        public tb_UNGLUONG Add(tb_UNGLUONG ul)
        {
            try
            {
                db.tb_UNGLUONG.Add(ul);
                db.SaveChanges();
                return ul;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_UNGLUONG Update(tb_UNGLUONG ul)
        {
            try
            {
                var _ul = db.tb_UNGLUONG.FirstOrDefault(x => x.ID == ul.ID);
                _ul.NAM = ul.NAM;
                _ul.THANG = ul.THANG;
                _ul.NGAY = ul.NGAY;
                _ul.SOTIEN = ul.SOTIEN;
                _ul.MANV = ul.MANV;
                _ul.GHICHU = ul.GHICHU;
                _ul.UPDATED_BY = 1;
                _ul.UPDATED_DATE = DateTime.Now;
                db.SaveChanges();
                return ul;
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
                var _ul = db.tb_UNGLUONG.FirstOrDefault(x => x.ID == id);
                db.tb_UNGLUONG.Remove(_ul);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class NHANVIEN_DIEUCHUYEN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_NHANVIEN_DIEUCHUYEN getItem(string soqd)
        {
            return db.tb_NHANVIEN_DIEUCHUYEN.FirstOrDefault(x => x.SOQD == soqd);
        }
        public List<tb_NHANVIEN_DIEUCHUYEN> getList()
        {
            return db.tb_NHANVIEN_DIEUCHUYEN.ToList();
        }
        public List<DIEUCHUYEN_DTO> getListFull()
        {
            var lstDC = db.tb_NHANVIEN_DIEUCHUYEN.ToList();
            List<DIEUCHUYEN_DTO> lstDTO = new List<DIEUCHUYEN_DTO>();
            DIEUCHUYEN_DTO nvDTO;
            foreach (var item in lstDC)
            {
                nvDTO = new DIEUCHUYEN_DTO();
                nvDTO.SOQD = item.SOQD;
                nvDTO.NGAY = item.NGAY.Value.ToString("dd/MM/yyyy");

                nvDTO.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                nvDTO.HOTEN = nv.HOTEN;

                nvDTO.MAPB = item.MAPB;
                var pb = db.tb_PHONGBAN.FirstOrDefault(p => p.IDPB== item.MAPB);
                nvDTO.TENPB = pb.TENPB;

                nvDTO.MAPB2 = item.MAPB2;
                var pb2 = db.tb_PHONGBAN.FirstOrDefault(p2 => p2.IDPB== item.MAPB2);
                nvDTO.TENPB2 = pb2.TENPB;

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
        public tb_NHANVIEN_DIEUCHUYEN Add(tb_NHANVIEN_DIEUCHUYEN dc)
        {
            try
            {
                db.tb_NHANVIEN_DIEUCHUYEN.Add(dc);
                db.SaveChanges();
                return dc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_NHANVIEN_DIEUCHUYEN Update(tb_NHANVIEN_DIEUCHUYEN dc)
        {
            try
            {
                var _dc = db.tb_NHANVIEN_DIEUCHUYEN.FirstOrDefault(x => x.SOQD == dc.SOQD);
                _dc.MAPB2 = dc.MAPB2;
                _dc.MANV = dc.MANV;
                _dc.NGAY = dc.NGAY;
                _dc.LYDO = dc.LYDO;
                _dc.GHICHU = dc.GHICHU;
                _dc.UPDATED_BY = dc.UPDATED_BY;
                _dc.UPDATED_DATE = dc.UPDATED_DATE;
                db.SaveChanges();
                return dc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(string soqd)
        {
            try
            {
                var _dc = db.tb_NHANVIEN_DIEUCHUYEN.FirstOrDefault(x => x.SOQD == soqd);
                db.tb_NHANVIEN_DIEUCHUYEN.Remove(_dc);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh()
        {
            var _nvdc = db.tb_NHANVIEN_DIEUCHUYEN.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_nvdc != null)
            {
                return _nvdc.SOQD;
            }
            else
                return "00000";
        }
    }
}

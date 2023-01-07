using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NHANVIEN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_NHANVIEN getItem(int id)
        {
            return db.tb_NHANVIEN.FirstOrDefault(x => x.MANV == id);
        }
        public List<tb_NHANVIEN> getList()
        {
            return db.tb_NHANVIEN.ToList();
        }
        public NHANVIEN_DTO getItemFull(int id)
        {
            var item = db.tb_NHANVIEN.FirstOrDefault(x=>x.MANV==id);
            NHANVIEN_DTO nvDTO = new NHANVIEN_DTO();
                nvDTO.MANV = item.MANV;
                nvDTO.HOTEN = item.HOTEN;
                nvDTO.NGAYSINH = item.NGAYSINH;
                nvDTO.GIOITINH = item.GIOITINH;
                nvDTO.CCCD = item.CCCD;
                nvDTO.DIENTHOAI = item.DIENTHOAI;
                nvDTO.DIACHI = item.DIACHI;
                nvDTO.HINHANH = item.HINHANH;
                nvDTO.DATHOIVIEC = item.DATHOIVIEC;

                nvDTO.IDBP = item.IDBP;
                var bp = db.tb_BOPHAN.FirstOrDefault(b => b.IDBP == item.IDBP);
                nvDTO.TENBP = bp.TENBP;

                nvDTO.IDCV = item.IDCV;
                var cv = db.tb_CHUCVU.FirstOrDefault(c => c.IDCV == item.IDCV);
                nvDTO.TENCV = cv.TENCV;

                nvDTO.IDPB = item.IDPB;
                var pb = db.tb_PHONGBAN.FirstOrDefault(p => p.IDPB == item.IDPB);
                nvDTO.TENPB = pb.TENPB;

                nvDTO.IDTD = item.IDTD;
                var td = db.tb_TRINHDO.FirstOrDefault(t => t.IDTD == item.IDTD);
                nvDTO.TENTD = td.TENTD;

                nvDTO.IDDT = item.IDDT;
                var dt = db.tb_DANTOC.FirstOrDefault(d => d.ID == item.IDDT);
                nvDTO.TENDT = dt.TENDT;

                nvDTO.IDTG = item.IDTG;
                var tg = db.tb_TONGIAO.FirstOrDefault(t => t.ID == item.IDTG);
                nvDTO.TENTG = tg.TENTG;

                
            
            return nvDTO;
        }
        public List<NHANVIEN_DTO> getListFull()
        {
            var lstNV = db.tb_NHANVIEN.ToList();
            List<NHANVIEN_DTO> lstNVDTO = new List<NHANVIEN_DTO>();
            NHANVIEN_DTO nvDTO;
            foreach(var item in lstNV)
            {
                nvDTO = new NHANVIEN_DTO();
                nvDTO.MANV = item.MANV;
                nvDTO.HOTEN= item.HOTEN;
                nvDTO.NGAYSINH = item.NGAYSINH;
                nvDTO.GIOITINH = item.GIOITINH;
                nvDTO.CCCD = item.CCCD;
                nvDTO.DIENTHOAI = item.DIENTHOAI;
                nvDTO.DIACHI = item.DIACHI;
                nvDTO.HINHANH= item.HINHANH;
                nvDTO.DATHOIVIEC = item.DATHOIVIEC;

                nvDTO.IDBP = item.IDBP;
                var bp = db.tb_BOPHAN.FirstOrDefault(b => b.IDBP == item.IDBP);
                nvDTO.TENBP = bp.TENBP;

                nvDTO.IDCV = item.IDCV;
                var cv = db.tb_CHUCVU.FirstOrDefault(c => c.IDCV == item.IDCV);
                nvDTO.TENCV = cv.TENCV;

                nvDTO.IDPB = item.IDPB;
                var pb = db.tb_PHONGBAN.FirstOrDefault(p => p.IDPB == item.IDPB);
                nvDTO.TENPB = pb.TENPB;

                nvDTO.IDTD = item.IDTD;
                var td = db.tb_TRINHDO.FirstOrDefault(t => t.IDTD == item.IDTD);
                nvDTO.TENTD = td.TENTD;

                nvDTO.IDDT = item.IDDT;
                var dt = db.tb_DANTOC.FirstOrDefault(d => d.ID == item.IDDT);
                nvDTO.TENDT = dt.TENDT;

                nvDTO.IDTG = item.IDTG;
                var tg = db.tb_TONGIAO.FirstOrDefault(t => t.ID == item.IDTG);
                nvDTO.TENTG = tg.TENTG;

                lstNVDTO.Add(nvDTO);
            }
            return lstNVDTO;
        }
        public tb_NHANVIEN Add(tb_NHANVIEN nv)
        {
            try
            {
                db.tb_NHANVIEN.Add(nv);
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_NHANVIEN Update(tb_NHANVIEN nv)
        {
            try
            {
                var _nv = db.tb_NHANVIEN.FirstOrDefault(x => x.MANV == nv.MANV);
                _nv.HOTEN = nv.HOTEN;
                _nv.GIOITINH = nv.GIOITINH;
                _nv.NGAYSINH = nv.NGAYSINH;
                _nv.CCCD = nv.CCCD;
                _nv.DIENTHOAI = nv.DIENTHOAI;
                _nv.DIACHI = nv.DIACHI;
                _nv.HINHANH = nv.HINHANH;
                _nv.DATHOIVIEC = nv.DATHOIVIEC;
                _nv.IDBP = nv.IDBP;
                _nv.IDCV = nv.IDCV;
                _nv.IDPB = nv.IDPB;
                _nv.IDTD = nv.IDTD;
                _nv.IDDT = nv.IDDT;
                _nv.IDTG = nv.IDTG;
                _nv.MACTY = nv.MACTY;
                db.SaveChanges();
                return nv;
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
                var _nv = db.tb_NHANVIEN.FirstOrDefault(x => x.MANV == id);
                db.tb_NHANVIEN.Remove(_nv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public List<tb_NHANVIEN> getSinhNhat()
        {
            db.Database.Connection.Open();
            return db.tb_NHANVIEN.Where(x => x.NGAYSINH.Value.Month == DateTime.Now.Month).ToList();
        }
    }
}

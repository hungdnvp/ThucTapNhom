using BusinessLayer.DTO;
using BusinessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace QLNHANSU
{
    public partial class frmBaoHiem : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoHiem()
        {
            InitializeComponent();
        }
        private void frmBaoHiem_Load(object sender, EventArgs e)
        {
            _bh = new BAOHIEM();
            _nhanvien = new NHANVIEN();
            _them = false;
            _showHide(true);
            loadData();
            loadNhanVien();
        }
        void _showHide(bool bh)
        {
            btnLuu.Enabled = !bh;
            btnHuy.Enabled = !bh;
            btnThem.Enabled = bh;
            btnSua.Enabled = bh;
            btnXoa.Enabled = bh;
            btnDong.Enabled = bh;
            txtSoQD.Enabled = !bh;
            txtLyDo.Enabled = !bh;
            txtNoiDung.Enabled = !bh;
            dtNgay.Enabled = !bh;
            slkNhanVien.Enabled = !bh;



        }
        void _reset()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtNoiDung.Text = string.Empty;

        }
        void loadNhanVien()
        {
            
            slkNhanVien.Properties = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }
        void loadData()
        {
            gcDanhSach.DataSource = _bh.getListFull(1);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void SaveData()
        {
            if (_them)
            {
                var maxSoQD = _bh.MaxSoQuyetDinh(1);
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                tb_BAOHIEM bh = new tb_BAOHIEM();
                bh.SOQUYETDINH = so.ToString("00000") + @"/QĐBH";
                bh.NOICAP = txtLyDo.Text;
                bh.NOIKHAMBENH = txtNoiDung.Text;
                bh.NGAYCAP = dtNgay.Value;
                bh.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                bh.LOAI = 1;
                bh.CREATED_BY = 1;
                bh.CREATED_DATE = DateTime.Now;
                _bh.Add(bh);

            }
            else
            {
                var bh = _bh.getItem(_soQD);
                bh.NOICAP = txtLyDo.Text;
                bh.NOIKHAMBENH = txtNoiDung.Text;
                bh.NGAYCAP = dtNgay.Value;
                bh.MANV = EditValue.ToString());
                bh.UPDATED_BY = 1;
                bh.UPDATED_DATE = DateTime.Now;
                _bh.Update(bh);

            }


        }
        void SyLogBaoHiem(int id){
            int maBH = 0;
            var maxSoQD = _bh.MaxSoQuyetDinh(1);
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                tb_BAOHIEM bh = new tb_BAOHIEM();
                bh.SOQUYETDINH = so.ToString("00000") + @"/QĐBH";
                bh.NOICAP = txtLyDo.Text;
                bh.NOIKHAMBENH = txtNoiDung.Text;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            _reset();
        }
    }
}
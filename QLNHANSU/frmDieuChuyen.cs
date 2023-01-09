using BusinessLayer;
using DataLayer;
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

namespace QLNHANSU
{
    public partial class frmDieuChuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmDieuChuyen()
        {
            InitializeComponent();
        }
        NHANVIEN_DIEUCHUYEN _nvdc;
        NHANVIEN _nhanvien;
        PHONGBAN _phongban;
        bool _them;
        string _soQD;

        private void frmDieuChuyen_Load(object sender, EventArgs e)
        {
            _nvdc = new NHANVIEN_DIEUCHUYEN();
            _nhanvien = new NHANVIEN();
            _phongban = new PHONGBAN();
            _them = false;
            _showHide(true);
            loadData();
            loadNhanVien();
            loadDonViDen();
        }
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            txtSoQD.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
            dtNgay.Enabled = !kt;
            cboDonViDen.Enabled = !kt;
            slkNhanVien.Enabled = !kt;



        }
        void _reset()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtGhiChu.Text = string.Empty;

        }
        void loadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getListFull();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }
        void loadDonViDen()
        {
            cboDonViDen.DataSource = _phongban.getList();
            cboDonViDen.ValueMember = "IDPB";
            cboDonViDen.DisplayMember = "TENPB";
        }
        void loadData()
        {
            gcDanhSach.DataSource = _nvdc.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            _reset();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nvdc.Delete(_soQD);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            _reset();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            tb_NHANVIEN_DIEUCHUYEN dc;
            if (_them)
            {
                var maxSoQD = _nvdc.MaxSoQuyetDinh();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                dc = new tb_NHANVIEN_DIEUCHUYEN();
                dc.SOQD = so.ToString("00000") + @"/"+DateTime.Now.Year.ToString()+@"/QĐĐC";
                dc.LYDO = txtLyDo.Text;
                dc.GHICHU = txtGhiChu.Text;
                dc.NGAY = dtNgay.Value;
                dc.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                dc.MAPB = _nhanvien.getItem(int.Parse(slkNhanVien.EditValue.ToString())).IDPB;
                dc.MAPB2 = int.Parse(cboDonViDen.SelectedValue.ToString());
                dc.CREATED_BY = 1;
                dc.CREATED_DATE = DateTime.Now;
                _nvdc.Add(dc);

            }
            else
            {
                dc = _nvdc.getItem(_soQD);
                dc.LYDO = txtLyDo.Text;
                dc.GHICHU = txtGhiChu.Text;
                dc.NGAY = dtNgay.Value;
                dc.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                dc.MAPB2 = int.Parse(cboDonViDen.SelectedValue.ToString());
                dc.UPDATED_BY = 1;
                dc.UPDATED_DATE = DateTime.Now;
                _nvdc.Update(dc);

            }
            var nv = _nhanvien.getItem(dc.MANV.Value);
            nv.IDPB = dc.MAPB2;
            _nhanvien.Update(nv);


        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soQD = gvDanhSach.GetFocusedRowCellValue("SOQD").ToString();
                var dc = _nvdc.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtNgay.Value = dc.NGAY.Value;
                slkNhanVien.EditValue = dc.MANV;
                txtGhiChu.Text = dc.GHICHU;
                txtLyDo.Text = dc.LYDO;
                cboDonViDen.SelectedValue = dc.MAPB2;

            }
        }
    }
}
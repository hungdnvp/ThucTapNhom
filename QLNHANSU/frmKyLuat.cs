using BusinessLayer;
using BusinessLayer.DTO;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QLNHANSU.Reports;
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
    public partial class frmKyLuat : DevExpress.XtraEditors.XtraForm
    {
        public frmKyLuat()
        {
            InitializeComponent();
        }
        KYLUAT _ktkl;
        NHANVIEN _nhanvien;
        bool _them;
        string _soQD;
        List<KYLUAT_DTO> _lstKL;

        private void frmKyLuat_Load(object sender, EventArgs e)
        {
            _ktkl = new KYLUAT();
            _nhanvien = new NHANVIEN();
            _them = false;
            _showHide(true);
            loadData();
            loadNhanVien();
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
            txtNoiDung.Enabled = !kt;
            dtTuNgay.Enabled = !kt;
            dtDenNgay.Enabled = !kt;
            slkNhanVien.Enabled = !kt;



        }
        void _reset()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            dtDenNgay.Value = DateTime.Now;
            dtDenNgay.Value = dtDenNgay.Value.AddMonths(6);
        }
        void loadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }
        void loadData()
        {
            gcDanhSach.DataSource = _ktkl.getListFull(2);
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
            _showHide(false); _them = false;
            _showHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _ktkl.Delete(_soQD);
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
            _lstKL = _ktkl.getItemFull(_soQD);
            rptKyLuat rpt = new rptKyLuat(_lstKL);
            rpt.ShowRibbonPreview();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if (_them)
            {
                var maxSoQD = _ktkl.MaxSoQuyetDinh(2);
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                tb_KYLUAT kl = new tb_KYLUAT();
                kl.SOQUYETDINH = so.ToString("00000") + @"/QĐKL";
                kl.LYDO = txtLyDo.Text;
                kl.NOIDUNG = txtNoiDung.Text;
                kl.TUNGAY = dtTuNgay.Value;
                kl.DENNGAY = dtDenNgay.Value;
                kl.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                kl.LOAI = 2;
                kl.CREATED_BY = 1;
                kl.CREATED_DATE = DateTime.Now;
                _ktkl.Add(kl);

            }
            else
            {
                var kl = _ktkl.getItem(_soQD);
                kl.TUNGAY = dtTuNgay.Value;
                kl.DENNGAY = dtDenNgay.Value;
                kl.LYDO = txtLyDo.Text;
                kl.NOIDUNG = txtNoiDung.Text;
                kl.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                kl.UPDATED_BY = 1;
                kl.UPDATED_DATE = DateTime.Now;
                _ktkl.Update(kl);

            }


        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soQD = gvDanhSach.GetFocusedRowCellValue("SOQUYETDINH").ToString();
                var kl = _ktkl.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtTuNgay.Value = kl.TUNGAY.Value;
                dtDenNgay.Value = kl.DENNGAY.Value;
                slkNhanVien.EditValue = kl.MANV;
                txtNoiDung.Text = kl.NOIDUNG;
                txtLyDo.Text = kl.LYDO;
                _lstKL = _ktkl.getItemFull(_soQD);

            }
        }
    }
}
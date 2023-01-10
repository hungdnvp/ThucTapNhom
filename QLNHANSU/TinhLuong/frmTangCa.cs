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

namespace QLNHANSU.TinhLuong
{
    public partial class frmTangCa : DevExpress.XtraEditors.XtraForm
    {
        public frmTangCa()
        {
            InitializeComponent();
        }
        TANGCA _tc;
        NHANVIEN _nv;
        LOAICA _lc;
        SYS_CONFIG _config;
        bool _them;
        int _id;

        private void frmTangCa_Load(object sender, EventArgs e)
        {
            _them = false;
            _tc = new TANGCA();
            _nv = new NHANVIEN();
            _lc = new LOAICA();
            _config = new SYS_CONFIG();
            _showHide(true);
            loadData();
            loadNhanVien();
            loadLoaiCa();
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
            txtNoiDung.Enabled = !kt;
            spSoGio.Enabled = !kt;
            lkNhanVien.Enabled = !kt;
            cboLoaiCa.Enabled = !kt;
        }
        void loadNhanVien()
        {
            lkNhanVien.Properties.DataSource = _nv.getListFull();
            lkNhanVien.Properties.DisplayMember = "HOTEN";
            lkNhanVien.Properties.ValueMember = "MANV";
        }
        void loadLoaiCa()
        {
            cboLoaiCa.DataSource = _lc.getList();
            cboLoaiCa.DisplayMember = "TENLOAICA";
            cboLoaiCa.ValueMember = "IDLOAICA";
        }
        void loadData()
        {
            gcDanhSach.DataSource = _tc.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            txtNoiDung.Text = string.Empty;
            spSoGio.EditValue = 0;
            lkNhanVien.EditValue = 0;
            cboLoaiCa.SelectedIndex = 0;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _tc.Delete(_id);
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
            txtNoiDung.Text = string.Empty;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if (_them)
            {
                tb_TANGCA tc = new tb_TANGCA();
                tc.IDLOAICA = int.Parse(cboLoaiCa.SelectedValue.ToString());
                tc.SOGIO = int.Parse(spSoGio.EditValue.ToString());
                tc.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                tc.GHICHU = txtNoiDung.Text;
                tc.NGAY = DateTime.Now.Day;
                tc.THANG = DateTime.Now.Month;
                tc.NAM = DateTime.Now.Year;
                var lc = _lc.getItem(int.Parse(cboLoaiCa.SelectedValue.ToString()));
                var cg = _config.getItem("TANGCA");
                tc.SOTIEN = tc.SOGIO * lc.HESO * int.Parse(cg.VALUE);

                tc.CREATED_BY = 1;
                tc.CREATED_DATE = DateTime.Now;
                _tc.Add(tc);
            }
            else
            {
                var tc = _tc.getItem(_id);
                tc.IDLOAICA = int.Parse(cboLoaiCa.SelectedValue.ToString());
                tc.SOGIO = int.Parse(spSoGio.EditValue.ToString());
                tc.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                tc.GHICHU = txtNoiDung.Text;
                tc.NGAY = DateTime.Now.Day;
                tc.THANG = DateTime.Now.Month;
                tc.NAM = DateTime.Now.Year;
                var lc = _lc.getItem(int.Parse(cboLoaiCa.SelectedValue.ToString()));
                var cg = _config.getItem("TANGCA");
                tc.SOTIEN = tc.SOGIO * lc.HESO * int.Parse(cg.VALUE);

                tc.UPDATED_BY = 1;
                tc.UPDATED_DATE = DateTime.Now;
                _tc.Update(tc);

            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                txtNoiDung.Text = gvDanhSach.GetFocusedRowCellValue("GHICHU").ToString();
                spSoGio.EditValue = gvDanhSach.GetFocusedRowCellValue("SOGIO");
                lkNhanVien.EditValue = gvDanhSach.GetFocusedRowCellValue("MANV");
                cboLoaiCa.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDLOAICA");

            }
        }
    }
}
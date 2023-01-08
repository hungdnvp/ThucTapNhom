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
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }
        void loadData()
        {
            gcDanhSach.DataSource = _bh.getListFull(1);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
    }
}
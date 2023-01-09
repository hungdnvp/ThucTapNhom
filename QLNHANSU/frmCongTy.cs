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
    public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
    {
        public frmCongTy()
        {
            InitializeComponent();
        }
        CONGTY _congty;
        bool _them;
        int _id;
        private void frmCongTy_Load(object sender, EventArgs e)
        {
            _them = false;
            _congty = new CONGTY();
            _showHide(true);
            loadData();
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
            txtTenCT.Enabled = !kt;
            txtEmail.Enabled = !kt;
            txtDienThoai.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _congty.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            txtTenCT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
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
                _congty.Delete(_id);
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
            txtTenCT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
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
            if (_them)
            {
                tb_CONGTY ct = new tb_CONGTY();
                ct.TENCTY = txtTenCT.Text;
                ct.EMAIL = txtEmail.Text;
                ct.DIENTHOAI = txtDienThoai.Text;
                ct.DIACHI = txtDiaChi.Text;
                _congty.Add(ct);
            }
            else
            {
                var ct = _congty.getItem(_id);
                ct.TENCTY = txtTenCT.Text;
                ct.EMAIL = txtEmail.Text;
                ct.DIENTHOAI = txtDienThoai.Text;
                ct.DIACHI = txtDiaChi.Text;
                _congty.Update(ct);
            }

        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MACTY").ToString());
                txtTenCT.Text = gvDanhSach.GetFocusedRowCellValue("TENCTY").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
                txtDienThoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
            }
        }
    }
}
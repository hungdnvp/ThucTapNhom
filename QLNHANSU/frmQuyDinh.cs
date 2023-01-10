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
    public partial class frmQuyDinh : DevExpress.XtraEditors.XtraForm
    {
        public frmQuyDinh()
        {
            InitializeComponent();
        }
        QUYDINH _qd;
        bool _them;
        int _id;

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            _them = false;
            _qd = new QUYDINH();
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
            txtQuyDinh.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _qd.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            txtQuyDinh.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
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
                _qd.Delete(_id);
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
            txtQuyDinh.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if (_them)
            {
                tb_CONFIG qd = new tb_CONFIG();
                qd.NAME = txtQuyDinh.Text;
                qd.VALUE = txtGhiChu.Text;
                _qd.Add(qd);
            }
            else
            {
                var qd = _qd.getItem(_id);
                qd.NAME = txtQuyDinh.Text;
                qd.VALUE = txtGhiChu.Text;
                _qd.Update(qd);
            }

        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
            txtQuyDinh.Text = gvDanhSach.GetFocusedRowCellValue("NAME").ToString();
            txtGhiChu.Text = gvDanhSach.GetFocusedRowCellValue("VALUE").ToString();
        }
    }
}
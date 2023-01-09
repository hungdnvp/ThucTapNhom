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
using BusinessLayer;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Mask;

namespace QLNHANSU
{
    public partial class frmTonGiao : DevExpress.XtraEditors.XtraForm
    {
        public frmTonGiao()
        {
            InitializeComponent();
        }
        TONGIAO _tongiao;
        bool _them;
        int _id;

        private void frmTonGiao_Load(object sender, EventArgs e)
        {
            _them = false;
            _tongiao = new TONGIAO();
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
            txtTonGiao.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _tongiao.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            txtTonGiao.Text = string.Empty;
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
                _tongiao.Delete(_id);
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
            txtTonGiao.Text = string.Empty;
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
                tb_TONGIAO tg = new tb_TONGIAO();
                tg.TENTG = txtTonGiao.Text;
                _tongiao.Add(tg);
            }
            else
            {
                var tg = _tongiao.getItem(_id);
                tg.TENTG = txtTonGiao.Text;
                _tongiao.Update(tg);
            }

        }


        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
            txtTonGiao.Text = gvDanhSach.GetFocusedRowCellValue("TENTG").ToString();
        }

    }
}
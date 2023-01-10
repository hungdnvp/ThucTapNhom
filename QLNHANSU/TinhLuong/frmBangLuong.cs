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
using BusinessLayer;
using QLNHANSU.Reports;
using DevExpress.XtraReports.UI;
using DataLayer;

namespace QLNHANSU.TinhLuong
{
    public partial class frmBangLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmBangLuong()
        {
            InitializeComponent();
        }
        BANGLUONG _bl;
        List<tb_BANGLUONG> _lstBangLuong;
        int _namky;

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            _bl = new BANGLUONG();
            cboNam.Text = DateTime.Now.Year.ToString();
            cboThang.Text = DateTime.Now.Month.ToString();
        }
        void loadData()
        {
            gcDanhSach.DataSource = _bl.getList(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstBangLuong = _bl.getList(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
            _namky = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text);
        }

        private void btnTinhLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            _bl.TinhLuongNhanVien(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
            loadData();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptBangLuong rpt = new rptBangLuong(_lstBangLuong, _namky);
            rpt.ShowRibbonPreview();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXemBangLuong_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
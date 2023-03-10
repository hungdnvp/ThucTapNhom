using BusinessLayer;
using QLNHANSU.ChamCong;
using QLNHANSU.Reports;
using QLNHANSU.TinhLuong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNHANSU
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public bool isThoat = true;
        public MainForm()
        {
            InitializeComponent();
        }
        
        void openForm(Type typeform)
        {
            foreach(var frm in MdiChildren)
            {
                if (frm.GetType() == typeform)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeform);
            f.MdiParent = this;
            f.Show();
        }
        NHANVIEN _nhanvien;
        HOPDONGLAODONG _hopdong;
        private void MainForm_Load(object sender, EventArgs e)
        {
            _nhanvien = new NHANVIEN();
            _hopdong = new HOPDONGLAODONG();
            ribbonControl1.SelectedPage = rbChamCong;
            loadSinhNhat();
            loadTangLuong();
            PhanQuyen();
        }
        void PhanQuyen()
        {
            switch (Const.TaiKhoan.LoaiTaiKhoan)
            {
                case TaiKhoan.LoaiTK.ketoan:
                    btnDanToc.Enabled = btnTonGiao.Enabled = btnTrinhDo.Enabled = btnCongTy.Enabled
                        = btnKhenThuong.Enabled = btnKyLuat.Enabled = btnDieuChuyen.Enabled 
                        = btnThoiViec.Enabled = btnHopDong.Enabled = btnLoaiCa.Enabled 
                        = btnLoaiCong.Enabled = btnPhuCap.Enabled = btnCaiDat.Enabled = false;
                    break;
                case TaiKhoan.LoaiTK.nhansu:
                    btnDanToc.Enabled = btnTonGiao.Enabled = btnTrinhDo.Enabled = btnCongTy.Enabled
                        = btnKhenThuong.Enabled = btnKyLuat.Enabled = btnDieuChuyen.Enabled
                        = btnThoiViec.Enabled = btnHopDong.Enabled = btnLoaiCa.Enabled = btnBaoHiem.Enabled 
                        = btnLoaiCong.Enabled = btnPhuCap.Enabled = btnTangCa.Enabled 
                        = btnUngLuong.Enabled = btnBangCong.Enabled = btnBangCongCT.Enabled 
                        = btnBangLuong.Enabled = btnCaiDat.Enabled = false;
                    break;

            }
        }
        void loadSinhNhat()
        {
            lstSinhNhat.DataSource = _nhanvien.getSinhNhat();
            lstSinhNhat.DisplayMember = "HOTEN";
            lstSinhNhat.ValueMember = "MANV";
        }
        void loadTangLuong()
        {
            lstTangLuong.DataSource = _hopdong.getTangLuong();
            lstTangLuong.DisplayMember = "HOTEN";
            lstTangLuong.ValueMember = "MANV";
        }
        private void btnDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmDanToc));
        }

        private void btnTonGiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTonGiao));
        }
        private void btnTrinhDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTrinhDo));
        }

        private void btnPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmPhongBan));
        }

        private void btnCongTy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmCongTy));
        }

        private void btnBoPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmBoPhan));
        }

        private void btnChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmChucVu));
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmNhanVien));
        }

        private void btnHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmHopDongLaoDong));
        }
        private void btnBaoHiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmBaoHiem));
        }

        private void btnKhenThuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmKhenThuong));
        }

        private void btnKyLuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmKyLuat));
        }

        private void btnDieuChuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmDieuChuyen));
        }

        private void btnThoiViec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmThoiViec));
        }

        private void btnNangLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmQuanLyLuong));
        }

        private void lstSinhNhat_CustomizeItem(object sender, DevExpress.XtraEditors.CustomizeTemplatedItemEventArgs e)
        {
            if (e.TemplatedItem.Elements[1].Text.Substring(0, 2) == DateTime.Now.Day.ToString())
            {
                e.TemplatedItem.AppearanceItem.Normal.ForeColor = Color.Red;
            }
        }

        private void lstTangLuong_CustomizeItem(object sender, DevExpress.XtraEditors.CustomizeTemplatedItemEventArgs e)
        {
            if (e.TemplatedItem.Elements[1].Text.Substring(0, 2) == DateTime.Now.Day.ToString())
            {
                e.TemplatedItem.AppearanceItem.Normal.ForeColor = Color.Red;
            }
        }

        private void btnLoaiCa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmLoaiCa));
        }

        private void btnLoaiCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmLoaiCong));
        }

        private void btnBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmBangCong));
        }

        private void btnBangCongCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBangCongCT frm = new frmBangCongCT();
            frm.ShowDialog();
        }

        private void btnPhuCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmPhuCap));
        }

        private void btnTangCa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTangCa));
        }

        private void btnUngLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmUngLuong));
        }

        private void btnBangLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmBangLuong));
        }
        public event EventHandler DangXuat;

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình không ?", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
            

        }

        private void btnCaiDat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmQuyDinh));
        }

        
    }
}

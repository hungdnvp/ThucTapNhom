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
        
        // xu ly thao tac close , open switch giua cac form
        void openForm(Type typeform)
        {
            foreach(var frm in MdiChildren)
            {
                if (frm.GetType()==typeform)
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
            ribbonControl1.SelectedPage =rbChamCong;
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
                    // nhan su khac dieu kien on off cac component
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
            lstSinhNhat.ValueMember = "MANV" ;
        }
        void loadTangLuong()
        {
            lstTangLuong.DataSource = _hopdong.getTangLuong();
            lstTangLuong.DisplayMember = "HOTEN";
            lstTangLuong.ValueMember = "MANV";
        }
      
        public event EventHandler DangXuat;

        

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình không ?", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
            

        }
        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangXuat(this, new EventArgs());
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
       
    }
}

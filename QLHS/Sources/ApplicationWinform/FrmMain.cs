using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using ApplicationWinform.QLPhanQuyenTableAdapters;

namespace ApplicationWinform
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string taikhoan = "";
        public FrmMain()
        {
            InitializeComponent();
        }
        string taikhoan1;
        public FrmMain(string taikhoan1)
        {
            InitializeComponent();
            this.taikhoan1 = taikhoan1;
        }

        //
        Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        //
        //#region   decentralization (Phân quyền)
        //void FindMenuPhanQuyen(RibbonControl ribbonControl, string pScreenName, bool pEnable)
        //{
        //    foreach (RibbonPage page in ribbonControl.Pages)
        //        foreach (RibbonPageGroup groups in page.Groups)
        //        {
        //            foreach (BarItemLink menu in groups.ItemLinks)
        //            {
        //                if (menu.Item is BarButtonGroup && ((BarButtonGroup)menu.Item).ItemLinks.Count > 0)
        //                {
        //                    foreach (BarItemLink item in ((BarButtonGroup)menu.Item).ItemLinks)
        //                        FindPhanQuyen(item, pScreenName, pEnable);
        //                    menu.Item.Enabled = CheckAllBarButtonGroupChildVisible((BarButtonGroup)menu.Item);
        //                    menu.Item.Visibility = CheckVisible(menu.Enabled);
        //                }
        //                else FindPhanQuyen(menu, pScreenName, pEnable);
        //            }
        //            groups.Visible = CheckRibbonGroup(groups);
        //        }
        //}
        //void FindPhanQuyen(BarItemLink item, string pScreenName, bool pEnable)
        //{
        //    if (string.Equals(pScreenName, item.Item.Tag))
        //    {
        //        item.Item.Enabled = pEnable;
        //        item.Item.Visibility = CheckVisible(pEnable);
        //    }
        //}
        //bool CheckAllMenuChildVisible(RibbonPageGroup mnuItems)
        //{
        //    foreach (BarItemLink menuItem in mnuItems.ItemLinks)
        //    {
        //        if (menuItem.Item is BarButtonGroup && ((BarButtonGroup)menuItem.Item).ItemLinks.Count > 0 && menuItem.Item.Enabled)
        //            return CheckAllBarButtonGroupChildVisible((BarButtonGroup)menuItem.Item);
        //        if (menuItem.Item.Enabled)
        //            return true;
        //    }
        //    return false;
        //}
        //bool CheckAllBarButtonGroupChildVisible(BarButtonGroup group)
        //{
        //    foreach (BarItemLink item in group.ItemLinks)
        //        if (item.Item.Enabled)
        //            return true;
        //    return false;
        //}
        //BarItemVisibility CheckVisible(bool enable)
        //{
        //    return enable ? BarItemVisibility.Always : BarItemVisibility.Never;
        //}
        //bool CheckRibbonGroup(RibbonPageGroup group)
        //{
        //    foreach (BarItemLink item in group.ItemLinks)
        //        if (item.Item.Enabled)
        //            return true;
        //    return false;
        //}
        //public List<string> GetMaNhomNguoiDung(string _TenDangNhap)
        //{
        //    List<string> lst = new List<string>();
        //    DataTable dt = new QL_NguoiDungNhomNguoiDungTableAdapter().GetMaNhomTuTenDangNhap(_TenDangNhap);
        //    foreach (DataRow dr in dt.Rows)
        //        lst.Add(dr[1].ToString());
        //    return lst;
        //}

        //void Decentralization(RibbonControl ribbonControl, string _TenDangNhap)
        //{
        //    List<string> nhomND = GetMaNhomNguoiDung(_TenDangNhap);
        //    foreach (string item in nhomND)
        //    {
        //        //DM_ManHinhTableAdapter adt = new DM_ManHinhTableAdapter(); 
        //        DataTable dsQuyen = new DataTable();   
        //        dsQuyen = new DM_ManHinhTableAdapter().GetMaDMTuMaNhom(item);
        //        foreach (DataRow mh in dsQuyen.Rows)
        //            FindMenuPhanQuyen(ribbonControl, mh[0].ToString().Trim(), Convert.ToBoolean(mh[2].ToString()));
        //    }
        //}
        //void loadMenuVisible(RibbonControl ribbonControl, bool Visible)
        //{
        //    foreach (RibbonPage page in ribbonControl.Pages)
        //    {
        //        foreach (RibbonPageGroup group in page.Groups)
        //        {
        //            foreach (BarItemLink item in group.ItemLinks)
        //            {
        //                item.Item.Visibility = BarItemVisibility.Never;
        //                item.Item.Enabled = false;
        //                BarButtonGroup buttonGroup = item.Item as BarButtonGroup;
        //                if (buttonGroup != null)
        //                    BarButtonGroupItems(buttonGroup, Visible);
        //            }
        //        }
        //    }
        //}
        //void BarButtonGroupItems(BarButtonGroup buttonGroup, bool visibleButtons)
        //{
        //    foreach (BarItemLink subLink in buttonGroup.ItemLinks)
        //    {
        //        subLink.Item.Visibility = BarItemVisibility.Never;
        //        subLink.Item.Enabled = false;

        //    }
        //}


        //#endregion
        //
        private void FrmMain_Load(object sender, EventArgs e)
        {
            taikhoan = FrmLogin.taikhoan;
        }
        //Quản trị
        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnDMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmDoiMK));
            if (frm == null)
            {
                FrmDoiMK forms = new FrmDoiMK();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmThongTin));
            if (frm == null)
            {
                FrmThongTin forms = new FrmThongTin();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmDangKy));
            if (frm == null)
            {
                FrmDangKy forms = new FrmDangKy();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        //Quản lý
        private void btnQLGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(QLGiaoVien));
            if (frm == null)
            {
                QLGiaoVien forms = new QLGiaoVien();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnQLKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(QLKhoaHoc));
            if (frm == null)
            {
                QLKhoaHoc forms = new QLKhoaHoc();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnQLLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(QLLopHoc));
            if (frm == null)
            {
                QLLopHoc forms = new QLLopHoc();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnQLHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(QLHocSinh));
            if (frm == null)
            {
                QLHocSinh forms = new QLHocSinh();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnQLKQ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(QLKetQua));
            if (frm == null)
            {
                QLKetQua forms = new QLKetQua();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmTraCuu));
            if (frm == null)
            {
                FrmTraCuu forms = new FrmTraCuu();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDSLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(QLLichHoc));
            if (frm == null)
            {
                QLLichHoc forms = new QLLichHoc();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGioiThieu frm = new FrmGioiThieu();
            frm.Show();
        }

        private void btnDSHV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(FrmDSHV));
            if (frm == null)
            {
                FrmDSHV forms = new FrmDSHV();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
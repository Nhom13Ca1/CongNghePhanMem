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
using LinQtoSQL;
using BLL;
using DevExpress.XtraGrid.Views.Grid;

namespace ApplicationWinform
{
    public partial class QLLopHoc : DevExpress.XtraEditors.XtraForm
    {
        QLHV_LinQ qlhv = new QLHV_LinQ();
        public QLLopHoc()
        {
            InitializeComponent();
        }
        //
        void loaddl()
        {
            //gridLop.DataSource = qlhv.loadLop();
            gridView1.OptionsBehavior.Editable = false;
        }
        void fileExcel()
        {
            gridLop.ExportToXlsx(Application.StartupPath.ToString() + "\\ex.xls");
        }
        void loadcbo()
        {
            cboKhoa.DisplayMember ="TENKHOAHOC";
            cboKhoa.ValueMember ="MAKHOAHOC";
            //cboKhoa.DataSource = qlhv.loadKhoa();
        }
        void disable()
        {
            layoutControl1.Enabled = false;
        }
        void dis_ctr()
        {
            btnDel.Enabled = btnUpdate.Enabled = false;
            btnSave.Enabled = btnCancel.Enabled = false;
        }
        void enable()
        {
            layoutControl1.Enabled = true;
            txtMaLop.Enabled = false;
        }
        void en_ctr()
        {
            btnDel.Enabled = btnUpdate.Enabled = true;
        }
        void reset()
        {
            
        }
        //bool isempty()
        //{
            //if (txtTenlop.Equals("") || txtPhong.Equals("") || txtSiso.Equals("") || txtHphi.Equals("") || txtGio.Equals("") || txtNgay.Equals(""))
            //    return true;
            //return false;
        //}
        //
        private void QLLopHoc_Load(object sender, EventArgs e)
        {
            disable();
            dis_ctr();
            loadcbo();
            loaddl();
        }

        private void gridLop_Click(object sender, EventArgs e)
        {
            //en_ctr();
            //btnAdd.Enabled = false;

            //txtMaLop.Text = gridView1.GetFocusedRowCellValue(MaLop).ToString();
            //cboKhoa.SelectedValue = gridView1.GetFocusedRowCellValue(KhoaHoc).ToString();
            //txtTenlop.Text = gridView1.GetFocusedRowCellValue(TenLop).ToString();
            //txtPhong.Text = gridView1.GetFocusedRowCellValue(PhongHoc).ToString();
            //txtSiso.Text = gridView1.GetFocusedRowCellValue(SiSo).ToString();
            //txtHphi.Text = gridView1.GetFocusedRowCellValue(HocPhi).ToString();
            //txtNgay.Text = gridView1.GetFocusedRowCellValue(NgayHoc).ToString();
            //txtGio.Text = gridView1.GetFocusedRowCellValue(GioHoc).ToString();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            enable();
            btnSave.Enabled = btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            gridLop.Enabled = false;
            //txtMaLop.Text = "LH_" + qlhv.autolop();
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xóa lớp học ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    //if (!qlhv.kt_fkey_lop(txtMaLop.Text))
                    //{
                    //    string malop = gridView1.GetFocusedRowCellValue(MaLop).ToString();
                    //    string mak = gridView1.GetFocusedRowCellValue(KhoaHoc).ToString();
                    //    qlhv.xoaLop(malop);
                    //    MessageBox.Show("Xóa thành công !");

                    //    qlhv.SAVE();
                    //    dis_ctr();
                    //    reset();
                    //    loaddl();
                    //    btnAdd.Enabled = true;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Xóa thất bại !!"); return;
                    //}
                }
            }
            catch
            {
                //MessageBox.Show("Xóa thất bại !"); return;
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            enable();
            btnCancel.Enabled = btnSave.Enabled = true;
            btnDel.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //LOPHOC hv = new LOPHOC();
            //if (!isempty())
            //{
            //    string mal = txtMaLop.Text;;
            //    string mak = cboKhoa.SelectedValue.ToString();

            //    //hv.MALOPHOC = mal;
            //    //hv.MAKHOAHOC = mak;
            //    //hv.TENLOP = txtTenlop.Text;
            //    //hv.SISO = int.Parse(txtSiso.Text);
            //    //hv.PHONG = txtPhong.Text;
            //    //hv.HOCPHI = float.Parse(txtHphi.Text);
            //    //hv.NGAYHOC = txtNgay.Text;
            //    //hv.GIOHOC = txtGio.Text;

            //    if (!qlhv.kt_pkey_lop(mal))
            //    {
            //        qlhv.themLop(hv);
            //        MessageBox.Show("Thêm thành công !");
            //    }
            //    else
            //    {
            //        qlhv.suaLop(hv);
            //        MessageBox.Show("Sửa thành công !");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Dữ liệu trống !");
            //}
            //qlhv.SAVE();
            dis_ctr();
            disable();
            reset();
            gridLop.Enabled = true;
            btnAdd.Enabled = true;
            loaddl();
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dis_ctr();
            disable();
            btnAdd.Enabled = true;
            reset();
            gridLop.Enabled = true;
        }

    }
}
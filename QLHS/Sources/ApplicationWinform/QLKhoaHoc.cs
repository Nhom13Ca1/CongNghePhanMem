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

namespace ApplicationWinform
{
    public partial class QLKhoaHoc : DevExpress.XtraEditors.XtraForm
    {
        QLHV_LinQ qlhv = new QLHV_LinQ();
        public QLKhoaHoc()
        {
            InitializeComponent();
        }
        //
        void loaddl()
        {
            //gridControl1.DataSource = qlhv.loadKhoa();
            gridView1.OptionsBehavior.Editable = false;
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
            edtMakhoa.Enabled = false;
        }
        void en_ctr()
        {
            btnDel.Enabled = btnUpdate.Enabled = true;
        }
        void reset()
        {
            edtTenkhoa.Text = dateBD.Text = dateKT.Text = "";
        }
        bool isempty()
        {
            if (edtMakhoa.Equals("") || dateBD.Equals("") || dateKT.Equals(""))
                return true;
            return false;
        }
        //
        private void QLKhoaHoc_Load(object sender, EventArgs e)
        {
            loaddl();
            dis_ctr();
            disable();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            enable();
            btnSave.Enabled = btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            gridControl1.Enabled = false;
            //edtMakhoa.Text = "KH_" + qlhv.autokh();
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xóa lớp học ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    //if (!qlhv.kt_fkey_khoa(edtMakhoa.Text))
                    //{
                    //    string mak = gridView1.GetFocusedRowCellValue(MaKhoa).ToString();
                    //    qlhv.xoaKhoa(mak);
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
            //KHOAHOC kh = new KHOAHOC();
            if (!isempty())
            {
                //string mak = edtMakhoa.Text;
                //kh.MAKHOAHOC = mak;
                //kh.TENKHOAHOC = edtTenkhoa.Text;
                //kh.NGAYBATDAU = DateTime.Parse(dateBD.Text);
                //kh.NGAYKETTHUC = DateTime.Parse(dateKT.Text);

                //if (!qlhv.kt_pkey_khoa(mak))
                //{
                //    qlhv.themKhoa(kh);
                //    MessageBox.Show("Thêm thành công !");
                //}
                //else
                //{
                //    qlhv.suaKhoa(kh);
                //    MessageBox.Show("Sửa thành công !");
                //}
            }
            else
            {
                MessageBox.Show("Dữ liệu trống !");
            }
            //qlhv.SAVE();
            dis_ctr();
            disable();
            reset();
            gridControl1.Enabled = true;
            btnAdd.Enabled = true;
            loaddl();
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dis_ctr();
            disable();
            btnAdd.Enabled = true;
            reset();
            gridControl1.Enabled = true;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            en_ctr();
            btnAdd.Enabled = false;

            edtMakhoa.Text = gridView1.GetFocusedRowCellValue(MaKhoa).ToString();
            edtTenkhoa.Text = gridView1.GetFocusedRowCellValue(TenKhoa).ToString();
            dateBD.Text = gridView1.GetFocusedRowCellValue(NgayBD).ToString();
            dateKT.Text = gridView1.GetFocusedRowCellValue(NgayKT).ToString();
        }
    }
}
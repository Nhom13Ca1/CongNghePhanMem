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
    public partial class QLKetQua : DevExpress.XtraEditors.XtraForm
    {
        QLHV_LinQ qlhv = new QLHV_LinQ();
        public QLKetQua()
        {
            InitializeComponent();
        }
        //
        void loaddl()
        {
            //gridControl1.DataSource = qlhv.loadKq();
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
        }
        void en_ctr()
        {
            btnDel.Enabled = btnUpdate.Enabled = true;
        }
        void reset()
        {
            
        }
        bool isempty()
        {
            if (edtDiem.Equals(""))
                return true;
            return false;
        }
        string xeploai(float diem)
        {
            if (diem == 0)
                return "Yeu";
                //string xl = "";
            if (diem < 5)
                return "Yếu";
            else if (diem >= 5 && diem < 6.5)
                return "Trung bình";
            else if (diem >= 6.5 && diem < 8)
                return "Khá";
            else
                return "Giỏi";
        }
        string ketqua(float diem)
        {
            string kq = "";
            if (diem >= 5)
                kq += "Đủ điều kiện thi";
            else
                kq += "Chưa đủ điều kiện thi";
            return kq;
        }
        //
        private void QLKetQua_Load(object sender, EventArgs e)
        {
            dis_ctr();
            disable();
            loaddl();
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xóa kết quả học ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    string mal = gridView1.GetFocusedRowCellValue(MaMon).ToString();
                    string mahv = gridView1.GetFocusedRowCellValue(MaKetQua).ToString();
                    //qlhv.xoaKq(mahv, mal);
                    MessageBox.Show("Xóa thành công !");

                    //qlhv.SAVE();
                    dis_ctr();
                    reset();
                    loaddl();
                    btnAdd.Enabled = true;
                }
            }
            catch
            { }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            enable();
            btnCancel.Enabled = btnSave.Enabled = true;
            btnDel.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //KETQUA kq = new KETQUA();
            if (!isempty())
            {
                //string mal = edtMalop.Text; ;
                //string mahv = edtMahv.Text;
                //float diem = float.Parse(edtDiem.Text);

                //kq.MAHV = mahv;
                //kq.MALH = mal;
                //kq.DIEM = Math.Round(diem, 1);
                //kq.XEPLOAI = xeploai(diem);
                //kq.KETQUA1 = ketqua(diem);

                //if (qlhv.kt_pkey_kq(mahv, mal))
                //{
                //    qlhv.suaKq(kq);
                //    MessageBox.Show("Cập nhật thành công !");
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
            btnAdd.Enabled = true;
            loaddl();
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dis_ctr();
            disable();
            reset();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                en_ctr();

                //edtMalop.Text = gridView1.GetFocusedRowCellValue(MaMon).ToString();
                //edtMahv.Text = gridView1.GetFocusedRowCellValue(MaKetQua).ToString();
                //edtDiem.Text = gridView1.GetFocusedRowCellValue(HocKy).ToString();
            }
            catch { }
        }


    }
}
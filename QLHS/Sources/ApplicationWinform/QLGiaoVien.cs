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
    public partial class QLGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        QLHS_LinQ qlhs = new QLHS_LinQ();
        public QLGiaoVien()
        {
            InitializeComponent();
        }
        void loaddl()
        {
            gridControl1.DataSource = qlhs.loadGV();
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
            edtMagv.Enabled = false;
        }
        void en_ctr()
        {
            btnDel.Enabled = btnUpdate.Enabled = true;
        }
        void reset()
        {
           edtMagv.Equals("") ; edtHoten.Equals("") ; edtDchi.Equals(""); edtSdt.Equals(""); dateNgsinh.Equals("");
           radNam.Checked = true; 
        }
        bool isempty()
        {
            if (edtMagv.Equals("") || edtHoten.Equals("") || edtDchi.Equals("") || edtSdt.Equals("") || dateNgsinh.Equals("") || !radNam.Checked && !radNu.Checked)
            {
                //if (!radNam.Checked && !radNu.Checked)
                {
                    return true;
                }
            }
            return false;
        }
        private void QLGiaoVien_Load(object sender, EventArgs e)
        {
            loaddl();
            loadcbo();
            dis_ctr();
            disable();
            radNam.Checked = true; 
        }
        //
        string magv(int stt)
        {
            if (stt < 10)
                return "000";
            else if (stt > 10 && stt < 100)
                return "00";
            return "0";
        }
        string gt()
        {
            string gtinh = "";
            if (radNam.Checked)
                gtinh = "Nam";
            else if (radNu.Checked)
                gtinh = "Nữ";
            return gtinh;
        }
        void check(string gt)
        {
            if (gt == "Nam")
                radNam.Checked = true;
            else
                radNu.Checked = true;
        }
        void loadcbo()
        {
            cboMH.DataSource = qlhs.loadMH();
            cboMH.DisplayMember = "TENMON";
            cboMH.ValueMember = "MAMON";
        }
        //
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int stt = qlhs.autogv();
            edtMagv.Text = "GV" + magv(stt) + stt;
            btnAdd.Enabled = false;
            enable();
            gridControl1.Enabled = false;
            btnSave.Enabled = btnCancel.Enabled = true;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try {
                DialogResult r = MessageBox.Show("Bạn có muốn xóa giáo viên ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    string magv = gridView1.GetFocusedRowCellValue(MaGV).ToString();
                    if (magv == FrmLogin.taikhoan)
                    {
                        MessageBox.Show("Tài khoản đang sử dụng, xóa thất bại"); return;
                    }
                    else
                    {
                        qlhs.xoaGV(magv);
                        MessageBox.Show("Xóa thành công !");

                        qlhs.SAVE();
                        loaddl();
                        reset();
                        dis_ctr();
                        btnAdd.Enabled = true;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString(),"Xóa thất bại"); return;
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
            GIAOVIEN gv = new GIAOVIEN();
            if (!isempty())
            {
                try
                {
                    string gtinh = gt();
                    gv.MAGIAOVIEN = edtMagv.Text;
                    gv.MAMON = cboMH.SelectedValue.ToString();
                    gv.DIACHI = edtDchi.Text;
                    gv.HOTEN = edtHoten.Text;
                    gv.SODIENTHOAI = edtSdt.Text;
                    gv.NGAYSINH = DateTime.Parse(dateNgsinh.Text);
                    gv.MATKHAU = "111111";
                    gv.GIOITINH = gtinh;

                    if (!qlhs.kt_pkey_gv(edtMagv.Text))
                    {
                        qlhs.themGv(gv);
                        MessageBox.Show("Thêm thành công !");
                    }
                    else
                    {
                        qlhs.suaGV(gv);
                        MessageBox.Show("Sửa thành công !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu trống, kiểm tra lại !"); return;
            }
            qlhs.SAVE();
            dis_ctr();
            disable();
            reset();
            btnAdd.Enabled = true;
            gridControl1.Enabled = true;
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
            btnAdd.Enabled = false;
            btnCancel.Enabled = true;
            string gt = gridView1.GetFocusedRowCellValue(GioiTinh).ToString();
            en_ctr();

            cboMH.SelectedValue = gridView1.GetFocusedRowCellValue(MonHoc).ToString();
            edtDchi.Text = gridView1.GetFocusedRowCellValue(DiaChi).ToString();
            edtHoten.Text = gridView1.GetFocusedRowCellValue(HoTen).ToString();
            edtMagv.Text = gridView1.GetFocusedRowCellValue(MaGV).ToString();
            edtSdt.Text = gridView1.GetFocusedRowCellValue(Sdt).ToString();
            dateNgsinh.Text = gridView1.GetFocusedRowCellValue(NgSinh).ToString();
            check(gt);
        }


    }
}
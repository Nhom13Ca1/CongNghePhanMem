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
    public partial class QLLichHoc : DevExpress.XtraEditors.XtraForm
    {
        QLHV_LinQ qlhv = new QLHV_LinQ();
        public QLLichHoc()
        {
            InitializeComponent();
        }
        //
        void xuatExcel()
        {
            gridControl1.ExportToXlsx(Application.StartupPath.ToString() + "\\DanhSachLop.xls");
        }
        void loadcbo()
        {
            cboMaLop.DisplayMember = "TENLOP";
            cboMaLop.ValueMember = "MALOPHOC";
            //cboMaLop.DataSource = qlhv.loadLop();
        }
        void loaddl(string mal)
        {
            //gridControl1.DataSource = qlhv.danhsachlop(mal);
        }
        //
        private void QLLichHoc_Load(object sender, EventArgs e)
        {
            loadcbo();
        }

        private void QLLichHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn đóng chức năng quản lý lịch không?", "Đóng chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuatExcel();
        }


        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string mal = cboMaLop.SelectedValue.ToString();
                //gridControl1.DataSource = qlhv.ds_lop(mal);

            }
            catch { }
        }
    }
}
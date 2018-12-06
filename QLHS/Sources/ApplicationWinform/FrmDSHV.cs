using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinQtoSQL;

namespace ApplicationWinform
{
    public partial class FrmDSHV : Form
    {
        QLHV_LinQ qlhv = new QLHV_LinQ();
        public FrmDSHV()
        {
            InitializeComponent();
        }

        private void FrmDSHV_Load(object sender, EventArgs e)
        {
            //gridControl1.DataSource = qlhv.ds_dat();
            gridView1.OptionsBehavior.Editable = false;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            gridControl1.ExportToXlsx(Application.StartupPath.ToString() + "\\DanhSachHocVienDat.xls");
            MessageBox.Show("Thành công !");
        }
    }
}

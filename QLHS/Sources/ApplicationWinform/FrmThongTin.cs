using ApplicationWinform.QLPhanQuyenTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationWinform
{
    public partial class FrmThongTin : Form
    {
        QL_NguoiDungTableAdapter adt = new QL_NguoiDungTableAdapter();
        public FrmThongTin()
        {
            InitializeComponent();
        }

        private void qL_NguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLPhanQuyen);

        }

        private void FrmThongTin_Load(object sender, EventArgs e)
        {
            string taikhoan = FrmLogin.taikhoan;
            // TODO: This line of code loads data into the 'qLPhanQuyen.QL_NguoiDung' table. You can move, or remove it, as needed.
            this.qL_NguoiDungTableAdapter.FillBy(this.qLPhanQuyen.QL_NguoiDung, taikhoan); 

        }
    }
}

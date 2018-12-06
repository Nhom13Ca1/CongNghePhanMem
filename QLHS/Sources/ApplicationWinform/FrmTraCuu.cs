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
    public partial class FrmTraCuu : Form
    {
        QLHV_LinQ qlhv = new QLHV_LinQ();
        public FrmTraCuu()
        {
            InitializeComponent();
        }
        //
        void loaddl(string mahv)
        {
            
        }
        void reset()
        {
            txtMaHV.Text = txtTen.Text = txtDate.Text = txtAddr.Text =  txtSdt.Text = txtGT.Text = txtDiem.Text = "";
        }
        void loadcbo()
        {
            cboHV.DisplayMember = "HOTENHV";
            cboHV.ValueMember = "MASOHV";
            //cboHV.DataSource = qlhv.loadHv();
        }
        //
        private void btnFind_Click(object sender, EventArgs e)
        {
            loaddl(cboHV.SelectedValue.ToString());
        }

        private void FrmTraCuu_Load(object sender, EventArgs e)
        {
            loadcbo();
        }
    }
}

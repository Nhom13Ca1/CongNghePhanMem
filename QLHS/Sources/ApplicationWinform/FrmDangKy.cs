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
    public partial class FrmDangKy : Form
    {
        //QLPhanQuyen user = new QLPhanQuyen();
        QL_NguoiDungTableAdapter user_adpt = new QL_NguoiDungTableAdapter();
        public FrmDangKy()
        {
            InitializeComponent();
        }
        //
        bool check()
        {
            if (chkAct.Checked)
                return true;
            return false;
        }
        void reset()
        {
            txtName.Text = txtEmail.Text = txtPass.Text = txtRepass.Text = txtUser.Text = "";
        }
        bool isempty()
        {
            if (txtUser.Equals("") || txtPass.Equals("") || txtRepass.Equals("") || txtEmail.Equals("") || txtName.Equals(""))
                return true;
            return false;
        }
        //
        private void btnRes_Click(object sender, EventArgs e)
        {
            if (!isempty())
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    user_adpt.InsertQuery(txtUser.Text, txtPass.Text, check(), txtName.Text, txtEmail.Text);
                    MessageBox.Show("Thêm thành công !");
                    reset();
                }
            }
            else
            {
                MessageBox.Show("Thông tin trống !"); return;
            }
        }

        private void txtRepass_Validating(object sender, CancelEventArgs e)
        {
            if (txtRepass.Text != txtPass.Text)
            {
                errorProvider1.SetError(txtRepass, "Mật khẩu chưa khớp");
            }
            else
            {
                errorProvider1.SetError(txtRepass, null);
            }
        }
    }
}

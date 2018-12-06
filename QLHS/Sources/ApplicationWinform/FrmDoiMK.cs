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
    public partial class FrmDoiMK : Form
    {
        string taikhoan = "";
        QL_NguoiDungTableAdapter user_adpt = new QL_NguoiDungTableAdapter();
        public FrmDoiMK()
        {
            InitializeComponent();
        }
        //
        void reset()
        {
            txtPass.Text = txtRepass.Text = "";
        }
        bool isempty()
        {
            if (txtPass.Equals("") || txtRepass.Equals(""))
                return true;
            return false;
        }
        //
        private void FrmDoiMK_Load(object sender, EventArgs e)
        {
            taikhoan = FrmLogin.taikhoan;
            txtUser.Text = taikhoan;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isempty())
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    user_adpt.UpdateQuery(txtPass.Text, txtUser.Text);
                    MessageBox.Show("Cập nhật thành công !");
                    reset();
                }
                else
                {
                    MessageBox.Show("Mật nhật thất bại");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu trống !"); return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
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

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
using System.Data.SqlClient;

namespace ApplicationWinform
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        QL_NguoiDung cauhinh = new QL_NguoiDung();
        public static string taikhoan = "";
        public FrmLogin()
        {
            InitializeComponent();
        }
        //
        public void processlogin()
        {
            int result;
            string tk = cboTK.SelectedValue.ToString();
            result = cauhinh.check_users(tk, txtPass.Text);
            if (result == 0)
            {
                MessageBox.Show("Thông tin đăng nhập không đúng !");
                txtPass.Clear();
                cboTK.SelectedIndex = 0;
                return;
            }
            else if (result == 1)
            {
                MessageBox.Show("Tài khoản bị khóa !");
                return;
            }
            else if (Program.frmmain == null || Program.frmmain.IsDisposed)
                Program.frmmain = new FrmMain(tk);
            this.Visible = false;
            Program.frmmain.Show();

        }
        //
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                MessageBox.Show("Mật khẩu trống !");
                txtPass.Focus();
                return;
            }
            int kq = cauhinh.check_config();
            if (kq == 0)
            {
                processlogin();
                taikhoan = cboTK.SelectedValue.ToString();
            }
            else if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
            }
            else
            {
                MessageBox.Show("Chuỗi cấu hình không hợp lệ");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        void loadTK()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from GIAOVIEN", Properties.Settings.Default.QLHSConnectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboTK.DataSource = dt;
            cboTK.DisplayMember = "MAGIAOVIEN";
            cboTK.ValueMember = "MAGIAOVIEN";
        }
        //
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            loadTK();
        }
    }
}
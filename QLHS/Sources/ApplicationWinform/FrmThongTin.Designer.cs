namespace ApplicationWinform
{
    partial class FrmThongTin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tenDangNhapLabel;
            System.Windows.Forms.Label matKhauLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label hoatDongLabel;
            this.tenDangNhapTextBox = new System.Windows.Forms.TextBox();
            this.qL_NguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLPhanQuyen = new ApplicationWinform.QLPhanQuyen();
            this.matKhauTextBox = new System.Windows.Forms.TextBox();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.hoatDongCheckBox = new System.Windows.Forms.CheckBox();
            this.qL_NguoiDungTableAdapter = new ApplicationWinform.QLPhanQuyenTableAdapters.QL_NguoiDungTableAdapter();
            this.tableAdapterManager = new ApplicationWinform.QLPhanQuyenTableAdapters.TableAdapterManager();
            tenDangNhapLabel = new System.Windows.Forms.Label();
            matKhauLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            hoatDongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // tenDangNhapLabel
            // 
            tenDangNhapLabel.AutoSize = true;
            tenDangNhapLabel.Location = new System.Drawing.Point(25, 80);
            tenDangNhapLabel.Name = "tenDangNhapLabel";
            tenDangNhapLabel.Size = new System.Drawing.Size(109, 17);
            tenDangNhapLabel.TabIndex = 1;
            tenDangNhapLabel.Text = "Tên đăng nhập:";
            // 
            // matKhauLabel
            // 
            matKhauLabel.AutoSize = true;
            matKhauLabel.Location = new System.Drawing.Point(25, 108);
            matKhauLabel.Name = "matKhauLabel";
            matKhauLabel.Size = new System.Drawing.Size(70, 17);
            matKhauLabel.TabIndex = 3;
            matKhauLabel.Text = "Mật khẩu:";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(25, 136);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(54, 17);
            hoTenLabel.TabIndex = 5;
            hoTenLabel.Text = "Họ tên:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(25, 164);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // hoatDongLabel
            // 
            hoatDongLabel.AutoSize = true;
            hoatDongLabel.Location = new System.Drawing.Point(25, 192);
            hoatDongLabel.Name = "hoatDongLabel";
            hoatDongLabel.Size = new System.Drawing.Size(78, 17);
            hoatDongLabel.TabIndex = 9;
            hoatDongLabel.Text = "Hoạt động:";
            // 
            // tenDangNhapTextBox
            // 
            this.tenDangNhapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qL_NguoiDungBindingSource, "TenDangNhap", true));
            this.tenDangNhapTextBox.Location = new System.Drawing.Point(181, 77);
            this.tenDangNhapTextBox.Name = "tenDangNhapTextBox";
            this.tenDangNhapTextBox.ReadOnly = true;
            this.tenDangNhapTextBox.Size = new System.Drawing.Size(256, 22);
            this.tenDangNhapTextBox.TabIndex = 2;
            // 
            // qL_NguoiDungBindingSource
            // 
            this.qL_NguoiDungBindingSource.DataMember = "QL_NguoiDung";
            this.qL_NguoiDungBindingSource.DataSource = this.qLPhanQuyen;
            // 
            // qLPhanQuyen
            // 
            this.qLPhanQuyen.DataSetName = "QLPhanQuyen";
            this.qLPhanQuyen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matKhauTextBox
            // 
            this.matKhauTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qL_NguoiDungBindingSource, "MatKhau", true));
            this.matKhauTextBox.Location = new System.Drawing.Point(181, 105);
            this.matKhauTextBox.Name = "matKhauTextBox";
            this.matKhauTextBox.PasswordChar = '•';
            this.matKhauTextBox.ReadOnly = true;
            this.matKhauTextBox.Size = new System.Drawing.Size(256, 22);
            this.matKhauTextBox.TabIndex = 4;
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qL_NguoiDungBindingSource, "HoTen", true));
            this.hoTenTextBox.Location = new System.Drawing.Point(181, 133);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.ReadOnly = true;
            this.hoTenTextBox.Size = new System.Drawing.Size(256, 22);
            this.hoTenTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qL_NguoiDungBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(181, 161);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(256, 22);
            this.emailTextBox.TabIndex = 8;
            // 
            // hoatDongCheckBox
            // 
            this.hoatDongCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.qL_NguoiDungBindingSource, "HoatDong", true));
            this.hoatDongCheckBox.Enabled = false;
            this.hoatDongCheckBox.Location = new System.Drawing.Point(181, 189);
            this.hoatDongCheckBox.Name = "hoatDongCheckBox";
            this.hoatDongCheckBox.Size = new System.Drawing.Size(260, 24);
            this.hoatDongCheckBox.TabIndex = 10;
            this.hoatDongCheckBox.Text = "Còn hoạt động";
            this.hoatDongCheckBox.UseVisualStyleBackColor = true;
            // 
            // qL_NguoiDungTableAdapter
            // 
            this.qL_NguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = this.qL_NguoiDungTableAdapter;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ApplicationWinform.QLPhanQuyenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 369);
            this.Controls.Add(hoatDongLabel);
            this.Controls.Add(this.hoatDongCheckBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.hoTenTextBox);
            this.Controls.Add(matKhauLabel);
            this.Controls.Add(this.matKhauTextBox);
            this.Controls.Add(tenDangNhapLabel);
            this.Controls.Add(this.tenDangNhapTextBox);
            this.Name = "FrmThongTin";
            this.Tag = "6";
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.FrmThongTin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhanQuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLPhanQuyen qLPhanQuyen;
        private System.Windows.Forms.BindingSource qL_NguoiDungBindingSource;
        private QLPhanQuyenTableAdapters.QL_NguoiDungTableAdapter qL_NguoiDungTableAdapter;
        private QLPhanQuyenTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tenDangNhapTextBox;
        private System.Windows.Forms.TextBox matKhauTextBox;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox hoatDongCheckBox;
    }
}
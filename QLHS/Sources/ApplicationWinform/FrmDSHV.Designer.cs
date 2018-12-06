namespace ApplicationWinform
{
    partial class FrmDSHV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDSHV));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHocSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LopHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Diem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XepLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.cboDanhSach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 127);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(939, 316);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHocSinh,
            this.LopHoc,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.Diem,
            this.XepLoai});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.Caption = "Mã học sinh";
            this.MaHocSinh.FieldName = "MAHOCSINH";
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.Visible = true;
            this.MaHocSinh.VisibleIndex = 0;
            // 
            // LopHoc
            // 
            this.LopHoc.Caption = "Lớp học";
            this.LopHoc.FieldName = "TENLOP";
            this.LopHoc.Name = "LopHoc";
            this.LopHoc.Visible = true;
            this.LopHoc.VisibleIndex = 1;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ và tên";
            this.HoTen.FieldName = "HOTEN";
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 2;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày sinh";
            this.NgaySinh.FieldName = "NGAYSINH";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 3;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới tính";
            this.GioiTinh.FieldName = "GIOITINH";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 4;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DIACHI";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 5;
            // 
            // Diem
            // 
            this.Diem.Caption = "Điểm";
            this.Diem.FieldName = "DIEM";
            this.Diem.Name = "Diem";
            this.Diem.Visible = true;
            this.Diem.VisibleIndex = 6;
            // 
            // XepLoai
            // 
            this.XepLoai.Caption = "Xếp loại";
            this.XepLoai.FieldName = "XEPLOAI";
            this.XepLoai.Name = "XepLoai";
            this.XepLoai.Visible = true;
            this.XepLoai.VisibleIndex = 7;
            // 
            // btnExcel
            // 
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.Location = new System.Drawing.Point(495, 17);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(160, 46);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Xuất danh sách";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // cboDanhSach
            // 
            this.cboDanhSach.FormattingEnabled = true;
            this.cboDanhSach.Items.AddRange(new object[] {
            "Học kỳ I",
            "Học kỳ II",
            "Cả năm"});
            this.cboDanhSach.Location = new System.Drawing.Point(158, 29);
            this.cboDanhSach.Name = "cboDanhSach";
            this.cboDanhSach.Size = new System.Drawing.Size(165, 24);
            this.cboDanhSach.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Xem danh sách theo";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(329, 17);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(160, 46);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Xem danh sách";
            // 
            // FrmDSHV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 443);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDanhSach);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmDSHV";
            this.Tag = "5";
            this.Text = "Danh sách khen thưởng";
            this.Load += new System.EventHandler(this.FrmDSHV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraGrid.Columns.GridColumn MaHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn LopHoc;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn Diem;
        private DevExpress.XtraGrid.Columns.GridColumn XepLoai;
        private System.Windows.Forms.ComboBox cboDanhSach;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;

    }
}
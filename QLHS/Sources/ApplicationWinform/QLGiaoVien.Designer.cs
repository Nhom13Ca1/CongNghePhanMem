namespace ApplicationWinform
{
    partial class QLGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLGiaoVien));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateNgsinh = new System.Windows.Forms.DateTimePicker();
            this.cboMH = new System.Windows.Forms.ComboBox();
            this.edtDchi = new DevExpress.XtraEditors.TextEdit();
            this.edtSdt = new DevExpress.XtraEditors.TextEdit();
            this.edtHoten = new DevExpress.XtraEditors.TextEdit();
            this.edtMagv = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MonHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtDchi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHoten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMagv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnAdd,
            this.btnDel,
            this.btnUpdate,
            this.btnSave,
            this.btnCancel,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1133, 167);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm mới";
            this.btnAdd.Id = 1;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnDel
            // 
            this.btnDel.Caption = "Xóa dữ liệu";
            this.btnDel.Id = 2;
            this.btnDel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDel.ImageOptions.SvgImage")));
            this.btnDel.Name = "btnDel";
            this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDel_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Sửa dữ liệu";
            this.btnUpdate.Id = 3;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu thay đổi";
            this.btnSave.Id = 4;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Hủy thay đổi";
            this.btnCancel.Id = 5;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý giáo viên";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDel);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUpdate);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCancel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.radNu);
            this.layoutControl1.Controls.Add(this.radNam);
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this.dateNgsinh);
            this.layoutControl1.Controls.Add(this.cboMH);
            this.layoutControl1.Controls.Add(this.edtDchi);
            this.layoutControl1.Controls.Add(this.edtSdt);
            this.layoutControl1.Controls.Add(this.edtHoten);
            this.layoutControl1.Controls.Add(this.edtMagv);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 167);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1133, 120);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // radNu
            // 
            this.radNu.Location = new System.Drawing.Point(1058, 44);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(59, 31);
            this.radNu.TabIndex = 13;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.Location = new System.Drawing.Point(989, 44);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(63, 31);
            this.radNam.TabIndex = 12;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(850, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Giới tính";
            // 
            // dateNgsinh
            // 
            this.dateNgsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgsinh.Location = new System.Drawing.Point(376, 44);
            this.dateNgsinh.Name = "dateNgsinh";
            this.dateNgsinh.Size = new System.Drawing.Size(191, 23);
            this.dateNgsinh.TabIndex = 10;
            // 
            // cboMH
            // 
            this.cboMH.FormattingEnabled = true;
            this.cboMH.Location = new System.Drawing.Point(99, 44);
            this.cboMH.Name = "cboMH";
            this.cboMH.Size = new System.Drawing.Size(188, 24);
            this.cboMH.TabIndex = 9;
            // 
            // edtDchi
            // 
            this.edtDchi.Location = new System.Drawing.Point(99, 81);
            this.edtDchi.MenuManager = this.ribbonControl1;
            this.edtDchi.Name = "edtDchi";
            this.edtDchi.Size = new System.Drawing.Size(468, 22);
            this.edtDchi.StyleController = this.layoutControl1;
            this.edtDchi.TabIndex = 8;
            // 
            // edtSdt
            // 
            this.edtSdt.Location = new System.Drawing.Point(656, 44);
            this.edtSdt.MenuManager = this.ribbonControl1;
            this.edtSdt.Name = "edtSdt";
            this.edtSdt.Size = new System.Drawing.Size(188, 22);
            this.edtSdt.StyleController = this.layoutControl1;
            this.edtSdt.TabIndex = 7;
            // 
            // edtHoten
            // 
            this.edtHoten.Location = new System.Drawing.Point(656, 16);
            this.edtHoten.MenuManager = this.ribbonControl1;
            this.edtHoten.Name = "edtHoten";
            this.edtHoten.Size = new System.Drawing.Size(461, 22);
            this.edtHoten.StyleController = this.layoutControl1;
            this.edtHoten.TabIndex = 5;
            // 
            // edtMagv
            // 
            this.edtMagv.Location = new System.Drawing.Point(99, 16);
            this.edtMagv.MenuManager = this.ribbonControl1;
            this.edtMagv.Name = "edtMagv";
            this.edtMagv.Size = new System.Drawing.Size(468, 22);
            this.edtMagv.StyleController = this.layoutControl1;
            this.edtMagv.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1133, 120);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.edtMagv;
            this.layoutControlItem1.Enabled = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(557, 28);
            this.layoutControlItem1.Text = "Mã giáo viên";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(557, 65);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(550, 29);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.edtHoten;
            this.layoutControlItem2.Location = new System.Drawing.Point(557, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(550, 28);
            this.layoutControlItem2.Text = "Họ và tên";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.edtSdt;
            this.layoutControlItem4.Location = new System.Drawing.Point(557, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(277, 37);
            this.layoutControlItem4.Text = "Số điện thoại";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(79, 17);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cboMH;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(277, 37);
            this.layoutControlItem6.Text = "Môn học";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(79, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateNgsinh;
            this.layoutControlItem3.Location = new System.Drawing.Point(277, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(280, 37);
            this.layoutControlItem3.Text = "Ngày sinh";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(79, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.edtDchi;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 65);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(557, 29);
            this.layoutControlItem5.Text = "Địa chỉ";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(79, 17);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.label1;
            this.layoutControlItem7.Location = new System.Drawing.Point(834, 28);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(139, 37);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.radNam;
            this.layoutControlItem8.Location = new System.Drawing.Point(973, 28);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(69, 37);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.radNu;
            this.layoutControlItem9.Location = new System.Drawing.Point(1042, 28);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(65, 37);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 287);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1133, 318);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaGV,
            this.HoTen,
            this.NgSinh,
            this.Sdt,
            this.DiaChi,
            this.MonHoc,
            this.GioiTinh,
            this.MatKhau});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MaGV
            // 
            this.MaGV.Caption = "Mã giáo viên";
            this.MaGV.FieldName = "MAGIAOVIEN";
            this.MaGV.Name = "MaGV";
            this.MaGV.Visible = true;
            this.MaGV.VisibleIndex = 0;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ và tên";
            this.HoTen.FieldName = "HOTEN";
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            // 
            // NgSinh
            // 
            this.NgSinh.Caption = "Ngày sinh";
            this.NgSinh.FieldName = "NGAYSINH";
            this.NgSinh.Name = "NgSinh";
            this.NgSinh.Visible = true;
            this.NgSinh.VisibleIndex = 2;
            // 
            // Sdt
            // 
            this.Sdt.Caption = "Số điện thoại";
            this.Sdt.FieldName = "SODIENTHOAI";
            this.Sdt.Name = "Sdt";
            this.Sdt.Visible = true;
            this.Sdt.VisibleIndex = 3;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DIACHI";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 4;
            // 
            // MonHoc
            // 
            this.MonHoc.Caption = "Môn học";
            this.MonHoc.FieldName = "MAMON";
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.Visible = true;
            this.MonHoc.VisibleIndex = 5;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới tính";
            this.GioiTinh.FieldName = "GIOITINH";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 6;
            // 
            // MatKhau
            // 
            this.MatKhau.Caption = "Mật khẩu";
            this.MatKhau.FieldName = "MATKHAU";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Visible = true;
            this.MatKhau.VisibleIndex = 7;
            // 
            // QLGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 605);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "QLGiaoVien";
            this.Tag = "8";
            this.Text = "Quản lý giáo viên";
            this.Load += new System.EventHandler(this.QLGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edtDchi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMagv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraEditors.TextEdit edtDchi;
        private DevExpress.XtraEditors.TextEdit edtSdt;
        private DevExpress.XtraEditors.TextEdit edtHoten;
        private DevExpress.XtraEditors.TextEdit edtMagv;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaGV;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn NgSinh;
        private DevExpress.XtraGrid.Columns.GridColumn Sdt;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private System.Windows.Forms.DateTimePicker dateNgsinh;
        private System.Windows.Forms.ComboBox cboMH;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn MonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn MatKhau;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}
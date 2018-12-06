namespace ApplicationWinform
{
    partial class QLKhoaHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLKhoaHoc));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dateKT = new DevExpress.XtraEditors.DateEdit();
            this.dateBD = new DevExpress.XtraEditors.DateEdit();
            this.edtTenkhoa = new DevExpress.XtraEditors.TextEdit();
            this.edtMakhoa = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenkhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMakhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.btnCancel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1067, 177);
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
            this.btnDel.Caption = "Xóa dữ liệu.";
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý khóa học";
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
            this.layoutControl1.Controls.Add(this.dateKT);
            this.layoutControl1.Controls.Add(this.dateBD);
            this.layoutControl1.Controls.Add(this.edtTenkhoa);
            this.layoutControl1.Controls.Add(this.edtMakhoa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 177);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1067, 120);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dateKT
            // 
            this.dateKT.EditValue = null;
            this.dateKT.Location = new System.Drawing.Point(627, 44);
            this.dateKT.MenuManager = this.ribbonControl1;
            this.dateKT.Name = "dateKT";
            this.dateKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateKT.Size = new System.Drawing.Size(424, 22);
            this.dateKT.StyleController = this.layoutControl1;
            this.dateKT.TabIndex = 7;
            // 
            // dateBD
            // 
            this.dateBD.EditValue = null;
            this.dateBD.Location = new System.Drawing.Point(107, 44);
            this.dateBD.MenuManager = this.ribbonControl1;
            this.dateBD.Name = "dateBD";
            this.dateBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBD.Size = new System.Drawing.Size(423, 22);
            this.dateBD.StyleController = this.layoutControl1;
            this.dateBD.TabIndex = 6;
            // 
            // edtTenkhoa
            // 
            this.edtTenkhoa.Location = new System.Drawing.Point(627, 16);
            this.edtTenkhoa.MenuManager = this.ribbonControl1;
            this.edtTenkhoa.Name = "edtTenkhoa";
            this.edtTenkhoa.Size = new System.Drawing.Size(424, 22);
            this.edtTenkhoa.StyleController = this.layoutControl1;
            this.edtTenkhoa.TabIndex = 5;
            // 
            // edtMakhoa
            // 
            this.edtMakhoa.Location = new System.Drawing.Point(107, 16);
            this.edtMakhoa.MenuManager = this.ribbonControl1;
            this.edtMakhoa.Name = "edtMakhoa";
            this.edtMakhoa.Size = new System.Drawing.Size(423, 22);
            this.edtMakhoa.StyleController = this.layoutControl1;
            this.edtMakhoa.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1067, 120);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.edtMakhoa;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(520, 28);
            this.layoutControlItem1.Text = "Mã khóa học";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(87, 17);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 56);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1041, 38);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.edtTenkhoa;
            this.layoutControlItem2.Location = new System.Drawing.Point(520, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(521, 28);
            this.layoutControlItem2.Text = "Tên khóa học";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(87, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateBD;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(520, 28);
            this.layoutControlItem3.Text = "Ngày bắt đầu";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(87, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dateKT;
            this.layoutControlItem4.Location = new System.Drawing.Point(520, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(521, 28);
            this.layoutControlItem4.Text = "Ngày kết thúc";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(87, 17);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 297);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1067, 382);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKhoa,
            this.TenKhoa,
            this.NgayBD,
            this.NgayKT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MaKhoa
            // 
            this.MaKhoa.Caption = "Mã khóa học";
            this.MaKhoa.FieldName = "MAKHOAHOC";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Visible = true;
            this.MaKhoa.VisibleIndex = 0;
            // 
            // TenKhoa
            // 
            this.TenKhoa.Caption = "Tên khóa học";
            this.TenKhoa.FieldName = "TENKHOAHOC";
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.Visible = true;
            this.TenKhoa.VisibleIndex = 1;
            // 
            // NgayBD
            // 
            this.NgayBD.Caption = "Ngày bắt đầu";
            this.NgayBD.FieldName = "NGAYBATDAU";
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.Visible = true;
            this.NgayBD.VisibleIndex = 2;
            // 
            // NgayKT
            // 
            this.NgayKT.Caption = "Ngày kết thúc";
            this.NgayKT.FieldName = "NGAYKETTHUC";
            this.NgayKT.Name = "NgayKT";
            this.NgayKT.Visible = true;
            this.NgayKT.VisibleIndex = 3;
            // 
            // QLKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 679);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "QLKhoaHoc";
            this.Tag = "11";
            this.Text = "Quản lý khóa học";
            this.Load += new System.EventHandler(this.QLKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenkhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMakhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit edtTenkhoa;
        private DevExpress.XtraEditors.TextEdit edtMakhoa;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DateEdit dateKT;
        private DevExpress.XtraEditors.DateEdit dateBD;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn TenKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn NgayBD;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKT;
    }
}
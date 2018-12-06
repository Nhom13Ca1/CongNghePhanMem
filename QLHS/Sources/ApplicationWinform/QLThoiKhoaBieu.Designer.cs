namespace ApplicationWinform
{
    partial class QLThoiKhoaBieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLThoiKhoaBieu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtPhong = new DevExpress.XtraEditors.TextEdit();
            this.txtTenlop = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridLop = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhoaHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SiSo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenlop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(1052, 167);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm mới";
            this.btnAdd.Id = 1;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Name = "btnAdd";
            // 
            // btnDel
            // 
            this.btnDel.Caption = "Xóa dữ liệu";
            this.btnDel.Id = 2;
            this.btnDel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDel.ImageOptions.SvgImage")));
            this.btnDel.Name = "btnDel";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Sửa dữ liệu";
            this.btnUpdate.Id = 3;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Name = "btnUpdate";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu thay đổi";
            this.btnSave.Id = 4;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Name = "btnSave";
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Hủy thay đổi";
            this.btnCancel.Id = 5;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Name = "btnCancel";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý lớp học";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDel);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUpdate);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCancel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.comboBox1);
            this.layoutControl1.Controls.Add(this.txtMaLop);
            this.layoutControl1.Controls.Add(this.cboLop);
            this.layoutControl1.Controls.Add(this.txtPhong);
            this.layoutControl1.Controls.Add(this.txtTenlop);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 167);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1052, 120);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(414, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(621, 16);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(415, 25);
            this.txtMaLop.TabIndex = 13;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(109, 16);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(413, 24);
            this.cboLop.TabIndex = 12;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(622, 48);
            this.txtPhong.MenuManager = this.ribbonControl1;
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(414, 22);
            this.txtPhong.StyleController = this.layoutControl1;
            this.txtPhong.TabIndex = 7;
            // 
            // txtTenlop
            // 
            this.txtTenlop.Location = new System.Drawing.Point(109, 48);
            this.txtTenlop.MenuManager = this.ribbonControl1;
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(414, 22);
            this.txtTenlop.StyleController = this.layoutControl1;
            this.txtTenlop.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1052, 120);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(513, 60);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(513, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtTenlop;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(513, 28);
            this.layoutControlItem3.Text = "Tên lớp";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(89, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtPhong;
            this.layoutControlItem4.Location = new System.Drawing.Point(513, 32);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(513, 28);
            this.layoutControlItem4.Text = "Sĩ số";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(89, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboLop;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(512, 32);
            this.layoutControlItem1.Text = "Khối";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(89, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMaLop;
            this.layoutControlItem2.Location = new System.Drawing.Point(512, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(514, 32);
            this.layoutControlItem2.Text = "Mã lớp";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(89, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.comboBox1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(513, 34);
            this.layoutControlItem5.Text = "Thời khóa biểu";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(89, 17);
            // 
            // gridLop
            // 
            this.gridLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLop.Location = new System.Drawing.Point(0, 287);
            this.gridLop.MainView = this.gridView1;
            this.gridLop.MenuManager = this.ribbonControl1;
            this.gridLop.Name = "gridLop";
            this.gridLop.Size = new System.Drawing.Size(1052, 396);
            this.gridLop.TabIndex = 5;
            this.gridLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaLop,
            this.KhoaHoc,
            this.TenLop,
            this.SiSo});
            this.gridView1.GridControl = this.gridLop;
            this.gridView1.Name = "gridView1";
            // 
            // MaLop
            // 
            this.MaLop.Caption = "Mã lớp";
            this.MaLop.FieldName = "MALOP";
            this.MaLop.Name = "MaLop";
            this.MaLop.Visible = true;
            this.MaLop.VisibleIndex = 0;
            // 
            // KhoaHoc
            // 
            this.KhoaHoc.Caption = "Khối";
            this.KhoaHoc.FieldName = "MAKHOI";
            this.KhoaHoc.Name = "KhoaHoc";
            this.KhoaHoc.Visible = true;
            this.KhoaHoc.VisibleIndex = 1;
            // 
            // TenLop
            // 
            this.TenLop.Caption = "Tên lớp";
            this.TenLop.FieldName = "TENLOP";
            this.TenLop.Name = "TenLop";
            this.TenLop.Visible = true;
            this.TenLop.VisibleIndex = 2;
            // 
            // SiSo
            // 
            this.SiSo.Caption = "Sĩ số";
            this.SiSo.FieldName = "SISO";
            this.SiSo.Name = "SiSo";
            this.SiSo.Visible = true;
            this.SiSo.VisibleIndex = 3;
            // 
            // QLThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 683);
            this.Controls.Add(this.gridLop);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "QLThoiKhoaBieu";
            this.Text = "QLThoiKhoaBieu";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenlop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.ComboBox cboLop;
        private DevExpress.XtraEditors.TextEdit txtPhong;
        private DevExpress.XtraEditors.TextEdit txtTenlop;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl gridLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaLop;
        private DevExpress.XtraGrid.Columns.GridColumn KhoaHoc;
        private DevExpress.XtraGrid.Columns.GridColumn TenLop;
        private DevExpress.XtraGrid.Columns.GridColumn SiSo;
    }
}
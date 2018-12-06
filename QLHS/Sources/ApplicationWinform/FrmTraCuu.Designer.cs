namespace ApplicationWinform
{
    partial class FrmTraCuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTraCuu));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.cboHV = new System.Windows.Forms.ComboBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.label8);
            this.layoutControl1.Controls.Add(this.btnFind);
            this.layoutControl1.Controls.Add(this.cboHV);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(525, 74);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnFind
            // 
            this.btnFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.ImageOptions.Image")));
            this.btnFind.Location = new System.Drawing.Point(400, 16);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(109, 40);
            this.btnFind.StyleController = this.layoutControl1;
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cboHV
            // 
            this.cboHV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboHV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboHV.FormattingEnabled = true;
            this.cboHV.Location = new System.Drawing.Point(83, 16);
            this.cboHV.Name = "cboHV";
            this.cboHV.Size = new System.Drawing.Size(172, 24);
            this.cboHV.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(525, 74);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 48);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnFind;
            this.layoutControlItem2.Location = new System.Drawing.Point(384, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(115, 48);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboHV;
            this.layoutControlItem1.Location = new System.Drawing.Point(10, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(235, 48);
            this.layoutControlItem1.Text = "Học viên";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(53, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã học viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên học viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giới tính";
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(154, 96);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.ReadOnly = true;
            this.txtMaHV.Size = new System.Drawing.Size(318, 22);
            this.txtMaHV.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(154, 124);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(318, 22);
            this.txtTen.TabIndex = 8;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(154, 152);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(318, 22);
            this.txtDate.TabIndex = 9;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(154, 180);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.ReadOnly = true;
            this.txtAddr.Size = new System.Drawing.Size(318, 22);
            this.txtAddr.TabIndex = 10;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(154, 208);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.ReadOnly = true;
            this.txtSdt.Size = new System.Drawing.Size(318, 22);
            this.txtSdt.TabIndex = 11;
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(154, 236);
            this.txtGT.Name = "txtGT";
            this.txtGT.ReadOnly = true;
            this.txtGT.Size = new System.Drawing.Size(318, 22);
            this.txtGT.TabIndex = 12;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(154, 264);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.ReadOnly = true;
            this.txtDiem.Size = new System.Drawing.Size(318, 22);
            this.txtDiem.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Điểm";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(261, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 42);
            this.label8.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.label8;
            this.layoutControlItem3.Location = new System.Drawing.Point(245, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(139, 48);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // FrmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 377);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMaHV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmTraCuu";
            this.Tag = "7";
            this.Text = "FrmTraCuu";
            this.Load += new System.EventHandler(this.FrmTraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private System.Windows.Forms.ComboBox cboHV;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
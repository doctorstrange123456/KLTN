namespace KhoaLuanTotNghiep.ChucNang
{
    partial class frmHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDong));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tblKhachHangaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHopDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grbHopDong = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiPhiNop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiPhiConLai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVanDonThang = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.DateFrom = new DevExpress.XtraEditors.DateEdit();
            this.DateTo = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHopDongBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grbHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1260, 177);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm mới";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa thông tin ";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Lưu thông tin";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xóa thông tin";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Thêm hợp đồng";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "In hợp đồng";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Thoát";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Mẫu hợp đồng";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh sách hợp đồng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hợp đồng";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "In";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Chức năng";
            // 
            // tblKhachHangaBindingSource
            // 
            this.tblKhachHangaBindingSource.DataSource = typeof(KhoaLuanTotNghiep.tbl_KhachHanga);
            // 
            // tblHopDongBindingSource
            // 
            this.tblHopDongBindingSource.DataSource = typeof(KhoaLuanTotNghiep.tbl_HopDong);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1260, 524);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grbHopDong);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1260, 465);
            this.panel4.TabIndex = 6;
            // 
            // grbHopDong
            // 
            this.grbHopDong.Controls.Add(this.gridControl1);
            this.grbHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbHopDong.Location = new System.Drawing.Point(0, 0);
            this.grbHopDong.Name = "grbHopDong";
            this.grbHopDong.Size = new System.Drawing.Size(1260, 465);
            this.grbHopDong.TabIndex = 4;
            this.grbHopDong.TabStop = false;
            this.grbHopDong.Text = "Hợp đồng";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblHopDongBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 19);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1254, 443);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIDHD,
            this.colNameHD,
            this.colNgayKy,
            this.colChiPhi,
            this.colChiPhiNop,
            this.colChiPhiConLai});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colIDHD
            // 
            this.colIDHD.Caption = "ID hợp đồng";
            this.colIDHD.FieldName = "IDHD";
            this.colIDHD.Name = "colIDHD";
            this.colIDHD.Visible = true;
            this.colIDHD.VisibleIndex = 1;
            // 
            // colNameHD
            // 
            this.colNameHD.Caption = "Tên hợp đồng";
            this.colNameHD.FieldName = "NameHD";
            this.colNameHD.Name = "colNameHD";
            this.colNameHD.Visible = true;
            this.colNameHD.VisibleIndex = 2;
            // 
            // colNgayKy
            // 
            this.colNgayKy.Caption = "Ngày ký";
            this.colNgayKy.DisplayFormat.FormatString = "d/MM/yyyy";
            this.colNgayKy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayKy.FieldName = "NgayKy";
            this.colNgayKy.Name = "colNgayKy";
            this.colNgayKy.Visible = true;
            this.colNgayKy.VisibleIndex = 3;
            // 
            // colChiPhi
            // 
            this.colChiPhi.Caption = "Chi phí";
            this.colChiPhi.DisplayFormat.FormatString = "c";
            this.colChiPhi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colChiPhi.FieldName = "ChiPhi";
            this.colChiPhi.Name = "colChiPhi";
            this.colChiPhi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ChiPhi", "{0:0.##}")});
            this.colChiPhi.Visible = true;
            this.colChiPhi.VisibleIndex = 4;
            // 
            // colChiPhiNop
            // 
            this.colChiPhiNop.Caption = "Số tiền đã đưa";
            this.colChiPhiNop.DisplayFormat.FormatString = "c";
            this.colChiPhiNop.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colChiPhiNop.FieldName = "ChiPhiNop";
            this.colChiPhiNop.Name = "colChiPhiNop";
            this.colChiPhiNop.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ChiPhiNop", "{0:0.##}")});
            this.colChiPhiNop.Visible = true;
            this.colChiPhiNop.VisibleIndex = 5;
            // 
            // colChiPhiConLai
            // 
            this.colChiPhiConLai.Caption = "Số tiền còn lại";
            this.colChiPhiConLai.DisplayFormat.FormatString = "c";
            this.colChiPhiConLai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colChiPhiConLai.FieldName = "Thanhtiencal";
            this.colChiPhiConLai.Name = "colChiPhiConLai";
            this.colChiPhiConLai.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Thanhtiencal", "{0:0.##}")});
            this.colChiPhiConLai.Visible = true;
            this.colChiPhiConLai.VisibleIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 59);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnVanDonThang);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.DateFrom);
            this.panel2.Controls.Add(this.DateTo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 57);
            this.panel2.TabIndex = 7;
            // 
            // btnVanDonThang
            // 
            this.btnVanDonThang.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVanDonThang.Appearance.Options.UseFont = true;
            this.btnVanDonThang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVanDonThang.ImageOptions.Image")));
            this.btnVanDonThang.Location = new System.Drawing.Point(811, 8);
            this.btnVanDonThang.Name = "btnVanDonThang";
            this.btnVanDonThang.Size = new System.Drawing.Size(95, 30);
            this.btnVanDonThang.TabIndex = 4;
            this.btnVanDonThang.Text = "VĐ Month";
            this.btnVanDonThang.Click += new System.EventHandler(this.btnVanDonThang_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(710, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 30);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(441, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 21);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Đến ngày";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(133, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 21);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Từ ngày";
            // 
            // DateFrom
            // 
            this.DateFrom.EditValue = null;
            this.DateFrom.Location = new System.Drawing.Point(203, 8);
            this.DateFrom.MenuManager = this.ribbonControl1;
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Properties.AutoHeight = false;
            this.DateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateFrom.Properties.DisplayFormat.FormatString = "d/MM/yyyy";
            this.DateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateFrom.Properties.EditFormat.FormatString = "d/MM/yyyy";
            this.DateFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateFrom.Properties.Mask.EditMask = "";
            this.DateFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.DateFrom.Size = new System.Drawing.Size(184, 25);
            this.DateFrom.TabIndex = 0;
            // 
            // DateTo
            // 
            this.DateTo.EditValue = null;
            this.DateTo.Location = new System.Drawing.Point(520, 8);
            this.DateTo.MenuManager = this.ribbonControl1;
            this.DateTo.Name = "DateTo";
            this.DateTo.Properties.AutoHeight = false;
            this.DateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTo.Properties.DisplayFormat.FormatString = "d/MM/yyyy";
            this.DateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTo.Properties.EditFormat.FormatString = "d/MM/yyyy";
            this.DateTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTo.Properties.Mask.EditMask = "";
            this.DateTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.DateTo.Size = new System.Drawing.Size(184, 25);
            this.DateTo.TabIndex = 1;
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 701);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHopDong";
            this.Text = "frmHopDong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHopDongBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.grbHopDong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.BindingSource tblKhachHangaBindingSource;
        private System.Windows.Forms.BindingSource tblHopDongBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grbHopDong;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDHD;
        private DevExpress.XtraGrid.Columns.GridColumn colNameHD;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKy;
        private DevExpress.XtraGrid.Columns.GridColumn colChiPhi;
        private DevExpress.XtraGrid.Columns.GridColumn colChiPhiNop;
        private DevExpress.XtraGrid.Columns.GridColumn colChiPhiConLai;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnVanDonThang;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit DateFrom;
        private DevExpress.XtraEditors.DateEdit DateTo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
    }
}
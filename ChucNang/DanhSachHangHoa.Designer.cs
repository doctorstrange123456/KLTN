namespace KhoaLuanTotNghiep.ChucNang
{
    partial class DanhSachHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachHangHoa));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tblKhachHangaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tblHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDPLHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrongLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDDongGoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDHTVC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDXNKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.barButtonItem5});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1110, 177);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thông tin hàng hóa";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa thông tin";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thoát";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "In danh sách";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh sách hàng hóa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Chức năng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "In";
            // 
            // tblKhachHangaBindingSource
            // 
            this.tblKhachHangaBindingSource.DataSource = typeof(KhoaLuanTotNghiep.tbl_KhachHanga);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblHangHoaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 177);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1110, 432);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tblHangHoaBindingSource
            // 
            this.tblHangHoaBindingSource.DataSource = typeof(KhoaLuanTotNghiep.tbl_HangHoa);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIDHH,
            this.colTenHH,
            this.colNgayNhap,
            this.colNgayXuat,
            this.colSoLuong,
            this.colDonGia,
            this.colIDPLHH,
            this.colTrongLuong,
            this.colVAT,
            this.colThanhTien,
            this.colIDDongGoi,
            this.colIDHTVC,
            this.colIDKH,
            this.colIDXNKhau});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 42;
            // 
            // colIDHH
            // 
            this.colIDHH.Caption = "ID hàng hóa";
            this.colIDHH.FieldName = "IDHH";
            this.colIDHH.Name = "colIDHH";
            this.colIDHH.Visible = true;
            this.colIDHH.VisibleIndex = 1;
            this.colIDHH.Width = 81;
            // 
            // colTenHH
            // 
            this.colTenHH.Caption = "Tên hàng hóa";
            this.colTenHH.FieldName = "TenHH";
            this.colTenHH.Name = "colTenHH";
            this.colTenHH.Visible = true;
            this.colTenHH.VisibleIndex = 2;
            this.colTenHH.Width = 111;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.Caption = "Ngày nhập";
            this.colNgayNhap.FieldName = "NgayNhap";
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.Visible = true;
            this.colNgayNhap.VisibleIndex = 3;
            this.colNgayNhap.Width = 97;
            // 
            // colNgayXuat
            // 
            this.colNgayXuat.Caption = "Ngày xuất";
            this.colNgayXuat.FieldName = "NgayXuat";
            this.colNgayXuat.Name = "colNgayXuat";
            this.colNgayXuat.Visible = true;
            this.colNgayXuat.VisibleIndex = 4;
            this.colNgayXuat.Width = 89;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 5;
            this.colSoLuong.Width = 77;
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn giá";
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 6;
            this.colDonGia.Width = 76;
            // 
            // colIDPLHH
            // 
            this.colIDPLHH.Caption = "Phân loại hàng hóa";
            this.colIDPLHH.FieldName = "IDPLHH";
            this.colIDPLHH.Name = "colIDPLHH";
            this.colIDPLHH.Visible = true;
            this.colIDPLHH.VisibleIndex = 7;
            this.colIDPLHH.Width = 123;
            // 
            // colTrongLuong
            // 
            this.colTrongLuong.Caption = "Trọng lượng";
            this.colTrongLuong.FieldName = "TrongLuong";
            this.colTrongLuong.Name = "colTrongLuong";
            this.colTrongLuong.Visible = true;
            this.colTrongLuong.VisibleIndex = 8;
            this.colTrongLuong.Width = 123;
            // 
            // colVAT
            // 
            this.colVAT.Caption = "VAT";
            this.colVAT.FieldName = "VAT";
            this.colVAT.Name = "colVAT";
            this.colVAT.Visible = true;
            this.colVAT.VisibleIndex = 9;
            this.colVAT.Width = 54;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Caption = "Thành tiền";
            this.colThanhTien.FieldName = "ThanhTien";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ThanhTien", "SUM={0:0.##}")});
            this.colThanhTien.Visible = true;
            this.colThanhTien.VisibleIndex = 10;
            this.colThanhTien.Width = 173;
            // 
            // colIDDongGoi
            // 
            this.colIDDongGoi.Caption = "Đóng gói";
            this.colIDDongGoi.FieldName = "IDDongGoi";
            this.colIDDongGoi.Name = "colIDDongGoi";
            this.colIDDongGoi.Visible = true;
            this.colIDDongGoi.VisibleIndex = 11;
            this.colIDDongGoi.Width = 127;
            // 
            // colIDHTVC
            // 
            this.colIDHTVC.Caption = "Hình thức vận chuyển";
            this.colIDHTVC.FieldName = "IDHTVC";
            this.colIDHTVC.Name = "colIDHTVC";
            this.colIDHTVC.Visible = true;
            this.colIDHTVC.VisibleIndex = 12;
            this.colIDHTVC.Width = 127;
            // 
            // colIDKH
            // 
            this.colIDKH.Caption = "Khách hàng";
            this.colIDKH.FieldName = "IDKH";
            this.colIDKH.Name = "colIDKH";
            this.colIDKH.Visible = true;
            this.colIDKH.VisibleIndex = 13;
            this.colIDKH.Width = 127;
            // 
            // colIDXNKhau
            // 
            this.colIDXNKhau.Caption = "Xuất/Nhập khẩu";
            this.colIDXNKhau.FieldName = "IDXNKhau";
            this.colIDXNKhau.Name = "colIDXNKhau";
            this.colIDXNKhau.Visible = true;
            this.colIDXNKhau.VisibleIndex = 14;
            this.colIDXNKhau.Width = 150;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // DanhSachHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 609);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachHangHoa";
            this.Text = "DanhSachHangHoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhSachHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.BindingSource tblKhachHangaBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource tblHangHoaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDHH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHH;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colIDPLHH;
        private DevExpress.XtraGrid.Columns.GridColumn colTrongLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colVAT;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDongGoi;
        private DevExpress.XtraGrid.Columns.GridColumn colIDHTVC;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKH;
        private DevExpress.XtraGrid.Columns.GridColumn colIDXNKhau;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    }
}
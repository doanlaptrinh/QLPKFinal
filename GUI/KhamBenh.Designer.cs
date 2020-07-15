namespace GUI
{
    partial class KhamBenh
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
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtSlThuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInDonThuoc = new System.Windows.Forms.Button();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.btnXoaKiemTra = new System.Windows.Forms.Button();
            this.btnThemKiemTra = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbIdKiemTra = new System.Windows.Forms.ComboBox();
            this.cbIdThuoc = new System.Windows.Forms.ComboBox();
            this.txtChuanDoan = new System.Windows.Forms.TextBox();
            this.txtGetIDBenhNhan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaDonThuoc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lichSuKhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongKhamDataSet = new GUI.QuanLyPhongKhamDataSet();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.phieuKiemTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiKiemTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDPhienKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lichSuKhamTableAdapter = new GUI.QuanLyPhongKhamDataSetTableAdapters.LichSuKhamTableAdapter();
            this.phieuKiemTraTableAdapter = new GUI.QuanLyPhongKhamDataSetTableAdapters.PhieuKiemTraTableAdapter();
            this.phieuDonThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuDonThuocTableAdapter = new GUI.QuanLyPhongKhamDataSetTableAdapters.PhieuDonThuocTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDPhienKham2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDBenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenBenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenBacSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuanDoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChuKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLieuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDPhienKham1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lichSuKhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuKiemTraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuDonThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGhiChu.Location = new System.Drawing.Point(90, 749);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(252, 52);
            this.txtGhiChu.TabIndex = 122;
            this.txtGhiChu.Text = "";
            // 
            // txtSlThuoc
            // 
            this.txtSlThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSlThuoc.Location = new System.Drawing.Point(300, 510);
            this.txtSlThuoc.Name = "txtSlThuoc";
            this.txtSlThuoc.Size = new System.Drawing.Size(67, 23);
            this.txtSlThuoc.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 120;
            this.label1.Text = "SL";
            // 
            // txtInDonThuoc
            // 
            this.txtInDonThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInDonThuoc.Location = new System.Drawing.Point(510, 771);
            this.txtInDonThuoc.Name = "txtInDonThuoc";
            this.txtInDonThuoc.Size = new System.Drawing.Size(115, 30);
            this.txtInDonThuoc.TabIndex = 118;
            this.txtInDonThuoc.Text = "In Đơn Thuốc";
            this.txtInDonThuoc.UseVisualStyleBackColor = true;
            this.txtInDonThuoc.Click += new System.EventHandler(this.txtInDonThuoc_Click);
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemThuoc.Location = new System.Drawing.Point(373, 510);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(75, 23);
            this.btnThemThuoc.TabIndex = 116;
            this.btnThemThuoc.Text = "Thêm";
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // btnXoaKiemTra
            // 
            this.btnXoaKiemTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaKiemTra.Location = new System.Drawing.Point(998, 487);
            this.btnXoaKiemTra.Name = "btnXoaKiemTra";
            this.btnXoaKiemTra.Size = new System.Drawing.Size(113, 23);
            this.btnXoaKiemTra.TabIndex = 115;
            this.btnXoaKiemTra.Text = "Xóa Kiểm Tra";
            this.btnXoaKiemTra.UseVisualStyleBackColor = true;
            this.btnXoaKiemTra.Click += new System.EventHandler(this.btnXoaKiemTra_Click);
            // 
            // btnThemKiemTra
            // 
            this.btnThemKiemTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemKiemTra.Location = new System.Drawing.Point(271, 249);
            this.btnThemKiemTra.Name = "btnThemKiemTra";
            this.btnThemKiemTra.Size = new System.Drawing.Size(75, 23);
            this.btnThemKiemTra.TabIndex = 114;
            this.btnThemKiemTra.Text = "Thêm";
            this.btnThemKiemTra.UseVisualStyleBackColor = true;
            this.btnThemKiemTra.Click += new System.EventHandler(this.btnThemKiemTra_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Location = new System.Drawing.Point(270, 1);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 117;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbIdKiemTra
            // 
            this.cbIdKiemTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbIdKiemTra.FormattingEnabled = true;
            this.cbIdKiemTra.Items.AddRange(new object[] {
            "Xét Nghiệm Máu",
            "Chụp X Quang",
            "Đo Huyết Áp"});
            this.cbIdKiemTra.Location = new System.Drawing.Point(127, 248);
            this.cbIdKiemTra.Name = "cbIdKiemTra";
            this.cbIdKiemTra.Size = new System.Drawing.Size(138, 24);
            this.cbIdKiemTra.TabIndex = 113;
            this.cbIdKiemTra.Text = "Xét Nghiệm Máu";
            // 
            // cbIdThuoc
            // 
            this.cbIdThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbIdThuoc.FormattingEnabled = true;
            this.cbIdThuoc.Items.AddRange(new object[] {
            "Thuốc A",
            "Thuốc B",
            "Thuốc C"});
            this.cbIdThuoc.Location = new System.Drawing.Point(121, 509);
            this.cbIdThuoc.Name = "cbIdThuoc";
            this.cbIdThuoc.Size = new System.Drawing.Size(144, 24);
            this.cbIdThuoc.TabIndex = 112;
            // 
            // txtChuanDoan
            // 
            this.txtChuanDoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtChuanDoan.Location = new System.Drawing.Point(121, 475);
            this.txtChuanDoan.Name = "txtChuanDoan";
            this.txtChuanDoan.Size = new System.Drawing.Size(238, 23);
            this.txtChuanDoan.TabIndex = 111;
            // 
            // txtGetIDBenhNhan
            // 
            this.txtGetIDBenhNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGetIDBenhNhan.Location = new System.Drawing.Point(126, 1);
            this.txtGetIDBenhNhan.Name = "txtGetIDBenhNhan";
            this.txtGetIDBenhNhan.Size = new System.Drawing.Size(138, 23);
            this.txtGetIDBenhNhan.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 109;
            this.label5.Text = "Kê đơn thuốc";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 108;
            this.label4.Text = "Kiểm tra";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 107;
            this.label3.Text = "ID Bệnh Nhân";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 752);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 106;
            this.label6.Text = "Ghi Chú";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 105;
            this.label2.Text = "Chuẩn Đoán";
            // 
            // btnXoaDonThuoc
            // 
            this.btnXoaDonThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaDonThuoc.Location = new System.Drawing.Point(995, 749);
            this.btnXoaDonThuoc.Name = "btnXoaDonThuoc";
            this.btnXoaDonThuoc.Size = new System.Drawing.Size(113, 23);
            this.btnXoaDonThuoc.TabIndex = 103;
            this.btnXoaDonThuoc.Text = "Xóa Đơn Thuốc";
            this.btnXoaDonThuoc.UseVisualStyleBackColor = true;
            this.btnXoaDonThuoc.Click += new System.EventHandler(this.btnXoaDonThuoc_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Location = new System.Drawing.Point(994, 239);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 23);
            this.btnXoa.TabIndex = 104;
            this.btnXoa.Text = "Xóa Bệnh Án";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lichSuKhamBindingSource
            // 
            this.lichSuKhamBindingSource.DataMember = "LichSuKham";
            this.lichSuKhamBindingSource.DataSource = this.quanLyPhongKhamDataSet;
            // 
            // quanLyPhongKhamDataSet
            // 
            this.quanLyPhongKhamDataSet.DataSetName = "QuanLyPhongKhamDataSet";
            this.quanLyPhongKhamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridControl2.DataSource = this.phieuKiemTraBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(33, 272);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1075, 197);
            this.gridControl2.TabIndex = 130;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // phieuKiemTraBindingSource
            // 
            this.phieuKiemTraBindingSource.DataMember = "PhieuKiemTra";
            this.phieuKiemTraBindingSource.DataSource = this.quanLyPhongKhamDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colLoaiKiemTra,
            this.colGiaTien,
            this.colIDPhienKham});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.MinWidth = 25;
            this.colID1.Name = "colID1";
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            this.colID1.Width = 94;
            // 
            // colLoaiKiemTra
            // 
            this.colLoaiKiemTra.FieldName = "LoaiKiemTra";
            this.colLoaiKiemTra.MinWidth = 25;
            this.colLoaiKiemTra.Name = "colLoaiKiemTra";
            this.colLoaiKiemTra.Visible = true;
            this.colLoaiKiemTra.VisibleIndex = 1;
            this.colLoaiKiemTra.Width = 94;
            // 
            // colGiaTien
            // 
            this.colGiaTien.FieldName = "GiaTien";
            this.colGiaTien.MinWidth = 25;
            this.colGiaTien.Name = "colGiaTien";
            this.colGiaTien.Visible = true;
            this.colGiaTien.VisibleIndex = 2;
            this.colGiaTien.Width = 94;
            // 
            // colIDPhienKham
            // 
            this.colIDPhienKham.FieldName = "IDPhienKham";
            this.colIDPhienKham.MinWidth = 25;
            this.colIDPhienKham.Name = "colIDPhienKham";
            this.colIDPhienKham.Visible = true;
            this.colIDPhienKham.VisibleIndex = 3;
            this.colIDPhienKham.Width = 94;
            // 
            // lichSuKhamTableAdapter
            // 
            this.lichSuKhamTableAdapter.ClearBeforeFill = true;
            // 
            // phieuKiemTraTableAdapter
            // 
            this.phieuKiemTraTableAdapter.ClearBeforeFill = true;
            // 
            // phieuDonThuocBindingSource
            // 
            this.phieuDonThuocBindingSource.DataMember = "PhieuDonThuoc";
            this.phieuDonThuocBindingSource.DataSource = this.quanLyPhongKhamDataSet;
            // 
            // phieuDonThuocTableAdapter
            // 
            this.phieuDonThuocTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridControl1.DataSource = this.lichSuKhamBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(37, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1071, 208);
            this.gridControl1.TabIndex = 132;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDPhienKham2,
            this.colIDBenhNhan,
            this.colTenBenhNhan,
            this.colNgayKham,
            this.colTenBacSi,
            this.colChuanDoan,
            this.colGhiChuKham});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIDPhienKham2
            // 
            this.colIDPhienKham2.FieldName = "IDPhienKham";
            this.colIDPhienKham2.MinWidth = 25;
            this.colIDPhienKham2.Name = "colIDPhienKham2";
            this.colIDPhienKham2.Visible = true;
            this.colIDPhienKham2.VisibleIndex = 0;
            this.colIDPhienKham2.Width = 94;
            // 
            // colIDBenhNhan
            // 
            this.colIDBenhNhan.FieldName = "IDBenhNhan";
            this.colIDBenhNhan.MinWidth = 25;
            this.colIDBenhNhan.Name = "colIDBenhNhan";
            this.colIDBenhNhan.Visible = true;
            this.colIDBenhNhan.VisibleIndex = 1;
            this.colIDBenhNhan.Width = 94;
            // 
            // colTenBenhNhan
            // 
            this.colTenBenhNhan.FieldName = "TenBenhNhan";
            this.colTenBenhNhan.MinWidth = 25;
            this.colTenBenhNhan.Name = "colTenBenhNhan";
            this.colTenBenhNhan.Visible = true;
            this.colTenBenhNhan.VisibleIndex = 2;
            this.colTenBenhNhan.Width = 94;
            // 
            // colNgayKham
            // 
            this.colNgayKham.FieldName = "NgayKham";
            this.colNgayKham.MinWidth = 25;
            this.colNgayKham.Name = "colNgayKham";
            this.colNgayKham.Visible = true;
            this.colNgayKham.VisibleIndex = 3;
            this.colNgayKham.Width = 94;
            // 
            // colTenBacSi
            // 
            this.colTenBacSi.FieldName = "TenBacSi";
            this.colTenBacSi.MinWidth = 25;
            this.colTenBacSi.Name = "colTenBacSi";
            this.colTenBacSi.Visible = true;
            this.colTenBacSi.VisibleIndex = 4;
            this.colTenBacSi.Width = 94;
            // 
            // colChuanDoan
            // 
            this.colChuanDoan.FieldName = "ChuanDoan";
            this.colChuanDoan.MinWidth = 25;
            this.colChuanDoan.Name = "colChuanDoan";
            this.colChuanDoan.Visible = true;
            this.colChuanDoan.VisibleIndex = 5;
            this.colChuanDoan.Width = 94;
            // 
            // colGhiChuKham
            // 
            this.colGhiChuKham.FieldName = "GhiChuKham";
            this.colGhiChuKham.MinWidth = 25;
            this.colGhiChuKham.Name = "colGhiChuKham";
            this.colGhiChuKham.Visible = true;
            this.colGhiChuKham.VisibleIndex = 6;
            this.colGhiChuKham.Width = 94;
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridControl3.DataSource = this.phieuDonThuocBindingSource;
            this.gridControl3.Location = new System.Drawing.Point(33, 543);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(1075, 200);
            this.gridControl3.TabIndex = 133;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTenThuoc,
            this.colDonViTinh,
            this.colSoLuong,
            this.colLieuDung,
            this.colGhiChu,
            this.colDonGia,
            this.colIDPhienKham1});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colTenThuoc
            // 
            this.colTenThuoc.FieldName = "TenThuoc";
            this.colTenThuoc.MinWidth = 25;
            this.colTenThuoc.Name = "colTenThuoc";
            this.colTenThuoc.Visible = true;
            this.colTenThuoc.VisibleIndex = 1;
            this.colTenThuoc.Width = 94;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.MinWidth = 25;
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 2;
            this.colDonViTinh.Width = 94;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.MinWidth = 25;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 3;
            this.colSoLuong.Width = 94;
            // 
            // colLieuDung
            // 
            this.colLieuDung.FieldName = "LieuDung";
            this.colLieuDung.MinWidth = 25;
            this.colLieuDung.Name = "colLieuDung";
            this.colLieuDung.Visible = true;
            this.colLieuDung.VisibleIndex = 4;
            this.colLieuDung.Width = 94;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.MinWidth = 25;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 5;
            this.colGhiChu.Width = 94;
            // 
            // colDonGia
            // 
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.MinWidth = 25;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 6;
            this.colDonGia.Width = 94;
            // 
            // colIDPhienKham1
            // 
            this.colIDPhienKham1.FieldName = "IDPhienKham";
            this.colIDPhienKham1.MinWidth = 25;
            this.colIDPhienKham1.Name = "colIDPhienKham1";
            this.colIDPhienKham1.Visible = true;
            this.colIDPhienKham1.VisibleIndex = 7;
            this.colIDPhienKham1.Width = 94;
            // 
            // KhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1130, 811);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtSlThuoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInDonThuoc);
            this.Controls.Add(this.btnThemThuoc);
            this.Controls.Add(this.btnXoaKiemTra);
            this.Controls.Add(this.btnThemKiemTra);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbIdKiemTra);
            this.Controls.Add(this.cbIdThuoc);
            this.Controls.Add(this.txtChuanDoan);
            this.Controls.Add(this.txtGetIDBenhNhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoaDonThuoc);
            this.Controls.Add(this.btnXoa);
            this.Name = "KhamBenh";
            this.Text = "KhamBenh";
            this.Load += new System.EventHandler(this.KhamBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lichSuKhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuKiemTraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuDonThuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtSlThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtInDonThuoc;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.Button btnXoaKiemTra;
        private System.Windows.Forms.Button btnThemKiemTra;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbIdKiemTra;
        private System.Windows.Forms.ComboBox cbIdThuoc;
        private System.Windows.Forms.TextBox txtChuanDoan;
        private System.Windows.Forms.TextBox txtGetIDBenhNhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoaDonThuoc;
        private System.Windows.Forms.Button btnXoa;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiKiemTra;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaTien;
        private DevExpress.XtraGrid.Columns.GridColumn colIDPhienKham;
        private QuanLyPhongKhamDataSet quanLyPhongKhamDataSet;
        private System.Windows.Forms.BindingSource lichSuKhamBindingSource;
        private QuanLyPhongKhamDataSetTableAdapters.LichSuKhamTableAdapter lichSuKhamTableAdapter;
        private System.Windows.Forms.BindingSource phieuKiemTraBindingSource;
        private QuanLyPhongKhamDataSetTableAdapters.PhieuKiemTraTableAdapter phieuKiemTraTableAdapter;
        private System.Windows.Forms.BindingSource phieuDonThuocBindingSource;
        private QuanLyPhongKhamDataSetTableAdapters.PhieuDonThuocTableAdapter phieuDonThuocTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDPhienKham2;
        private DevExpress.XtraGrid.Columns.GridColumn colIDBenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKham;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBacSi;
        private DevExpress.XtraGrid.Columns.GridColumn colChuanDoan;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChuKham;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTenThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colLieuDung;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colIDPhienKham1;
    }
}
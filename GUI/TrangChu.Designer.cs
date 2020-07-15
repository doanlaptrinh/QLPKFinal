namespace GUI
{
    partial class TrangChu
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnBenhNhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnKiemTra = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoanhThu = new DevExpress.XtraBars.BarButtonItem();
            this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuongDan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangKy,
            this.btnDangXuat,
            this.btnPhanQuyen,
            this.btnNhanVien,
            this.btnBenhNhan,
            this.btnThuoc,
            this.btnKiemTra,
            this.barButtonItem8,
            this.barButtonItem9,
            this.btnDoanhThu,
            this.barLinkContainerItem1,
            this.barButtonItem11,
            this.barButtonItem12,
            this.btnHuongDan,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1132, 193);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Caption = "Đăng Kí";
            this.btnDangKy.Id = 1;
            this.btnDangKy.ImageOptions.Image = global::GUI.Properties.Resources.Account_register_login_profile_user_512;
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangKy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKi_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Id = 2;
            this.btnDangXuat.ImageOptions.Image = global::GUI.Properties.Resources.logout_512;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Caption = "Quản lý Tài Khoản";
            this.btnPhanQuyen.Id = 3;
            this.btnPhanQuyen.ImageOptions.Image = global::GUI.Properties.Resources.user_512;
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhanQuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhanQuyen_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân Viên";
            this.btnNhanVien.Id = 4;
            this.btnNhanVien.ImageOptions.Image = global::GUI.Properties.Resources.doctor_consultation_512;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnBenhNhan
            // 
            this.btnBenhNhan.Caption = "Bệnh Nhân";
            this.btnBenhNhan.Id = 5;
            this.btnBenhNhan.ImageOptions.Image = global::GUI.Properties.Resources.boy_patient_boy_patient_pills_512;
            this.btnBenhNhan.Name = "btnBenhNhan";
            this.btnBenhNhan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBenhNhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBenhNhan_ItemClick);
            // 
            // btnThuoc
            // 
            this.btnThuoc.Caption = "Thuốc";
            this.btnThuoc.Id = 6;
            this.btnThuoc.ImageOptions.Image = global::GUI.Properties.Resources.Medicine_512;
            this.btnThuoc.Name = "btnThuoc";
            this.btnThuoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThuoc_ItemClick);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Caption = "Kiểm Tra";
            this.btnKiemTra.Id = 7;
            this.btnKiemTra.ImageOptions.Image = global::GUI.Properties.Resources.a_38_512;
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKiemTra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKiemTra_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Khám Bệnh";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.ImageOptions.Image = global::GUI.Properties.Resources.learning_stetoscope_medicine_512;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Lịch Sử Khám";
            this.barButtonItem9.Id = 9;
            this.barButtonItem9.ImageOptions.Image = global::GUI.Properties.Resources.prescription_512;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Caption = "Doanh Thu";
            this.btnDoanhThu.Id = 10;
            this.btnDoanhThu.ImageOptions.Image = global::GUI.Properties.Resources.financial_report_512;
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDoanhThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // barLinkContainerItem1
            // 
            this.barLinkContainerItem1.Caption = "barLinkContainerItem1";
            this.barLinkContainerItem1.Id = 11;
            this.barLinkContainerItem1.Name = "barLinkContainerItem1";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Liên Hệ: quockhank318@gmail.com";
            this.barButtonItem11.Id = 12;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "SĐT: 0338062044";
            this.barButtonItem12.Id = 13;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Caption = "Hướng Dẫn";
            this.btnHuongDan.Id = 14;
            this.btnHuongDan.ImageOptions.Image = global::GUI.Properties.Resources.Basic_UI_Elements___2_3___Filled_Outline___44_48_512;
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 15;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDangKy);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnPhanQuyen);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10,
            this.ribbonPageGroup11});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản Lý";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnBenhNhan);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnThuoc);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnKiemTra);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.barButtonItem9, true);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnDoanhThu);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup12});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Trợ Giúp";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.btnHuongDan);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 648);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TrangChu";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản Lý Phòng Khám";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrangChu_FormClosed);
            this.Load += new System.EventHandler(this.TrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDangKy;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnPhanQuyen;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnBenhNhan;
        private DevExpress.XtraBars.BarButtonItem btnThuoc;
        private DevExpress.XtraBars.BarButtonItem btnKiemTra;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem btnDoanhThu;
        private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnHuongDan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}


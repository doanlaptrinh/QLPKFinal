namespace GUI
{
    partial class BenhNhan
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
            this.txtBornpatient = new DevExpress.XtraEditors.DateEdit();
            this.txtGenderpatient = new System.Windows.Forms.ComboBox();
            this.txtNotepatient = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddpatient = new System.Windows.Forms.Button();
            this.btnUpdatepatient = new System.Windows.Forms.Button();
            this.btnDelpatient = new System.Windows.Forms.Button();
            this.txtPhonepatient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddresspatient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDpatient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamepatient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenBenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quanLyPhongKhamDataSet = new GUI.QuanLyPhongKhamDataSet();
            this.benhNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benhNhanTableAdapter = new GUI.QuanLyPhongKhamDataSetTableAdapters.BenhNhanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtBornpatient.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBornpatient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBornpatient
            // 
            this.txtBornpatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBornpatient.EditValue = null;
            this.txtBornpatient.Location = new System.Drawing.Point(293, 151);
            this.txtBornpatient.Name = "txtBornpatient";
            this.txtBornpatient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBornpatient.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBornpatient.Properties.EditFormat.FormatString = "\'yyyy-MM-dd\'";
            this.txtBornpatient.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtBornpatient.Size = new System.Drawing.Size(125, 22);
            this.txtBornpatient.TabIndex = 67;
            // 
            // txtGenderpatient
            // 
            this.txtGenderpatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGenderpatient.FormattingEnabled = true;
            this.txtGenderpatient.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtGenderpatient.Location = new System.Drawing.Point(297, 101);
            this.txtGenderpatient.Name = "txtGenderpatient";
            this.txtGenderpatient.Size = new System.Drawing.Size(121, 24);
            this.txtGenderpatient.TabIndex = 66;
            this.txtGenderpatient.Text = "Nam";
            // 
            // txtNotepatient
            // 
            this.txtNotepatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNotepatient.Location = new System.Drawing.Point(582, 111);
            this.txtNotepatient.Name = "txtNotepatient";
            this.txtNotepatient.Size = new System.Drawing.Size(247, 107);
            this.txtNotepatient.TabIndex = 65;
            this.txtNotepatient.Text = "";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Điện Thoại";
            // 
            // btnAddpatient
            // 
            this.btnAddpatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddpatient.Location = new System.Drawing.Point(842, 6);
            this.btnAddpatient.Name = "btnAddpatient";
            this.btnAddpatient.Size = new System.Drawing.Size(75, 23);
            this.btnAddpatient.TabIndex = 51;
            this.btnAddpatient.Text = "Thêm";
            this.btnAddpatient.UseVisualStyleBackColor = true;
            this.btnAddpatient.Click += new System.EventHandler(this.btnAddpatient_Click);
            // 
            // btnUpdatepatient
            // 
            this.btnUpdatepatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdatepatient.Location = new System.Drawing.Point(842, 64);
            this.btnUpdatepatient.Name = "btnUpdatepatient";
            this.btnUpdatepatient.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatepatient.TabIndex = 52;
            this.btnUpdatepatient.Text = "Sửa";
            this.btnUpdatepatient.UseVisualStyleBackColor = true;
            this.btnUpdatepatient.Click += new System.EventHandler(this.btnUpdatepatient_Click);
            // 
            // btnDelpatient
            // 
            this.btnDelpatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelpatient.Location = new System.Drawing.Point(842, 118);
            this.btnDelpatient.Name = "btnDelpatient";
            this.btnDelpatient.Size = new System.Drawing.Size(75, 23);
            this.btnDelpatient.TabIndex = 53;
            this.btnDelpatient.Text = "Xóa";
            this.btnDelpatient.UseVisualStyleBackColor = true;
            this.btnDelpatient.Click += new System.EventHandler(this.btnDelpatient_Click);
            // 
            // txtPhonepatient
            // 
            this.txtPhonepatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhonepatient.Location = new System.Drawing.Point(582, 61);
            this.txtPhonepatient.Name = "txtPhonepatient";
            this.txtPhonepatient.Size = new System.Drawing.Size(195, 23);
            this.txtPhonepatient.TabIndex = 64;
            this.txtPhonepatient.Leave += new System.EventHandler(this.txtPhonepatient_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Tên Bệnh Nhân";
            // 
            // txtAddresspatient
            // 
            this.txtAddresspatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddresspatient.Location = new System.Drawing.Point(582, 10);
            this.txtAddresspatient.Name = "txtAddresspatient";
            this.txtAddresspatient.Size = new System.Drawing.Size(195, 23);
            this.txtAddresspatient.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Mã số BHYT";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Giới Tính";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "Ghi Chú";
            // 
            // txtIDpatient
            // 
            this.txtIDpatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDpatient.Location = new System.Drawing.Point(297, 10);
            this.txtIDpatient.Name = "txtIDpatient";
            this.txtIDpatient.Size = new System.Drawing.Size(176, 23);
            this.txtIDpatient.TabIndex = 62;
            this.txtIDpatient.Leave += new System.EventHandler(this.txtIDpatient_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Địa Chỉ";
            // 
            // txtNamepatient
            // 
            this.txtNamepatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNamepatient.Location = new System.Drawing.Point(297, 56);
            this.txtNamepatient.Name = "txtNamepatient";
            this.txtNamepatient.Size = new System.Drawing.Size(176, 23);
            this.txtNamepatient.TabIndex = 61;
            this.txtNamepatient.Leave += new System.EventHandler(this.txtNamepatient_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Ngày Sinh";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridControl1.DataSource = this.benhNhanBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(2, 224);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1116, 273);
            this.gridControl1.TabIndex = 68;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTenBenhNhan,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colDienThoai,
            this.colDiaChi,
            this.colGhiChu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            // colTenBenhNhan
            // 
            this.colTenBenhNhan.FieldName = "TenBenhNhan";
            this.colTenBenhNhan.MinWidth = 25;
            this.colTenBenhNhan.Name = "colTenBenhNhan";
            this.colTenBenhNhan.Visible = true;
            this.colTenBenhNhan.VisibleIndex = 1;
            this.colTenBenhNhan.Width = 94;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.MinWidth = 25;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 2;
            this.colNgaySinh.Width = 94;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.MinWidth = 25;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 3;
            this.colGioiTinh.Width = 94;
            // 
            // colDienThoai
            // 
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.MinWidth = 25;
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 4;
            this.colDienThoai.Width = 94;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.MinWidth = 25;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 5;
            this.colDiaChi.Width = 94;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.MinWidth = 25;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 6;
            this.colGhiChu.Width = 94;
            // 
            // quanLyPhongKhamDataSet
            // 
            this.quanLyPhongKhamDataSet.DataSetName = "QuanLyPhongKhamDataSet";
            this.quanLyPhongKhamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // benhNhanBindingSource
            // 
            this.benhNhanBindingSource.DataMember = "BenhNhan";
            this.benhNhanBindingSource.DataSource = this.quanLyPhongKhamDataSet;
            // 
            // benhNhanTableAdapter
            // 
            this.benhNhanTableAdapter.ClearBeforeFill = true;
            // 
            // BenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 498);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtBornpatient);
            this.Controls.Add(this.txtGenderpatient);
            this.Controls.Add(this.txtNotepatient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddpatient);
            this.Controls.Add(this.btnUpdatepatient);
            this.Controls.Add(this.btnDelpatient);
            this.Controls.Add(this.txtPhonepatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddresspatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIDpatient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNamepatient);
            this.Controls.Add(this.label6);
            this.Name = "BenhNhan";
            this.Text = "BenhNhan";
            this.Load += new System.EventHandler(this.BenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBornpatient.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBornpatient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit txtBornpatient;
        private System.Windows.Forms.ComboBox txtGenderpatient;
        private System.Windows.Forms.RichTextBox txtNotepatient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddpatient;
        private System.Windows.Forms.Button btnUpdatepatient;
        private System.Windows.Forms.Button btnDelpatient;
        private System.Windows.Forms.TextBox txtPhonepatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddresspatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDpatient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamepatient;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private QuanLyPhongKhamDataSet quanLyPhongKhamDataSet;
        private System.Windows.Forms.BindingSource benhNhanBindingSource;
        private QuanLyPhongKhamDataSetTableAdapters.BenhNhanTableAdapter benhNhanTableAdapter;
    }
}
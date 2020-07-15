namespace GUI
{
    partial class DoanhThu
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.doanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongKhamDataSet = new GUI.QuanLyPhongKhamDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDPhienKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoanhThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.doanhThuTableAdapter = new GUI.QuanLyPhongKhamDataSetTableAdapters.DoanhThuTableAdapter();
            this.btnInDoanhThu = new System.Windows.Forms.Button();
            this.txtNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.txtNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanhThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayKetThuc.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridControl1.DataSource = this.doanhThuBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(267, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(613, 341);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // doanhThuBindingSource
            // 
            this.doanhThuBindingSource.DataMember = "DoanhThu";
            this.doanhThuBindingSource.DataSource = this.quanLyPhongKhamDataSet;
            // 
            // quanLyPhongKhamDataSet
            // 
            this.quanLyPhongKhamDataSet.DataSetName = "QuanLyPhongKhamDataSet";
            this.quanLyPhongKhamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDPhienKham,
            this.colThoiGian,
            this.colDoanhThu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIDPhienKham
            // 
            this.colIDPhienKham.FieldName = "IDPhienKham";
            this.colIDPhienKham.MinWidth = 25;
            this.colIDPhienKham.Name = "colIDPhienKham";
            this.colIDPhienKham.Visible = true;
            this.colIDPhienKham.VisibleIndex = 0;
            this.colIDPhienKham.Width = 94;
            // 
            // colThoiGian
            // 
            this.colThoiGian.FieldName = "ThoiGian";
            this.colThoiGian.MinWidth = 25;
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.Visible = true;
            this.colThoiGian.VisibleIndex = 1;
            this.colThoiGian.Width = 94;
            // 
            // colDoanhThu
            // 
            this.colDoanhThu.FieldName = "DoanhThu";
            this.colDoanhThu.MinWidth = 25;
            this.colDoanhThu.Name = "colDoanhThu";
            this.colDoanhThu.Visible = true;
            this.colDoanhThu.VisibleIndex = 2;
            this.colDoanhThu.Width = 94;
            // 
            // doanhThuTableAdapter
            // 
            this.doanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // btnInDoanhThu
            // 
            this.btnInDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInDoanhThu.Location = new System.Drawing.Point(764, 377);
            this.btnInDoanhThu.Name = "btnInDoanhThu";
            this.btnInDoanhThu.Size = new System.Drawing.Size(116, 39);
            this.btnInDoanhThu.TabIndex = 1;
            this.btnInDoanhThu.Text = "In Báo Cáo";
            this.btnInDoanhThu.UseVisualStyleBackColor = true;
            this.btnInDoanhThu.Click += new System.EventHandler(this.btnInDoanhThu_Click);
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.EditValue = null;
            this.txtNgayBatDau.Location = new System.Drawing.Point(60, 43);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayBatDau.Size = new System.Drawing.Size(125, 22);
            this.txtNgayBatDau.TabIndex = 2;
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.EditValue = null;
            this.txtNgayKetThuc.Location = new System.Drawing.Point(60, 91);
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayKetThuc.Size = new System.Drawing.Size(125, 22);
            this.txtNgayKetThuc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lọc Theo Ngày";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNgayBatDau);
            this.panel1.Controls.Add(this.txtNgayKetThuc);
            this.panel1.Location = new System.Drawing.Point(15, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 151);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Từ";
            // 
            // btnLoc
            // 
            this.btnLoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoc.Location = new System.Drawing.Point(151, 187);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(89, 32);
            this.btnLoc.TabIndex = 6;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 425);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInDoanhThu);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanhThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongKhamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayKetThuc.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QuanLyPhongKhamDataSet quanLyPhongKhamDataSet;
        private System.Windows.Forms.BindingSource doanhThuBindingSource;
        private QuanLyPhongKhamDataSetTableAdapters.DoanhThuTableAdapter doanhThuTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDPhienKham;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn colDoanhThu;
        private System.Windows.Forms.Button btnInDoanhThu;
        private DevExpress.XtraEditors.DateEdit txtNgayBatDau;
        private DevExpress.XtraEditors.DateEdit txtNgayKetThuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoc;
    }
}
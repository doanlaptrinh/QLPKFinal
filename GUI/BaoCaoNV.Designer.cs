namespace GUI
{
    partial class BaoCaoNV
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
            this.crpProducts = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.BaoCaoNhanVien1 = new GUI.BaoCaoNhanVien();
            this.SuspendLayout();
            // 
            // crpProducts
            // 
            this.crpProducts.ActiveViewIndex = 0;
            this.crpProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpProducts.Location = new System.Drawing.Point(0, 0);
            this.crpProducts.Name = "crpProducts";
            this.crpProducts.ReportSource = this.BaoCaoNhanVien1;
            this.crpProducts.Size = new System.Drawing.Size(949, 485);
            this.crpProducts.TabIndex = 0;
            // 
            // BaoCaoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 485);
            this.Controls.Add(this.crpProducts);
            this.Name = "BaoCaoNV";
            this.Text = "BaoCaoNV";
            this.Load += new System.EventHandler(this.BaoCaoNV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpProducts;
        private BaoCaoNhanVien BaoCaoNhanVien1;
    }
}
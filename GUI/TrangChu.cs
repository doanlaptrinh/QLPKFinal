using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        private new Form IsActive(Type ftype)
        {
            foreach(Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                    return f;
            }
            return null;
        }
        private void btnBenhNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form form = IsActive(typeof(BenhNhan)); 
            if (form == null)
            {
                BenhNhan fm = new BenhNhan();
                fm.MdiParent = this;
                fm.Show();
            }
            else
                form.Activate(); 

        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(NhanVien)); 
            if (form == null)
            {
                NhanVien fm = new NhanVien();
                fm.MdiParent = this;
                fm.Show();
            }
            else
                form.Activate(); 
        }

        private void TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(Thuoc)); 
            if (form == null)
            {
                Thuoc fm = new Thuoc();
                fm.MdiParent = this;
                fm.Show();
            }
            else
                form.Activate();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            
                DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
                themes.LookAndFeel.SkinName = "Valentine";
            
        }

        private void btnKiemTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(KiemTra));
            if (form == null)
            {
                KiemTra fm = new KiemTra();
                fm.MdiParent = this;
                fm.Show();
            }
            else
                form.Activate();
        }
    }
}

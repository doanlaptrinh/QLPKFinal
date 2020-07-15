using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string []user;
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
                themes.LookAndFeel.SkinName = "Lilian";
                DTO_Public.ten= user[1];
                DTO_Public.quyen = user[2];
                phanQuyen();

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

        private void btnDangKi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangKi dk = new DangKi();
            dk.Show();
        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuanLyTaiKhoan ql = new QuanLyTaiKhoan();
            ql.Show();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(KhamBenh));
            if (form == null)
            {
                KhamBenh fm = new KhamBenh();
                fm.MdiParent = this;
                fm.Show();
            }
            else
                form.Activate();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(DoanhThu));
            if (form == null)
            {
                DoanhThu fm = new DoanhThu();
                fm.MdiParent = this;
                fm.Show();
            }
            else
                form.Activate();
          
        }
        private void phanQuyen()
        {
            BUS_TrangChu bus = new BUS_TrangChu();
            DTO_TrangChu dto = new DTO_TrangChu();
            dto.phanQuyen = DTO_Public.quyen;
            if(bus.phanQuyen(dto)==false)
            {

                btnPhanQuyen.Enabled = false;
                btnNhanVien.Enabled = false;
                btnThuoc.Enabled = false;
                btnKiemTra.Enabled = false;
                btnDoanhThu.Enabled = false;
            }
        }
    }
}

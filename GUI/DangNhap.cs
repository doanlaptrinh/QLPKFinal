using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;

namespace GUI
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        BUS_DangNhap busTV = new BUS_DangNhap();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" && txtPass.Text != "")
            {
                
                DTO_DangNhap tv = new DTO_DangNhap(txtUser.Text, txtPass.Text, "");
                if (busTV.ktThanhVien(tv))
                {
                    this.Hide();
                    TrangChu fm = new TrangChu();
                    fm.Show();

                }
                else
                {
                    MessageBox.Show("Đăng nhập ko thành công");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
            }

        }
    }
}
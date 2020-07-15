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
using BUS;
using DTO;
namespace GUI
{
    public partial class DangKi : DevExpress.XtraEditors.XtraForm
    {
        BUS_Registercs busRE = new BUS_Registercs();
        public DangKi()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                if (busRE.CheckTrungTaiKhoan(txtUser.Text) == true)
                {
                    MessageBox.Show("Trung Tai Khoan");
                    txtUser.Select();
                }
                else
                {
                    DTO_Register tk = new DTO_Register(txtUser.Text, txtPass.Text, 2,txtTenNhanVien.Text);
                    if (busRE.ThemTaiKhoan(tk))
                    {
                        MessageBox.Show("Thêm thành công");
                        txtUser.Text = "";
                        txtPass.Text = "";
                        txtRePass.Text = "";
                        txtTenNhanVien.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Thêm ko thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập Tai Khoan");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy bỏ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                if (busRE.checktk(txtUser.Text))
                {
                    MessageBox.Show("Nhap sai dinh dang");
                    txtUser.Select();
                }
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text != "")
            {
                if (busRE.checktk(txtPass.Text))
                {
                    MessageBox.Show("Nhap sai dinh dang");
                    txtPass.Select();
                }
            }
        }

        private void txtRePass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text != txtRePass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
                txtRePass.Text = "";
                txtRePass.Select();
            }
        }
    }
}
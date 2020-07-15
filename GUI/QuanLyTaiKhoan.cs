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
    public partial class QuanLyTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        BUS_Registercs busTK = new BUS_Registercs();
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.NguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungTableAdapter.Fill(this.quanLyPhongKhamDataSet.NguoiDung);
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.NhanVien' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.NguoiDung' table. You can move, or remove it, as needed.


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DangKi re = new DangKi();
            re.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (txtUser.Text != "")
            {

                DTO_Register dto_TK = new DTO_Register(txtUser.Text, txtPass.Text, Convert.ToInt32(cbPhanQuyen.Text),txtTen.Text);
                // Sửa
                if (busTK.SuaTaiKhoan(dto_TK))
                {
                    MessageBox.Show("Sửa thành công");
                    this.nguoiDungTableAdapter.Fill(this.quanLyPhongKhamDataSet.NguoiDung);

                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Chọn hàng cần sửa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var rowH = gridView1.FocusedRowHandle; //(rowH ở đây là nó sẽ xác định được bạn đang ở dòng nào)
            var rowHv = gridView1.GetRowCellValue(rowH, gridView1.Columns["TaiKhoan"]);// (rowHv là giá trị của Id)
            string user = rowHv.ToString();

            DTO_Register re = new DTO_Register();
            re.nguoiDung_taiKhoan = (user);

            // Sửa
            if (busTK.XoaTaiKhoan(re))
            {
                MessageBox.Show("Xóa thành công");
                this.nguoiDungTableAdapter.Fill(this.quanLyPhongKhamDataSet.NguoiDung);

            }
            else
            {
                MessageBox.Show("Xóa ko thành công");
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var rowH = gridView1.FocusedRowHandle; //(rowH ở đây là nó sẽ xác định được bạn đang ở dòng nào)
            var rowHv = gridView1.GetRowCellValue(rowH, gridView1.Columns["TaiKhoan"]);
            var rowHv1 = gridView1.GetRowCellValue(rowH, gridView1.Columns["MatKhau"]);
            var rowHv2 = gridView1.GetRowCellValue(rowH, gridView1.Columns["PhanQuyen"]);
            var rowHv3 = gridView1.GetRowCellValue(rowH, gridView1.Columns["TenNhanVien"]);

            txtUser.Text = Convert.ToString(rowHv);
            txtPass.Text = Convert.ToString(rowHv1);
            cbPhanQuyen.Text = Convert.ToString(rowHv2);
            txtTen.Text = Convert.ToString(rowHv3);
            this.nguoiDungTableAdapter.Fill(this.quanLyPhongKhamDataSet.NguoiDung);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
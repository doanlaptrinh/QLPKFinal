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
    public partial class NhanVien : DevExpress.XtraEditors.XtraForm
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {

                if (busNV.CheckTrung(txtID.Text) == true)
                {
                    MessageBox.Show("Trung ID");
                    txtID.Select();
                }
                else
                {

                    if (txtNPhone.Text == "")
                    {
                        txtNPhone.Text = "0";
                    }
                    DTO_NhanVien nv = new DTO_NhanVien(Convert.ToInt32(txtID.Text), txtTen.Text, txtGender.Text, dateEdit1.Text, txtNativeLane.Text, Convert.ToInt32(txtNPhone.Text), txtNativeLane.Text, txtPosition.Text);
                    if (busNV.ThemNhanVien(nv))
                    {
                        MessageBox.Show("Thêm thành công");
                        this.nhanVienTableAdapter.Fill(this.quanLyPhongKhamDataSet.NhanVien);

                    }
                    else
                    {
                        MessageBox.Show("Thêm ko thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập ID");
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyPhongKhamDataSet.NhanVien);

        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
           
                if (txtID.Text != "")
                {
                    
                    DTO_NhanVien nv = new DTO_NhanVien(Convert.ToInt32(txtID.Text), txtTen.Text, txtGender.Text, dateEdit1.Text, txtNativeLane.Text, Convert.ToInt32(txtNPhone.Text), txtNativeLane.Text, txtPosition.Text);
                    // Sửa
                    if (busNV.SuaNhanVen(nv))
                    {
                        MessageBox.Show("Sửa thành công");
                        this.nhanVienTableAdapter.Fill(this.quanLyPhongKhamDataSet.NhanVien);

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

        private void btnDelNV_Click(object sender, EventArgs e)
        {
            var rowH = gridView1.FocusedRowHandle; //(rowH ở đây là nó sẽ xác định được bạn đang ở dòng nào)
            var rowHv = gridView1.GetRowCellValue(rowH, gridView1.Columns["ID"]);// (rowHv là giá trị của Id)
            int ID = Convert.ToInt32(rowHv);

            DTO_NhanVien nv = new DTO_NhanVien();
            nv.nhanVien_id = (ID);

            // Sửa
            if (busNV.XoaNhanVien(nv))
            {
                MessageBox.Show("Xóa thành công");
                this.nhanVienTableAdapter.Fill(this.quanLyPhongKhamDataSet.NhanVien);

            }
            else
            {
                MessageBox.Show("Xóa ko thành công");
            }

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var rowH = gridView1.FocusedRowHandle; //(rowH ở đây là nó sẽ xác định được bạn đang ở dòng nào)
            var rowHv = gridView1.GetRowCellValue(rowH, gridView1.Columns["ID"]);
            var rowHv1 = gridView1.GetRowCellValue(rowH, gridView1.Columns["HoTen"]);
            var rowHv2 = gridView1.GetRowCellValue(rowH, gridView1.Columns["GioiTinh"]);
            var rowHv3 = gridView1.GetRowCellValue(rowH, gridView1.Columns["NgaySinh"]);
            var rowHv4 = gridView1.GetRowCellValue(rowH, gridView1.Columns["QueQuan"]);
            var rowHv5 = gridView1.GetRowCellValue(rowH, gridView1.Columns["SoDienThoai"]);
            var rowHv6 = gridView1.GetRowCellValue(rowH, gridView1.Columns["Email"]);
            var rowHv7 = gridView1.GetRowCellValue(rowH, gridView1.Columns["ChucVu"]);
            txtID.Text = Convert.ToString(rowHv);
            txtTen.Text = Convert.ToString(rowHv1);
            txtGender.Text = Convert.ToString(rowHv2);
            dateEdit1.Text = Convert.ToString(rowHv3);
            txtNativeLane.Text = Convert.ToString(rowHv4);
            txtNPhone.Text = Convert.ToString(rowHv5);
            txtEmail.Text = Convert.ToString(rowHv6);
            txtPosition.Text = Convert.ToString(rowHv7);
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if(txtID.Text !="")
            {
                if(busNV.checkSo(txtID.Text))
                {
                    MessageBox.Show("Nhap sai dinh dang");
                    txtID.Text = "";
                    txtID.Select();
                }
            }
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            if (txtTen.Text != "")
            {
                if (busNV.checkChu(txtTen.Text)) 
                {
                    MessageBox.Show("Nhap sai dinh dang");
                    txtTen.Text = "";
                    txtTen.Select();
                }
            }
        }

        private void txtNPhone_Leave(object sender, EventArgs e)
        {
            if (txtNPhone.Text != "")
            {
                if (busNV.checkSo(txtNPhone.Text)) 
                {
                    MessageBox.Show("Nhap sai dinh dang");
                    txtNPhone.Text = "";
                    txtNPhone.Select();
                }
            }
        }

      

        private void txtPosition_Leave(object sender, EventArgs e)
        {
            if (txtPosition.Text != "")
            {
                if (busNV.checkChu(txtPosition.Text)) 
                {
                    MessageBox.Show("Nhap sai dinh dang");
                    txtPosition.Text = "";
                    txtPosition.Select();
                }
            }
        }
    }
}
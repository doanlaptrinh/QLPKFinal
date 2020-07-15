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
   
    public partial class Thuoc : DevExpress.XtraEditors.XtraForm
    {
        BUS_Thuoc bus_Thuoc = new BUS_Thuoc();
        public Thuoc()
        {
            InitializeComponent();
        }

        private void Thuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.DonThuoc' table. You can move, or remove it, as needed.
            this.donThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet.DonThuoc);
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.DonThuoc' table. You can move, or remove it, as needed.


        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            if (txtIdThuoc.Text != "")
            {
                if (bus_Thuoc.CheckTrung(txtIdThuoc.Text) == true)
                {
                    MessageBox.Show("Trung ID");
                    txtIdThuoc.Select();
                }
                else
                {
                    if (txtDonGia.Text == "")
                    {
                        txtDonGia.Text = "0";
                    }
                    DTO_Thuoc th = new DTO_Thuoc(Convert.ToInt32(txtIdThuoc.Text), txtTenThuoc.Text, txtSoLuong.Text, txtLieuDung.Text, Convert.ToInt32(txtDonGia.Text), txtGhiChu.Text);
                    if (bus_Thuoc.ThemThuoc(th))
                    {
                        MessageBox.Show("Thêm thành công");

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

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
           
                if (txtIdThuoc.Text != "")
                {

                    DTO_Thuoc kt = new DTO_Thuoc(Convert.ToInt32(txtIdThuoc.Text), txtTenThuoc.Text, txtSoLuong.Text,txtLieuDung.Text,Convert.ToInt32(txtDonGia.Text),txtGhiChu.Text);

                    if (bus_Thuoc.SuaThuoc(kt))
                    {
                        MessageBox.Show("Sửa thành công");
                    this.donThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet.DonThuoc);

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
            
                var rowH = gridView1.FocusedRowHandle;
                var rowHv = gridView1.GetRowCellValue(rowH, gridView1.Columns["ID"]);
                int ID = Convert.ToInt32(rowHv);
                DTO_Thuoc kt = new DTO_Thuoc();
                kt.thuoc_id = ID;
                if (bus_Thuoc.XoaThuoc(kt))
                {
                    MessageBox.Show("Xóa thành công");
                this.donThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet.DonThuoc);
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
            var rowHv1 = gridView1.GetRowCellValue(rowH, gridView1.Columns["TenThuoc"]);
            var rowHv2 = gridView1.GetRowCellValue(rowH, gridView1.Columns["DonViTinh"]);
            var rowHv3 = gridView1.GetRowCellValue(rowH, gridView1.Columns["LieuDung"]);
            var rowHv4 = gridView1.GetRowCellValue(rowH, gridView1.Columns["DonGia"]);
            var rowHv5 = gridView1.GetRowCellValue(rowH, gridView1.Columns["GhiChu"]);
            txtIdThuoc.Text = Convert.ToString(rowHv);
            txtTenThuoc.Text = Convert.ToString(rowHv1);
            txtSoLuong.Text = Convert.ToString(rowHv2);
            txtLieuDung.Text = Convert.ToString(rowHv3);
            txtDonGia.Text = Convert.ToString(rowHv4);
            txtGhiChu.Text = Convert.ToString(rowHv5);
        }
    }
    
}
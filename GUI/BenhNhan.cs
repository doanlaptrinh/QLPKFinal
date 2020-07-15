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
    public partial class BenhNhan : DevExpress.XtraEditors.XtraForm
    {
        BUS_BenhNhan busBN = new BUS_BenhNhan();
        public BenhNhan()
        {
            InitializeComponent();
        }

        private void BenhNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.BenhNhan' table. You can move, or remove it, as needed.
            this.benhNhanTableAdapter.Fill(this.quanLyPhongKhamDataSet.BenhNhan);
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.BenhNhan' table. You can move, or remove it, as needed.

        }

        private void btnAddpatient_Click(object sender, EventArgs e)
        {

            if (txtIDpatient.Text != "")
            {
                if (busBN.CheckTrung(txtIDpatient.Text) == true)
                {
                    MessageBox.Show("Trung ID");
                    txtIDpatient.Select();
                }
                else
                {
                    if (txtPhonepatient.Text == "")
                        txtPhonepatient.Text = "0";
                    DTO_BenhNhan bn = new DTO_BenhNhan(Convert.ToInt32(txtIDpatient.Text), txtNamepatient.Text, txtGenderpatient.Text, txtBornpatient.Text, txtPhonepatient.Text, txtAddresspatient.Text, txtNotepatient.Text);
                    if (busBN.ThemBenhNhan(bn))
                    {
                        MessageBox.Show("Thêm thành công");
                        this.benhNhanTableAdapter.Fill(this.quanLyPhongKhamDataSet.BenhNhan);
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

        private void btnUpdatepatient_Click(object sender, EventArgs e)
        {
            if (txtIDpatient.Text != "")
            {

                DTO_BenhNhan bn = new DTO_BenhNhan(Convert.ToInt32(txtIDpatient.Text), txtNamepatient.Text, txtGenderpatient.Text,txtBornpatient.Text,txtPhonepatient.Text,txtAddresspatient.Text,txtNotepatient.Text);
                if (busBN.SuaBenhNhan(bn))
                {
                    MessageBox.Show("Sửa thành công");
                    this.benhNhanTableAdapter.Fill(this.quanLyPhongKhamDataSet.BenhNhan);

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

        private void btnDelpatient_Click(object sender, EventArgs e)
        {
            var rowH = gridView1.FocusedRowHandle; 
            var rowHv = gridView1.GetRowCellValue(rowH, gridView1.Columns["ID"]);
            int ID = Convert.ToInt32(rowHv);

            DTO_BenhNhan bn = new DTO_BenhNhan();
            bn.benhNhan_id = ID;
            // Sửa
            try
            {


                if (busBN.XoaBenhNhan(bn))
                {
                    MessageBox.Show("Xóa thành công");
                    this.benhNhanTableAdapter.Fill(this.quanLyPhongKhamDataSet.BenhNhan);

                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var rowH = gridView1.FocusedRowHandle;
            var rowHv = gridView1.GetRowCellValue(rowH, gridView1.Columns["ID"]);
            var rowHv1 = gridView1.GetRowCellValue(rowH, gridView1.Columns["TenBenhNhan"]);
            var rowHv2 = gridView1.GetRowCellValue(rowH, gridView1.Columns["GioiTinh"]);
            var rowHv3 = gridView1.GetRowCellValue(rowH, gridView1.Columns["NgaySinh"]);
            var rowHv4 = gridView1.GetRowCellValue(rowH, gridView1.Columns["DienThoai"]);
            var rowHv5 = gridView1.GetRowCellValue(rowH, gridView1.Columns["DiaChi"]);
            var rowHv6 = gridView1.GetRowCellValue(rowH, gridView1.Columns["GhiChu"]);
            txtIDpatient.Text = Convert.ToString(rowHv);
            txtNamepatient.Text = Convert.ToString(rowHv1);
            txtGenderpatient.Text = Convert.ToString(rowHv2);
            txtBornpatient.Text = Convert.ToString(rowHv3);
            txtPhonepatient.Text = Convert.ToString(rowHv4);
            txtAddresspatient.Text = Convert.ToString(rowHv5);
            txtNotepatient.Text = Convert.ToString(rowHv6);
        }
        private void txtPhonepatient_Leave(object sender, EventArgs e)
        {
            if (txtPhonepatient.Text != "")
            {
                if (busBN.checkSo(txtPhonepatient.Text))
                {
                    MessageBox.Show("Nhap sai dinh dang");
                    txtPhonepatient.Select();
                }
            }
        }

        private void txtIDpatient_Leave(object sender, EventArgs e)
        {
            if (txtIDpatient.Text != "")
            {
                if (busBN.checkSo(txtIDpatient.Text))
                {
                    MessageBox.Show("Nhap sai dinh dang");
                    txtIDpatient.Select();
                }
            }
        }

        private void txtNamepatient_Leave(object sender, EventArgs e)
        {
            if (txtNamepatient.Text != "")
            {
                if (busBN.checkChu(txtNamepatient.Text))
                {
                    MessageBox.Show("Nhap sai dinh dang");
                    txtNamepatient.Select();
                }
            }
        }
    }
}
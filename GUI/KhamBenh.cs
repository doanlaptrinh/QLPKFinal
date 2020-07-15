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
using System.Data.SqlClient;
using DTO;
using BUS;
namespace GUI
{
    public partial class KhamBenh : DevExpress.XtraEditors.XtraForm
    {
        
        BUS_KhamBenh busKB = new BUS_KhamBenh();
        //string idphienkham;
        public KhamBenh()
        {
            InitializeComponent();
        }

        private void gridControl1_EmbeddedNavigator_Click(object sender, EventArgs e)
        {

        }

        private void KhamBenh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.PhieuDonThuoc' table. You can move, or remove it, as needed.
            
           
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.LichSuKham' table. You can move, or remove it, as needed.
            this.lichSuKhamTableAdapter.Fill(this.quanLyPhongKhamDataSet.LichSuKham);
       
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.PhieuDonThuoc' table. You can move, or remove it, as needed.
            this.phieuDonThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet.PhieuDonThuoc);
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.PhieuKiemTra' table. You can move, or remove it, as needed.
            this.phieuKiemTraTableAdapter.Fill(this.quanLyPhongKhamDataSet.PhieuKiemTra);
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.LichSuKham' table. You can move, or remove it, as needed.
          

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtGetIDBenhNhan.Text != "")
            {
                
                if (busKB.CheckTrungID(txtGetIDBenhNhan.Text) == true)
                {
                    MessageBox.Show("ID không tồn tại");
                    txtGetIDBenhNhan.Select();
                }
                else
                {
                    string tenbs=DTO_Public.ten;
                    if (busKB.ThemKhamBenh(txtGetIDBenhNhan.Text, tenbs))
                    {
                        MessageBox.Show("Thêm thành công");
                        this.lichSuKhamTableAdapter.Fill(this.quanLyPhongKhamDataSet.LichSuKham);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var rowH = gridView1.FocusedRowHandle;
            var rowHv = gridView1.GetRowCellValue(rowH, gridView1.Columns["IDPhienKham"]);
            string ID = Convert.ToString(rowHv);
            if (busKB.XoaBenhAn(ID))
            {
                MessageBox.Show("Xóa thành công");
                this.lichSuKhamTableAdapter.Fill(this.quanLyPhongKhamDataSet.LichSuKham);

            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnThemKiemTra_Click(object sender, EventArgs e)
        {
            var rowH = gridView1.FocusedRowHandle;
            var rowHv = gridView1.GetRowCellValue(rowH, gridView1.Columns["IDPhienKham"]);
            string ID = Convert.ToString(rowHv);
            if (busKB.CheckTrungKT(cbIdKiemTra.Text,ID))
                {
                    MessageBox.Show("Đã thêm kiểm tra này rồi");
                }
                else
                {
                   
                    
                    if (busKB.ThemKiemTra(cbIdKiemTra.Text,ID))
                    {
                        MessageBox.Show("Thêm thành công");
                        gridControl1_DoubleClick(sender, e);
                        this.phieuKiemTraTableAdapter.Fill(this.quanLyPhongKhamDataSet.PhieuKiemTra);

                    }
                    else
                    {
                        MessageBox.Show("Thêm ko thành công");
                    }
                }
            
           
        }

        private void btnXoaKiemTra_Click(object sender, EventArgs e)
        {
            var rowH = gridView2.FocusedRowHandle;
            var rowHv = gridView2.GetRowCellValue(rowH, gridView2.Columns["ID"]);
            string ID = Convert.ToString(rowHv);
            if (busKB.XoaKiemTra(ID))
            {
                MessageBox.Show("Xóa thành công");
                gridControl1_DoubleClick(sender, e);
                //this.phieuKiemTraTableAdapter.Fill(this.quanLyPhongKhamDataSet.PhieuKiemTra);

            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            var rowH = gridView1.FocusedRowHandle;
            var rowHv = gridView1.GetRowCellValue(rowH, gridView1.Columns["IDPhienKham"]);
            string ID = Convert.ToString(rowHv);
            if (txtSlThuoc.Text != "")
            {
                if (busKB.ChecTrungThuoc(cbIdThuoc.Text,ID))
                {
                    MessageBox.Show("Đã thêm thuốc này rồi");
                }
                else
                {
                    //idphienkham= Convert.ToString( busKB.GetIDDonThuoc());

                    if (busKB.ThemDonThuoc(cbIdThuoc.Text,Convert.ToInt32(txtSlThuoc.Text), Convert.ToInt32(ID)))
                    {
                        MessageBox.Show("Thêm thành công");
                        gridControl1_DoubleClick(sender, e);
                        this.phieuDonThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet.PhieuDonThuoc);

                    }
                    else
                    {
                        MessageBox.Show("Thêm ko thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập số lượng thuốc");
            }
        }

        private void btnXoaDonThuoc_Click(object sender, EventArgs e)
        {
            var rowH = gridView3.FocusedRowHandle;
            var rowHv = gridView3.GetRowCellValue(rowH, gridView3.Columns["ID"]);
            string ID = Convert.ToString(rowHv);
            if (busKB.XoaDonThuoc(ID))
            {
                MessageBox.Show("Xóa thành công");
                gridControl1_DoubleClick(sender, e);
                this.phieuDonThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet.PhieuDonThuoc);
                //gridView3.RefreshData(); 
                
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void txtInDonThuoc_Click(object sender, EventArgs e)
        {
            if (txtChuanDoan.Text != "")
            {
                var rowH = gridView1.FocusedRowHandle;
                var rowHv = gridView1.GetRowCellValue(rowH, gridView1.Columns["IDPhienKham"]);
                string ID = Convert.ToString(rowHv);   
                busKB.SuaKhamBenh(ID,txtChuanDoan.Text,txtGhiChu.Text);
                busKB.ThemDoanhThu(Convert.ToInt32(ID));
                DonThuoc donthuoc = new DonThuoc();
                donthuoc.Show();
            }
            else
            {
                MessageBox.Show("Chưa nhập chuẩn đoán");
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            this.phieuDonThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet.PhieuDonThuoc);
            var rowH = gridView1.FocusedRowHandle;
            var rowHv = gridView1.GetRowCellValue(rowH, gridView1.Columns["IDPhienKham"]);
            string ID = Convert.ToString(rowHv);
            DataTable data = busKB.Xemdonthuoc(ID);
            gridControl3.DataSource = data;
            this.phieuDonThuocTableAdapter.Fill(this.quanLyPhongKhamDataSet.PhieuDonThuoc);
            
            //KiemTra


            this.phieuKiemTraTableAdapter.Fill(this.quanLyPhongKhamDataSet.PhieuKiemTra);
            data = busKB.Xemkiemtra(ID);
            gridControl2.DataSource = data;
            this.phieuKiemTraTableAdapter.Fill(this.quanLyPhongKhamDataSet.PhieuKiemTra);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
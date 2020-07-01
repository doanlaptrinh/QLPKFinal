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
    public partial class KiemTra : DevExpress.XtraEditors.XtraForm
    {
        BUS_KiemTra busKT = new BUS_KiemTra();
        public KiemTra()
        {
            InitializeComponent();
        }

        private void KiemTra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.KiemTra' table. You can move, or remove it, as needed.
            this.kiemTraTableAdapter.Fill(this.quanLyPhongKhamDataSet.KiemTra);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != "")
                {
                    if (busKT.CheckTrung(txtID.Text) == true)
                    {
                        MessageBox.Show("Trung ID");
                        txtID.Select();
                    }
                    else
                    {
                        if (txtDonGia.Text == "")
                        {
                            txtDonGia.Text = "0";
                        }
                        DTO_KiemTra th = new DTO_KiemTra(Convert.ToInt32(txtID.Text), txtTenKiemTra.Text, Convert.ToInt32(txtDonGia.Text));
                        if (busKT.ThemKiemTra(th))
                        {
                            MessageBox.Show("Thêm thành công");
                            this.kiemTraTableAdapter.Fill(this.quanLyPhongKhamDataSet.KiemTra);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
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
    public partial class DoanhThu : DevExpress.XtraEditors.XtraForm
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongKhamDataSet.DoanhThu' table. You can move, or remove it, as needed.
            this.doanhThuTableAdapter.Fill(this.quanLyPhongKhamDataSet.DoanhThu);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInDoanhThu_Click(object sender, EventArgs e)
        {
            InDoanhThu fm = new InDoanhThu();
            fm.Show();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

            this.doanhThuTableAdapter.Fill(this.quanLyPhongKhamDataSet.DoanhThu);
            BUS_DoanhThu busdt = new BUS_DoanhThu();
            DTO_DoanhThu dto;
            if (txtNgayKetThuc.Text == "" && txtNgayBatDau.Text == "")
                dto = new DTO_DoanhThu(Convert.ToDateTime("2000-01-01"), Convert.ToDateTime("2100-12-31"));
            else
                dto = new DTO_DoanhThu(Convert.ToDateTime(txtNgayBatDau.Text), Convert.ToDateTime(txtNgayKetThuc.Text));

            busdt.Locdoanhthu(dto);
            gridControl1.DataSource= busdt.Locdoanhthu(dto);

            this.doanhThuTableAdapter.Fill(this.quanLyPhongKhamDataSet.DoanhThu);
        }
    }
}
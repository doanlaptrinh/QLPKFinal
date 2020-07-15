using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BenhNhan
    {
        private int _benhNhan_id;
        private string _benhNhan_tenBenhNhan;
        private string _benhNhan_ngaySinh;
        private string _benhNhan_gioiTinh;
        private string _benhNhan_dienThoai;
        private string _benhNhan_diaChi;
        private string _benhNhan_ghiChu;
        public int benhNhan_id
        {
            get
            {
                return _benhNhan_id;
            }

            set
            {
                _benhNhan_id = value;
            }
        }
        public string benhNhan_tenBenhNhan
        {
            get
            {
                return _benhNhan_tenBenhNhan;
            }

            set
            {
                _benhNhan_tenBenhNhan = value;
            }
        }
        public string benhNhan_ngaySinh
        {
            get
            {
                return _benhNhan_ngaySinh;
            }

            set
            {
                _benhNhan_ngaySinh = value;
            }
        }
        public string benhNhan_gioiTinh
        {
            get
            {
                return _benhNhan_gioiTinh;
            }

            set
            {
                _benhNhan_gioiTinh = value;
            }
        }
        public string benhNhan_dienThoai
        {
            get
            {
                return _benhNhan_dienThoai;
            }

            set
            {
                _benhNhan_dienThoai = value;
            }
        }
        public string benhNhan_diaChi
        {
            get
            {
                return _benhNhan_diaChi;
            }

            set
            {
                _benhNhan_diaChi = value;
            }
        }
        public string benhNhan_ghiChu
        {
            get
            {
                return _benhNhan_ghiChu;
            }

            set
            {
                _benhNhan_ghiChu = value;
            }
        }
        public DTO_BenhNhan()
        {

        }

        public DTO_BenhNhan(int id, string hoten, string gioitinh, string ngaysinh,  string sdt,string diachi, string ghichu)
        {
            this.benhNhan_id = id;
            this.benhNhan_tenBenhNhan = hoten;
            this.benhNhan_gioiTinh = gioitinh;
            this.benhNhan_ngaySinh = ngaysinh;
            this.benhNhan_dienThoai = sdt;
            this.benhNhan_diaChi = diachi;
            this.benhNhan_ghiChu = ghichu;
        }
    }
}

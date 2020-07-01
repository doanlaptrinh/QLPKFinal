using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        private int _nhanVien_id;
        private string _nhanVien_hoTen;
        private string _nhanVien_gioiTinh;
        private string _nhanVien_ngaySinh;
        private string _nhanVien_queQuan;
        private int _nhanVien_sodt;
        private string _nhanVien_email;
        private string _nhanVien_chucVu;
        public int nhanVien_id
        {
            get
            {
                return _nhanVien_id;
            }

            set
            {
                _nhanVien_id = value;
            }
        }
        public string nhanVien_hoTen
        {
            get
            {
                return _nhanVien_hoTen;
            }

            set
            {
                _nhanVien_hoTen = value;
            }
        }
        public string nhanVien_gioiTinh
        {
            get
            {
                return _nhanVien_gioiTinh;
            }

            set
            {
                _nhanVien_gioiTinh = value;
            }
        }
        public string nhanVien_ngaySinh
        {
            get
            {
                return _nhanVien_ngaySinh;
            }

            set
            {
                _nhanVien_ngaySinh = value;
            }
        }
        public string nhanVien_queQuan
        {
            get
            {
                return _nhanVien_queQuan;
            }

            set
            {
                _nhanVien_queQuan = value;
            }
        }
        public int nhanVien_sodt
        {
            get
            {
                return _nhanVien_sodt;
            }

            set
            {
                _nhanVien_sodt = value;
            }
        }
        public string nhanVien_email
        {
            get
            {
                return _nhanVien_email;
            }

            set
            {
                _nhanVien_email = value;
            }
        }
        public string nhanVien_chucVu
        {
            get
            {
                return _nhanVien_chucVu;
            }

            set
            {
                _nhanVien_chucVu = value;
            }
        }
        public DTO_NhanVien()
        {

        }

        public DTO_NhanVien(int id, string hoten, string gioitinh, string ngaysinh, string quequan, int sdt, string email, string chucvu)
        {
            this.nhanVien_id = id;
            this.nhanVien_hoTen = hoten;
            this.nhanVien_gioiTinh = gioitinh;
            this.nhanVien_ngaySinh = ngaysinh;
            this.nhanVien_queQuan = quequan;
            this.nhanVien_sodt = sdt;
            this.nhanVien_email = email;
            this.nhanVien_chucVu = chucvu;
        }
    }
}

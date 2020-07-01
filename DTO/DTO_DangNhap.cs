using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DangNhap
    {
        private string _nguoiDung_taiKhoan;
        private string _nguoiDung_matKhau;
        private string _nguoiDung_phanQuyen;

        public string nguoiDung_taiKhoan
        {
            get
            {
                return _nguoiDung_taiKhoan;
            }

            set
            {
                _nguoiDung_taiKhoan = value;
            }
        }
        public string nguoiDung_matKhau
        {
            get
            {
                return _nguoiDung_matKhau;
            }

            set
            {
                _nguoiDung_matKhau = value;
            }
        }
        public string nguoiDung_phanQuyen
        {
            get
            {
                return _nguoiDung_phanQuyen;
            }

            set
            {
                _nguoiDung_phanQuyen = value;
            }
        }
        public DTO_DangNhap()
        {

        }

        public DTO_DangNhap(string tk, string mk, string pq)
        {
            this.nguoiDung_taiKhoan = tk;
            this.nguoiDung_matKhau = mk;
            this.nguoiDung_phanQuyen = pq;
            
        }
    }
}

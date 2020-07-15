using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Register
    {
        private string _nguoiDung_taiKhoan;
        private string _nguoiDung_matKhau;
        private int _nguoiDung_phanQuyen;
        private string _nguoiDung_Ten;
        public DTO_Register()
        {

        }
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
        public int nguoiDung_phanQuyen
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
        public string nguoiDung_Ten
        {
            get
            {
                return _nguoiDung_Ten;
            }

            set
            {
                _nguoiDung_Ten = value;
            }
        }
        public DTO_Register(string taikhoan, string matkhau, int phanquyen,string ten)
        { 
            this.nguoiDung_taiKhoan = taikhoan;
            this.nguoiDung_matKhau = matkhau;
            this.nguoiDung_phanQuyen = phanquyen;
            this.nguoiDung_Ten = ten;
        }
    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TrangChu
    {
        private  string _tenDangNhap;
        private string _quyen;
        public string TenDangNhap
        {
            get
            {
                return _tenDangNhap;
            }
            set
            {
                _tenDangNhap = value;
            }
        }
        public DTO_TrangChu()
        {

        }
        public  DTO_TrangChu(string tenDangNhap,string quyen)
        {
            TenDangNhap = tenDangNhap;
            phanQuyen = quyen;
        }
        public string phanQuyen
        {
            get
            {
                return _quyen;
            }
            set
            {
                _quyen = value;
            }
        }
    }
}

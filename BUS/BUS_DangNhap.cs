using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_DangNhap
    {
        DAL_DangNhap dalThanhVien = new DAL_DangNhap();

        
        public bool ktThanhVien(DTO_DangNhap tv)
        {
            return dalThanhVien.ktThanhVien(tv);
        }
    }
}

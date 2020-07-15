using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_DoanhThu
    {
        DAL_DoanhThu daldoanhthu = new DAL_DoanhThu();
        public DataTable Locdoanhthu(DTO_DoanhThu a)
        {
            return daldoanhthu.LocDoanhThu(a.Ngaybatdau,a.Ngayketthuc);
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_KiemTra
    {
        DAL_KiemTra dal_kiemtra = new DAL_KiemTra();
        public bool ThemKiemTra(DTO_KiemTra kiemtra)
        {

            return dal_kiemtra.ThemKiemTra(kiemtra);
        }
        public bool CheckTrung(string id)
        {
            return dal_kiemtra.CheckTrungID(id);
        }
    }
}

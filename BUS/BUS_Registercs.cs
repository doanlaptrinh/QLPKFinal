using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Registercs
    {
        DAL_Register dalRE = new DAL_Register();
        Code_hotro codehotro = new Code_hotro();

        public bool ThemTaiKhoan(DTO_Register tk)
        {
            return dalRE.themTaiKhoan(tk);
        }
        public bool CheckTrungTaiKhoan(string tk)
        {
            return dalRE.CheckTrungTaiKhoan(tk);
        }
        public bool checktk(string check)
        {
            return codehotro.checktk(check);
        }
        public bool SuaTaiKhoan(DTO_Register tk)
        {
            return dalRE.SuaTaiKhoan(tk);
        }
        public bool XoaTaiKhoan(DTO_Register tk)
        {
            return dalRE.XoaTaiKhoan(tk);
        }
    }
}

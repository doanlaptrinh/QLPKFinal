using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
     public class BUS_BenhNhan
    {
        DAL_BenhNhan dalBenhNhan = new DAL_BenhNhan();
        Code_hotro codehotro = new Code_hotro();

        public bool ThemBenhNhan(DTO_BenhNhan bn)
        {
            return dalBenhNhan.ThemBenhNhan (bn);
        }
        public bool CheckTrung(string id)
        {
            return dalBenhNhan.CheckTrungID(id);
        }
        public bool SuaBenhNhan(DTO_BenhNhan bn)
        {
            return dalBenhNhan.SuaBenhNhan(bn);
        }
        public bool XoaBenhNhan(DTO_BenhNhan nv)
        {
            return dalBenhNhan.XoaBenhNhan(nv);
        }
        public bool checkSo(string check)
        {
            return codehotro.ktso(check);
        }
        public bool checkChu(string check)
        {
            return codehotro.ktchu(check);
        }
    }
}

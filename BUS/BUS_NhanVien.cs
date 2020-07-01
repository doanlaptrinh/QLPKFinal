using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        Code_hotro codehotro = new Code_hotro();

        public bool ThemNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.ThemNhanVien(nv);
        }
        public bool CheckTrung(string id)
        {
            return dalNhanVien.CheckTrungID(id);
        }
        public bool SuaNhanVen(DTO_NhanVien nv)
        {
            return dalNhanVien.SuaNhanVien(nv);
        }
        public bool XoaNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.XoaNhanVien(nv);
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

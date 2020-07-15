using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_KhamBenh
    {
        
        DAL_KhamBenh dalKhamBenh = new DAL_KhamBenh();
        Code_hotro codehotro = new Code_hotro();
        public bool ThemKhamBenh(string id,string ten)
        {
            return dalKhamBenh.ThemKhamBenh(id,ten);
        }
        public bool CheckTrungID(string kb)
        {
            return dalKhamBenh.CheckTrungID(kb);
        }
        public bool XoaBenhAn(string id)
        {
            return dalKhamBenh.XoaBenhAn(id);
        }
        public bool ThemKiemTra(string id,string idpk)
        {
            return dalKhamBenh.ThemKiemtra(id,idpk);
        }
        public bool CheckTrungKT(string ID,string idpk)
        {
            return dalKhamBenh.CheckTrungKT(ID,idpk);
        }
        public bool XoaKiemTra(string id)
        {
            return dalKhamBenh.XoaKiemTra(id);
        }
        public bool ThemDonThuoc(string id, int sl,int idphienkham)
        {
            return dalKhamBenh.ThemDonThuoc(id,sl,idphienkham);
        }
        public bool ChecTrungThuoc(string id,string idpk)
        {
            return dalKhamBenh.CheckTrungThuoc(id,idpk);
        }
        public bool XoaDonThuoc(string id)
        {
            return dalKhamBenh.XoaDonThuoc(id);
        }
        //public int GetIDDonThuoc()
        //{
        //    return dalKhamBenh.Getidphienkham();
        //}
        public DataTable Xemdonthuoc(string id)
        {
            return dalKhamBenh.Xemdonthuoc(id);
        }
        public DataTable Xemkiemtra(string id)
        {
            return dalKhamBenh.Xemkiemtra(id);
        }
        public bool SuaKhamBenh(string id, string chuandoan,string ghichu)
        {
            return dalKhamBenh.SuaKhamBenh(id,chuandoan,ghichu);
        }
        public bool ThemDoanhThu(int id)
        {
            return dalKhamBenh.ThemDoanhThu(id);
        }
    }
   
}

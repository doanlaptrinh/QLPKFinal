using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Thuoc
    {
        private int _thuoc_id;
        private string _thuoc_tenthuoc;
        private string _thuoc_soLuong;
        private string _thuoc_lieuDung;
        private int _thuoc_donGia;
        private string _thuoc_ghiChu;
        public int thuoc_id
        {
            get
            {
                return _thuoc_id;
            }

            set
            {
                _thuoc_id = value;
            }
        }
        public string thuoc_tenthuoc
        {
            get
            {
                return _thuoc_tenthuoc;
            }

            set
            {
                _thuoc_tenthuoc = value;
            }
        }
        public string thuoc_soLuong
        {
            get
            {
                return _thuoc_soLuong;
            }

            set
            {
                _thuoc_soLuong = value;
            }
        }
        public string thuoc_lieuDung
        {
            get
            {
                return _thuoc_lieuDung;
            }

            set
            {
                _thuoc_lieuDung = value;
            }
        }
        public int thuoc_donGia
        {
            get
            {
                return _thuoc_donGia;
            }

            set
            {
                _thuoc_donGia = value;
            }
        }
        
        public string thuoc_ghiChu
        {
            get
            {
                return _thuoc_ghiChu;
            }

            set
            {
                _thuoc_ghiChu = value;
            }
        }
        public DTO_Thuoc()
        {

        }

        public DTO_Thuoc(int id, string tenthuoc, string soluong, string lieudung, int dongia, string ghichu)
        {
            this.thuoc_id = id;
            this.thuoc_tenthuoc = tenthuoc;
            this.thuoc_soLuong = soluong;
            this.thuoc_lieuDung = lieudung;
            this._thuoc_donGia = dongia;
            
            this.thuoc_ghiChu = ghichu;
        }
    }
}

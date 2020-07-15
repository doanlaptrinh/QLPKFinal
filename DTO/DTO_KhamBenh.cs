using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhamBenh: DTO_NhanVien
    {
        private int _khamBenh_idBN;
        private string _khamBenh_kiemtra;
        private string _khamBenh_chuandoan;
        private string _khamBenh_thuoc;
        private string _khamBenh_ghichu;
        private int _khamBenh_slT;
        public int KhamBenh_idBN
        {
            get
            {
                return _khamBenh_idBN;
            }

            set
            {
                _khamBenh_idBN = value;
            }
        }
        public string KhamBenh_kiemtra
        {
            get
            {
                return _khamBenh_kiemtra;
            }

            set
            {
                _khamBenh_kiemtra = value;
            }
        }
        public string KhamBenh_chuandoan
        {
            get
            {
                return _khamBenh_chuandoan;
            }

            set
            {
                _khamBenh_chuandoan = value;
            }
        }
        public string KhamBenh_thuoc
        {
            get
            {
                return _khamBenh_thuoc;
            }

            set
            {
                _khamBenh_thuoc = value;
            }
        }
        public int KhamBenh_slT
        {
            get
            {
                return _khamBenh_slT;
            }

            set
            {
                _khamBenh_slT = value;
            }
        }
        public string KhamBenh_ghichu
        {
            get
            {
                return _khamBenh_ghichu;
            }

            set
            {
                _khamBenh_ghichu = value;
            }
        }
        public DTO_KhamBenh()
        {

        }

        public DTO_KhamBenh(int idBN,string kiemtra,string chuandoan,string thuoc,int slT,string ghichu)
        {
            this.KhamBenh_idBN = idBN;
            this.KhamBenh_kiemtra = kiemtra;
            this.KhamBenh_chuandoan = chuandoan;
            this.KhamBenh_thuoc = thuoc;
            this.KhamBenh_slT = slT;
            this.KhamBenh_ghichu = ghichu;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KiemTra
    {
        private int _kiemtra_id;
        private string _kiemtra_tenkiemtra;
        private int _kiemtra_donGia;
       
        public int kiemtra_id
        {
            get
            {
                return _kiemtra_id;
            }

            set
            {
                _kiemtra_id = value;
            }
        }
        public string kiemtra_tenkiemtra
        {
            get
            {
                return _kiemtra_tenkiemtra;
            }

            set
            {
                _kiemtra_tenkiemtra = value;
            }
        }
        
        public int kiemtra_donGia
        {
            get
            {
                return _kiemtra_donGia;
            }

            set
            {
                _kiemtra_donGia = value;
            }
        }
                
        public DTO_KiemTra()
        {

        }

        public DTO_KiemTra(int id, string tenkiemtra, int dongia)
        {
            this.kiemtra_id = id;
            this.kiemtra_tenkiemtra = tenkiemtra;
            this._kiemtra_donGia = dongia;

        }
    }
}

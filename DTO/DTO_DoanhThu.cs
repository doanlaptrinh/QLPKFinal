using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DoanhThu
    {

        private DateTime _ngaybatdau;
        private DateTime _ngayketthuc;

        public DTO_DoanhThu()
        {

        }
        public DateTime Ngaybatdau
        {
            get
            {
                return _ngaybatdau;
            }

            set
            {
                _ngaybatdau = value;
            }
        }
        public DateTime Ngayketthuc
        {
            get
            {
                return _ngayketthuc;
            }

            set
            {
                _ngayketthuc = value;
            }
        }

        public DTO_DoanhThu(DateTime ngaybd, DateTime ngaykt)
        {
            this.Ngaybatdau = ngaybd;
            this.Ngayketthuc = ngaykt;

        }
    }
}

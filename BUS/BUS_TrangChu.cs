using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_TrangChu
    {
        Code_hotro ht=new Code_hotro();
        public bool phanQuyen(DTO_TrangChu q)
        {
            return ht.checkQuyen(q);
        }
    }
}

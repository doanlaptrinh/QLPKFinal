using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using DTO;
namespace DAL
{
    public class Code_hotro
    {
        public bool ktso(string s)
        {
            Regex re = new Regex(@"^[0-9]{1,15}$");
            if (s != "")
            {
                if (!re.IsMatch(s))
                {
                    
                    return true;
                }
            }
            return false;
        }
        public bool ktchu(string s)
        {
            Regex re = new Regex(@"^[aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ ]{1,50}$");
            if (s != "")
            {
                if (!re.IsMatch(s))
                {
                    
                    return true;
                }
            }
            return false;
        }
        public bool checktk(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= '0' && s[i] <= '9'))
                {
                    continue;
                }
                else
                    return true;

            }
            return false;
        }
        public bool checkQuyen(DTO_TrangChu q)
        {
            if (q.phanQuyen == "1")
                return true;
            return false;
        }
    }
}

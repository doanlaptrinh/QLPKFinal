using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
            Regex re = new Regex(@"^[a-zA-Z]{1,50}$");
            if (s != "")
            {
                if (!re.IsMatch(s))
                {
                    
                    return true;
                }
            }
            return false;
        }
    }
}

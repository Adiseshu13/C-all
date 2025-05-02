using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all
{
    public class Palindrome
    {
        public string PalCheck(string Pal)
        {
            Reverse rev=new Reverse();
            string revPal=rev.RevStr(Pal);
            string result = revPal == Pal ? "Palindrome" : "Not Palindrome";


            return result;
        }
    }
}

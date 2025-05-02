using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all
{
    public class Reverse
    {
        public string RevStr(string inp)
        {
            List<char> chrs = inp.ToList();
            int len=chrs.Count;
            for(int i = 0; i <= (len-1) / 2; i++)
            {
                char temp = chrs[i];
                chrs[i] = chrs[len -1 - i];
                chrs[len -1 - i] = temp;

            }

            string result = string.Concat(chrs);

            return result;
        }


        public string RevStrWords(string inp)
        {
            StringBuilder temp = new StringBuilder();
            StringBuilder result= new StringBuilder();
            foreach (char c in inp)
            {
                if(c==' ')
                {
                }


            }



            return " ";
        }

    }
}

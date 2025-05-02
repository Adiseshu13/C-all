using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all
{
    public class Counts
    {
        public int charsInStr(string str)
        {
            int result=0;
            foreach (char c in str)
            {
                result++;
            }


            return result;
        }
    }
}

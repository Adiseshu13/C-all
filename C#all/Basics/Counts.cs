using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all.Basics
{
    public class Counts
    {
        // Returns the number ofcharacters in a string.
        public int charsInStr(string str)
        {
            int result = 0;
            foreach (char c in str)
            {
                result++;
            }


            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all
{
    public class Substrings
    {
        // return list of all the substrings of the input string.
        public List<string> subStrings(string inp)
        {
            int len = inp.Length;
            List<string> result = new List<string>();
            for(int i = 0; i <= len - 1; i++)
            {
                result.Add(inp[i].ToString());
                if (i == len - 1)
                {
                    break;
                }
                for (int j = i+1; j <= len - 1; j++)
                {
                    result.Add(inp.Substring(i, (j - i + 1)));
                }
            }
            return result;
        }
    }
}

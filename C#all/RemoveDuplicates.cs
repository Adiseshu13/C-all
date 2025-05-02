using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all
{
    public class RemoveDuplicates
    {

        public string RemoveDuplicateChars(string input)
        {

            List<char> chars = new List<char>();
            foreach (char c in input)
            {
                if (!chars.Contains(c))
                {
                    chars.Add(c);
                }                
            }
            StringBuilder sb = new StringBuilder();
            foreach (char c in chars)
            {
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}

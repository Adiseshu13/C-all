using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all.Basics
{
    public class Reverse
    {
        // Returns the string by Reversing.
        public string RevStr(string inp)
        {
            List<char> chrs = inp.ToList();
            int len = chrs.Count;
            for (int i = 0; i <= (len - 1) / 2; i++)
            {
                char temp = chrs[i];
                chrs[i] = chrs[len - 1 - i];
                chrs[len - 1 - i] = temp;

            }

            string result = string.Concat(chrs);

            return result;
        }

        // Reversing string without using Loops or inbuilt functions 
        public string ReverseStringRecursive(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length <= 1)
            {
                return str;
            }
            else
            {
                return ReverseStringRecursive(str.Substring(1)) + str[0];
            }
        }

        //Returns the string by reversing the words. 
        public string RevStrWords(string inp)
        {
            StringBuilder temp = new StringBuilder();
            StringBuilder result = new StringBuilder();
            foreach (char c in inp)
            {
                if (c == ' ')
                {
                }


            }









            return " ";
        }

    }
}

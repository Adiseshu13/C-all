using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all.Basics
{
    public class Duplicates
    {
        //Returns the Duplicate characters in the string
        public List<char> DupChars(string inp)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            List<char> result = new List<char>();

            foreach (char c in inp)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }

            }

            foreach (char c in dict.Keys)
            {
                if (dict[c] > 1)
                {
                    result.Add(c);
                }
            }


            return result;
        }

        // Returns duplicate Strings in the list of string.
        public List<string> DupStrs(List<string> inp)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<string> result = new List<string>();
            foreach (string s in inp)
            {
                if (!dict.ContainsKey(s))
                {
                    dict.Add(s, 1);
                }
                else if (dict[s] == 1)
                {
                    dict[s]++;
                    result.Add(s);
                }
            }

            return result;
        }

        //Removes Dulicate letters from the string and returns string.
        public string RemDupLet(string inp)
        {
            StringBuilder result = new StringBuilder();
            List<char> chars = new List<char>();
            foreach (char ch in inp)
            {
                if (!chars.Contains(ch))
                {
                    result.Append(ch);
                    chars.Add(ch);
                }
            }


            return result.ToString();
        }
    }
}

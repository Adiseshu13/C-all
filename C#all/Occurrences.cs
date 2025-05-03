using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all
{
    public class Occurrences
    {
        //Returns how many times the letters have occurred in the string.
        public void LetterOccurrences(string inp)
        {
            Dictionary<char,int> res = new Dictionary<char,int>();
            foreach (char c in inp)
            {
                if(!(c==' '))
                {
                    if (res.ContainsKey(c))
                    {
                        res[c] += 1;
                    }
                    else
                    {
                        res[c] = 1;
                    }

                }
            }

            foreach(var i in res)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }             
        
        }
    }
}

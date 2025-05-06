using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all.Algorithms
{
    public class MooreVoting
    {
        // Return the number repeating more than n/2 times in an integer array of length n.

        //[1,2,1,2,2,1,2,2]
        public int mostRepeatedValue(int[] arr)
        {
            int match = 0;
            int temp=0;
            foreach (int item in arr)
            {
                if (match == 0)
                {
                    temp = item;
                }
                if (item == temp)
                {
                    match++;
                }
                else
                {
                    match--;
                }

            }

            return temp;
        }
    }
}

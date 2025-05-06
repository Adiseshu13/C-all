using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all.Basics
{
    public class Largest
    {
        // Return the second largest integer in the list. 
        public int secondLargestInt(int[] nums)
        {
            int len = nums.Length;
            int a = int.MinValue, b = int.MinValue;
            if (len == 0 || len == 1)
            {
                return 0;
            }

            foreach (int num in nums)
            {
                if (num > a)
                {
                    b = a;
                    a = num;
                }
                else if (num > b)
                {
                    b = num;
                }
            }
            return b;
        }
    }
}

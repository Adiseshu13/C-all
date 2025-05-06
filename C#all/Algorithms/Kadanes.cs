using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all.Algorithms
{
    public class Kadanes
    {

        // returns the maximum sum of the subarrays
        //[4,-5, 6,7]
        //[-1,-2,-3]
        public int maxSumSubArray(int[] subArray)
        {
            int tempresult = 0;
            int maxresult = int.MinValue;
            foreach (int num in subArray)
            {
                tempresult += num;
                maxresult = int.Max(maxresult, tempresult);
                if (tempresult < 0)
                {
                    tempresult = 0;
                }
            }
            return maxresult;
        }
    }
}

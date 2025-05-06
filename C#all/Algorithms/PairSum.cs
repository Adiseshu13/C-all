using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all.Algorithms
{
    // Given an array of integers and desiered sum. return the positions of the numbers which can be added to get the desired sum. 
    public class PairSum
    {
        //[-4, 3, 5, -9, 5, 4, 3, -1, 2];
        //      -5
        public int[] indexesOfDesiredSumNumbermatches(int[] numbers, int desiredSum)
        {
            Array.Sort(numbers);
            int len = numbers.Length;
            int i = 0; int j = len - 1;
            int[ ] result = new int[2];

            while (j > i)
            {
                if ((numbers[i] + numbers[j]) == desiredSum)
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
                else if ((numbers[i] + numbers[j]) > desiredSum)
                {
                    j--;
                }
                else
                {
                    i++;                
                }
                
            }

            return new int[0];
        }
    }
}

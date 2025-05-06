using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all.Basics
{
    public class ArrayConversions
    {

        public int[] twoDtooneD(int[,] inp)
        {
            int len = inp.GetLength(0);
            int width = inp.GetLength(1);
            int[] output = new int[len * width];
            int k = 0;

            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < len; i++)
                {
                    output[k] = inp[i, j];
                    k++;
                }

            }
            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all.Basics
{
    public class Sums
    {
        public int sumOfDigits(int n)
        {
            int result = 0;
            while (n > 0)
            {
                result = result + n % 10;
                n /= 10;
            }
            return result;
        }
    }
}

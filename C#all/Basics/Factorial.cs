using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all.Basics
{
    public class Factorial
    {
        // Returns Factorial of a number.
        public int fact(int n)
        {
            int result = 1;
            while (n > 0)
            {
                result = n * result;
                n--;
            }
            return result;
        }
    }
}

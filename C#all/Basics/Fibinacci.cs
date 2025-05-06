using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all.Basics
{
    public class Fibinacci
    {
        // Returns the fibinacci number.
        public int Fib(int n)
        {
            int n1 = 0;
            int n2 = 1;
            if (n == 1)
            {
                return n1;
            }
            else if (n == 2)
            {
                return n2;
            }
            else
            {
                int che = 2;
                while (che != n)
                {
                    int temp = n1;
                    n1 = n2;
                    n2 = temp + n1;
                    che++;
                }
                return n2;
            }

        }
    }
}

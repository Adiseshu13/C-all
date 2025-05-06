using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all.Basics
{
    public class Prime
    {
        public string primeCheck(int n)
        {
            if (n < 1)
            {
                return " Invalid Input ";
            }
            else if (n == 1)
            {
                return " Prime ";
            }
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        return " Not Prime ";
                    }
                }
                return " Prime ";
            }



        }
    }
}

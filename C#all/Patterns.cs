using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_all
{
    public class Patterns
    {


        public void ReverseTriangle(int n)
        {
            int k = 1;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < i + 1;j++)
                {
                    Console.Write(k+" ");
                    k++;
                }
                Console.WriteLine();

            }

        }

        public void ReverseTriangles(int n)
        {
            for(int i=1; i<=n; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }

        }

        public void InvertedTable(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int k = 0; k < i; k++)
                {
                    Console.Write("  ");
                }
                for(int k = 0; k < n - i; k++)
                {
                    Console.Write(i+1+" ");
                }
                Console.WriteLine();
            }
        }

        public void Pyramid(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for(int j=0;j<n-i; j++)
                {
                    Console.Write("  ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                for(int j = i - 1; j > 0; j--)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }

        public void HollowDiamond(int n)
        {

        }



    }
}

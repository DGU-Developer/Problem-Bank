using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            int rem, sum;
            i = 2;
            while (i < 500)
            {
                sum = 0;
                k = i / 2;
                j = 1;
                while (j <= k)
                {
                    rem = i % j;
                    if (rem == 0)
                        sum = sum + j;
                    j = j + 1;
                }
                if (sum == i)
                    Console.Write(" " + i);
                i = i + 1;
            }
        }
    }
}

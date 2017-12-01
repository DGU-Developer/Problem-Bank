using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            int rem, prime;
            i = 2;
            while (i <= 100)
            {
                prime = 1;
                k = i / 2;
                j = 2;
                while (j <= k)
                {
                    rem = i % j;
                    if (rem == 0)
                        prime = 0;
                    j = j + 1;
                }
                if (prime == 1)
                {
                    Console.Write(" " + i);
                }
                i = i + 1;
            }
        }
    }
}

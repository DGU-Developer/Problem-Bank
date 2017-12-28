using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_09_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 1; i <= 9; i++)
            {
                for (k = 1; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (j = i; j < i + 9; j++)
                {
                    if (j > 9)
                    {
                        k = j - 9;
                    }
                    else
                    {
                        k = j;
                    }
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }
    }
}

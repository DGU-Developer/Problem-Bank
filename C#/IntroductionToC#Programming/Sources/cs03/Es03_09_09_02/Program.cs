using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_09_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 9; i++)
            {
                for (j = 9; j > i; j--)
                    Console.Write(" ");
                for (; j > 1; j--)
                    Console.Write(j);
                for (; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
        }
    }
}

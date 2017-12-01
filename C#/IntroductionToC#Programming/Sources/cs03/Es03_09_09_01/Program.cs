using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_09_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0, k = 0;
            for (j = 1; j <= 9; j++)
            {
                if (j % 2 != 0)
                {
                    for (i = 0; i < ((9 - j) / 2); i++)
                    {
                        Console.Write(" ");
                    }
                    for (k = 0; k < j; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            for (j = 7; j >= 1; j--)
            {
                if (j % 2 != 0)
                {
                    for (i = 0; i < ((9 - j) / 2); i++)
                    {
                        Console.Write(" ");
                    }
                    for (k = 0; k < j; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

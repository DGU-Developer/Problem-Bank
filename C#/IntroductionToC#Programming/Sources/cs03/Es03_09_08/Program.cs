using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, multiply;
            for (i = 1; i <= 9; i++)
            {
                for (j = 2; j <= 5; j++)
                {
                    multiply = j * i;
                    Console.Write(j + " * " + i + " = ");
                    if (j == 5)
                    {
                        Console.WriteLine(multiply + ", ");
                    }
                    else
                    {
                        Console.Write(multiply + ", ");
                    }
                }
            }
            for (i = 1; i <= 9; i++)
            {
                for (j = 6; j <= 9; j++)
                {
                    multiply = j * i;
                    Console.Write(j + " * " + i + " = ");
                    if (j == 9)
                    {
                        if (i == 9 && j == 9)
                        {
                            Console.WriteLine(multiply);
                        }
                        else
                        {
                            Console.WriteLine(multiply + ", ");
                        }
                    }
                    else
                    {
                        Console.Write(multiply + ", ");
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_07_01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (i = 1; i <= 10; i++)
            {
                multiply = 1;
                for (j = 1; j <= i; j++)
                {
                    multiply *= j;
                }
                S += multiply;
            }
            Console.WriteLine("S = 1 + (1*2) + (1*2*3) + (1*2*3*4) + (1*2*3*4*5) + (1*2*3*4*5*6) + (1*2*3*4*5*6*7) + (1*2*3*4*5*6*7*8) + (1*2*3*4*5*6*7*8*9) + (1*2*3*4*5*6*7*8*9*10) = " + S);
        }
    }
}

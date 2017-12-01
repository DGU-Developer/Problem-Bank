using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_07_02
{
    class Program
    {
        static void Main(string[] args)
        {
            float S = 0;
            int i;
            for (i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    S -= (float)1 / i;
                }
                else
                {
                    S += (float)1 / i;
                }
            }
            Console.WriteLine("S = 1 - 1/2 + 1/3 - 1/4 + 1/5 - 1/6 + 1/7 - 1/8 + 1/9 - 1/10 = " + S);
        }
    }
}

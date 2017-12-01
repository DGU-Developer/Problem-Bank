using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, third, temp, i;
            for (i = 100; i < 500; i++)
            {
                temp = i;
                first = temp / 100;
                temp -= 100 * first;
                second = temp / 10;
                temp -= 10 * second;
                third = temp;

                if (i == (Math.Pow(first, 3) + Math.Pow(second, 3) + Math.Pow(third, 3)))
                    Console.Write(" " + i);
            }
        }
    }
}

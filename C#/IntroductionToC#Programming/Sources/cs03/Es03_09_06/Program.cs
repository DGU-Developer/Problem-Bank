using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 0;
            int operand2 = 1;

            for (int i = 1; i <= 100; i++)
                operand1 += 2 * i;
            for (int i = 1; i <= 10; i++)
                operand2 *= i;

            Console.WriteLine(operand1 + operand2);
        }
    }
}

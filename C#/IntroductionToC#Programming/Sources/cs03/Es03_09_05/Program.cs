using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            int gcm = 1;

            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            int loopCount = (number1 < number2) ? number1 : number2;

            for (int i = 1; i <= loopCount; i++)
            {
                if (number1 % i == 0 && number2 % i == 0)
                {
                    gcm *= i;
                    number1 = number1 / i;
                    number2 = number2 / i;
                    i = 1;
                }
            }

            Console.WriteLine("GCM = " + gcm);
            Console.WriteLine("GCD = " + (number1 * number2 * gcm));
        }
    }
}

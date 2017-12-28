using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es02_12_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, temp;
            Console.Write("일련의 수 : ");
            do
            {
                temp = Console.Read() - '0';
                if (temp > max)
                {
                    max = temp;
                }
            } while (temp != 0);
            Console.WriteLine("최대값 : " + max);
        }
    }
}

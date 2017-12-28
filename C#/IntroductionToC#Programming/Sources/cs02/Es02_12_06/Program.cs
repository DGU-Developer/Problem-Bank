using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es02_12_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, R1, R2, R3;
            Console.Write("Enter R1 : ");
            R1 = double.Parse(Console.ReadLine());
            Console.Write("Enter R2 : ");
            R2 = double.Parse(Console.ReadLine());
            Console.Write("Enter R3 : ");
            R3 = double.Parse(Console.ReadLine());
            R = R1 + R2 + R3;
            Console.WriteLine("직렬 연결 : " + R);
            R = 1 / (1 / R1 + 1 / R2 + 1 / R3);
            Console.WriteLine("병렬 연결 : " + R);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es02_12_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c, S;
            Console.Write("Enter 원금 : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter 이율 : ");
            c = float.Parse(Console.ReadLine());
            Console.Write("Enter 기간 : ");
            b = int.Parse(Console.ReadLine());
            S = a * Math.Pow(1 + c, b);
            Console.WriteLine("원리합계 : " + S);
        }
    }
}

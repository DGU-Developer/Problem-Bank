using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es02_12_07
{
    class Program
    {
        static void Main(string[] args)
        {
            float r;
            double V, S, pi;
            Console.Write("반지름 : ");
            pi = 3.141592;
            r = float.Parse(Console.ReadLine());
            V = (float)4 / 3 * pi * Math.Pow(r, 3);
            Console.WriteLine("부피 : " + V);
            S = 4 * pi * Math.Pow(r, 2);
            Console.WriteLine("표면적 : " + S);
        }
    }
}

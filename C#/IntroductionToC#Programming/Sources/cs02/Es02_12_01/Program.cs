using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es02_12_01
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, l;
            double s;
            Console.Write("Enter a : ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Enter b : ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Enter c : ");
            c = float.Parse(Console.ReadLine());
            l = (a + b + c) / 2;
            Console.WriteLine("l : " + l);
            s = Math.Sqrt(Math.Pow(l - a, 2) + Math.Pow(l - b, 2) + Math.Pow(l - c, 2));
            Console.WriteLine("s : " + s);
        }
    }
}

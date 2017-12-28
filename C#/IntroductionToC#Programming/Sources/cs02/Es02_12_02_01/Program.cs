using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es02_12_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, n;
            double z;
            Console.Write("Enter x : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter y : ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Enter n : ");
            n = int.Parse(Console.ReadLine());
            z = Math.Log(Math.Pow(x - y, n), Math.E);
            Console.WriteLine("z : " + z);
        }
    }
}

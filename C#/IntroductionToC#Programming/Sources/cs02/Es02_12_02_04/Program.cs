using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es02_12_02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, x;
            double z;
            Console.Write("Enter c : ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Enter x : ");
            x = int.Parse(Console.ReadLine());
            z = Math.Exp(c * Math.Pow(x, 2));
            Console.WriteLine("z : " + z);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es02_12_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double z;
            Console.Write("Enter x : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter y : ");
            y = int.Parse(Console.ReadLine());
            z = Math.Abs(Math.Pow(x, 2) - Math.Pow(y, 2));
            Console.WriteLine("z : " + z);
        }
    }
}

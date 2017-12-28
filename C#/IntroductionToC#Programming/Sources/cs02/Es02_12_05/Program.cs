using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es02_12_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double H, W, B, SW;
            Console.Write("Enter H : ");
            H = double.Parse(Console.ReadLine());
            Console.Write("Enter W : ");
            W = double.Parse(Console.ReadLine());
            SW = (H - 100) * 0.9;
            Console.WriteLine("표준체중 : " + SW);
            B = W / SW * 100;
            Console.WriteLine("비만도 : " + B);
        }
    }
}

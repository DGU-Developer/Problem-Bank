using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es02_12_04
{
    class Program
    {
        static void Main(string[] args)
        {
            float Cel, Fah;
            Console.Write("Enter Celsius : ");
            Cel = float.Parse(Console.ReadLine());
            Fah = (float)9 / 5 * Cel + 32;
            Console.WriteLine("Celsius : " + Cel);
            Console.WriteLine("Fahrenheit : " + Fah);
        }
    }
}

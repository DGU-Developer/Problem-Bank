using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es02_12_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("연도 : ");
            year = int.Parse(Console.ReadLine());
            if ((year % 4) == 0 && ((year % 100) != 0 || (year % 400) == 0))
            {
                Console.WriteLine(year + "년은 윤년입니다.");
            }
            else
            {
                Console.WriteLine(year + "년은 윤년이 아닙니다.");
            }
        }
    }
}

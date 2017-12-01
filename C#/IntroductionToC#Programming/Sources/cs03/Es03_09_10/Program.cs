using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int change;

            Console.WriteLine("물건의 가격을 입력하세요(1000원 미만)");
            change = 1000 - int.Parse(Console.ReadLine());
            if (change > 0)
            {
                Console.WriteLine("500원 " + Math.DivRem(change, 500, out change) + "개");
                Console.WriteLine("100원 " + Math.DivRem(change, 100, out change) + "개");
                Console.WriteLine("50원 " + Math.DivRem(change, 50, out change) + "개");
                Console.WriteLine("10원 " + Math.DivRem(change, 10, out change) + "개");
                Console.WriteLine("5원 " + Math.DivRem(change, 5, out change) + "개");
                Console.WriteLine("1원 " + change + "개");
            }
            else
                Console.WriteLine("입력한 물건 가격이 1000원 미만이 아닙니다.");
        }
    }
}

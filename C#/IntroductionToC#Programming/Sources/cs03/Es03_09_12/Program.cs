using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_12
{
    class Program
    {
        static void magic(int n)
        {
            int nsqr;
            int i, j;     /* start position */
            int k;
            int[,] matrix = new int[n, n];
            nsqr = n * n;
            i = 0; j = n / 2;

            for (k = 1; k <= nsqr; k = k + 1)
            {
                matrix[i, j] = k;
                i = i - 1;
                j = j + 1;
                if (k % n == 0)
                {
                    i = i + 2;
                    j = j - 1;
                }
                else if (i < 0)
                    i = i + n;
                else if (j == n)
                    j = j - n;
            }
            for (i = 0; i < n; i = i + 1)
            {
                for (j = 0; j < n; j = j + 1)
                    Console.Write(matrix[i, j]);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("마방진의 크기를 홀수로 입력하시오");
            size = int.Parse(Console.ReadLine());
            if (size % 2 != 0)
                magic(size);
            else
                Console.WriteLine("짝수를 입력하셨습니다");
        }
    }
}

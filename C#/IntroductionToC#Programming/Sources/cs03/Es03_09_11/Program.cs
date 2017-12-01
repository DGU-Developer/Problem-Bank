using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_11
{
    class Program
    {
        static void transpose(int[,] matrix, int row, int col)
        {
            int i, j;
            Console.WriteLine("===== {0} by {1} transpose Matrix =====", col, row);
            for (i = 0; i < col; i++)
            {
                for (j = 0; j < row; j++)
                    Console.Write(matrix[j, i] + "  ");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int row = 2;
            int col = 3;
            int i, j;
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine("===== {0} by {1} Matrix =====", row, col);
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                    Console.Write(matrix[i, j] + "  ");
                Console.WriteLine();
            }
            transpose(matrix, row, col);
        }
    }
}

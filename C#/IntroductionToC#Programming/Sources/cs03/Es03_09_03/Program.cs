using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            bool palindromic = true;
            number = Console.ReadLine();
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (String.Compare(number.Substring(i, 1), number.Substring(number.Length - 1 - i, 1)) != 0)
                    palindromic = false;
            }
            Console.WriteLine(palindromic);
        }
    }
}

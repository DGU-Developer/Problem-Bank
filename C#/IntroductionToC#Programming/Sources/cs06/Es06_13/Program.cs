using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es06_13
{
    class Program : ApplicationException
    {
        static void Main(string[] args)
        {
            int mysteriousState = int.Parse(args[0]);
            while (true)
            {
                Console.Write("Who ");
                try
                {
                    Console.Write("is ");
                    if (mysteriousState == 1) return;
                    Console.Write("that ");
                    if (mysteriousState == 2) break;
                    Console.Write("strange ");
                    if (mysteriousState == 3) continue;
                    Console.Write("but kindly ");
                    if (mysteriousState == 4)
                        throw new ExerciseCh6_9();
                    Console.Write("not at all ");
                }
                finally
                {
                    Console.Write("amusing ");
                }
                Console.Write("yet compelling ");
                break;
            }
            Console.Write("man?");
        }
    }
}

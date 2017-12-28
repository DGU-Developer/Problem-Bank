using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es06_10_02
{
    class Ex : Exception
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entering first try block");
            try
            {
                Console.WriteLine("Entering second try block");
                try
                {
                    throw new Ex();
                }
                finally
                {
                    Console.WriteLine("finally in 2nd try block");
                }
            }
            catch (Ex e)
            {
                Console.WriteLine("Caught Ex in first try block");
            }
            finally
            {
                Console.WriteLine("finally in 1st try block");
            }
        }
    }
}

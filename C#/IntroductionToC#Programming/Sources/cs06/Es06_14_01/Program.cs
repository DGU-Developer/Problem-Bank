using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es06_14_01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    string filePath = Console.ReadLine();
                    File.Open(filePath, FileMode.Open);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("존재하지 않는 파일입니다. 다시 입력하세요.");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es03_09_13
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"c:\csharp.cs", System.Text.Encoding.Default);
            string temp;
            temp = sr.ReadToEnd();
            sr.Close();
            StreamWriter sw = new StreamWriter(@"c:\csharp.cs", false, System.Text.Encoding.Default);
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp.Substring(i, 1) == "/")
                {
                    i++;
                    if (temp.Substring(i, 1) == "/")
                        for (i++; temp.Substring(i, 1) != "\r"; i++) ;
                }
                sw.Write(temp.Substring(i, 1));
            }
            sw.Close();
        }
    }
}

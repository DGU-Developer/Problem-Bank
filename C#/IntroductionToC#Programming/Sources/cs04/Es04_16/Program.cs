using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es04_16
{
    class Complex
    {
        public double real; // 실수부
        public double image; // 허수부

        public Complex(double rVal, double iVal) // 복소수 생성자
        {
            real = rVal;
            image = iVal;
        }

        public static Complex operator +(Complex operand1, Complex operand2) // 복소수에 대한 + 연산 정의
        {
            Complex result = new Complex(0, 0);
            result.real = operand1.real + operand2.real;
            result.image = operand1.image + operand2.image;
            return result;
        }

        public static Complex operator -(Complex operand1, Complex operand2) // 복소수에 대한 - 연산 정의
        {
            Complex result = new Complex(0, 0);
            result.real = operand1.real - operand2.real;
            result.image = operand1.image - operand2.image;
            return result;
        }

        public static Complex operator *(Complex operand1, Complex operand2) // 복소수에 대한 * 연산 정의
        {
            Complex result = new Complex(0, 0);
            result.real = operand1.real * operand2.real - operand1.image * operand2.image;
            result.image = operand1.real * operand2.image + operand1.image * operand2.real;
            return result;
        }

        public static Complex operator /(Complex operand1, Complex operand2) // 복소수에 대한 / 연산 정의
        {
            Complex result = new Complex(0, 0);
            result.real = (operand1.real * operand2.real + operand1.image * operand2.image) / (Math.Pow(operand2.real, 2) + Math.Pow(operand2.image, 2));
            result.image = (operand1.image * operand2.real - operand1.real * operand2.image) / (Math.Pow(operand2.real, 2) + Math.Pow(operand2.image, 2));
            return result;
        }

        override public string ToString()
        {
            return "(" + real + "," + image + "i)";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex result;
            Complex operand1 = new Complex(1, 2); // (1,2i)
            Complex operand2 = new Complex(3, 4); // (3,3i)

            result = operand1 + operand2;   // 복소수 + 연산
            Console.WriteLine(operand1 + " + " + operand2 + " = " + result);

            result = operand1 - operand2;   // 복소수 - 연산
            Console.WriteLine(operand1 + " - " + operand2 + " = " + result);

            result = operand1 * operand2;   // 복소수 * 연산
            Console.WriteLine(operand1 + " * " + operand2 + " = " + result);

            result = operand1 / operand2;   // 복소수 / 연산
            Console.WriteLine(operand1 + " / " + operand2 + " = " + result);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es04_12
{
    class Complex
    {
        public double real;     //실수부
        public double image;    //허수부

        public Complex(double a)
        {
            real = a;
        }

        public Complex(double a, double b)
        {
            real = a;
            image = b;
        }
        public override String ToString() //복소수를(실수부, 허수부)형태로 변환
        {
            return (real + "+" + image + "i");
        }

        public static Complex AddComplex(Complex f1, Complex f2) //AddComplex
        {
            return new Complex(f1.real + f2.real, f1.image + f2.image);
        }

        public static Complex SubComplex(Complex f1, Complex f2) //SubComplex
        {
            return new Complex(f1.real - f2.real, f1.image - f2.image);
        }

        public static Complex MulComplex(Complex f1, Complex f2) //MulComplex
        {
            return new Complex(((f1.real * f2.real) - (f1.image * f2.image)), ((f1.real * f2.image) + (f1.image * f2.real)));
        }

        public static Complex DivComplex(Complex f1, Complex f2) //DivComplex
        {
            return new Complex((((f1.real * f2.real) + (f1.image * f2.image)) / ((f2.real * f2.real) + (f2.image * f2.image))), (((f1.image * f2.real) - (f1.real * f2.image)) / ((f2.real * f2.real) + (f2.image * f2.image))));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex f3, f4, f5, f6;

            Console.Write("처음숫자를 입력하세요 ex) 1,2 : ");
            string no1 = Console.ReadLine();
            Console.Write("두번째 숫자를 입력하세요 ex) 3,4 : ");
            string no2 = Console.ReadLine();

            string[] No1 = no1.Split(',');
            string[] No2 = no2.Split(',');

            Complex f1 = new Complex(Convert.ToDouble(No1[0]), Convert.ToDouble(No1[1]));
            Complex f2 = new Complex(Convert.ToDouble(No2[0]), Convert.ToDouble(No2[1]));


            f3 = Complex.AddComplex(f1, f2);
            f4 = Complex.SubComplex(f1, f2);
            f5 = Complex.MulComplex(f1, f2);
            f6 = Complex.DivComplex(f1, f2);


            Console.WriteLine("f1={0}", f3);
            Console.WriteLine("f2={0}", f4);
            Console.WriteLine("f3={0}", f5);
            Console.WriteLine("f4={0}", f6);
        }
    }
}

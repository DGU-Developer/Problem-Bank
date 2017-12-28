using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es04_13
{
    class Stack
    {
        private int[] stack;
        private int sp = -1;
        public Stack()
        {
            stack = new int[100];  //스택의 크기는 100
        }
        public Stack(int size) //일련의 정수 입력(입력의 끝은 0)을 역순으로 출력
        {
            stack = new int[size];
        }

        public void Push(int data)  //Push
        {
            stack[++sp] = data;
        }

        public int Pop() //Pop
        {
            return stack[sp--];
        }

        public int GetStackPointer()  //스택 포인터
        {
            return sp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack a = new Stack();

            a.Push(1);
            a.Push(2);
            a.Push(3);

            while (a.GetStackPointer() != -1)
            {
                Console.WriteLine(a.Pop());
            }
            Console.ReadLine();
        }
    }
}

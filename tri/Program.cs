using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    class Program
    {
        int a, b, c;

        public Program(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        void WriteSolution(string op1, string op2)
        {
            Console.WriteLine("{0}{1}{2}{3}{4}", a, op1, b, op2, c);
        }

        static void Main(string[] args)
        {
            List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
            int a = tokens[0];
            int b = tokens[1];
            int c = tokens[2];
            var program = new Program(a, b, c);

            if (a + b == c) program.WriteSolution("+", "=");
            else if (a - b == c) program.WriteSolution("-", "=");
            else if (a * b == c) program.WriteSolution("*", "=");
            else if (b != 0 && a / b == c) program.WriteSolution("/", "=");
            else if (a == b + c) program.WriteSolution("=", "+");
            else if (a == b - c) program.WriteSolution("=", "-");
            else if (a == b * c) program.WriteSolution("=", "*");
            else if (c != 0 && a == b / c) program.WriteSolution("=", "/");
        }
    }
}

using System;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            for (int i = 0; i < input.Length - 1; i++)
            {

                if (input[i] == 's' && input[i + 1] == 's')
                {
                    Console.WriteLine("hiss");
                    return;
                } 

            }
            Console.WriteLine("no hiss");
        }
    }
}

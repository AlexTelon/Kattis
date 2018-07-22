using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> sounds = Console.ReadLine().Split().ToList();
                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "what does the fox say?")
                    {
                        break;
                    }

                    // sentences describing other animal sounds, remove their sounds
                    List<string> sentence = input.Split().ToList();
                    var sound = sentence[2];

                    sounds.RemoveAll(x => x == sound);
                }

                Console.WriteLine(String.Join(" ", sounds));
            }
        }
    }
}

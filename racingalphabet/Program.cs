using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        public static string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ '";

        static void Main(string[] args)
        {
            // [1..20]
            int n = int.Parse(Console.ReadLine());

            Debug.Assert(Alphabet.Length == 28);

            var diameter = 60; // [feet]
            var speed = 15; // [feet/s]
            var circumference = diameter * Math.PI;

            // the distance between to adjecent letters
            var deltaDist = circumference / 28;

            for (int m = 0; m < n; m++)
            {
                var steps = 0;

                // [8..120]
                var input = Console.ReadLine();
                var current = ' ';
                var next = ' ';

                // we start with picking up the first one
                var pickups = 1;

                for (int i = 0; i < input.Length - 1; i++)
                {
                    current = input[i];
                    next = input[i + 1];

                    steps += MinStepsBetween(current, next);
                    pickups++;
                }

                var dist = steps * deltaDist;
                var time = dist / speed;

                time += pickups; // every pickup takes 1 sec

                Console.WriteLine(time);
            }
        }

        private static int MinStepsBetween(char current, char next) 
        {
            var currentPos = Alphabet.IndexOf(current);
            var nextPos = Alphabet.IndexOf(next);

            var steps = Math.Abs(nextPos - currentPos);

            var ret = Math.Min(steps, Alphabet.Length - steps);

            return ret;
        }
    }
}

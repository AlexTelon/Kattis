using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int testCase = 1; testCase <= n; testCase++)
            {
                List<string> tokens = Console.ReadLine().Split().ToList();
                string alien_number = tokens[0];

                var source_digits = new List<char>(tokens[1]);
                int source_base = source_digits.Count;

                var target_digits = new List<char>(tokens[2]);
                int target_base = target_digits.Count;


                double sum = 0;
                //calculate alien_number decimal value.
                // go through it char for char and sum up their values on source_base
                for (int j = 0; j < alien_number.Length; j++)
                {
                    int value = source_digits.FindIndex(u=> u == alien_number[j]);

                    int position = (alien_number.Length - j) - 1; // first position should be 0

                    ///   value is basically a number like 9,
                    ///   position is the location of that 9 in the whole number 
                    ///   base is the number base.
                    sum += value * Math.Pow(source_base, position);
                }

                // we now have the value of the alien_number in normal decimal form
                // Now convert it to target language

                double reminder = sum;
                List<char> result = new List<char>();
                int x = Convert.ToInt32(Math.Floor(Math.Log(reminder, target_base)));

                for (int i = x; i >= 0; i--)
                {
                    double power = Math.Pow(target_base, i);

                    // we have found the apropiate power level now
                    // lets find the highest possible value
                    double value = 0;
                    int m;
                    for (m = 0; m < target_base; m++)
                    {
                        if ((m + 1) * power > reminder)
                        {
                            break;
                        }
                        value = (m + 1) * power;
                    }

                    result.Add(target_digits[m]);
                    reminder -= value;
                }
                Console.WriteLine("Case #{0}: {1}", testCase, new String(result.ToArray()));
            }
        }
    }
}

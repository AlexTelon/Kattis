using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        private const uint ALPHABET_SIZE = 26;

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            //var input = "EWPGAJRB";
            //var input = "UEQBJPJCBUDGBNKCAHXCVERXUCVK";

            var a = input.Substring(0, input.Length / 2);
            var b = input.Substring(input.Length / 2, input.Length / 2);

            var a2 = Rotate(a);
            var b2 = Rotate(b);

            var result = Merge(a2, b2);
            Console.WriteLine(result);
        }

        /// <summary>
        /// The last step is to combine these new strings (“ZRKB” and “BKSC”) by rotating each character in the first string by the value of the corresponding character in the second string. 
        /// For the first position, rotating ‘Z’ by ‘B’ means moving it forward 1 character, which wraps it around to ‘A’. 
        /// Continuing this process for every character results in the final decrypted message, “ABCD”.
        /// </summary>
        /// <param name="inputA"></param>
        /// <param name="inputB"></param>
        /// <returns></returns>
        private static string Merge(string inputA, string inputB)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < inputA.Length; i++)
            {
                char a = inputA[i];
                char b = inputB[i];

                // how much is the chars worth?
                int valueB = NormalizeChar(b);

                // rotate the char by the corresponding amount
                a = Rotate(a, valueB);

                // build the new string
                stringBuilder.Append(a);
            }

            return stringBuilder.ToString();

        }
        
        /// <summary>
        /// Rotate every char with the number of steps that is decided by the DRM messages task.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string Rotate(string input)
        {
            int sum = Sum(input);
            return Rotate(input, sum);
        }

        /// <summary>
        /// Rotate every char by a given number of steps
        /// </summary>
        /// <param name="input"></param>
        /// <param name="steps"></param>
        /// <returns></returns>
        private static string Rotate(string input, int steps)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                stringBuilder.Append(Rotate(input[i], steps));
            }
            return stringBuilder.ToString();
        }


        private static char Rotate(char c, int sum)
        {
            // we get a char which we want to convert down to a  0-25 range
            var shiftedNormalized = (NormalizeChar(c) + sum);

            // no we do modulus so it wraps around
            var modulurized = shiftedNormalized % ALPHABET_SIZE;

            // now de-normalize it to get it back to its real range
            return (char) DeNormalizeChar((char) modulurized);
        }

        private static int Sum(string input)
        {
            return input.Select(c => NormalizeChar(c)).Sum();
        }

        private static int NormalizeChar(char c)
        {
            return (int)c - (int)'A';
        }

        private static int DeNormalizeChar(char c)
        {
            return (int)c + (int)'A';
        }

    }
}

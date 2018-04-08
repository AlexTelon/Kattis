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
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_.";

            while (true)
            {
                var tokens = Console.ReadLine().Split();

                // [1.. 27]
                int N = int.Parse(tokens[0]);
                if (N == 0) break;

                string message = tokens[1];

                var output = new StringBuilder();
                output.Append(new String('^', message.Length));

                for (int i = 0; i < message.Length; i++)
                {
                    var c = message[i];

                    var index = alphabet.IndexOf(c);

                    // shift the index position
                    index = (index + N) % alphabet.Length;

                    var newChar = alphabet[index];

                    output[i] = newChar; 
                }



                Console.WriteLine(Reverse(output.ToString()));
            }
        }

        private static string Reverse(string output)
        {
            var charArray = output.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

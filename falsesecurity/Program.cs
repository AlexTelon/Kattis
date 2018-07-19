using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    class Program
    {
        public static Dictionary<char, string> ToMorse = new Dictionary<char, string>()
        {
            {'A', ".-" },
            {'B', "-..." },
            {'C', "-.-." },
            {'D', "-.." },
            {'E', "." },
            {'F', "..-." },
            {'G', "--." },
            {'H', "...." },
            {'I', ".." },
            {'J', ".---" },
            {'K', "-.-" },
            {'L', ".-.." },
            {'M', "--" },
            {'N', "-." },
            {'O', "---" },
            {'P', ".--." },
            {'Q', "--.-" },
            {'R', ".-." },
            {'S', "..." },
            {'T', "-" },
            {'U', "..-" },
            {'V', "...-" },
            {'W', ".--" },
            {'X', "-..-" },
            {'Y', "-.--" },
            {'Z', "--.." },
            {'_', "..--" },
            {',', ".-.-" },
            {'.', "---." },
            {'?', "----" }
        };

        static void Main(string[] args)
        {
            string encrypted = Console.ReadLine();

            while (!string.IsNullOrEmpty(encrypted))
            {
                string decrypted = "";

                string morseformat = "";
                string lengths = "";

                for (int i = 0; i < encrypted.Length; i++)
                {
                    char c = encrypted[i];
                    morseformat += ToMorse[c];
                    lengths += ToMorse[c].Length;
                }

                lengths = new string(lengths.Reverse().ToArray());

                int index = 0;
                foreach (char c in lengths)
                {
                    int len = (int)Char.GetNumericValue(c);
                    string substring = morseformat.Substring(index, len);
                    index += len;

                    // hack to use the dictionary backwards, all values are unique so this is fine
                    var charFromMorse = ToMorse.FirstOrDefault(x => x.Value == substring).Key;

                    decrypted += charFromMorse;
                }

                Console.WriteLine(decrypted);

                encrypted = Console.ReadLine();
            }
        }
    }
}

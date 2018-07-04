using System;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            var cipher = Console.ReadLine();
            var prefix = Console.ReadLine();

            string message = "" + prefix;

            for (int i = 0; i < cipher.Length; i++)
            {
                // A is nr 65 and should not shift at all
                char a = message[i];
                char b = cipher[i];


                int shift = (int)message[i] - 65;
                var orig = ((int)cipher[i] - 65);
                var shifted = (orig - shift) + 26;

                var wrapped = (shifted % 26);

                
                message += (char) (wrapped  + 65);

            }
            Console.WriteLine(new string(message.Skip(prefix.Length).ToArray()));
        }
    }
}

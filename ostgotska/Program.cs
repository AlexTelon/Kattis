using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var words = input.Trim().Split().Where(s => s.Length > 0);

            int ostgotskaWords = 0;
            foreach (var word in words)
            {
                int count = new Regex(Regex.Escape("ae")).Matches(word).Count;
                if (count > 0)
                {
                    ostgotskaWords++;
                }
            }

            int wordCount = words.Count();
            if (wordCount == 0 || (double)ostgotskaWords / wordCount >= 0.4)
            {
                Console.WriteLine("dae ae ju traeligt va");
            }
            else
            {
                Console.WriteLine("haer talar vi rikssvenska");
            }
        }
    }
}

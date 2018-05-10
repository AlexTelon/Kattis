using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis.DebugExtras
{
    /// <summary>
    /// A console that is easy to modify.
    /// 
    /// Intended for use when you want to inject stuff to ReadLine automatically, or maybe dont want to see the input in your console.
    /// </summary>
    class DebugConsole : IConsole
    {
        public string ReadLine()
        {
            var builder = new StringBuilder();
            while (true)
            {
                // do a silent read
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                builder.Append(key);
            }

            return builder.ToString();
        }

        public void Write(string m = "")
        {
            Console.Write(m);
        }

        public void WriteLine(string m = "")
        {
            Console.WriteLine(m);
        }
    }
}

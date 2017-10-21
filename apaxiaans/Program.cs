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

            string name = Console.ReadLine();
            string output = "" + name[0];

            for (int i = 0; i < name.Length; i++)
            {
                if (output[output.Length - 1] != name[i])
                {
                    output += name[i];
                }
            }

            Console.WriteLine(output);
        }
    }
}

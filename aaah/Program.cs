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
            string me = Console.ReadLine();
            string doctor = Console.ReadLine();

            if (me.Length >= doctor.Length) Console.WriteLine("go");
            else Console.WriteLine("no");
        }
    }
}

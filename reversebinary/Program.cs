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
            //List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
            int value = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            string reversed = new string(binary.Reverse().ToArray());
            int newVal = Convert.ToInt32(reversed, 2);

            Console.WriteLine(newVal);
            //Console.WriteLine(string.Join("", value));
        }
    }
}

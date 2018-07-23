using System;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string original = Console.ReadLine();
            string final = Console.ReadLine();

            bool success = Verify(n, original, final);

            if (success)
            {
                Console.WriteLine("Deletion succeeded");
            }
            else
            {
                Console.WriteLine("Deletion failed");
            }
        }

        private static bool Verify(int n, string original, string final)
        {
            if (original.Length != final.Length) return false;

            if (n % 2 == 0)
            {
                // if an even number of swaps have been made they must be equal
                return original == final;
            }
            else
            {
                // all must be different
                for (int i = 0; i < original.Length; i++)
                {
                    if (original[i] == final[i]) return false;
                }
                return true;
            }
        }
    }
}

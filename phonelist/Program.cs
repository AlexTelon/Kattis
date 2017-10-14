using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        class Node
        {
            public bool IsLeaf => children.Count == 0;
            Dictionary<int, Node> children = new Dictionary<int, Node>();

            /// <summary>
            /// its the callee that checks the index
            /// </summary>
            /// <param name="numbers"></param>
            /// <param name="index"></param>
            /// <returns></returns>
            public bool Visit(int[] numbers, uint index)
            {
                if (index >= numbers.Length)
                {
                    // if we are not a leaf (meaning there is numbers that continue past this then we are NOT consistent)
                    if (!IsLeaf) return false;
                    // otherwise, we are a leaf and thats what the last number in every phone number should be
                    return true;
                }

                int number = numbers[index];
                if (children.ContainsKey(number))
                {
                    if (children[number].IsLeaf) return false;
                } else
                {
                    children[number] = new Node();
                }

                return children[number].Visit(numbers, ++index);
            }

        }

        static void Main(string[] args)
        {
            // 1 - 40
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                Node start = new Node();

                string consistent = "YES";
                // 1 - 10 000
                int n = int.Parse(Console.ReadLine());

                for (int j = 0; j < n; j++)
                {
                    // 1 - 10 digits
                    int[] phone = Array.ConvertAll(Console.ReadLine().ToCharArray(), c => (int) Char.GetNumericValue(c));
                    if (!start.Visit(phone, 0))
                    {
                        consistent = "NO";
                        break;
                    }
                }
                Console.WriteLine(consistent);
            }
        }
    }
}

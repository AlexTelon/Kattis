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
            bool first = true;
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0) break;

                //var data = new List<List<char>>();

                // 100 x 100 is supersmall so its fine to use max here.
                char[,] matrix = new char[100, 100];

                int maxRow = 0;

                for (int i = 0; i < n; i++)
                {
                    string row = Console.ReadLine();
                    maxRow = Math.Max(maxRow, row.Length);
                    //data.Add(Console.ReadLine().ToList());
                    for (int j = 0; j < row.Length; j++)
                    {
                        char c = row[j];
                        if (c == '-') c = '|';
                        else if (c == '|') c = '-';

                        //if (i == 6)
                        //{

                        //}

                        //if (c == '\0') c = ' ';

                        // Note to self, how did I do this?
                        // first print out in place
                        // using 
                        // 3
                        // abc
                        // def
                        // ghi
                        // Then swap one axis at a time and see the results
                        matrix[j, (n - 1) - i] = c;
                    }
                }

                if (first)
                {
                    first = false;
                }
                else
                {
                    Console.WriteLine();
                }

                List<string> manThisThing = new List<string>();

                //Console.WriteLine();
                for (int i = 0; i < maxRow; i++)
                {
                    bool foundFirstChar = false;
                    string row = "";
                    for (int j = 0; j < n; j++)
                    {
                        char o = matrix[i, j];

                        if (o != '\0') foundFirstChar = true;

                        if (!foundFirstChar && o == '\0') o = ' ';


                        if (o != '\0')
                        {
                            row += o;
                            //newline = true;
                            //Console.Write(o);
                        }
                    }
                    manThisThing.Add(row.TrimEnd(' '));
                    //Console.WriteLine();
                    //if (newline) Console.WriteLine();
                }
                Console.WriteLine(string.Join("\n", manThisThing));
            }
        }
    }
}
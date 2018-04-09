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
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split().ToList();
                var name = tokens[0];
                var studyDate = tokens[1];
                var birthDate = tokens[2];
                var courses = int.Parse(tokens[3]);


                // rule 1, if the student first began post-secondary studies in 2010 or later, the student is eligible;
                var startYear = int.Parse(studyDate.Substring(0, 4));
                if (startYear >= 2010)
                {
                    Console.WriteLine(name + " eligible");
                    continue;
                }
                // rule 2, if the student is born in 1991 or later, the student is eligible
                var birthYear = int.Parse(birthDate.Substring(0, 4));
                if (birthYear >= 1991)
                {
                    Console.WriteLine(name + " eligible");
                    continue;
                }

                // rule 3, if none of the above applies, and the student has completed more than an equivalent of 8 semesters of full-time study, the student is ineligible;
                if (courses > 8 * 5)
                {
                    Console.WriteLine(name + " ineligible");
                    continue;
                }

                Console.WriteLine(name + " coach petitions");
            }
        }
    }
}

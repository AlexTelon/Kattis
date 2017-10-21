using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {

        class Person
        {
            public string Guess;
            public string Name;
            public int Sum;

            public void TakeExam(string exam)
            {
                int i = 0;
                foreach (var token in exam)
                {
                    if (Guess[i++ % Guess.Length] == token) {
                        Sum++;
                    }
                }
            }

            public Person(string name, string guess)
            {
                Name = name;
                Guess = guess;
            }
        }

        static void Main(string[] args)
        {
            Console.ReadLine();
            string exam = Console.ReadLine();

            Person Adrian = new Person("Adrian", "ABC");
            Person Bruno = new Person("Bruno", "BABC");
            Person Goran = new Person("Goran", "CCAABB");

            List<Person> boys = new List<Person>() { Adrian, Bruno, Goran };

            foreach (var boy in boys)
            {
                boy.TakeExam(exam);
            }

            boys.OrderBy(x => x.Sum);

            int max = boys.Max(x => x.Sum);
            Console.WriteLine(max);
            Console.WriteLine(String.Join("\n", boys.Where(x => x.Sum == max).Select(x => x.Name)));

        }
    }
}

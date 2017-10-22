using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        public struct Submission
        {
            public int Time;
            public bool Pass;

            public Submission(int time, bool pass)
            {
                Time = time;
                Pass = pass;
            }
        }

        static void Main(string[] args)
        {
            int correctAnswers = 0;
            var totalTime = 0;

            var results = new Dictionary<char, List<Submission>>();

            while (true)
            {
                var tokens = Console.ReadLine().Split();
                int time = int.Parse(tokens[0]);
                if (time == -1) break;
                Char problem = char.Parse(tokens[1]);
                bool correct = (tokens[2] == "right");

                var submission = new Submission(time, correct);

                if (!results.ContainsKey(problem))
                {
                    // Add first result to this new problem
                    results.Add(problem, new List<Submission>() { submission });
                }
                else
                {
                    results[problem].Add(submission);
                }
            }


            foreach (var item in results)
            {
                char prob = item.Key;
                List<Submission> submissions = item.Value;

                var lastEntry = submissions[submissions.Count() - 1];

                // Check if we ever passed.
                if (lastEntry.Pass)
                {
                    correctAnswers++;
                    
                    // add penalty for each faulty submission
                    totalTime += 20 * (submissions.Count() - 1);
                    // add time until we found a solution
                    totalTime += lastEntry.Time;
                }
            }

            Console.Write(correctAnswers + " " + totalTime);
        }
    }
}

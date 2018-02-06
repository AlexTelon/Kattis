using System;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "0" && input[1] == "0" && input[2] == "0") return;

                var trueRadius = double.Parse(input[0], System.Globalization.CultureInfo.InvariantCulture);
                var points = int.Parse(input[1]);
                var pointInCircle = int.Parse(input[2]);


                var correctAnswer = Math.PI * trueRadius * trueRadius;

                var diameter = trueRadius * 2;
                var squareArea = diameter * diameter;
                var ratio = (double)pointInCircle / points;

                // estimated answer using the throw random points method
                double estimatedAnswer = ratio * squareArea;

                Console.WriteLine(correctAnswer + " " + estimatedAnswer);
            }
        }
    }
}

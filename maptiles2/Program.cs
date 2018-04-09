using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        class Position
        {
            public Position(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }

            public override string ToString()
            {
                return "" + X + " " + Y;
            }
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var zoomLevel = input.Length;

            var coordinate = new Position(0,0);

            foreach (var c in input)
            {
                int zoom_in_location = (int) char.GetNumericValue(c);
                coordinate = ZoomIn(zoom_in_location, coordinate);
            }
            Console.WriteLine(zoomLevel + " " + coordinate);
        }

        // zoom in one level in the map
        // pos can be 0, 1, 2, 3
        private static Position ZoomIn(int pos, Position coordinate)
        {
            if (pos == 0) return new Position(coordinate.X * 2, coordinate.Y * 2);
            if (pos == 1) return new Position(coordinate.X * 2 + 1, coordinate.Y * 2);
            if (pos == 2) return new Position(coordinate.X * 2, coordinate.Y * 2 + 1);
            if (pos == 3) return new Position(coordinate.X * 2 + 1, coordinate.Y * 2 + 1);
            else throw new NotImplementedException();
        }
    }
}

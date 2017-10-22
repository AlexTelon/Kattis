using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        class GameBoard
        {
            private char[,] Board = new char[7, 7];

            public int Peg(int x, int y)
            {
                if (x < 0 || x > 6 || y < 0 || y > 6) return 0;
                return (Board[x, y] == 'o') ? 1 : 0;
            }

            public int Value(int x, int y)
            {
                // only check legal moves added by the existance of a hole
                if (Board[x, y] != '.') return 0;

                int sum = 0;
                if (Peg(x-1, y) == 1) sum += Peg(x - 2, y);
                if (Peg(x+1, y) == 1) sum += Peg(x + 2, y);
                if (Peg(x, y+1) == 1) sum += Peg(x, y + 2);
                if (Peg(x, y-1) == 1) sum += Peg(x, y - 2);
                return sum;
            }

            public int LegalMoves()
            {
                int sum = 0;
                for (int y = 0; y < 7; y++)
                {
                    for (int x = 0; x < 7; x++)
                    {
                        sum += Value(x, y);
                    }
                }
                return sum;
            }

            internal void Init()
            {
                for (int i = 0; i < 7; i++)
                {
                    var chars = Console.ReadLine().ToCharArray();
                    var rowSize = 7*sizeof(char);
                    Buffer.BlockCopy(chars, 0, Board, i * rowSize, rowSize);
                }
            }
        }


        static void Main(string[] args)
        {
            var game = new GameBoard();
            game.Init();

            Console.WriteLine(game.LegalMoves());
        }
    }
}

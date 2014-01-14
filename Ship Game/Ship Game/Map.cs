using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Game
{
    class Map
    {
        Random rnd = new Random();
        public Map()
        {
            int size = int.Parse(Console.ReadLine());
            _mapField = new Cell[size, size];
            for (int i = 0; i < Math.Sqrt(_mapField.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(_mapField.Length); j++)
                {
                    _mapField[i, j].X = i;
                    _mapField[i, j].Y = j;
                    _mapField[i, j].Z = rnd.Next(0, 20);
                }
            }
        }

        private Cell[,] _mapField;

        public void Print()
        {
            string symbol = "";
            for (int i = 0; i < Math.Sqrt(_mapField.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(_mapField.Length); j++)
                {
                    if (_mapField[i, j].Z < 2)
                    {
                        symbol = "0";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (_mapField[i, j].Z >= 2 && _mapField[i, j].Z < 10)
                    {
                        symbol = "#";
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        symbol = "*";
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

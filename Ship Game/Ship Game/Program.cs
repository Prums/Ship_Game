﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            map.Print();
            Console.ReadKey();
        }
    }
}

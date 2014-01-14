using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Game
{
    class Cell
    {
        private int _x; // X координата 
        private int _y; // У координата
        private int _z; // Z координата

        // Конструктор взаимодейстивя с _x
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        // Конструктор взаимодейстивя с _y
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        // Конструктор взаимодейстивя с _z 
        public int Z
        {
            get { return _z; }
            set { _z = value; }
        }
    }
}

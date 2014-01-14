using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Game
{
    class Weather
    {
        Wind Wind { get; set; }

        // Функция, позволяющая инициализировать  новый экземпляр класса Wind
        public void InitiateWind(int velocity, int direction)
        {
            Wind = new Wind(velocity,direction);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Game
{
    // Низший класс, реализующий преставление ветра
    struct Wind
    {
        public Wind(int velocity, int direction)
        {
            _velocity = velocity;
            _direction = direction;
        }
        // Переменная, отвечающая за силу ветра. Минимальное значение 0, максимальное 20.
        private int _velocity;
        /* Представляет представление направления ветра. Диапазон значений: 1 - север, 2 - северо-восток, 3 - восток, 4 - юго-восток, 5 - юг, 6 - юго-запад, 7 - запад */
        private int _direction;
    }
}

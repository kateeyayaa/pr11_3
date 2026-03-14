using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    internal class Robot
    {
        private int kollife;

        public int GetLife() // метод для чтения закрытого поля
        {
            return kollife;
        }

        // Метод уменьшения жизни
        public void Min(int a)
        {
            kollife = a;

            // уменьшение жизни на 50%
            kollife = kollife / 2;
        }

        // Метод для увеличения жизни других роботов
        // a = начальная жизнь робота, k = текущая жизнь после уменьшения
        public void Kol(int a, int k)
        {
            int diffPercent = (int)(((a - k) * 100.0) / a);

            if (diffPercent == 50)
                kollife += 30;
            else if (diffPercent == 30)
                kollife += 20;
        }

        // Метод для задания жизни с клавиатуры
        public void SetLife(int life)
        {
            kollife = life;
        }

    }
}

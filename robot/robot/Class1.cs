using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    internal class robot
    {
        public int kollife;

        // Получить количество жизней
        public int getlife()
        {
            return kollife;
        }

        // Уменьшение количества жизней
        public void Min(int a)
        {
            Random rn = new Random();
            int r = rn.Next(0, 2); // 0 или 1

            kollife = a;

            if (r == 0)
            {
                // уменьшение на 50%
                kollife = (int)(kollife * 0.5);
            }
            else
            {
                // уменьшение на 30%
                kollife = (int)(kollife * 0.7);
            }
        }

        // Увеличение жизней других роботов
        public void Kol(int a, int k)
        {
            int percent = (a - k) * 100 / a;

            if (percent >= 50)
            {
                kollife = kollife + 30;
            }
            else if (percent >= 30)
            {
                kollife = kollife + 20;
            }
        }
    }
}

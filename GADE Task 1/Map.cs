using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GADE_Task_1
{
    class Map
    {
        public Unit[] units = new Unit[10];

        public Map()
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int newX = r.Next(0, 20);
                int newY = r.Next(0, 20);
                int team = i % 2;
                int tempAttack = 0;

                switch (r.Next(0, 4))
                {
                    case 0:
                        tempAttack = 5;
                        break;
                    case 1:
                        tempAttack = 10;
                        break;
                    case 2:
                        tempAttack = 15;
                        break;
                    case 3:
                        tempAttack = 20;
                        break;
                }
                switch (r.Next(0, 2))
                {
                    case 0:
                        units[i] =  new MeleeUnit(newX, newY, 100, 1, tempAttack, 1, team, i.ToString());
                        break;
                    case 1:
                        units[i] = new RangedUnit(newX, newY, 100, 4, tempAttack, 1, team, i.ToString());
                        break;
                }
            }
        }
    }
}
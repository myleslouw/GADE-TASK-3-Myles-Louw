using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_Task_1
{
    public abstract class Unit
    {
        //Q1.3
        protected int x;
        protected int y;
        protected int health;
        protected int MaxHealth;
        protected int speed;
        protected int attack;
        protected int attackRange;
        protected int team;
        protected string symbol;
        protected bool attaking;

        //  Q1.4
        public abstract int Attack
        {
            get;
            set;
        }
        public abstract int X
        {
            get;
            set;
        }

        public abstract int Y
        {
            get;
            set;
        }

        public abstract string Symbol
        {
            get;
            set;
        }

        public abstract int Team
        {
            get;
            set;
        }

        public abstract void Move(ref Unit closestUnit);
        public abstract void Combat(ref Unit Attacker);
        public abstract bool InRange(ref Unit Attacker);
        public abstract Unit Closest(ref Unit[] map);
        public abstract void Death();
        public abstract override string ToString();
    }
}
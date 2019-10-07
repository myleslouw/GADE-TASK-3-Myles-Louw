using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_Task_1
{
    public abstract class Building
    {
        protected int x;
        protected int y;
        protected int health;
        protected int maxHealth;
        protected string team;
        protected string symbol;


        public abstract int Health
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

        public abstract string Team
        {
            get;
            set;
        }

        public abstract void Save();
        public abstract void Death();
        public abstract override string ToString();
    }
}

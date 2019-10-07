using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GADE_Task_1;

namespace GADE_Task_1
{
    class MeleeUnit : Unit
    {
        public MeleeUnit(int x, int y, int health, int speed, int attack, int attackRange, int team, string symbol)
        {
            this.x = x;
            this.y = y;
            this.health = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.team = team;
            this.symbol = symbol;
        }

        // I used the override keyword to override the abstract method in the Unit class
        public override void Move(ref Unit closestUnit)
        {
            //if this melee unit is the only closest unit remaining
            if (this == closestUnit)
            {
                return; //then use return to end the method
            }

            //only react to enemy units- so if not team
            if (closestUnit.Team != team)
            {
                //combat
                if (health < 25)   //if the health is below 25hp then they must run away
                {
                    Random r = new Random();  //inheritance from class Random produces random sequence of number
                                              // random.Next method generates a random number between 0 to 2

                    switch (r.Next(0, 2))
                    {
                        case 0: x += (1 * speed); break; // this means that x position + 1 times speed, so it will move one and use the speed ( x + 1 X speed)
                        case 1: x -= (1 * speed); break; //x - 1
                    }

                    switch (r.Next(0, 2)) //same but this time for y
                    {
                        case 0: y += (1 * speed); break;  //speed is the move distance
                        case 1: y -= (1 * speed); break;
                    }

                    //checks the bounds and resets character

                    if (x <= 0)
                    {
                        x = 0;
                    }
                    else if (x >= 20)
                    {
                        x = 20;
                    }
                    if (y <= 0)
                    {
                        y = 0;
                    }
                    else if (y >= 20)
                    {
                        y = 20;
                    }
                }

                //cheacks if in combat
                //maths.abs returns the absolute value of a number
                else if (Math.Abs(x - closestUnit.X) <= speed && Math.Abs(y - closestUnit.Y) <= speed)  //the distane between 2 position
                {
                    Combat(ref closestUnit);
                }
                else //move towards the closest unit
                {
                    if (x > closestUnit.X) //if ahead then go backwards
                    {
                        x -= speed;
                    }
                    else if (x < closestUnit.X)
                    {
                        x += speed;
                    }
                    if (y > closestUnit.Y)
                    {
                        y -= speed;
                    }
                    else if (y < closestUnit.Y)
                    {
                        y += speed;
                    }
                }

            }

        }
        public override int Attack
        {
            get
            {
                return Attack;
            }
            set
            {
                Attack = value;
            }
        }
        public override int X
        {
            get
            {
                return X;
            }
            set
            {
                X = value;
            }
        }
        public override int Y
        {
            get
            {
                return Y;
            }
            set
            {
                Y = value;
            }
        }
        public override string Symbol
        {
            get
            {
                return Symbol;
            }
            set
            {
                Symbol = value;
            }
        }
        public override int Team
        {
            get
            {
                return Team;
            }
            set
            {
                Team = value;
            }
        }
        public override void Combat(ref Unit attacker)
        {
            this.health = this.health - attacker.Attack; //melee unit health - attacker health
            if (health <= 0)
            {
                Death();
            }
        }
        public override bool InRange(ref Unit attacker)
        {
            if (DistanceTo(attacker) == attackRange)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int DistanceTo(Unit unit)
        {
            int dx = Math.Abs(unit.X - x);   //compares positions
            int dy = Math.Abs(unit.Y - y);
            double part = Convert.ToDouble((dx * dx) + (dy * dy));  //convert value to double  then multiply x and y postions by themselves
            return Convert.ToInt32(Math.Sqrt(part)); //get square root of part above
        }

        public override Unit Closest(ref Unit[] map)
        {
            Unit closest = this;
            int smallestRange = 100;
            foreach (Unit u in map)
            {
                if (u.Team != team)  //if not units team
                {
                    if (smallestRange > DistanceTo(u) && u != this)  //if less than the smallest range and not the melee unit
                    {
                        smallestRange = DistanceTo(u); //then the smallest range
                        closest = u; //and the closest unit is u
                    }
                }
            }
            return closest;
        }

        public override void Death()
        {
            throw new DeathException(this.ToString() + " IS DEAD");  //throw a message as a string using the ToString method
        }

        public override string ToString()
        {
            return symbol + ": [" + x + "," + y + "] " + health + "hp " + attack;
        }
    }
    public class DeathException : System.Exception
    {
        public DeathException() : base()
        {

        }

        public DeathException(string message) : base(message)   //using a string message for base
        {

        }
        public DeathException(string message, System.Exception inner) : base(message, inner)
        {
            //inner property calls original exception that caused the problem
        }


        protected DeathException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        // streaming context is the source and destination
        {

        }

    }
}
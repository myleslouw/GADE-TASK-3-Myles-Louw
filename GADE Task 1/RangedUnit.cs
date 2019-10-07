using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_Task_1
{
    internal class RangedUnit : Unit
    {
        #region UNIT ATTRIBUTES
        public RangedUnit(int x, int y, int health, int speed, int attack, int range, string team, string symbol, bool attacking, string name) : 
            base(x, y, health, speed, attack, range, team, symbol,attacking, "Archer"); //set parameters for ranged unit and affect base
        class inheritance
        {
        }
        #endregion

        #region UNIT ACCESSORS TO BASE CLASS

        protected int Health
        {
            get { return base.health; }
            set { base.health = value; }
        }

        protected int Speed
        {
            get { return base.speed; }
            set { base.speed = value; }
        }

        protected int Attack
        {
            get { return base.attack; }
            set { base.attack = value; }
        }

        protected int Range
        {
            get { return base.range; }
            set { base.range = value; }
        }

        protected string Team
        {
            get { return base.team; }
            set { base.team = value; }
        }

        protected string Symbol
        {
            get { return base.symbol; }
            set { base.symbol = value; }
        }

        protected bool Attacking
        {
            get { return attacking; }
            set { base.attacking = value; }
        }

        #endregion UNIT ACCESSORS TO BASE CLASS

        #region UNIT DAMAGE & COMBAT

        public override void handleCombat(Unit enemy) //handle damage the enemy takes
        {
            enemy.takeDamage(this.Attack); //referenced object gets damaged
        }

        public override void damageUnit(int attack) //if the unit attacks another unit it will damages the unit
        {
            this.health -= attack;
        }

        #endregion UNIT DAMAGE & COMBAT

        #region UNIT DISTANCE, RANGE and POSITION

        public override int getDistance(int enemyX, int enemyY)
        //Calculate distance between unit positions using absolute object.
        {
            int distanceX = Math.Abs(enemyPositionX - x);
            int distanceY = Math.Abs(enemyPositionY - y);

            double enemyXY = Convert.ToDouble((distanceX * distanceX)
+ (distanceY * distanceY));

            return Convert.ToInt32(Math.Sqrt(enemyXY));
        }

        public override void moveToPosition(int newX, int newY)
        {
            this.X = newX;
            this.Y = newY;
        }

        public override bool isWithinRange(int posX, int posY)
        {
            return this.getDistance(posX, posY) <= this.Range; //is the unit in range? If so, get the distance and then return it for storage.
        }

        #endregion UNIT DISTANCE, RANGE and POSITION

        #region UNIT DESTRUCTION

        public override void destroyUnit(Object[,] mapPos)
        {
            //Remove unit from map and replace as null/ nothing in place.
            mapPos[this.X, this.Y] = null;
        }

        public override bool isDead() //check if the player is dead.
        {
            if (this.maxHealth == 0)
            {
                return false;
            }
            return (this.Health / this.maxHealth) <= 0.25;
        }

        #endregion UNIT DESTRUCTION

        #region UNIT NEAREST ENEMY

        public override Unit nearestUnit(Object[,] mapPos)
        {
            int minimumDistance = 20;

            int mapBounds = 20; //ranged unit range may not exceed 20

            Unit closestEnemy = null;

            for (int x = 0; x < mapBounds; x++)
            {
                for (int y = 0; y < mapBounds; y++)
                {
                    //If it detects enemy, pass
                    Object obj = mapPos[x, y];

                    if (obj is Building)
                    {
                        continue;
                    }

                    Unit possibleEnemy = (Unit)obj;

                    if (possibleEnemy != null && possibleEnemy.Team != this.team) //still checking if true it is an enemy
                    {
                        int distance = this.getDistance(possibleEnemy.X, possibleEnemy.Y); //If confirmed, get the distance of the enemy

                        if (minimumDistance > distance)
                        {
                            nearestEnemy = possibleEnemy;
                            shortestDistance = distance;
                        }
                    }
                }
            }

            return nearestEnemy;
        }

        #endregion UNIT NEAREST ENEMY

        #region UNIT SHOW STATS REPORT

        public override String toString()
        {
            string display =
                "Name: " + Name + "\n" +
                "Health: " + Health + "\n" +
                "Attack: " + Attack + "\n" +
                "Range: " + Range + "\n" +
                "Speed: " + Speed + "\n";

            //TODO: Send to RichTextBox in Forms using appendText.

            return display;
        }

        #endregion UNIT SHOW STATS REPORT
    }
}
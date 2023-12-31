using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TankShooter.General;
using static TankShooter.General.Enum;

namespace TankShooter.Object
{
    class Bullets:Base
    {
        private Direction directionBullet;
        private int speedBullet;
        private int power;

        #region Bullet Processing
        public void BulletMove()
        {
            switch (directionBullet)
            {
                case Direction.eLeft:
                    this.RectX -=speedBullet; 
                    break;
                case Direction.eRight:
                    this.RectX +=speedBullet;
                    break;
                case Direction.eUp:
                    this.RectY -=speedBullet;
                    break;
                case Direction.eDown:
                    this.RectY +=speedBullet;
                    break;
            }
        }
        public Direction DirectionBullet
        {
            get { return directionBullet; }
            set { directionBullet = value; }
        }
        public int SpeedBullet
        {
            get { return speedBullet; }
            set { speedBullet = value; }
        }
        public int PowerBullet
        {
            get { return power; }
            set { power = value; }
        }
        #endregion
    }
}

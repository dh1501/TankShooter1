using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using TankShooter.Object;
using TankShooter.General;
using TankShooter.Object.Environment;
using static TankShooter.General.Enum;



namespace TankShooter.Object.General
{
    class Tank:Base
    {
        // MAX FRAME
        protected const int MAX_NUMBER_TANK = 4;
        protected const int MAX_NUMBER_EFFECT = 6;

        // FRAME NUMBER
        protected int frTank = 7;
        protected int frXEffect = 0;
        protected int frYEffect = 0;

        // VARIABLES
        protected int moveSpeed;
        protected int bulletSpeed;
        protected int power;
        private BulletType bulletType;
        protected Skin skinTank;
        protected PlayerSkin playerSkin;
        protected bool isMove;
        protected bool isActivate;
        protected bool left, right, up, down;
        protected Direction directionTank;
        private List<Bullets> bullets;
        protected Bitmap bmpEffect;

        #region Tank Init
        public int MoveSpeed
        {
            get { return moveSpeed; } 
            set { moveSpeed = value; } 
        }
        public int BulletSpeed
        {
            get { return bulletSpeed; }
            set { bulletSpeed = value; }
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public bool Left
        {
            get { return left;}
            set { left = value;}
        }
        public bool Right
        {
            get { return right;}
            set { right = value;}
        }
        public bool Up
        {
            get { return up; }
            set { up = value; }
        }
        public bool Down
        {
            get { return down; }
            set { down = value; }
        }
        public Direction DirectionTank
        {
            get { return directionTank; }
            set { directionTank = value; }
        }
        public bool IsMove
        {
            get { return isMove; }
            set { isMove = value; }
        }
        public List<Bullets> Bullets
        {
            get { return bullets; }
            set { bullets = value; }
        }
        public Skin EnemySkinTank
        {
            get { return skinTank; }
            set { skinTank = value; }
        }
        public PlayerSkin PlayerSkinTank
        {
            get { return playerSkin; }
            set { playerSkin = value; }
        }
        public bool IsActivate
        {
            get { return isActivate; }
            set { isActivate = value; }
        }
        public BulletType BulletType
        {
            get { return bulletType; }
            set { bulletType = value; }
        }
        #endregion

        #region Tank processing
        //Constructor
        public Tank()
        {
            this.isActivate = false;
            this.RectWidth = Common.tankSize;
            this.RectHeight = Common.tankSize;
            this.Bullets = new List<Bullets>();
            this.BulletType = BulletType.eNormalBullet;
        }
        public void Move()
        {
            if (this.isActivate)
            {
                if (left) this.RectX -= this.MoveSpeed;
                else if (right) this.RectX += this.MoveSpeed;
                else if (up) this.RectY -= this.MoveSpeed;
                else if (down) this.RectY += this.MoveSpeed;
            }
        }
        public override void Show(Bitmap bg)
        {
            if (IsActivate)
            {
                switch (directionTank)
                {
                    case Direction.eUp:
                        Common.PaintObject(bg, this.bmpObj, rect.X, rect.Y, (int)skinTank * Common.tankSize,
                            frTank * Common.tankSize, this.RectWidth, this.RectHeight); 
                        break;
                    case Direction.eDown:
                        Common.PaintObject(bg, this.bmpObj, rect.X, rect.Y, (MAX_NUMBER_TANK-(int)skinTank) * Common.tankSize,
                            frTank * Common.tankSize, this.RectWidth, this.RectHeight);
                        break;
                    case Direction.eLeft:
                        Common.PaintObject(bg, this.bmpObj, rect.X, rect.Y, frTank * Common.tankSize, 
                            MAX_NUMBER_TANK - (int)skinTank * Common.tankSize, this.RectWidth, this.RectHeight);
                        break;
                    case Direction.eRight:
                        Common.PaintObject(bg, this.bmpObj, rect.X, rect.Y, frTank * Common.tankSize,
                            (int)skinTank * Common.tankSize, this.RectWidth, this.RectHeight);
                        break;
                }
                
                if(this.isMove)
                {
                    frTank--;
                    if (frTank == -1)
                        frTank = MAX_NUMBER_TANK;
                } 
                
            }
            else
            {
                Common.PaintObject(bg, this.bmpEffect, this.RectX, this.RectY, 
                    frXEffect * this.RectWidth, frYEffect * this.RectHeight, this.RectWidth, this.RectHeight);
                frXEffect++;
                if (frXEffect == MAX_NUMBER_EFFECT)
                {
                    frXEffect = 0;
                    frYEffect++;
                    if (frYEffect == MAX_NUMBER_EFFECT) { 
                        frYEffect = 0;
                        IsActivate = true;
                    }
                }
            }
        }

        public void RotateTank() 
        {
            //Rotate
            if ((left == true && this.DirectionTank == Direction.eDown) ||
                (right == true && this.DirectionTank == Direction.eUp) ||
                (up == true && this.DirectionTank == Direction.eLeft) ||
                (down == true && this.DirectionTank == Direction.eRight))
            {
                this.bmpObj.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else if ((left == true && this.DirectionTank == Direction.eUp) ||
               (right == true && this.DirectionTank == Direction.eDown) ||
               (up == true && this.DirectionTank == Direction.eRight) ||
               (down == true && this.DirectionTank == Direction.eLeft))
            {
                this.bmpObj.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else if ((left == true && this.DirectionTank == Direction.eRight) ||
               (right == true && this.DirectionTank == Direction.eLeft) ||
               (up == true && this.DirectionTank == Direction.eDown) ||
               (down == true && this.DirectionTank == Direction.eUp))
            {
                this.bmpObj.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            else
            {
                this.bmpObj.RotateFlip(RotateFlipType.RotateNoneFlipNone);
            }

            //Direction
            if (left)
                directionTank = Direction.eLeft;
            else if (right)
                directionTank = Direction.eRight;
            else if (up)
                directionTank = Direction.eUp;
            else if (down)
                directionTank = Direction.eDown;
        }
        #endregion

        #region Bullet
        public void CreatBullet(string pathNormalBullet, string pathRocketBullet, string pathUntiBullet, string pathLazeBullet)
        {
            if (this.bullets.Count == 0 && this.IsActivate) 
            {
                //Bullet
                Bullets bullet;
                bullet = new Bullets();
                bullet.SpeedBullet = this.BulletSpeed;

                //Bullet Type
                switch (this.bulletType)
                {
                    case BulletType.eNormalBullet: //8x8x10
                        bullet.LoadImage(Common.path + pathNormalBullet);
                        bullet.RectWidth = 8;
                        bullet.RectHeight = 8;
                        bullet.PowerBullet = 10;
                        bullet.SpeedBullet = 5;
                        break;
                    case BulletType.eRocketBullet://12x12x15
                        bullet.LoadImage(Common.path + pathRocketBullet); 
                        bullet.RectWidth = 12;
                        bullet.RectHeight = 12;
                        bullet.PowerBullet = 15;
                        bullet.SpeedBullet = 5;
                        break;
                    case BulletType.eUntiBullet:
                        bullet.LoadImage(Common.path + pathUntiBullet);
                        bullet.RectWidth = 15;
                        bullet.RectHeight = 15;
                        bullet.PowerBullet = 30;
                        bullet.SpeedBullet = 7;
                        break;
                    case BulletType.eLazeBullet:
                        bullet.LoadImage(Common.path + pathLazeBullet);
                        bullet.RectWidth = 12;
                        bullet.RectHeight = 12;
                        bullet.PowerBullet = 10;
                        bullet.SpeedBullet = 10;
                        break;
                }

                //Tank Direction
                switch (directionTank)
                {
                    case Direction.eLeft:
                        bullet.DirectionBullet = Direction.eLeft;
                        bullet.BmpObj.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        bullet.RectX = this.RectX + bullet.RectWidth;
                        bullet.RectY = this.RectY + this.RectHeight / 2 - bullet.RectHeight / 2;
                        break;
                    case Direction.eRight:
                        bullet.DirectionBullet = Direction.eRight;
                        bullet.BmpObj.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        bullet.RectX = this.RectX + this.RectWidth - bullet.RectWidth;
                        bullet.RectY = this.RectY + this.RectHeight / 2 - bullet.RectHeight / 2;
                        break;
                    case Direction.eUp:
                        bullet.DirectionBullet = Direction.eUp;
                        bullet.RectY = this.RectY + bullet.RectHeight;
                        bullet.RectX = this.RectX + this.RectWidth / 2 - bullet.RectWidth / 2;
                        break;
                    case Direction.eDown:
                        bullet.DirectionBullet = Direction.eDown;
                        bullet.BmpObj.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        bullet.RectY = this.RectY + this.RectHeight - bullet.RectHeight;
                        bullet.RectX = this.RectX + this.RectWidth / 2 - bullet.RectWidth / 2;
                        break;
                }
                this.bullets.Add(bullet);
                bullet = null;
            }
        }
        public void DeleteBullet(int index)
        {
            this.bullets[index] = null;
            this.bullets.RemoveAt(index);
        }
        public void MoveShowBullet(Bitmap bg)
        {
            for (int i =0; i<this.Bullets.Count; i++)
            {
                this.Bullets[i].BulletMove();
                this.Bullets[i].Show(bg);
            }
        }

        #endregion

        #region Collision
        public bool IsCollision(Rectangle rectObj)
        {
            switch (this.directionTank)
            {
                case Direction.eLeft:
                    if (this.Rect.Left == rectObj.Right)
                        if (this.Rect.Top >= rectObj.Top && this.Rect.Top < rectObj.Bottom ||
                            this.Rect.Bottom > rectObj.Top && this.Rect.Bottom <= rectObj.Bottom ||
                            this.Rect.Bottom > rectObj.Bottom && this.Rect.Top < rectObj.Top)
                        {
                            return true;
                        }
                    break;
                case Direction.eRight:
                    if (this.Rect.Right == rectObj.Left)
                        if (this.Rect.Top >= rectObj.Top && this.Rect.Top < rectObj.Bottom ||
                            this.Rect.Bottom > rectObj.Top && this.Rect.Bottom <= rectObj.Bottom ||
                            this.Rect.Bottom > rectObj.Bottom && this.Rect.Top < rectObj.Top)
                        {
                            return true;
                        }
                    break;
                case Direction.eUp:
                    if (this.Rect.Top == rectObj.Bottom)
                        if (this.Rect.Left < rectObj.Right && this.Rect.Left >= rectObj.Left ||
                            this.Rect.Right > rectObj.Left && this.Rect.Right <= rectObj.Right ||
                            this.Rect.Right > rectObj.Right && this.Rect.Left < rectObj.Left)
                        {
                            return true;
                        }
                    break;
                case Direction.eDown:
                    if (this.Rect.Bottom == rectObj.Top)
                        if (this.Rect.Left < rectObj.Right && this.Rect.Left >= rectObj.Left ||
                            this.Rect.Right > rectObj.Left && this.Rect.Right <= rectObj.Right ||
                            this.Rect.Right >= rectObj.Right && this.Rect.Left <= rectObj.Left)
                        {
                            return true;
                        }
                    break;
            }
            return false;
        }
        public bool IsCollisionWall(List<Objects.Wall> walls, Direction directTank)
        {
            foreach (Objects.Wall wall in walls)
            {
                if (wall.WallNumber != 4)
                {
                    if (IsCollision(wall.Rect)) return true;
                }
            }
            return false;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TankShooter.General;
using TankShooter.Object.General;
using TankShooter.Object.Player;
using TankShooter.Objects;
using static TankShooter.General.Enum;

namespace TankShooter.Object
{
    class Enemy:Tank
    {
        private EnemyTankType enemyType;
        private int enemTankDistance;
        public Enemy()
        {
            bmpEffect = new Bitmap(Common.path + @"\Image\effect2.png");
        }

        #region check collide
        public bool IsPlayerankCollision(PlayerTank playerTank) //with player
        {
            if (this.IsCollision(playerTank.Rect))
                return true;
            return false;
        }

        public bool IsAlliedTankCollision(List<Enemy> alliedTanks) //with allied tank
        {
            foreach (Enemy enemyTank in alliedTanks)
            {
                if (this.IsCollision(enemyTank.Rect))
                    return true;
            }
            return false;
        }

        #endregion

        #region control enemy tank
        public bool HandleMoveNormal(List<Wall> walls, PlayerTank playerTank, List<Enemy> alliedTanks)
        {
            bool isWallCollision;
            bool isPlayerTankCollision;
            bool isAlliedTanksCollision;

            isWallCollision = this.IsCollisionWall(walls, this.directionTank);
            isPlayerTankCollision = this.IsPlayerankCollision(playerTank);
            isAlliedTanksCollision = this.IsAlliedTankCollision(alliedTanks);

            if (isWallCollision || isAlliedTanksCollision || isPlayerTankCollision) //walls, allied tank -> change direction
            {
                if (isPlayerTankCollision){
                    //Giam HP
                }
                Random random = new Random();
                switch(random.Next(0, 4))
                {
                    case 0:
                        Left = true;
                        Right = Up = Down = false;
                        break;
                    case 1:
                        Right = true;
                        Left = Up = Down = false;
                        break;
                    case 2:
                        Up = true;
                        Left = Right = Down = false;
                        break;
                    case 3:
                        Down = true;
                        Left = Right = Up = false;
                        break;
                }
                this.RotateTank();
                random = null;
                return false;
            }
            else
            {
                this.IsMove = true;
                return true;
            }         
        }

        bool isPriority = false;
        public bool HandleMoveMedium(List<Wall> walls, PlayerTank playerTank, List<Enemy> alliedTanks)
        {
            bool isWallCollision;
            bool isPlayerTankCollision;
            bool isAlliedTanksCollision;
            bool flag;
            flag = false;

            isWallCollision = this.IsCollisionWall(walls, this.directionTank);
            isPlayerTankCollision = this.IsPlayerankCollision(playerTank);
            isAlliedTanksCollision = this.IsAlliedTankCollision(alliedTanks);

            if (isWallCollision || isAlliedTanksCollision || isPlayerTankCollision) //walls, allied tank -> change direction
            {
                if (isPlayerTankCollision)
                {
                    //Giam HP
                }
                Random random = new Random();
                switch (random.Next(0, 4))
                {
                    case 0:
                        Left = true;
                        Right = Up = Down = false;
                        break;
                    case 1:
                        Right = true;
                        Left = Up = Down = false;
                        break;
                    case 2:
                        Up = true;
                        Left = Right = Down = false;
                        break;
                    case 3:
                        Down = true;
                        Left = Right = Up = false;
                        break;
                }
                this.RotateTank();
                random = null;
                return false;
            }
            else
            {
                if (playerTank.RectX != 17 * Common.STEP || playerTank.RectY != 36 * Common.STEP)
                {
                    if (this.Rect.Top + this.Rect.Height / 2 > playerTank.Rect.Top &&
                       this.Rect.Top + this.Rect.Height / 2 < playerTank.Rect.Bottom &&
                       this.RectX > playerTank.RectX)
                    {
                        Left = true;
                        Down = Up = Right = false;
                        flag = true;
                    }
                    else
                       if (this.Rect.Top + this.Rect.Height / 2 > playerTank.Rect.Top &&
                       this.Rect.Top + this.Rect.Height / 2 < playerTank.Rect.Bottom &&
                       this.RectX < playerTank.RectX)
                    {
                        Right = true;
                        Down = Up = Left = false;
                        flag = true;
                    }
                    else
                       if (this.Rect.Left + this.Rect.Width / 2 > playerTank.Rect.Left &&
                       this.Rect.Left + this.Rect.Width / 2 < playerTank.Rect.Right &&
                       this.RectY > playerTank.RectY)
                    {
                        Up = true;
                        Left = Down = Right = false;
                        flag = true;
                    }
                    else
                       if (this.Rect.Left + this.Rect.Width / 2 > playerTank.Rect.Left &&
                       this.Rect.Left + this.Rect.Width / 2 < playerTank.Rect.Right &&
                       this.RectY < playerTank.RectY)
                    {
                        Down = true;
                        Left = Up = Right = false;
                        flag = true;
                    }
                    if (flag)
                    {
                        isPriority = true;
                        flag = false;
                        this.RotateTank();
                        this.isMove = false;
                        return false;
                    }
                    else
                    {
                        if (isPriority == true)
                        {
                            isPriority = false;
                            return false;
                        }
                        else
                        {
                            this.isMove = true;
                            return true;
                        }
                    }
                }
                else
                {
                    isPriority = false;
                    this.isMove = true;
                    return true;
                }
            }
        }
        #endregion

        #region init
        public EnemyTankType EnemyType
        {
            get { return this.enemyType; }
            set { this.enemyType = value; }
        }
        public int EnemyTankDistance
        {
            get { return enemTankDistance; } set { enemTankDistance = value; } 
        }
        #endregion

    }
}
